using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authorization;
using GProject.WebApplication.Models;

namespace GProject.WebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserInfoDTO user)
        {
            try
            {
                //ViewData["ReturnUrl"] = returnUrl;
                ViewBag.Error = "Đăng nhập không thành công! Vui lòng nhập lại thông tin đăng nhập!";
                //-- Kiểm tra dữ liệu đầu vào
                if (ModelState.IsValid == true)
                {
                    if (user.Email == "hideonbush@gmail.com" && user.password == "123")
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", user.Email));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
                        claims.Add(new Claim(ClaimTypes.Email, user.Email));
                        claims.Add(new Claim(ClaimTypes.Name, user.Email));
                        claims.Add(new Claim(ClaimTypes.Role, "admin"));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Index", "Color");
                    }
                    else if (user.Email == "genji@gmail.com" && user.password == "123")
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", user.Email));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
                        claims.Add(new Claim(ClaimTypes.Email, user.Email));
                        claims.Add(new Claim(ClaimTypes.Name, user.Email));
                        claims.Add(new Claim(ClaimTypes.Role, "custom"));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Index","Color");
                    }
                    else { return View(); }
                }
                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await HttpContext.SignOutAsync();
                return Redirect("/");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult AccessDanied()
        {
            return View();
        }
    }
}
