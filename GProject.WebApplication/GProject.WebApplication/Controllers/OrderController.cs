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
using GProject.Data.Enums;
using GProject.WebApplication.Models.Payments;
using GProject.WebApplication.Services.IServices;
using GProject.WebApplication.Services;

namespace GProject.WebApplication.Controllers
{
    [Authorize(Roles = "customer")]
    public class OrderController : Controller
    {
        private readonly IVnPayService _vnPayService;
        public OrderController(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost]
        public async Task<ActionResult> Order(int selectVoucher, string cGiamGia, string idDeliveryAddress, string cShippingFee, string cTotalMoney,  string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
                var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(idDeliveryAddress));
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");        
                if(PaymentType == 1)
                {
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

                if(!PaymentCallback()) HttpContext.Session.SetString("mess", "Failed");

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.AddToOrder(selectVoucher, cGiamGia, cShippingFee, cTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                {

                    var dataVoucher = new UpdateNumberVoucherDto() { Id = selectVoucher };
                    await Commons.Add_or_UpdateAsync(dataVoucher, String.Concat(Commons.mylocalhost, "Voucher/update-number"));

                    HttpContext.Session.SetString("mess", "Success");
                }
                   

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
        public async Task<ActionResult> BuyNow(int selectVoucher, string cGiamGia, string idDeliveryAddress, string cShippingFee, string pTotalMoney, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
                var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(idDeliveryAddress));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.BuyNow(selectVoucher, cGiamGia, cShippingFee, pTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
                    ShippingEmail, cDescription, PaymentType, customer.Id, prodOrders);

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                {
                    var dataVoucher = new UpdateNumberVoucherDto() { Id = selectVoucher };
                    await Commons.Add_or_UpdateAsync(dataVoucher, String.Concat(Commons.mylocalhost, "Voucher/update-number"));
                    HttpContext.Session.SetString("mess", "Success");
                }

                HttpContext.Session.Remove("productOrders");
                return RedirectToAction("ShowDetailMyCart", "Product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }

        public async Task<ActionResult> ViewOrderCustomer(int? trangthai)
        {
            try
            {
                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                //-- Lấy danh sách từ api
                var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/get-all-Order"));
                var lstProductvariation = await pService.ShowMyOrder(customer.Id);

                lstOrder = lstOrder.Where(x => x.CustomerId == customer.Id).ToList();
                if(trangthai != null) lstOrder = lstOrder.Where(x => x.Status == (OrderStatus) trangthai).ToList();
                
                var data = new OrderDTO() { OrderList = lstOrder.Where(x => x.CustomerId == customer.Id).ToList() , ShowOrderDtoList = lstProductvariation };
                
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

        public IActionResult PaymentCallback()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);
            return response;
        }
    }
}
