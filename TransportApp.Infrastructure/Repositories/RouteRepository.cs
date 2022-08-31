using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;
using TransportAppApplication.Repositories;

namespace TransportApp.Infrastructure.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly ApplicationDbContext _db;

        public RouteRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Route> CreateNewRouteAsync(Route route)
        {
            await _db.Routes.AddAsync(route);
            _db.SaveChanges();
            return route;
        }

        public async Task<Route> DeleteRouteAsync(Route route)
        {
            if (route != null)
            {
                _db.Routes.Remove(route);
                await _db.SaveChangesAsync();
            }
            return null;
        }

        public async Task<List<Route>> GetListRouteAsync()
        {
            var routes = await _db.Routes.Include(x => x.BusStop).ThenInclude(x => x.Street).ToListAsync();
            if (routes != null)
            {
                return routes;
            }
            return null;
        }

        public async Task<Route> UpdateRouteAsync(Route route)
        {
            if (route != null)
            {
                _db.Routes.Update(route);
                await _db.SaveChangesAsync();
            }
            return null;
        }

        public async Task<Route> GetRouteByIdAsync(int id)
        {
            var busStop = await _db.Routes.Include(x => x.BusStop).ThenInclude(x => x.Street).FirstOrDefaultAsync(x => x.Id == id);
            if (busStop != null)
            {
                return busStop;
            }
            return null;
        }
    }
}
