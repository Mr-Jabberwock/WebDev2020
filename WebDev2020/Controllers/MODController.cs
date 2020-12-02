using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDev2020.Models;

namespace WebDev2020.Controllers
{
    public class MODController : Controller
    {
        // GET: MOD
        public ActionResult Blog()
        {
            WebClient client = new WebClient();
            var json = client.DownloadString("https://makersofdenmark20201027215010.azurewebsites.net/api/blog");

            var result = JsonSerializer.Deserialize<List<Blog>>(json);

            ViewData["Data"] = result;

            return View();

        }
    }
}