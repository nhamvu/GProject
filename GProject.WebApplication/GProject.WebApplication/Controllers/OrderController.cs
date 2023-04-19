using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using GProject.Data.MyRepositories.IRepositories;
using GProject.WebApplication.Services;
using static IdentityServer4.Models.IdentityResources;
using System.Net.Mail;
using System.Net;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class OrderController : Controller
    {
        private ISendMailRepository sendMailRepository;
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;
        public OrderController()
        {
            sendMailRepository = new SendMailRepository();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
        }

        public async Task<ActionResult> Index(string sName, string sEmail, string sPhone, int? sPaymentType, int? sStatus, int pg = 1)
        {
            try
            {

                int valsPaymentType = sPaymentType.HasValue ? sPaymentType.Value : -1;
                int valsStatus = sStatus.HasValue ? sStatus.Value : -1;
                var lstObjs = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/get-all-Order"));

                if (!string.IsNullOrEmpty(sName))
                    lstObjs = lstObjs.Where(c => c.ShippingFullName.ToLower().Contains(sName.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sEmail))
                    lstObjs = lstObjs.Where(c => c.ShippingEmail.ToLower().Contains(sEmail.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sPhone))
                    lstObjs = lstObjs.Where(c => c.ShippingPhone.ToLower().Contains(sPhone.ToLower())).ToList();
                if (valsPaymentType != -1)
                    lstObjs = lstObjs.Where(c => (int)c.PaymentType == sPaymentType).ToList();
                if (valsStatus != -1)
                    lstObjs = lstObjs.Where(c => (int)c.Status == valsStatus).ToList();

                const int pageSize = 20;
                if (pg < 1)
                    pg = 1;
                var pager = new Pager(lstObjs.Count(), pg, pageSize);
                var lstData = lstObjs.Skip((pg - 1) * pageSize).Take(pageSize).ToList();
                var data = new OrderDTO() { Orders = lstData };

                this.ViewBag.Pager = pager;
                this.ViewData[nameof(sName)] = (object)sName;
                this.ViewData[nameof(sEmail)] = (object)sEmail;
                this.ViewData[nameof(sPhone)] = (object)sPhone;
                this.ViewData[nameof(sPaymentType)] = (object)valsPaymentType;
                this.ViewData[nameof(sStatus)] = (object)valsStatus;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(data);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public async Task<ActionResult> Detail(Guid id)
        {
            try
            {
                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                return View(await pService.ShowMyOrder(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public ActionResult ChangeStatus(string id, int status)
        {
            try
            {
                var employee = HttpContext.Session.GetObjectFromJson<Employee>("userLogin");
                var order = orderRepository.GetAll().Where(c => c.Id == new Guid(id)).FirstOrDefault();
                if (order != null)
                {
                    order.Status = (Data.Enums.OrderStatus)status;
                    if (!orderRepository.Update(order))
                        HttpContext.Session.SetString("mess", "Failed");
                    else
                    {
                        switch (status)
                        {
                            case 6:
                                EMailSender(Commons.email, Commons.passemail, "nhamvdph18699@fpt.edu.vn", "Dream Fashion xin thông báo tới quý khách hàng", $"Thông báo đơn hàng {order.OrderId} được đặt vào {order.CreateDate} của bạn đã được xác nhận, chúng tôi sẽ giao hàng trong thời gian sớm nhất. Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!", employee.Email);
                                break;
                            case 5:
                                EMailSender(Commons.email, Commons.passemail, "nhamvdph18699@fpt.edu.vn", "Dream Fashion xin thông báo tới quý khách hàng", $"Thông báo đơn hàng {order.OrderId} được đặt vào {order.CreateDate} của bạn đã được hủy, chúng tôi xin lỗi vì sự bất tiện này. Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!", employee.Email);
                                break;
                            default:
                                break;
                        }

                        HttpContext.Session.SetString("mess", "Success");
                    }


                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Order(string cTotalMoney, string ShippingFullName, string ShippingPhone,
            string ShippingCity, string ShippingDistrict, string ShippingTown, string ShippingAddress, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Login", "Account");        

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.AddToOrder(cTotalMoney, ShippingFullName, ShippingPhone, ShippingCity, ShippingDistrict, ShippingTown, ShippingAddress,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");

                HttpContext.Session.Remove("productOrders");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }

        [HttpPost]
        public async Task<ActionResult> BuyNow(string pTotalMoney, string ShippingFullName, string ShippingPhone,
            string ShippingCity, string ShippingDistrict, string ShippingTown, string ShippingAddress, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Login", "Account");

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.BuyNow(pTotalMoney, ShippingFullName, ShippingPhone, ShippingCity, ShippingDistrict, ShippingTown, ShippingAddress,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");

                HttpContext.Session.Remove("productOrders");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }

        public bool EMailSender(string from, string password, string to, string subject, string body, string createby)
        {
            try
            {
                bool SendResult = SendMail(from, password, to, subject, body);
                GProject.Data.DomainClass.SendMail sendmail = new GProject.Data.DomainClass.SendMail()
                {
                    Id = Guid.NewGuid(),
                    Sender = from,
                    Recipient = to,
                    CCEmail = "",
                    Subject = subject,
                    Message = body,
                    FileName = "",
                    CreateBy = createby,
                    CreateDate = DateTime.Now,
                    SortOrder = 0,
                    Status = !SendResult ? Data.Enums.SendMailStatus.Unsuccessfully : Data.Enums.SendMailStatus.Successfully,
                    Description = ""
                };
                sendMailRepository.Add(sendmail);
                return SendResult;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool SendMail(string from, string pass, string to, string subject, string body)
        {

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(from);
                message.Subject = subject;
                message.To.Add(new MailAddress(to));
                message.Body = body;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,// cổng kết nối smtp
                    Credentials = new NetworkCredential(from, pass),
                    EnableSsl = true, // mã hóa dữ liệu khi gửi mail
                    DeliveryMethod = SmtpDeliveryMethod.Network,//Đặt phthuc gửi mail là Network
                    UseDefaultCredentials = false,
                };
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
