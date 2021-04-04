using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    //to add a prefix to the routes that use this controller we use the following annotation
    //[Route("Admin/[controller]")]
    public class AppointmentController : Controller
    {
        //Conventional routing
        //[Route("Main")]
        public IActionResult Index()
        {
            string todayDate = DateTime.Now.ToShortDateString();

            return View(); //insert name of view inside function to open custom view
        }

        //Conventional Routing
        //[Route("Details")]
        public IActionResult Details(int id)
        {
            if (id is 0 )
            {
                return Ok("No ID  is present");
            }

            return Ok("Your appt. number is " + id); //send status code along with var as a response
        }

        //Attribute based routing 
       //[Route("Information/{id?}")]
        public IActionResult Information(int id)
        {
            if(id is 0)
            {
                return Ok("Information called!");
            }
            return Ok("Information called for "+id);
        }
    }
}
