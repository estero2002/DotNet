using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayedSongs.Models;

namespace PlayedSongs.Controllers
{ 
    public class SongsController : Controller
    {
        private PlayedSongsEntities db = new PlayedSongsEntities();

        //
        // GET: /Songs/

        public ViewResult Index()
        {
            return View(db.Songs.ToList());
        }

        //
        // GET: /Songs/Details/5

        public ViewResult Details(int id)
        {
            Song song = db.Songs.Find(id);
            return View(song);
        }

        //
        // GET: /Songs/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Songs/Create

        [HttpPost]
        public ActionResult Create(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(song);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(song);
        }
        
        //
        // GET: /Songs/Edit/5
 
        public ActionResult Edit(int id)
        {
            Song song = db.Songs.Find(id);
            return View(song);
        }

        //
        // POST: /Songs/Edit/5

        [HttpPost]
        public ActionResult Edit(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Entry(song).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(song);
        }

        //
        // GET: /Songs/Delete/5
 
        public ActionResult Delete(int id)
        {
            Song song = db.Songs.Find(id);
            return View(song);
        }

        //
        // POST: /Songs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Song song = db.Songs.Find(id);
            db.Songs.Remove(song);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}