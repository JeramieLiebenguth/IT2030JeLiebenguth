using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class EventTypeMgmtController : Controller
    {
        private FinalProjectDB db = new FinalProjectDB();

        // GET: Genres
        public ActionResult Index()
        {
            return View(db.EventTypes.ToList());
        }

        // GET: Genres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventtype = db.EventTypes.Find(id);
            if (eventtype == null)
            {
                return HttpNotFound();
            }
            return View(eventtype);
        }

        // GET: Genres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventTypeId,Name")] EventType eventtype)
        {
            if (ModelState.IsValid)
            {
                db.EventTypes.Add(eventtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventtype);
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventtype = db.EventTypes.Find(id);
            if (eventtype == null)
            {
                return HttpNotFound();
            }
            return View(eventtype);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventTypeId,Name")] EventType eventtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventtype);
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventtype = db.EventTypes.Find(id);
            if (eventtype == null)
            {
                return HttpNotFound();
            }
            return View(eventtype);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
             EventType eventtype = db.EventTypes.Find(id);
            db.EventTypes.Remove(eventtype);
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