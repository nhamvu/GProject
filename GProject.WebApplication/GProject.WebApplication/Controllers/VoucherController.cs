using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GProject.WebApplication.Controllers
{
    public class VoucherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            try
            {
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all"));
                var data = new VoucherDto() { VoucherList = lstObjs };

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
        public async Task<ActionResult> Save(VoucherDto obj)
        {
            try
            {
                string url = Commons.mylocalhost;

                string randomVoucherId = RandomString().ToString();
                var customer = HttpContext.Session.GetObjectFromJson<Customer>("userLogin");
                var lstObjs = await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all"));
                var resultVoucher = lstObjs.Where(x => x.VoucherId == randomVoucherId);
                if (resultVoucher != null) RandomString();
                if(obj.Id == 0) obj.VoucherId = randomVoucherId;

                //-- Parse lại dữ liệu từ ViewModel
                var prd = new Voucher()
                {
                    Id = obj.Id,
                    VoucherId = obj.VoucherId,
                    Name = obj.Name,
                    DiscountRate = obj.DiscountRate,
                    DiscountForm= obj.DiscountForm,
                    NumberOfVouchers = obj.NumberOfVouchers,
                    MinimumOrder= obj.MinimumOrder,
                    ExpirationDate= obj.ExpirationDate,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    EmployeeId = customer.Id,
                    Status = obj.Status
                };

                //-- Check hành động là Create hay update
                if (obj.Id == 0) url += "Voucher/create";
                else url += "Voucher/update";

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
            var lstObjs = await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all"));
            var data2 = lstObjs.FirstOrDefault(c => c.Id == id);
            return Json(data2);
        }

        public string RandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 7)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet]
        public async Task<bool> UpdateSatus(int id)
        {
            await Commons.GetAll<Voucher>(String.Concat(Commons.mylocalhost, "Voucher/get-all?id=" + id));
            return true;
        }
    }
}
