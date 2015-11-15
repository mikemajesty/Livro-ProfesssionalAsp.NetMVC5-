using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Livro_ProfessionalAsp.NetMVC5_.Models;

namespace Livro_ProfessionalAsp.NetMVC5_.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreDBContext db = new MusicStoreDBContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var albums = GetAlbums();

            return View(albums);
        }

        //[Authorize]
        public ActionResult Buy(int id)
        {
            var album = GetAlbums().Single(a => a.AlbumId == id);

            //Charge the user and ship the album!!!
            return View(album);
        }
        public ActionResult DailyDeal()
        {
            var album = GetDailyDeal();
            return PartialView("_DailyDeal", album);
        }
        // Select an album and discount it by 50%
        private Album GetDailyDeal()
        {
            var album = db.Albums
                .OrderBy(a => System.Guid.NewGuid())
                .First();
            album.Price *= 0.5m;
            return album;
        }
        // A simple music catalog
        private static List<Album> GetAlbums()
        {
            var albums = new List<Album>{
                new Album { AlbumId = 1, Title = "The Fall of Math", Price = 8.99M},
                new Album { AlbumId = 2, Title = "The Blue Notebooks", Price = 8.99M},
                new Album { AlbumId = 3, Title = "Lost in Translation", Price = 9.99M },
                new Album { AlbumId = 4, Title = "Permutation", Price = 10.99M },
            };
            return albums;
        }
    }
}
