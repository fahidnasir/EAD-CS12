using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture16_ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.AnyThing = "this is a message";
            ViewBag.BooleanValue = true;

            return View();
        }

        public string SecondPage(int ab, string xy)
        {
            return "this is the repose from SecondPage Action of HomeController.";
        }
    }
}