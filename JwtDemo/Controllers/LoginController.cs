using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace JwtDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public string GetToken() {
            SecurityToken securityToken = new JwtSecurityToken(
                issuer: "issuer",
                audience: "audience",
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes("laozhanglaozhanglaozhanglaozhang")),
                    SecurityAlgorithms.HmacSha256),
                expires: DateTime.Now.AddHours(1),
                claims: new Claim[] { }
                );
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
