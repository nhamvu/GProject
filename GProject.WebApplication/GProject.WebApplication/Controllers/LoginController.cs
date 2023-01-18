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
                        return RedirectToAction("Index", "Color");
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
                #region Đăng nhập khi đã tạo đc user
                //var UserInfo = (new Employee(), new Customer());
                //string url = String.Concat(Commons.mylocalhost, $"User/Userlogin?email={user.Email}&password={user.password}");
                //var Rest = new RestSharpHelper(url);
                //var Response = await Rest.RequestBaseAsync(url, RestSharp.Method.Post);
                //if (Response.StatusCode == System.Net.HttpStatusCode.OK && !string.IsNullOrWhiteSpace(Response.Content))
                //{
                //    Response.Content.TryParseJson(out (Employee, Customer) result);
                //    UserInfo = result;
                //}
                //ViewBag.Error = "Đăng nhập không thành công! Vui lòng nhập lại thông tin đăng nhập!";
                ////-- Kiểm tra dữ liệu đầu vào
                //if (ModelState.IsValid == true)
                //{
                //    var Emp = UserInfo.Item1;
                //    var Cus = UserInfo.Item2;
                //    if (Emp != null)
                //    {
                //        var claims = new List<Claim>();
                //        claims.Add(new Claim("username", Emp.Name));
                //        claims.Add(new Claim(ClaimTypes.NameIdentifier, Emp.EmployeeId));
                //        claims.Add(new Claim(ClaimTypes.Email, Emp.EmployeeId));
                //        claims.Add(new Claim(ClaimTypes.Name, Emp.Name));
                //        if (Emp.Position == Data.Enums.EmployeePosition.Manager)
                //        {
                //            claims.Add(new Claim(ClaimTypes.Role, "manager"));
                //        }
                //        else
                //        {
                //            claims.Add(new Claim(ClaimTypes.Role, "employee"));
                //        }
                //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //        await HttpContext.SignInAsync(claimsPrincipal);
                //        return RedirectToAction("Index", "Color");
                //    }
                //    else if (Cus != null)
                //    {
                //        var claims = new List<Claim>();
                //        claims.Add(new Claim("username", Cus.Name));
                //        claims.Add(new Claim(ClaimTypes.NameIdentifier, Cus.CustomerId));
                //        claims.Add(new Claim(ClaimTypes.Email, Cus.Email));
                //        claims.Add(new Claim(ClaimTypes.Name, Cus.Name));
                //        claims.Add(new Claim(ClaimTypes.Role, "customer"));
                //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //        await HttpContext.SignInAsync(claimsPrincipal);
                //        return RedirectToAction("Index", "Color");
                //    }
                //    else { return View(); }
                //}
                //return BadRequest();
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
