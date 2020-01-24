using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            string[] products = { "laptop", "desktop", "tablet" };
            ViewData["products"] = products;
            return View();
        }

        public string Details(string product)
        {
            string message = "Selection = " + product;
            return message;
        }
    }
}