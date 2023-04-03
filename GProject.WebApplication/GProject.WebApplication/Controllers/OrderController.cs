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

namespace GProject.WebApplication.Controllers
{
    [Authorize(Roles = "customer")]
    public class OrderController : Controller
    {

        public OrderController()
        {

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

                GProject.WebApplication.Services.OrderService pService = new GProject.WebApplication.Services.OrderService();
                bool result = await pService.AddToOrder(selectVoucher, cGiamGia, cShippingFee, cTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
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
        public async Task<ActionResult> BuyNow(string idDeliveryAddress, string cShippingFee, string pTotalMoney, string ShippingEmail, string cDescription, int PaymentType = 0)
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
                bool result = await pService.BuyNow( cShippingFee, pTotalMoney, dataDeliveryAddress.Name, dataDeliveryAddress.PhoneNumber, dataDeliveryAddress.ProvinceName, dataDeliveryAddress.DistrictName, dataDeliveryAddress.WardName, dataDeliveryAddress.Address,
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
    }
}
