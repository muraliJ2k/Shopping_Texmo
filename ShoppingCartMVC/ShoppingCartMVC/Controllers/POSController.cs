using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingDA;

namespace ShoppingCartMVC.Controllers
{
    public class POSController : Controller
    {
        //
        // GET: /POS/

        public ActionResult Index()
        {
            ShoppingContext dal = new ShoppingContext();
            List<Products> prod = dal.ProductName.ToList();
            return View(prod);  
           // return View();
        }

    }
}
