using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext db;
        public ItemController(ApplicationDBContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> items = db.Items; 

            return View(items);
        }
    }
}
