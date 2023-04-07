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
    public class EvaluateController : Controller
    {
        private IEvaluateService iEvaluateService;
        public EvaluateController()
        {
            iEvaluateService = new EvaluateService();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            try
            {
                ////-- Lấy danh sách từ api
                //var lstObjs = await Commons.GetAll<Evaluate>(String.Concat(Commons.mylocalhost, "Evaluate/get-all-Evaluate"));
                //var data = new EvaluateDTO() { EvaluateList = lstObjs };

                ////-- truyền vào message nếu có thông báo
                //if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                //    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                //HttpContext.Session.Remove("mess");
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save(string Id, string ProductId, string Comment, int Rating)
        {
            try
            {
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                if (customer == null) return RedirectToAction("Index", "Login");

                Guid id = string.IsNullOrEmpty(Id) ? Guid.NewGuid() : new Guid(Id);
                string url = Commons.mylocalhost;
                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Evaluate() { Id = id, ProductId = new Guid(ProductId), CustomerId = customer.Id, Comment = Comment, Rating = Rating, CreateDate = DateTime.Now, UpdateDate = DateTime.Now };

                //-- Check hành động là Create hay update
                if (Id == null) url += "Evaluate/add-Evaluate";
                else url += "Evaluate/update-Evaluate";

                //-- Gửi request cho api sử lí
                bool result = await Commons.Add_or_UpdateAsync(prd, url);
                if (!result) 
                    HttpContext.Session.SetString("mess", "Failed");
                else 
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("ProductDetail", "Product", new { product_id = new Guid(ProductId) });
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
