using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello World.";
            return View();
        }
        [WebApplication1.ActionFilters.ActionFilters]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [WebApplication1.ActionFilters.ActionFilters]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}