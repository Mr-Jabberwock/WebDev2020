using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDev2020.Models;
using Newtonsoft.Json;
using System.IO;
//using Microsoft.AspNetCore.Mvc;

namespace WebDev2020.Controllers
{
    public class MODController : Controller
    {
        WebClient client = new WebClient();
        public ActionResult Blog()
        {
            var json = client.DownloadString("https://makersofdenmark20201027215010.azurewebsites.net/api/blog");
            var result = System.Text.Json.JsonSerializer.Deserialize<List<Blog>>(json);

            ViewData["Data"] = result;

            return View();

        }

        public ActionResult Blogger()
        {
            string url = "https://makersofdenmark20201027215010.azurewebsites.net/api/blog/create";
            Blog blog = new Blog { title = "Ny blog1", firstName = "Dan1", lastName = "Jon1", post = "Postyyyy111", urlPath = "WWW WHatever111", userId = "3fa85f64-5717-4562-b3fc-2c963f66afa6" };
            /*string json = JsonConvert.SerializeObject(blog, Formatting.Indented);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Method = "POST";
            httpWebRequest.Accept = "application/json; charset=utf-8";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                json = json.Replace("\r\n", "");
                //json = json.Replace("\",", "\","   + "\"" +"\u002B");
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
               // pass.Text = result.ToString();
            }*/

            
            var data = System.Text.Json.JsonSerializer.Serialize(blog);
            client.Headers.Add("Content-Type", "text/json");
            var result = client.UploadString(url, data);
            ViewData["Data"] = result;

            return View();
        }
    }
}