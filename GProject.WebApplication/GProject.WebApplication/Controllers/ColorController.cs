using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using GProject.WebApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Net.Mail;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static IdentityServer4.Models.IdentityResources;
using System.Configuration;
using GProject.WebApplication.Helpers;
using Twilio.Types;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class ColorController : Controller
    {
        private IColorService iColorService;
        public ColorController()
        {
            iColorService = new ColorService();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            try
            {
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                var data = new ColorDTO() { ColorList = lstObjs };

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

        [HttpPost]
        public async Task<ActionResult> Save( ColorDTO Color)
        {
            try
            {
                string url = Commons.mylocalhost;
                string image = "";
                if (Color.Image_Upload != null)
                {
                    string full_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", Color.Image_Upload.FileName);
                    using (var file = new FileStream(full_path, FileMode.Create))
                    {
                        Color.Image_Upload.CopyTo(file);
                    }
                    image = Color.Image_Upload.FileName;
                }
                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Color() { Id = Color.Id, HEXCode = Color.HEXCode, Name = Color.Name, Status = Color.Status, Image = image };

                //-- Check hành động là Create hay update
                if (Color.Id == null) url += "Color/add-Color";
                else url += "Color/update-Color";

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
                return BadRequest();
            }

        }

        public async Task<JsonResult> Detail(int id)
        {
            var lstObjs = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
            var data2 = lstObjs.FirstOrDefault(c => c.Id == id);
            return Json(data2);
        }
    }
}
