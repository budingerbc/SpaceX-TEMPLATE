using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceX.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceX.Controllers
{
    public class AstronautsController : Controller
    {
        private SpaceXContext db = new SpaceXContext();

        public IActionResult Index()
        {
            return View();
        }
    }
}
