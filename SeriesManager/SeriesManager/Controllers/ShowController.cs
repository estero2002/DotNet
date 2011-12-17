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
    public class ShowController : Controller
    {
        private SeriesManagerEntities db = new SeriesManagerEntities();

        //
        // GET: /Show/

        public ViewResult Index()
        {
            return View(db.Shows.ToList());
        }

        //
        // GET: /Show/Details/5

        public ViewResult Details(int id)
        {
            Show show = db.Shows.Find(id);
            return View(show);
        }

        //
        // GET: /Show/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Show/Create

        [HttpPost]
        public ActionResult Create(Show show)
        {
            if (ModelState.IsValid)
            {
                db.Shows.Add(show);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(show);
        }
        
        //
        // GET: /Show/Edit/5
 
        public ActionResult Edit(int id)
        {
            Show show = db.Shows.Find(id);
            return View(show);
        }

        //
        // POST: /Show/Edit/5

        [HttpPost]
        public ActionResult Edit(Show show)
        {
            if (ModelState.IsValid)
            {
                db.Entry(show).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(show);
        }

        //
        // GET: /Show/Delete/5
 
        public ActionResult Delete(int id)
        {
            Show show = db.Shows.Find(id);
            return View(show);
        }

        //
        // POST: /Show/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Show show = db.Shows.Find(id);
            db.Shows.Remove(show);
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