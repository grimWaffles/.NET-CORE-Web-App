using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*Types of status codes that can be sent*/

        //StatusCode: 200 - Result OK
        public IActionResult OkResult()
        {
            return Ok(/*insert variables here*/);
        }

        //StatusCode 201- data has  been  submitted and new resource has been created
        public IActionResult CreatedResult()
        {
            return Created("https://localhost:44352/appointment", new { name= "newitem"});
        }

        //StatusCode 204 - There is  no content to be displayed
        public IActionResult NoContentResult()
        {
            return NoContent();
        }

        //StatusCode 400 - This is a bad request result
        public IActionResult BadRequestResult()
        {
            return BadRequest();
        }

        /*Status codes with objects*/ //The real shit

        public IActionResult OkObjectResult()
        {
            var result = new OkObjectResult(new
            {
                message = "200 OK",
                value="This si the result."
            });

            return result;
        }

        //Redirect result
        public IActionResult ResultRedirect()
        {
            return Redirect("https://youtube.com");
        }


        /*Return content results such as views or json*/
        public IActionResult JsonResult()
        {
            return new JsonResult(new
            {
                message = "200 OK",
                date = DateTime.Now.ToShortDateString()

            });
        }

        //Return content result without a view
        public IActionResult ContentResult()
        {
            return Content("<h1>This is the way</h1>");
        }

    }
}
