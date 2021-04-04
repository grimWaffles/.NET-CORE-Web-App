using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class UserController : Controller
    {
        private readonly ApplicationDBContext db;private IJwtAuthenticationManager auth;

        public UserController(ApplicationDBContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] User user)
        {   
            try
            {
                db.Add(user);
                db.SaveChanges();

                return new JsonResult(new
                {
                    message="201 OK"
                });
            }
            catch(Exception e)
            {
                return new JsonResult(new
                {
                    message = "401 Could not save"
                });
            }

        }
    }
}
