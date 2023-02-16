using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authorization;
using GProject.WebApplication.Models;
using GProject.WebApplication.Helpers;
using GProject.Data.DomainClass;

namespace GProject.WebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserInfoDTO user)
        {
            try
            {
                #region Đăng nhập tạm khi chưa tạo đc user
                ViewBag.Error = "Đăng nhập không thành công! Vui lòng nhập lại thông tin đăng nhập!";
                if (ModelState.IsValid == true)
                {
                    if ((user.Email == "manager@gmail.com" || user.Email == "employee@gmail.com") && user.password == "123")
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", user.Email));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
                        claims.Add(new Claim(ClaimTypes.Email, user.Email));
                        claims.Add(new Claim(ClaimTypes.Name, "Trần Văn B"));
                        claims.Add(new Claim(ClaimTypes.Country, user.Image != null ? user.Image : ""));
                        if (user.Email == "manager@gmail.com")
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
                        return RedirectToAction("Index", "ProductMGR");
                    }
                    else if (user.Email == "customer@gmail.com" && user.password == "123")
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", user.Email));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
                        claims.Add(new Claim(ClaimTypes.Email, user.Email));
                        claims.Add(new Claim(ClaimTypes.Name, "Nguyễn Văn A"));
                        claims.Add(new Claim(ClaimTypes.Role, "customer"));
                        claims.Add(new Claim(ClaimTypes.Country, user.Image != null ? user.Image : ""));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Index", "Home");
                    }
                    else { return View(); }
                }
                return BadRequest();
                #endregion
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetLocalhost(string str)
        {
            Commons.mylocalhost = str + "/api/";
            return Ok();
        }
    }
}
