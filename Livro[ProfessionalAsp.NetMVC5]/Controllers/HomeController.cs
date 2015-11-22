using Livro_ProfessionalAsp.NetMVC5_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livro_ProfessionalAsp.NetMVC5_.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Titles = "Titulo da página";
            ViewBag.Message = "hello World";
            return View();
        }
        //passing many data with ViewBags, never do it STRONGLY TYPED VIEWS
        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product " + i });
            }
            ViewBag.Albums = albums;
            return View();
        }
        public ActionResult testingViewDataAndViewBag()
        {
            ViewData["Name"] = "Mike LIma";
            return View();
        }

    }
}