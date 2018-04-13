using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models.ViewModels;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        MVCMusicStoreDB dbContext = new MVCMusicStoreDB();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            ShoppingCartViewModel vn = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetCartTotal()
            };
            return View(vn);
        }

        //GET: /ShoppingCart/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            //id is Albumid
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        //POST: Ajax Call
        public ActionResult RemoveFromCart(int id)
        {

            //id == RecordId
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
            string albumTitle = dbContext.Carts.SingleOrDefault(c => c.RecordId == id).AlbumSelected.Title;
            int itemCnt = cart.RemoveFromCart(id);

            ShoppingCartRemoveViewModel vn = new ShoppingCartRemoveViewModel()
            {
                ItemCount = itemCnt,
                DeletedId = id,
                CartTotal = cart.GetCartTotal(),
                Message = albumTitle + " has been removed from the cart"
            };

            return Json(vn);
        }
    }
}