using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportApp.Application.Repositories;
using TransportApp.Domain;

namespace TransportApp.WebApp.Controllers
{
    public class RouteController : Controller
    {
        private readonly IRouteRepository _routeRepo;

        public RouteController(IRouteRepository routeRepo)
        {
            _routeRepo = routeRepo; 
        }
        public async Task<ActionResult> Index()
        {
            var routes = await _routeRepo.GetListRouteAsync();
           
            return View(routes);
        }

       
        // GET: RouteController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RouteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransportApp.Domain.Route route)
        {
            if (ModelState.IsValid)
            {
                await _routeRepo.CreateNewRouteAsync(route);
                TempData["success"] = "A Route Has Been Created";
                return RedirectToAction("Index");
            }
            return View(route);
        }

        // GET: RouteController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var route = await _routeRepo.GetRouteByIdAsync(id);

            return View(route);
        }

        // POST: RouteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TransportApp.Domain.Route route)
        {
            
            if (ModelState.IsValid)
            {
                await _routeRepo.UpdateRouteAsync(route);
                TempData["success"] = $"the route {route.Name} has been edited";
                return RedirectToAction("Index");
            }
            return View(route);
        }

        // GET: RouteController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var route = await _routeRepo.GetRouteByIdAsync(id);

            return View(route);
        }

        // POST: RouteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(TransportApp.Domain.Route route)
        {
            await _routeRepo.DeleteRouteAsync(route);
            TempData["success"] = $"Deleted route {route.Name}";
            return RedirectToAction("Index");
        }
    }
}
