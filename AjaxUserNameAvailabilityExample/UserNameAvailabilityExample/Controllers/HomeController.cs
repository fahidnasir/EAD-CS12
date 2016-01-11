using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserNameAvailabilityExample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CheckUserName()
        {

            string userName = Request["UserName"];
           
            //check from database

           // List<Student> list = new List<Student>();


            return this.Json(true,JsonRequestBehavior.AllowGet);
           
        }
    }
}
