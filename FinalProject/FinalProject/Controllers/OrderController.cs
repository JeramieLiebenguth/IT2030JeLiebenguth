using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class OrderController : Controller
    {
        FinalProjectDB db = new FinalProjectDB();

        public ActionResult Create()
        {
            return View(db.EventTypes.ToList());
        }


        public ActionResult Cancel(int id, string EventTypeName)
        {
            var organizeeventList = db.OrganizeEvents.Where(a => a.EventTypeId == id).ToList();

            return View();
        }


        public ActionResult TicketsOrdered(int id)
        {
            OrganizeEvent organizeevent = db.OrganizeEvents.Single(a => a.OrganizeEventId == id);
            return View(organizeevent);
        }
    }
}
