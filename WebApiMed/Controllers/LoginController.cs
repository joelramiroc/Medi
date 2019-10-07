using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebApi.Core.UserManager;
using WebApiMed.Models;

namespace WebApiMed.Controllers
{
    [Route("api/[controller]")]

    public class LoginController : Controller
    {
        private IConfiguration _config;
        IUserManager userManager;

        public LoginController(IConfiguration config, IUserManager userManager)
        {
            this.userManager = userManager;
            _config = config;
        }


        /// <summary>
        /// Autentica al usuario y retorna el token que lo identifica.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]UserLoginViewModel login)
        {
            IActionResult response = Unauthorized();
            var user = await AuthenticateUser(login);

            if (user == null) return response;
            var tokenString = GenerateJsonWebToken(user);
            response = this.Ok(new { token = tokenString, isAdmin = user.Username == "admin" });
            return response;
        }

        private string GenerateJsonWebToken(UserInformationViewModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token;

            if (userInfo.Username == "admin")
            {
                token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    this._config["Jwt:Issuer"],
                    new Claim[]
                    {
                        new Claim("Administrator", string.Empty),
                        new Claim("UserName", userInfo.Username)
                    },
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);
            }
            else
            {
                token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    null,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);
            }

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<UserInformationViewModel> AuthenticateUser(UserLoginViewModel login)
        {
            var user = await this.userManager.GetUserByUsername(login.Username, login.Password);

            return login.Username != null ? new UserInformationViewModel { Username = user.UserName } : null;
        }
    }
}