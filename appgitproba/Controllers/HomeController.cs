using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using appgitproba.Models;

namespace appgitproba.Controllers
{
    public class HomeController : Controller
    {
        CarDB _db = new CarDB();
        public ActionResult Index()
        {
            var model = _db.Cars.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
