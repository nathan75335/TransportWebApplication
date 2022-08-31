using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;

namespace TransportAppApplication.Repositories
{
    public interface IBusStopRepository
    {
        Task<BusStop> CreateNewBusStopAsync(BusStop street);

        Task<List<BusStop>> GetListBusStopAsync();

        Task<BusStop> UpdateBusStopAsync(int id);

        Task<BusStop> DeleteBusStopAsync(int id);
    }
}
