using Livro_ProfessionalAsp.NetMVC5_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livro_ProfessionalAsp.NetMVC5_.Controllers
{
    [AllowAnonymous()]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Album =  new Models.Album { Title = "Mike" };
            return View();
        }
        [ChildActionOnly]
        public ActionResult Menu(MenuOptions options)
        {
            return PartialView(options);
        }
    }
}