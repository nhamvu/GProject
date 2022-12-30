using GProject.Api.Models;
using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private ILoginService _iLoginService;

        public LoginController(IConfiguration config)
        {
            _config = config;
            _iLoginService= new LoginService();
        }

        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            UserModel user = new UserModel();
            user.username = username;
            user.password = password;
            IActionResult response = Unauthorized();
            var userInfo = AuthentiCateUser(user);
            if (userInfo != null)
            {
                var access_token = GenerateJSONWebToken(user);
                response = Ok(new { token = access_token });
            }
            return Ok();
        }

        private UserModel AuthentiCateUser(UserModel user)
        {
            return _iLoginService.Login(user.Email, user.password);
        }

        private string GenerateJSONWebToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Sub, user.username),
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);
            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;
        }
    }
}
