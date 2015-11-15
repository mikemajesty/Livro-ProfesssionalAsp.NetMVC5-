using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Livro_ProfessionalAsp.NetMVC5_.Models;

namespace Livro_ProfessionalAsp.NetMVC5_.Controllers
{
    public class StoreManagerController : Controller
    {
        private MusicStoreDBContext db = new MusicStoreDBContext();

        // GET: StoreManager
        public ActionResult Index()
        {
            return View(db.Albums.Include(c=>c.Genre).Include(c=>c.Artist).ToList());
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
        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name");
            ViewBag.ArtistID = new SelectList(db.Artists,"ArtistID","Name");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlbumID,Name,Title")] Album album)
        {
            if (ModelState.IsValid)
            {
                UpdateModel(album);
                db.Albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(album);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlbumID,Name,Title")] Album album)
        {
            if (ModelState.IsValid)
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(album);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Album album = db.Albums.Find(id);
            db.Albums.Remove(album);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
