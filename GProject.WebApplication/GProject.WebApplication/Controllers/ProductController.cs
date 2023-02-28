using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace GProject.WebApplication.Controllers
{
    [Authorize(Roles = "customer")]
    public class ProductController : Controller
    {
        //private IProductService iProductService;
        public ProductController()
        {
            //iProductService = new ProductService();
        }

        //[HttpGet]
        //public async Task<ActionResult> Index()
        //{
        //    try
        //    {
        //        //-- Lấy danh sách từ api
        //        var lstObjs = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "Product/get-all-Product"));
        //        var data = new ProductDTO() { ProductList = lstObjs };

        //        //-- truyền vào message nếu có thông báo
        //        if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
        //            ViewData["Mess"] = HttpContext.Session.GetString("mess");
        //        HttpContext.Session.Remove("mess");
        //        return View(data);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //[HttpPost]
        //public async Task<ActionResult> Save( ProductDTO Product)
        //{
        //    try
        //    {
        //        string url = Commons.mylocalhost;
        //        string image = "";
        //        if (Product.Image_Upload != null)
        //        {
        //            string full_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", Product.Image_Upload.FileName);
        //            using (var file = new FileStream(full_path, FileMode.Create))
        //            {
        //                Product.Image_Upload.CopyTo(file);
        //            }
        //            image = Product.Image_Upload.FileName;
        //        }
        //        //-- Parse lại dữ liệu từ ViewModel
        //        var prd = new Product() { Id = Product.Id, HEXCode = Product.HEXCode, Name = Product.Name, Status = Product.Status, Image = image };

        //        //-- Check hành động là Create hay update
        //        if (Product.Id == null) url += "Product/add-Product";
        //        else url += "Product/update-Product";

        //        //-- Gửi request cho api sử lí
        //        bool result = await Commons.Add_or_UpdateAsync(prd, url);
        //        if (!result) 
        //            HttpContext.Session.SetString("mess", "Failed");
        //        else 
        //            HttpContext.Session.SetString("mess", "Success");
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }

        //}

        //public async Task<JsonResult> Detail(int id)
        //{
        //    var lstObjs = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "Product/get-all-Product"));
        //    var data2 = lstObjs.FirstOrDefault(c => c.Id == id);
        //    return Json(data2);
        //}
    }
}
