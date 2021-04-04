using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{   
    [Authorize]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        private readonly ApplicationDBContext db;

        public NoteController(ApplicationDBContext context)
        {
            this.db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            //check if the user is authenticated
            var currentUser = HttpContext.User;

            int id = CheckUserValidity(currentUser);

            if (id != 0)
            {
                var result = new JsonResult(db.Notes.Where(c => c.UserId == id));

                return result;
            }
            else
            {
                return new JsonResult(new
                {
                    message = "Id is " + id
                }) ;
            }
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Index([FromBody] Note note)
        {
            var currentUser = HttpContext.User;

            int id = CheckUserValidity(currentUser); //Reviews token to find if the suer crendentials match.

            if (id != 0)
            {
                return Unauthorized();
            }

            try
            {
                db.Add(note); db.SaveChanges();

                return Ok(note);
            }
            catch(Exception e)
            {
                return Unauthorized();
            }
        }

        private int CheckUserValidity(System.Security.Claims.ClaimsPrincipal currentUser)
        {
            if(currentUser.HasClaim(c => c.Type == "UserId"))
            {
                int id = int.Parse(currentUser.Claims.First(c => c.Type == "UserId").Value);

                return id;
            }

            return 0;
        }
    }
}
