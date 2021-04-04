using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IConfiguration config; //used to read the json key and issuer
        private readonly ApplicationDBContext db;

        public LoginController(IConfiguration configuration,ApplicationDBContext context)
        {
            this.config = configuration;
            this.db = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            //prepare negative result 
            IActionResult response = Unauthorized();
            //check if user exists
            var thisUser = AuthenticateUser(user); //returns null if user does not exist in DB

            if (thisUser == null || thisUser.Id==0)
            {
                return response;
            }

            //Generate web token and return response
            var tokenString = GenerateJwt(user);
            response = Ok(tokenString);

            return response;
        }

        private string GenerateJwt(User user)
        {
            //needed to make the credentials, value fetched from appsettings.json
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:key"]));

            //encrypts the security key with the chosen algorithm
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Username),
                new Claim("UserId",user.Id.ToString())
            };

            var token = new JwtSecurityToken(config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User AuthenticateUser(User user)
        {
            int id = 0;

            IEnumerable<User> currentUser = db.Users.Where(u => u.Username == user.Username && u.Password == user.Password);

            if (currentUser != null)
            {
                foreach (User u in currentUser)
                {
                    id = u.Id;
                }

                user.Id = id;

                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
