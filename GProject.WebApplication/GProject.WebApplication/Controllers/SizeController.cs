using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using X.PagedList;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class SizeController : Controller
    {
        private ISizeService iSizeService;
        public SizeController()
        {
            iSizeService = new SizeService();
        }

        [HttpGet]
        public async Task<ActionResult> Index(int? page)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var data = new SizeDTO() { SizeList = lstObjs };
                if (page == null) page = 1;
                var pageNumber = page ?? 1;
                var pageSize = 5;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(lstObjs.ToPagedList(pageNumber, pageSize));
            }
            catch (Exception)
            {

                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save(SizeDTO Size)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                string url = Commons.mylocalhost;
                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Size() { Id = Size.Id, Code = Size.Code, Name = Size.Name, Status = Size.Status };

                //-- Check hành động là Create hay update
                if (Size.Id == null) url += "Size/add-Size";
                else url += "Size/update-Size";

                //-- Gửi request cho api sử lí
                bool result = await Commons.Add_or_UpdateAsync(prd, url);
                //if (!result) 
                //    HttpContext.Session.SetString("mess", "Failed");
                //else 
                //    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

        }

        [HttpPost]
        public async Task<ActionResult> CheckName(string Name, int? Id)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return Json(new { success = false });

                var lstObjs = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var existName = lstObjs.Any(x => x.Name == Name && (!Id.HasValue || x.Id != Id.Value));
                return Json(new { success = !existName });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public async Task<ActionResult> CheckCode(string Code, int? Id)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return Json(new { success = false });
                var lstObjs = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var existName = lstObjs.Any(x => x.Code == Code && (!Id.HasValue || x.Id != Id.Value));
                return Json(new { success = !existName });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        public async Task<JsonResult> Detail(int id)
        {
            var lstObjs = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
            var data2 = lstObjs.FirstOrDefault(c => c.Id == id);
            return Json(data2);
        }
    }
}
