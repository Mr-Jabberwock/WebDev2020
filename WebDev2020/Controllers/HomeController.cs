using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDev2020.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          
          return View();
        }

        public ActionResult Header()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
        public ActionResult Makerspace()
        {
            return View();
        }

        public ActionResult Makerblog()
        {
            return View();
        }

        public ActionResult Forum()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

    }
}