using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;

namespace TransportAppApplication.Repositories
{
    public interface IRouteRepository
    {
        Task<Route> CreateNewRouteAsync(Route street);

        Task<List<Route>> GetListRouteAsync();

        Task<Route> UpdateRouteAsync(int id);

        Task<Route> DeleteRouteAsync(int id);
    }
}
