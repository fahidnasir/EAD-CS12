using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture15_FirstMVCApplication.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RemoveIt()
        {
            return View();
        }
        public ActionResult RemoveItToo()
        {
            return View();
        }
    }
}