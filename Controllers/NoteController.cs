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
        private readonly ApplicationDBContext db; private readonly IJwtAuthenticationManager auth;

        public NoteController(ApplicationDBContext context,IJwtAuthenticationManager auth)
        {
            this.db = context; this.auth = auth;
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            if (id != 0)
            {
                var result = new JsonResult(db.Notes.Where(c => c.UserId == id));

                return result;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Index([FromBody] Note note)
        {
            try
            {
                db.Add(note); db.SaveChanges();

                return Ok();
            }
            catch(Exception e)
            {
                return new JsonResult(new
                {
                    message = "401 Could not save"
                });
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate([FromQuery] string username,[FromQuery] string password)
        {
            //check if user exists

            var token = auth.Authenticate(username, password);

            if (token != null)
            {
                return Ok(token);
            }

            return Unauthorized();
        }
    }
}
