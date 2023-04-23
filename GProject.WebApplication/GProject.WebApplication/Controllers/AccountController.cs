﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authorization;
using GProject.WebApplication.Models;
using GProject.WebApplication.Helpers;
using GProject.Data.DomainClass;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GProject.WebApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(UserManager<Customer> userManager, SignInManager<Customer> signInManager, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

		[HttpPost]
        public async Task<IActionResult> Login(UserInfoDTO user, string returnUrl = null)
        {
            try
            {
                #region Đăng nhập khi đã tạo đc user
                ViewBag.Error = "Đăng nhập không thành công! Vui lòng nhập lại thông tin đăng nhập!";
                //--Kiểm tra dữ liệu đầu vào
                var Employees = await Commons.GetAll<Employee>(String.Concat(Commons.mylocalhost, "Employee/get-all-Employee"));
                Employee Emp = Employees.FirstOrDefault(c => c.Email.ToLower() == user.Email.ToLower() && c.Password == user.password);

                var Customers = await Commons.GetAll<Customer>(String.Concat(Commons.mylocalhost, "Customer/get-all-Customer"));
                Customer Cus = Customers.FirstOrDefault(c => c.Email.ToLower() == user.Email.ToLower() && c.Password == user.password);
                if (Emp != null)
                {
                    Commons.setObjectAsJson(HttpContext.Session, "userLogin", Emp);
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", Emp.Name));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, Emp.EmployeeId));
                    claims.Add(new Claim(ClaimTypes.Email, Emp.EmployeeId));
                    claims.Add(new Claim(ClaimTypes.Name, Emp.Name));
                    claims.Add(new Claim(ClaimTypes.Country, user.Image != null ? user.Image : ""));
                    if (Emp.Position == Data.Enums.EmployeePosition.Manager)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "manager"));
                    }
                    else
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "employee"));
                    }
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl) && !returnUrl.NullToString().Contains("Account"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                else if (Cus != null)
                {
                    Commons.setObjectAsJson(HttpContext.Session, "userLogin", Cus);
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", Cus.Name));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, Cus.Id.ToString()));
                    claims.Add(new Claim(ClaimTypes.Email, Cus.Email));
                    claims.Add(new Claim(ClaimTypes.Name, Cus.Name));
                    claims.Add(new Claim(ClaimTypes.Role, "customer"));
                    claims.Add(new Claim(ClaimTypes.Country, user.Image != null ? user.Image : ""));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl) && !returnUrl.NullToString().Contains("Account"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Product");
                    }
                }
                return RedirectToAction("Login", "Account", new { returnUrl = returnUrl });
                #endregion
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [GProject.WebApplication.Services.Authorize]
        public async Task<IActionResult> Logout()
        {
			await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            HttpContext.Session.Remove("userLogin");
            return Redirect("/");
        }
        [HttpGet]
        public ActionResult GetLocalhost(string str)
        {
            Commons.mylocalhost = str + "/api/";
            return Ok();
        }

        [HttpGet]
        public ActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
			if (remoteError != null)
			{
				ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
				return RedirectToAction(nameof(Login));
			}

			var info = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
			var claims = info.Principal.Claims.ToList();
			// Lấy thông tin người dùng từ Google
			var userName = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
			var userEmail = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

			var lstCustomer = await Commons.GetAll<Customer>(String.Concat(Commons.mylocalhost, "Customer/get-all-Customer"));
            var existCus = lstCustomer.FirstOrDefault(c => c.Email.ToLower() == info.Principal.FindFirstValue(ClaimTypes.Email).ToLower());
            if (existCus == null)
            {
				existCus = new Customer()
				{
					Id = Guid.NewGuid(),
					Name = info.Principal.FindFirstValue(ClaimTypes.Name),
					Email = info.Principal.FindFirstValue(ClaimTypes.Email),
					CustomerId = Commons.RandomString(15),
					Password = "123456",
					CreateDate = DateTime.Now,
					DateOfBirth = DateTime.Now,
					PhoneNumber = "",
					Sex = 0,
					Address = "",
					Status = 0,
					Description = "",
					GoogleId = "",
					Image = ""
				};
				//-- Gửi request cho api sử lí
				bool result = await Commons.Add_or_UpdateAsync(existCus, Commons.mylocalhost + "Customer/add-Customer");
				if (!result)
				{
					return RedirectToAction("Login", "Account", new { returnUrl = returnUrl });
				}
            }
			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
			await HttpContext.SignInAsync(claimsPrincipal);
			Commons.setObjectAsJson(HttpContext.Session, "userLogin", existCus);
			if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl) && !returnUrl.NullToString().Contains("Account"))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Product");
			}
		}

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        public void SetViewBagInt(int? selected_id = null)
        {
            List<SexDTO> SexSTO = new List<SexDTO>()
                {
                    new SexDTO { ID = 0, Sex = "Nam"},
                    new SexDTO { ID = 1, Sex = "Nữ"},
                };
            ViewBag.Sex = new SelectList(SexSTO, "ID", "Sex", selected_id);
        }
        public IActionResult Register()
        {
            SetViewBagInt();
            return View();
        }
        public async Task<ActionResult> SaveRegister(CustomerDTO Customer)
        {
            try
            {
                string image = "";
                if (Customer.Image_Upload != null)
                {
                    string full_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", Customer.Image_Upload.FileName);
                    using (var file = new FileStream(full_path, FileMode.Create))
                    {
                        Customer.Image_Upload.CopyTo(file);
                    }
                    image = Customer.Image_Upload.FileName;
                }
                SetViewBagInt(Customer.Sex);
                //-- Parse lại dữ liệu từ ViewModel
                var cus = new Customer()
                {
                    Id = Customer.Id,
                    Name = Customer.Name,
                    Email = Customer.Email,
                    CustomerId = Commons.RandomString(10),
                    Password = Customer.Password,
                    CreateDate = DateTime.Now,
                    DateOfBirth = Customer.DateOfBirth,
                    PhoneNumber = Customer.PhoneNumber,
                    Sex = Customer.Sex,
                    Address = Customer.Address,
                    Status = 0,
                    Description = Customer.Description,
                    Image = image
                };

                //-- Gửi request cho api sử lí
                bool result = await Commons.Add_or_UpdateAsync(cus, Commons.mylocalhost + "Customer/add-Customer");
                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
