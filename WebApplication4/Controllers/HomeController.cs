using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2PSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        [HttpPost]
        public JsonResult CreateUsers(int Count)
        {
            string test = "";

            try
            {
                test = "Hello World " + Count.ToString();
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Some exception" });

            }

            return Json(new { success = true, value = test });
        }

        [HttpPost]
        public JsonResult CreateLoans()
        {
            int CountLoans = 1000;

            return Json(new { count = CountLoans });
        }

    }
}