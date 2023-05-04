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
using GProject.Data.Enums;
using GProject.WebApplication.Models.Payments;
using GProject.WebApplication.Services.IServices;
using GProject.WebApplication.Services;
using X.PagedList;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class OrderController : Controller
    {
		private readonly IVnPayService _vnPayService;
		private ISendMailRepository sendMailRepository;
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IProductVariationRepository productVariationRepository;
        public OrderController(IVnPayService vnPayService)
        {
			_vnPayService = vnPayService;
			sendMailRepository = new SendMailRepository();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            productVariationRepository = new ProductVariationRepository();
        }

        public async Task<ActionResult> Index(string sName, string sEmail, string sPhone, int? sPaymentType, string? sortOrder, int? page)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                int valsPaymentType = sPaymentType.HasValue ? sPaymentType.Value : -1;
                var lstObjs = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/get-all-Order"));


                ViewData["totalInPro"] = lstObjs.Where(x => x.Status == OrderStatus.InProgress).ToList().Count();
                ViewData["totalConfi"] = lstObjs.Where(x => x.Status == OrderStatus.Confirmed).ToList().Count();
                ViewData["totalDelivery"] = lstObjs.Where(x => x.Status == OrderStatus.Delivery).ToList().Count();
                ViewData["totalAcc"] = lstObjs.Where(x => x.Status == OrderStatus.Accomplished).ToList().Count();
                ViewData["totalXCan"] = lstObjs.Where(x => x.Status == OrderStatus.Canceled).ToList().Count();
                ViewData["totalXacNhan"] = lstObjs.Where(x => x.Status == OrderStatus.DaXacNhan).ToList().Count();

                ViewData["InProgress"] = sortOrder == "InProgress" ? "NotSort" : "InProgress";
                ViewData["Confirmed"] = sortOrder == "Confirmed" ? "NotSort" : "Confirmed";
                ViewData["Delivery"] = sortOrder == "Delivery" ? "NotSort" : "Delivery";
                ViewData["Accomplished"] = sortOrder == "Accomplished" ? "NotSort" : "Accomplished";
                ViewData["Returned"] = sortOrder == "InProgress" ? "NotSort" : "Returned";
                ViewData["XacNhan"] = sortOrder == "DaXacNhan" ? "NotSort" : "DaXacNhan";
                ViewData["Canceled"] = sortOrder == "Canceled" ? "NotSort" : "Canceled";


                switch (sortOrder)
                {
                    case "InProgress":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.InProgress).ToList();
                        break;
                    case "Confirmed":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.Confirmed).ToList();
                        break;
                    case "Delivery":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.Delivery).ToList();
                        break;
                    case "Accomplished":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.Accomplished).ToList();
                        break;
                    case "Returned":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.Returned).ToList();
                        break;
                    case "Canceled":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.Canceled).ToList();
                        break;
                    case "DaXacNhan":
                        lstObjs = lstObjs.Where(x => x.Status == OrderStatus.DaXacNhan).ToList();
                        break;
                    case "NotSort":
                        lstObjs = lstObjs.ToList();
                        break;
                    default: break;
                }


                if (!string.IsNullOrEmpty(sName))
                    lstObjs = lstObjs.Where(c => c.ShippingFullName.ToLower().Contains(sName.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sEmail))
                    lstObjs = lstObjs.Where(c => c.ShippingEmail.ToLower().Contains(sEmail.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sPhone))
                    lstObjs = lstObjs.Where(c => c.ShippingPhone.ToLower().Contains(sPhone.ToLower())).ToList();
                if (valsPaymentType != -1)
                    lstObjs = lstObjs.Where(c => (int)c.PaymentType == sPaymentType).ToList();


                // const int pageSize = 2;
                // if (pg < 1)
                //     pg = 1;
                //var pager = new Pager(lstObjs.Count(), pg, pageSize);
                // var lstData = lstObjs.Skip((pg - 1) * pageSize).Take(pageSize).ToList();
                if (page == null) page = 1;
                var pageNumber = page ?? 1;
                var pageSize = 5;
                var data = new OrderDto() { Orders = lstObjs };

                //this.ViewBag.Pager = pager;
                this.ViewData[nameof(sName)] = (object)sName;
                this.ViewData[nameof(sEmail)] = (object)sEmail;
                this.ViewData[nameof(sPhone)] = (object)sPhone;
                this.ViewData[nameof(sPaymentType)] = (object)valsPaymentType;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                //List<Order> lsOrder = lstObjs;

                return View(lstObjs.ToPagedList(pageNumber, pageSize));

            }
            catch (Exception ex)
            {
                return RedirectToAction("AccessDenied", "Account");
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
                return RedirectToAction("AccessDenied", "Account");
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
                    int oriStatus = (int)order.Status;
                    var LstorderDetail = orderDetailRepository.GetAll().Where(c => c.OrderId == order.Id).ToList();
                    order.Status = (Data.Enums.OrderStatus)status;
                    if (!orderRepository.Update(order))
                        HttpContext.Session.SetString("mess", "Failed");
                    else
                    {
                        switch (status)
                        {
                            case 6:
                                ChangQuantityInStock(oriStatus, status, LstorderDetail);
                                EMailSender(Commons.email, Commons.passemail, "huylqph18771@fpt.edu.vn", "Dream Fashion xin thông báo tới quý khách hàng", $"Thông báo đơn hàng {order.OrderId} được đặt vào {order.CreateDate} của bạn đã được xác nhận, chúng tôi sẽ giao hàng trong thời gian sớm nhất. Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!", employee.Email);
                                break;
                            case 5:
                                EMailSender(Commons.email, Commons.passemail, "huylqph18771@fpt.edu.vn", "Dream Fashion xin thông báo tới quý khách hàng", $"Thông báo đơn hàng {order.OrderId} được đặt vào {order.CreateDate} của bạn đã được hủy, chúng tôi xin lỗi vì sự bất tiện này. Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!", employee.Email);
                                //-- Hủy đơn hàng, trả lại số lượng còn lại của sản phẩm
                                ChangQuantityInStock(oriStatus, status, LstorderDetail);
                                break;
                            default:
                                ChangQuantityInStock(oriStatus, status, LstorderDetail);
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
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        /// <summary>
        /// Nếu mà đơn hàng đang 
        /// </summary>
        /// <param name="OriStatus"></param>
        /// <returns></returns>
        public void ChangQuantityInStock(int OriStatus, int changStatusVal, List<OrderDetail> orderDetails)
        {
            List<ProductVariation> variations = productVariationRepository.GetAll();
            //Nếu trạng thái đang là Hủy, và muốn đổi sang trạng thái khác Hủy, thì
            //cộng thêm số lượng ở orderDetail và giảm ở ProdVariation
            if (OriStatus == 5 && changStatusVal != 5)
            {
                foreach (var item in orderDetails)
                {
                    var prodVariation = variations.Where(c => c.Id == item.ProductVariationId).FirstOrDefault();
                    if (prodVariation != null)
                    {
                        prodVariation.QuantityInStock = prodVariation.QuantityInStock - item.Quantity;
                        productVariationRepository.Update(prodVariation);
                    }
                };
            }

            //Nếu trạng thái hiện tại khác hủy và muốn chuyển sang hủy, 
            //thì lại cộng thêm số lượng cho prodVariation
            if (OriStatus != 5 && changStatusVal == 5)
            {
                foreach (var item in orderDetails)
                {
                    var prodVariation = variations.Where(c => c.Id == item.ProductVariationId).FirstOrDefault();
                    if (prodVariation != null)
                    {
                        prodVariation.QuantityInStock = prodVariation.QuantityInStock + item.Quantity;
                        productVariationRepository.Update(prodVariation);
                    }
                };
            }
        }
        private static int _selectVoucher;
        private static string _cGiamGia;
        private static string _idDeliveryAddress;
        private static string _cShippingFee;
        private static string _cTotalMoney;
        private static string _ShippingEmail;
        private static string _cDescription;
        private static int _PaymentType;
        private static string _pTotalMoney;

        [HttpPost]
        public async Task<ActionResult> Order(int selectVoucher,string DiscountCode, string cGiamGia, string idDeliveryAddress, string cShippingFee, string cTotalMoney, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                int voucherId = 0;
                var voucherList = (await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all"))).ToList();
                if (selectVoucher != 0)
                        voucherId = selectVoucher;
                else
                {
                    if(!string.IsNullOrEmpty(DiscountCode)) 
                    {
                        var voucher = voucherList.FirstOrDefault(x => x.VoucherId == DiscountCode);
                        voucherId = voucher.Id;
                    }
                }
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
                var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(idDeliveryAddress));
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));                
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Login", "Account");
                if (PaymentType == 1)
                {
                    _selectVoucher = voucherId;
                    _cGiamGia = cGiamGia;
                    _idDeliveryAddress = idDeliveryAddress;
                    _cShippingFee = cShippingFee;
                    _cTotalMoney = cTotalMoney;
                    _ShippingEmail = ShippingEmail;
                    _cDescription = cDescription;
                    _PaymentType = PaymentType;

                    PaymentInformationModel model = new PaymentInformationModel()
                    {
                        Name = dataDeliveryAddress.Name,
                        OrderDescription = "Thanh toán đơn hàng",
                        Amount = Convert.ToSingle(cTotalMoney),
                        OrderType = "electric"
                    };
                    var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

                    return Redirect(url);
                }


                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.AddToOrder(voucherId, cGiamGia, cShippingFee, cTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                {

                    var dataVoucher = new UpdateNumberVoucherDto() { Id = voucherId };
                    await Commons.Add_or_UpdateAsync(dataVoucher, String.Concat(Commons.mylocalhost, "Voucher/update-number"));

                    HttpContext.Session.SetString("mess", "Success");
                }


                HttpContext.Session.Remove("productOrders");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpPost]
        public async Task<ActionResult> BuyNow(int selectVoucher, string DiscountCode, string cGiamGia, string idDeliveryAddress, string cShippingFee, string pTotalMoney, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                int voucherId = 0;
                var voucherList = (await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all"))).ToList();
                if (selectVoucher != 0)
                    voucherId = selectVoucher;
                else
                {
                    if (!string.IsNullOrEmpty(DiscountCode))
                    {
						var voucher = voucherList.FirstOrDefault(x => x.VoucherId == DiscountCode);
						voucherId = voucher.Id;
					}
                }
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
                var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(idDeliveryAddress));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Login", "Account");

                if (PaymentType == 1)
                {
                    _selectVoucher = voucherId;
                    _cGiamGia = cGiamGia;
                    _idDeliveryAddress = idDeliveryAddress;
                    _cShippingFee = cShippingFee;
                    _pTotalMoney = pTotalMoney;
                    _ShippingEmail = ShippingEmail;
                    _cDescription = cDescription;
                    _PaymentType = PaymentType;

                    PaymentInformationModel model = new PaymentInformationModel()
                    {
                        Name = dataDeliveryAddress.Name,
                        OrderDescription = "Thanh toán đơn hàng",
                        Amount = Convert.ToSingle(pTotalMoney),
                        OrderType = "electric"
                    };
                    var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

                    return Redirect(url);
                }

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.BuyNow(voucherId, cGiamGia, cShippingFee, pTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                {
                    var dataVoucher = new UpdateNumberVoucherDto() { Id = voucherId };
                    await Commons.Add_or_UpdateAsync(dataVoucher, String.Concat(Commons.mylocalhost, "Voucher/update-number"));
                    HttpContext.Session.SetString("mess", "Success");
                }

                HttpContext.Session.Remove("productOrders");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Account");
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


        [HttpGet]    
        public async Task<ActionResult> CheckOrderStatus(Guid? accomplished, Guid? canceled)
        {
            try
            {                
                if (accomplished.HasValue)
                {
                    var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/order-accomplished?id=" + accomplished));
                    return RedirectToAction("ViewOrderCustomer", "Order");
                }
                if (canceled.HasValue)
                {
                    var order = orderRepository.GetAll().Where(c => c.Id == canceled).FirstOrDefault();
                    var LstorderDetail = orderDetailRepository.GetAll().Where(c => c.OrderId == order.Id).ToList();
                    ChangQuantityInStock((int)order.Status, 5, LstorderDetail);
                    var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/order-canceled?id=" + canceled));
                    return RedirectToAction("ViewOrderCustomer", "Order");
                }
                return View();
            }
            catch (Exception)
            {

                return RedirectToAction("AccessDenied", "Account");
            }
        }

        public async Task<ActionResult> ViewOrderCustomer(string? sortOrder)
        {
            try
            {
                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                //-- Lấy danh sách từ api
                var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/get-all-Order"));
                var lstProductvariation = await pService.ShowMyOrder(customer.Id);
                lstOrder = lstOrder.Where(x => x.CustomerId == customer.Id).ToList();

                ViewData["totalInPro"] = lstOrder.Where(x => x.Status == OrderStatus.InProgress).ToList().Count();
                ViewData["totalConfi"] = lstOrder.Where(x => x.Status == OrderStatus.Confirmed).ToList().Count();
                ViewData["totalDelivery"] = lstOrder.Where(x => x.Status == OrderStatus.Delivery).ToList().Count();
                ViewData["totalAcc"] = lstOrder.Where(x => x.Status == OrderStatus.Accomplished).ToList().Count();
                ViewData["totalXCan"] = lstOrder.Where(x => x.Status == OrderStatus.Canceled).ToList().Count();
                ViewData["totalXacNhan"] = lstOrder.Where(x => x.Status == OrderStatus.DaXacNhan).ToList().Count();


                ViewData["InProgress"] = sortOrder == "InProgress" ? "NotSort" : "InProgress";
                ViewData["Confirmed"] = sortOrder == "Confirmed" ? "NotSort" : "Confirmed";
                ViewData["Delivery"] = sortOrder == "Delivery" ? "NotSort" : "Delivery";
                ViewData["Accomplished"] = sortOrder == "Accomplished" ? "NotSort" : "Accomplished";
                ViewData["Returned"] = sortOrder == "InProgress" ? "NotSort" : "Returned";
                ViewData["Canceled"] = sortOrder == "Canceled" ? "NotSort" : "Canceled";
                ViewData["XacNhan"] = sortOrder == "DaXacNhan" ? "NotSort" : "DaXacNhan";

                if(sortOrder == null )
                    lstOrder = lstOrder.Where(x => x.Status == OrderStatus.InProgress).ToList();

                switch (sortOrder)
                {
                    case "InProgress":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.InProgress).ToList();
                        break;
                    case "Confirmed":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.Confirmed).ToList();
                        break;
                    case "Delivery":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.Delivery).ToList();
                        break;
                    case "Accomplished":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.Accomplished).ToList();
                        break;
                    case "Returned":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.Returned).ToList();
                        break;
                    case "Canceled":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.Canceled).ToList();
                        break;
                    case "DaXacNhan":
                        lstOrder = lstOrder.Where(x => x.Status == OrderStatus.DaXacNhan).ToList();
                        break;
                    case "NotSort":
                        lstOrder = lstOrder.ToList();
                        break;
                    default: break;
                }

               
                var data = new OrderDTO() { OrderList = lstOrder.Where(x => x.CustomerId == customer.Id).OrderByDescending(x=> x.CreateDate).ToList(), ShowOrderDtoList = lstProductvariation };

                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IActionResult> PaymentCallback()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);

            if (!response)
            {
                ViewBag.Message = response;
                HttpContext.Session.SetString("mess", "Failed");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
                

            var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
            var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
            List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
            var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(_idDeliveryAddress));
            GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();

            bool result = false;
            if (_pTotalMoney == null)
            {
                result = await pService.AddToOrder(_selectVoucher, _cGiamGia, _cShippingFee, _cTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    _ShippingEmail, _cDescription, _PaymentType, customer.Id, prodOrders);
            }    
            else if(_cTotalMoney == null)
            {
                result = await pService.BuyNow(_selectVoucher, _cGiamGia, _cShippingFee, _pTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    _ShippingEmail, _cDescription, _PaymentType, customer.Id, prodOrders);
            }
            if (!result)
                HttpContext.Session.SetString("mess", "Failed");
            else
            {
                var dataVoucher = new UpdateNumberVoucherDto() { Id = _selectVoucher };
                await Commons.Add_or_UpdateAsync(dataVoucher, String.Concat(Commons.mylocalhost, "Voucher/update-number"));
                HttpContext.Session.SetString("mess", "Success");
            }
            ViewBag.Message = response;
            return RedirectToAction("ShowDetailMyCart", "Product");
        }
    }
}
