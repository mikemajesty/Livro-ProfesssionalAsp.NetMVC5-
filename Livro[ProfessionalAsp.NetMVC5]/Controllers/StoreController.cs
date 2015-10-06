using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livro_ProfessionalAsp.NetMVC5_.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse
        [HttpPost]
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        //
        // GET: /Store/Details
        public string Details()
        {
            return "Hello from Store.Details()";
        }
        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message =
               HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }
    }
}