using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        //Browse by Genre
        public ActionResult Browse()
        {
            return View(db.Genres.ToList());
        }

        //Pick an album from the list of albums
    
        public ActionResult Index(int id, string genreName)
        {
			var albumList = db.Albums.Where(a => a.GenreId == id).ToList();
			//ViewBag.genreName = genreName
			return View(albumList);
        }

		//See details of an album
		public ActionResult Details(int id)
		{
			Album album = db.Albums.Single(a => a.AlbumId == id);
			return View(album);
		}
    }
}