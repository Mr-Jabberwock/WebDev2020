using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.Json;
using System.Net;
using WebDev2020.Models;

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
            WebClient client = new WebClient();
            var json = client.DownloadString("https://makersofdenmark20201210180300.azurewebsites.net/api/blog");
            var result = JsonSerializer.Deserialize<List<Blog>>(json);

            ViewData["Data"] = result;

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