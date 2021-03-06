using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingDA;

namespace ShoppingCartMVC.Controllers
{
    public class ProductsController : Controller
    {
        private ShoppingContext db = new ShoppingContext();

        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View(db.ProductName.ToList());
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id = 0)
        {
            Products products = db.ProductName.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Products/Create

        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                db.ProductName.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(products);
        }

        //
        // GET: /Products/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Products products = db.ProductName.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        //
        // GET: /Products/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Products products = db.ProductName.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // POST: /Products/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.ProductName.Find(id);
            db.ProductName.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}