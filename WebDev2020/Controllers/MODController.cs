using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Blog> blog = new List<Blog>();
            Blog blog1 = new Blog { title = "blog", post = "Posty", firstName = "John", lastName = "Doe", urlPath = "dr.dk", userID = 1 };
            Blog blog2 = new Blog { title = "blog2", post = "Posty2", firstName = "John2", lastName = "Doe2", urlPath = "tv2.dk", userID = 2 };
            blog.Add(blog1);
            blog.Add(blog2);

            ViewData["Data"] = blog;

            return View();

        }
    }
}