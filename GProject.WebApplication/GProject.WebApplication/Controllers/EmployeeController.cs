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
    [Authorize(Roles = "manager, employee")]
    public class EmployeeController : Controller
    {
        private IEmployeeService iEmployeeService;
        public EmployeeController()
        {
            iEmployeeService = new EmployeeService();
        }

        public async Task<ActionResult> Index(string sId, string sName, string sEmail, string sPhone, int pg = 1)
        {
            try
            {
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Employee>(String.Concat(Commons.mylocalhost, "Employee/get-all-Employee"));
                if (!string.IsNullOrEmpty(sId))
                    lstObjs = lstObjs.Where(c => c.EmployeeId.ToLower().Contains(sId.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sName))
                    lstObjs = lstObjs.Where(c => c.Name.ToLower().Contains(sName.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sEmail))
                    lstObjs = lstObjs.Where(c => c.Email.ToLower().Contains(sEmail.ToLower())).ToList();
                if (!string.IsNullOrEmpty(sPhone))
                    lstObjs = lstObjs.Where(c => c.PhoneNumber.ToLower().Contains(sPhone.ToLower())).ToList();
                const int pageSize = 5;
                if (pg < 1)
                    pg = 1;
                var pager = new Pager(lstObjs.Count(), pg, pageSize);
                var lstData = lstObjs.Skip((pg - 1) * pageSize).Take(pageSize).ToList();
                this.ViewBag.Pager = pager;
                this.ViewData[nameof(sName)] = (object)sName;
                this.ViewData[nameof(sEmail)] = (object)sEmail;
                this.ViewData[nameof(sPhone)] = (object)sPhone;
                this.ViewData[nameof(sId)] = (object)sId;
                var data = new EmployeeDTO() { EmployeeList = lstData };

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
        public async Task<ActionResult> Save( EmployeeDTO Employee)
        {
            try
            {
                string image = "";
                if (Employee.Image_Upload != null)
                {
                    string full_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", Employee.Image_Upload.FileName);
                    using (var file = new FileStream(full_path, FileMode.Create))
                    {
                        Employee.Image_Upload.CopyTo(file);
                    }
                    image = Employee.Image_Upload.FileName;
                }
                string url = Commons.mylocalhost;
                //-- Parse lại dữ liệu từ ViewModel
                var cus = new Employee()
                {
                    Id = Employee.Id,
                    Name = Employee.Name,
                    Email = Employee.Email,
                    Position = Employee.Position,
                    PersonalId = Employee.PersonalId,
                    EmployeeId = Employee.EmployeeId,
                    Password = Employee.Password,
                    CreateDate = DateTime.Now,
                    DateOfBirth = Employee.DateOfBirth,
                    PhoneNumber = Employee.PhoneNumber,
                    Sex = Employee.Sex,
                    Address = Employee.Address,
                    Status = Employee.Status,
                    Description = Employee.Description,
                    Image = image
                };

                //-- Check hành động là Create hay update
                if (Employee.Id == null) url += "Employee/add-Employee";
                else url += "Employee/update-Employee";

                //-- Gửi request cho api sử lí
                bool result = await Commons.Add_or_UpdateAsync(cus, url);
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

        public async Task<JsonResult> Detail(Guid id)
        {
            var lstObjs = await Commons.GetAll<Employee>(String.Concat(Commons.mylocalhost, "Employee/get-all-Employee"));
            var data = lstObjs.FirstOrDefault(c => c.Id == id);
            return Json(data);
        }
    }
}
