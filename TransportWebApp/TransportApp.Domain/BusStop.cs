using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp.Domain
{
    public class BusStop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StreetId { get; set; }

        public Street Street { get; set; }

        public List <Route> Routes { get; set; }
    }
}
