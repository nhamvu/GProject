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
    public class OrderController : Controller
    {

        public OrderController()
        {

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

        [HttpPost]
        public async Task<ActionResult> Order(string cTotalMoney, string ShippingFullName, string ShippingPhone,
            string ShippingCity, string ShippingDistrict, string ShippingTown, string ShippingAddress, string ShippingEmail, string cDescription, int PaymentType = 0)
        {
            try
            {
                List<ProdOrder> prodOrders = HttpContext.Session.GetObjectFromJson<List<ProdOrder>>("productOrders");
                var lstCartDetail = await Commons.GetAll<CartDetail>(String.Concat(Commons.mylocalhost, "Cart/get-all-cart-detail"));
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");        

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
                if (customer == null) return RedirectToAction("Index", "Login");

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
    }
}
