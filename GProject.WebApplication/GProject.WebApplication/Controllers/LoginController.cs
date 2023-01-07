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
                string url = String.Concat(Commons.mylocalhost, $"User/Userlogin?email={user.Email}&password={user.password}");
                //string url = String.Concat(Commons.mylocalhost, "User/UserLogin?email=",user.Email, "&password=",user.password);
                var Rest = new RestSharpHelper(url);
                var Response = await Rest.RequestBaseAsync(url, RestSharp.Method.Post);
                var UserInfo = Response.Content.TryParseJson(out (Employee, Customer) result);

                ViewBag.Error = "Đăng nhập không thành công! Vui lòng nhập lại thông tin đăng nhập!";
                //-- Kiểm tra dữ liệu đầu vào
                if (ModelState.IsValid == true)
                {
                    var Emp = UserInfo.Select(c => c.Item1).FirstOrDefault();
                    var Cus = UserInfo.Select(c => c.Item2).FirstOrDefault();
                    if (Emp != null)
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", Emp.EmployeeId));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, Emp.EmployeeId));
                        claims.Add(new Claim(ClaimTypes.Email, Emp.EmployeeId));
                        claims.Add(new Claim(ClaimTypes.Name, Emp.Name));
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
                        return RedirectToAction("Index", "Color");
                    }
                    else if (Cus != null)
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", Cus.CustomerId));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, Cus.CustomerId));
                        claims.Add(new Claim(ClaimTypes.Email, Cus.Email));
                        claims.Add(new Claim(ClaimTypes.Name, Cus.Name));
                        claims.Add(new Claim(ClaimTypes.Role, "customer"));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Index", "Color");
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
