using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp.Domain
{
    public  class Route
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BusStopId { get; set; }

        public BusStop BusStop { get; set; }
    }
}
