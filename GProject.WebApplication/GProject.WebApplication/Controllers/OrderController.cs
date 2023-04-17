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
        public async Task<ActionResult> Order(int selectVoucher, string cGiamGia, string idDeliveryAddress, string cShippingFee, string cTotalMoney, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var deliveryAddressesList = await Commons.GetAll<DeliveryAddress>(String.Concat(Commons.mylocalhost, "DeliveryAddress/get-all"));
                var dataDeliveryAddress = deliveryAddressesList.FirstOrDefault(x => x.Id == Convert.ToInt32(idDeliveryAddress));
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");
                if (PaymentType == 1)
                {
                    _selectVoucher = selectVoucher;
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

                if (PaymentType == 1)
                {
                    _selectVoucher = selectVoucher;
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

        public async Task<ActionResult> Index(Guid? accomplished, Guid? canceled)
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
                    var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/order-canceled?id=" + canceled));
                    return RedirectToAction("ViewOrderCustomer", "Order");
                }
                return View();
            }
            catch (Exception)
            {

                throw;
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

                ViewData["InProgress"] = sortOrder == "InProgress" ? "NotSort" : "InProgress";
                ViewData["Confirmed"] = sortOrder == "Confirmed" ? "NotSort" : "Confirmed";
                ViewData["Delivery"] = sortOrder == "Delivery" ? "NotSort" : "Delivery";
                ViewData["Accomplished"] = sortOrder == "Accomplished" ? "NotSort" : "Accomplished";
                ViewData["Returned"] = sortOrder == "InProgress" ? "NotSort" : "Returned";
                ViewData["Canceled"] = sortOrder == "Canceled" ? "NotSort" : "Canceled";

                lstOrder = lstOrder.Where(x => x.CustomerId == customer.Id).ToList();

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
            //return View(response);
        }

        //[HttpGet]
        public async Task<IActionResult> OrderCanceledAsync(Guid id)
        {
            var lstOrder = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/order-canceled?id=" + id));
            return RedirectToAction("ViewOrderCustomer", "Order");
        }

        
    }
}
