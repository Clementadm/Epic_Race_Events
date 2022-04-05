using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class PilotesController : Controller
    {
        // GET: Pilotes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pilotes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pilotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pilotes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pilotes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pilotes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pilotes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pilotes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}