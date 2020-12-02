using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebDev2020.Models;

namespace WebDev2020.Controllers
{
    public class MODController : Controller
    {
        // GET: MOD
        [HttpGet]
        public ActionResult Blogs()
        {
            WebClient client = new WebClient();
            var json = client.DownloadString("https://makersofdenmark20201027215010.azurewebsites.net/api/blog");

            //check op på serialication / deserialication
            //det kaldes mapping
            var result = JsonSerializer.Deserialize<List<Blog>>(json);
            int stop = 0;

            ViewData["Data"] = result;

            return View();

        }
    }
}