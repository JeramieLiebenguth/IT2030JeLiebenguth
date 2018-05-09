using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreManagerController : Controller
    {
        private FinalProjectDB db = new FinalProjectDB();

        
        public ActionResult Index()
        {
            var OrganizeEvents = db.OrganizeEvents.Include(a => a.EventType).Include(a => a.Event);
            return View(OrganizeEvents.ToList());
        }
      
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrganizeEvent organizeevent = db.OrganizeEvents.Find(id);
            if (organizeevent == null)
            {
                return HttpNotFound();
            }
            return View(organizeevent);
        }

      
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name");
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrganizeEventId,EventTypeId,EventId,Title,")] OrganizeEvent organizeevent)
        {
            if (ModelState.IsValid)
            {
                db.OrganizeEvents.Add(organizeevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", organizeevent.EventId);
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Name", organizeevent.EventTypeId);
            return View(organizeevent);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrganizeEvent organizeevent = db.OrganizeEvents.Find(id);
            if (organizeevent == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", organizeevent.EventId);
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Name", organizeevent.EventTypeId);
            return View(organizeevent);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrganizeEventId,EventTypeId,EventId,Title,")] OrganizeEvent organizeevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organizeevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", organizeevent.EventId);
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "EventTypeId", "Name", organizeevent.EventTypeId);
            return View(organizeevent);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrganizeEvent organizeevent = db.OrganizeEvents.Find(id);
            if (organizeevent == null)
            {
                return HttpNotFound();
            }
            return View(organizeevent);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrganizeEvent organizeevent = db.OrganizeEvents.Find(id);
            db.OrganizeEvents.Remove(organizeevent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
      
    }
}
