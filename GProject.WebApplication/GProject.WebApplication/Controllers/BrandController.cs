using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class BrandController : Controller
    {
        private IBrandService iBrandService;
        public BrandController()
        {
            iBrandService = new BrandService();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
                var data = new BrandDTO() { BrandList = lstObjs };

                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(data);
            }
            catch (Exception)
            {

                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save( BrandDTO Brand)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                string url = Commons.mylocalhost;
                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Brand() { Id = Brand.Id, Name = Brand.Name, Status = Brand.Status, Description =Brand.Description };

                //-- Check hành động là Create hay update
                if (Brand.Id == null) url += "Brand/add-Brand";
                else url += "Brand/update-Brand";

                //-- Gửi request cho api sử lí
                bool result = await Commons.Add_or_UpdateAsync(prd, url);
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

        public async Task<JsonResult> Detail(int id)
        {
            var lstObjs = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
            var data2 = lstObjs.FirstOrDefault(c => c.Id == id);
            return Json(data2);
        }
    }
}
