using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class ProductMGRController : Controller
    {
        private IProductMGRService iProductService;
        public ProductMGRController()
        {
            iProductService = new ProductMGRService();
        }

        [HttpGet]
        public async Task<ActionResult> Index(int pg = 1)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                var lstBrand = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
                var lstColor = await Commons.GetAll<ProductVariationDTO>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                var lstSize = await Commons.GetAll<ProductSizeVariation>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));

                const int pageSize = 5;
                if (pg < 1)
                    pg = 1;

                int recsCount = lstObjs.Count();
                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = lstObjs.Skip(recSkip).Take(pageSize).ToList();

                var result = new ProductMGRDTO() { ProductVariationList = lstProductvariation, ProductList = data, ProductVariationViewModel = lstColor.Where(c => c.Status == 1).ToList(), SizeList = lstSize };
                this.ViewBag.Pager = pager;
                //this.ViewBag.Data = data;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(result);
            }
            catch (Exception)
            {

                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                return RedirectToAction("AccessDenied", "Account");
            GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
            ProductMGRDTO product = await pService.GetProductViewModel();
            return View(product);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductMGRDTO Product)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
                bool result = await pService.Save(Product, User.Identity.Name != null ? User.Identity.Name : "");

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Update(Guid? id)
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                return RedirectToAction("AccessDenied", "Account");
            GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
            ProductMGRDTO prd = new ProductMGRDTO();
            prd = await pService.GetProduct(id);
            return View(prd);
        }

        [HttpPost]
        public async Task<ActionResult> Update(ProductMGRDTO Product)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
                bool result = await pService.Save(Product, User.Identity.Name != null ? User.Identity.Name : "");

                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save(ProductMGRDTO Product)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
                bool result = await pService.Save(Product, User.Identity.Name != null ? User.Identity.Name : "");
                
                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

        }
        public async Task<JsonResult> ViewDetail(Guid? id)
        {
            GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
            ProductMGRDTO prd = new ProductMGRDTO();
            prd = await pService.GetProduct(id);
            return Json(prd);
        }

        public async Task<ActionResult> ChangeStatus(Guid id)
        {
            GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
            bool result = await pService.ChangeStatus(id);
            if (!result)
                HttpContext.Session.SetString("mess", "Failed");
            else
                HttpContext.Session.SetString("mess", "Success");
            return Json(result);
        }
    }
}
