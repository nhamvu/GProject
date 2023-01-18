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
                var lstObjs = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                var data = new ColorDTO() { ColorList = lstObjs };
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
                var prd = new Color() { Id = Color.Id, HEXCode = Color.HEXCode, Name = Color.Name, Status = Color.Status };
                if (Color.Id == null) { url = string.Concat(Commons.mylocalhost, "Color/add-Color"); }
                else { url = string.Concat(Commons.mylocalhost, "Color/update-Color"); }
                //-- GTuwir Request cho thằng kia sử lí
                await Commons.Add_or_UpdateAsync(prd, url);
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
