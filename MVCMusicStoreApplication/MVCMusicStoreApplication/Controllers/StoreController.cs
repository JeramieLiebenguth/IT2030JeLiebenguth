using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreDb db. = new MVCMusicStoreDB();

        //Browse by Genre
        public ActionResult Browse()
        {
            return View(DBNull.Genres.ToList());
        }

        //Pick an album from the list of albums
    
        public ActionResult Index(int id, string genreName)
        {
            return View();
        }
    }
}