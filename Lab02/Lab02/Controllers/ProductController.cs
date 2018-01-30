using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product/Index is displayed";
        }
        //Products/Browse
        public string Browse()
        {
            return "Browse displayed";
        }
        //Products/Details/105
        public string Details()
        {
            return "Details displayed for Id=105";
        }
        //Products/Location?zip=44124
        public string Location ()
        {
            return "Location displayed for zip=44124";
        }
    }
}