﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransportWebApp.Controllers
{
    public class HouseController : Controller
    {
        // GET: HouseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HouseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HouseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HouseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HouseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HouseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HouseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HouseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
