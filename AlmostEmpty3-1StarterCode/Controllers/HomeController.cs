using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Precoded index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewData["Title"] = "Hut8 Home Page";
            return View();
        }

        /// <summary>
        /// About page for website
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            //ViewData["Title"] = "About Hut8"; // Not the professional way
            return View();
        }
    }
}