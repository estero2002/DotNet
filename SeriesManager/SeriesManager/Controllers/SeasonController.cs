using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeriesManager.Models;

namespace SeriesManager.Controllers
{ 
    public class SeasonController : Controller
    {
        private SeriesManagerEntities db = new SeriesManagerEntities();

        //
        // GET: /Season/

        public ViewResult Index()
        {
            var seasons = db.Seasons.Include(s => s.Show);
            return View(seasons.ToList());
        }

        //
        // GET: /Season/Details/5

        public ViewResult Details(int id)
        {
            Season season = db.Seasons.Find(id);
            return View(season);
        }

        //
        // GET: /Season/Create

        public ActionResult Create()
        {
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name");
            return View();
        } 

        //
        // POST: /Season/Create

        [HttpPost]
        public ActionResult Create(Season season)
        {
            if (ModelState.IsValid)
            {
                db.Seasons.Add(season);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }
        
        //
        // GET: /Season/Edit/5
 
        public ActionResult Edit(int id)
        {
            Season season = db.Seasons.Find(id);
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }

        //
        // POST: /Season/Edit/5

        [HttpPost]
        public ActionResult Edit(Season season)
        {
            if (ModelState.IsValid)
            {
                db.Entry(season).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }

        //
        // GET: /Season/Delete/5
 
        public ActionResult Delete(int id)
        {
            Season season = db.Seasons.Find(id);
            return View(season);
        }

        //
        // POST: /Season/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Season season = db.Seasons.Find(id);
            db.Seasons.Remove(season);
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