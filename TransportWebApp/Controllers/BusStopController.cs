using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransportWebApp.Controllers
{
    public class BusStopController : Controller
    {
        // GET: BusStopController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BusStopController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BusStopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusStopController/Create
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

        // GET: BusStopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusStopController/Edit/5
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

        // GET: BusStopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusStopController/Delete/5
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
