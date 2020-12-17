using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.Json;
using System.Net;
using WebDev2020.Models;
using System.Diagnostics;
using System.IO;
using System.Text;

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

        WebClient client = new WebClient();
        public ActionResult Makerblog()
        {
            var json = client.DownloadString("https://makersofdenmark20201210180300.azurewebsites.net/api/blog");
            var result = JsonSerializer.Deserialize<List<Blog>>(json);

            ViewData["Data"] = result;

            return View();
        }

       [HttpPost]
        public ActionResult MakerBlog(string test) // string post
        {
            /*string url = "https://makersofdenmark20201210180300.azurewebsites.net/api/blog/create";
            Blog blog = new Blog { title = "title", firstName = "Danny", lastName = "Cruize", post = "post", urlPath = "WWW WHatever111", userId = "3fa85f64-5717-4562-b3fc-2c963f66afa6" };
            Console.WriteLine(blog);

            var data = JsonSerializer.Serialize(blog);
            client.Headers.Add("Content-Type", "text/json");
            var result = client.UploadString(url, data);
            ViewData["Data"] = result;*/

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
 