using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authorization;
using GProject.WebApplication.Models;
using GProject.WebApplication.Helpers;
using GProject.Data.DomainClass;
using Microsoft.AspNetCore.Identity;

namespace GProject.WebApplication.Controllers
{
    [AllowAnonymous]
    public class OAuthController : Controller
    {
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;
        private readonly ILogger<OAuthController> _logger;

        public OAuthController(UserManager<Customer> userManager, SignInManager<Customer> signInManager, ILogger<OAuthController> logger)
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
                Employee Emp = Employees.FirstOrDefault(c => c.Email.ToLower() == user.Email.ToLower() && c.Password == user.password.ToLower());

                var Customers = await Commons.GetAll<Customer>(String.Concat(Commons.mylocalhost, "Customer/get-all-Customer"));
                Customer Cus = Customers.FirstOrDefault(c => c.Email.ToLower() == user.Email.ToLower() && c.Password == user.password.ToLower());
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
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Color");
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
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Product");
                    }
                }
                return RedirectToAction("Login", "OAuth", new { returnUrl = returnUrl });
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

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        [HttpGet]
        public ActionResult GetLocalhost(string str)
        {
            Commons.mylocalhost = str + "/api/";
            return Ok();
        }

        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "OAuth", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in via {Name} provider.", info.LoginProvider);
                return LocalRedirect(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToAction(nameof(Logout));
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return RedirectToAction("ExternalLoginConfirmation", new ExternalLoginViewModel { Email = email });
            }
        }

        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    throw new ApplicationException("Error loading external login information during confirmation.");
                }

                var user = new Customer { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User created an account using {Name} provider.", info.LoginProvider);
                        return LocalRedirect(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewData["ReturnUrl"] = returnUrl;
            return RedirectToAction("ExternalLogin", new { provider = "google" });
        }

        [HttpGet]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new Customer { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User logged in.");

                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }

            return View(model);
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

    }
}
