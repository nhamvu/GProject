using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GProject.WebApplication.Controllers
{
    public class ColorController : Controller
    {
        private IColorService iColorService;

        public ColorController()
        {
            iColorService = new ColorService();
        }

        [Authorize(Roles ="admin")]
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
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Save(ColorDTO Color)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    string url = "";
                    var prd = new Color(){ Id = Color.Id, HEXCode = Color.HEXCode, Name = Color.Name,Status = Color.Status};
                    if (Color.Id == null) { url = string.Concat(Commons.mylocalhost, "Color/add-Color"); }
                    else { url = string.Concat(Commons.mylocalhost, "Color/update-Color"); }
                    ViewBag.Error = "Successfully !";
                    //-- GTuwir Request cho thằng kia sử lí
                    await Commons.Add_or_UpdateAsync(prd, url);
                    return RedirectToAction("Index");
                }
                else
                {
                    var lstObjs = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                    var data = new ColorDTO() { ColorList = lstObjs };
                    ViewBag.Error = "Failed !";
                    return View(data);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
