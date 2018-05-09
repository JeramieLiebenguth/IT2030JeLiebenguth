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


        public ActionResult Index()
        {
            return View(db.EventTypes.ToList());
        }

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


        public ActionResult Create()
        {
            return View();
        }

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