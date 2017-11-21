using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiLogger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Console.WriteLine("HomeController - Index: Hello!");

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
