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
    public class CategoryController : Controller
    {
        private ICategoryService iCategoryService;
        public CategoryController()
        {
            iCategoryService = new CategoryService();
        }

        [HttpGet]
        public async Task<ActionResult> Index(int? page)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Category>(String.Concat(Commons.mylocalhost, "Category/get-all-Category"));
                var data = new CategoryDTO() { CategoryList = lstObjs };
                if (page == null) page = 1;
                var pageNumber = page ?? 1;
                var pageSize = 5;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                List<Category> lsdata= lstObjs;

                return View(lsdata.ToPagedList(pageNumber, pageSize));
            }
            catch (Exception)
            {

                return RedirectToAction("AccessDenied", "Account");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save( CategoryDTO Category)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return RedirectToAction("AccessDenied", "Account");
                string url = Commons.mylocalhost;
                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Category() { Id = Category.Id, Name = Category.Name, SearchCount = "", Status = Category.Status, Description =Category.Description };
                
                //-- Check hành động là Create hay update
                if (Category.Id == null) url += "Category/add-Category";
                else url += "Category/update-Category";

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

        [HttpPost]
        public async Task<ActionResult> CheckName(string Name)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("myRole")) && HttpContext.Session.GetString("myRole").NullToString() == "customer")
                    return Json(new { success = false });

                var lstObjs = await Commons.GetAll<Category>(String.Concat(Commons.mylocalhost, "Category/get-all-Category"));
                var existName = lstObjs.Any(x => x.Name == Name);
                return Json(new { success = !existName });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }
    }
}
