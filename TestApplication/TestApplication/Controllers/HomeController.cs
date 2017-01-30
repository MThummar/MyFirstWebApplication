using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JavaScript()
        {
            return new FilePathResult("~/Views/Home/JavaScriptExample.html", "text/html");
        }
        public ActionResult JQuery()
        {
            return new FilePathResult("~/Views/Home/JQueryExample.html", "text/html");
        }
        public ActionResult Css()
        {
            return new FilePathResult("~/Views/Home/CSSExample.html", "text/html");
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
    }
}