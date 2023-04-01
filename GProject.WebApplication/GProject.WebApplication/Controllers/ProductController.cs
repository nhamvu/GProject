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
using System.Drawing;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GProject.WebApplication.Services;
using GProject.WebApplication.Models.DeliveryAddressAndShippingFee;

namespace GProject.WebApplication.Controllers
{
    [Authorize(Roles = "customer")]
    public class ProductController : Controller
    {
        private readonly DeliveryAddressAndShippingFeeService _deliveryAddressAndShippingFeeService;
        public ProductController()
        {
            _deliveryAddressAndShippingFeeService = new DeliveryAddressAndShippingFeeService();
        }

        //[HttpGet]
        public async Task<ActionResult> Index(int? type, int pg = 1, int pageSize = 8)
        {
            try
            {
                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                var data = await pService.GetDataForIndex(type.NullToString(), pg, pageSize);
				this.ViewBag.Pager = data.pager;
				return View(data.tuple);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }

        [Route("/productdetail/{product_id}")]
		public async Task<ActionResult> ProductDetail(Guid product_id)
		{
			try
			{
                ViewBag.Province = (await _deliveryAddressAndShippingFeeService.GetDataProvincesAsync()).OrderBy(x => x.ProvinceID);
                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                return View(await pService.GetProductDetail(product_id, customer));
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
		}

        public async Task<ActionResult> AddToCart(string cTotalMoney, string cColor, string cSize, string cQuantity, string cPrice, string cProductId, string cDescription)
        {
            try
            {
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");

                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                bool result = await pService.AddToCart(cTotalMoney, cColor, cSize, cQuantity, cPrice, cProductId, cDescription, customer.Id);
                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("ProductDetail", "Product", new { product_id = new Guid(cProductId) });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }



        [HttpGet]
        public ActionResult Order(string products)
        {
            List<ProdOrder> lstProdOrders = JsonConvert.DeserializeObject<List<ProdOrder>>(products);
            Commons.setObjectAsJson(HttpContext.Session, "productOrders", lstProdOrders);
            // Xử lý danh sách đối tượng ở đây
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> RemoveToCart(string products)
        {
            List<ProdOrder> lstProdOrders = JsonConvert.DeserializeObject<List<ProdOrder>>(products);
            var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
            foreach (var item in lstProdOrders)
            {
                string urlRemoveCartDetail = string.Concat(Commons.mylocalhost, "Cart/delete-cart-detail?id=", new Guid(item.cartId), "&productVariation_id=", new Guid(item.prodVariationId));
                var RestRemoveCartDetail = new RestSharpHelper(urlRemoveCartDetail);
                var resRemoveCartDetail = await RestRemoveCartDetail.RequestBaseAsync(urlRemoveCartDetail, RestSharp.Method.Delete);
                if (!resRemoveCartDetail.IsSuccessful)
                    HttpContext.Session.SetString("mess", "Failed");
            }
            HttpContext.Session.SetString("mess", "Success");
            var productId = lstProductvariation.Where(c => c.Id == new Guid(lstProdOrders.Select(c => c.prodVariationId).FirstOrDefault())).Select(c => c.ProductId).FirstOrDefault();
            // Xử lý danh sách đối tượng ở đây
            return RedirectToAction("ProductDetail", "Product", new { product_id = productId });
        }
        [HttpGet]
        public ActionResult GetCustomerInfo()
        {
            var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
            return Ok(customer);
        }

        [HttpGet]
        public async Task<ActionResult> ReleaseHeart(string cProductId)
        {
            try
            {
                GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();
                await pService.ReleaseHeart(cProductId);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Login");
            }
        }
        public async Task<ActionResult> ShowDetailMyCart(string prodName, int? brand, decimal? fPrice, decimal? tPrice, int idProvince)
		{
			try
			{
                //get data delivery address 

                ViewBag.Province = (await _deliveryAddressAndShippingFeeService.GetDataProvincesAsync()).OrderBy(x => x.ProvinceID);


                //

                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
				if (customer == null) return RedirectToAction("Index", "Login");
				decimal valFromPrice = fPrice.HasValue ? fPrice.Value : -1;
				decimal valToPrice = tPrice.HasValue ? tPrice.Value : -1;
				int valBrand = brand.HasValue ? brand.Value : -1;

				this.ViewData[nameof(prodName)] = (object)prodName;
				this.ViewData[nameof(fPrice)] = (object)valFromPrice;
				this.ViewData[nameof(tPrice)] = (object)valFromPrice;
				this.ViewData[nameof(brand)] = (object)valBrand;
				GProject.WebApplication.Services.ProductService pService = new GProject.WebApplication.Services.ProductService();

                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(await pService.ShowMyCart(customer.Id, prodName, valFromPrice, valToPrice, valBrand));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return RedirectToAction("AccessDenied", "Login");
			}
		}

        public ActionResult ProdNomal()
        {
            return RedirectToAction("Index", "Product", new { type = 0 });
        }
        public ActionResult ProdNew()
        {
            return RedirectToAction("Index", "Product", new { type = 1 });
        }
        public ActionResult ProdFeatured()
        {
            return RedirectToAction("Index", "Product", new { type = 2 });
        }
        public ActionResult ProdFavorited()
        {
            return RedirectToAction("Index", "Product", new { type = 3 });
        }
        public ActionResult ProdPromotional()
        {
            return RedirectToAction("Index", "Product", new { type = 4 });
        }

        [HttpGet]
        public async Task<JsonResult> GetDistricts(int id)
        {
            var districts = await _deliveryAddressAndShippingFeeService.GetDataDistrictsAsync(id);
            return Json(districts);
        }

        [HttpGet]
        public async Task<JsonResult> GetWards(int id)
        {
            var wards = await _deliveryAddressAndShippingFeeService.GetDataWardAsync(id);
            return Json(wards);
        }

        [HttpGet]
        public async Task<JsonResult> ShippingFee(int district_id, string ward_code)
        {
            var fee = await _deliveryAddressAndShippingFeeService.ShippingFee(district_id, ward_code);
            return Json(fee);
        }
    }
}
