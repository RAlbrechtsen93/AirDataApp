using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirDataApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Select which substance you want to see results of";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Select where you want to see results from";

            return View();
        }
    }
}