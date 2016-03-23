using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EURIS.Service;
using EURIS.Entities;

namespace EURISTest.Controllers
{
    public class ProdottoController : Controller
    {
        // GET: Prodotto
        public ActionResult Index()
        {
            ProdottoService prod = new ProdottoService();
            List<Prodotto> prodotti = prod.GetProdotti();

            ViewBag.Prodotti = prodotti;

            return View();
        }

        // GET: Prodotto/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Prodotto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prodotto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prodotto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prodotto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prodotto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prodotto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
