using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp.Domain
{
    public class Street
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        /// <summary>
        /// House Number of the house that are located next to the stop
        /// </summary>
        public List<int> NeighboursNumbers { get; set; }
        
        public List<BusStop> BusStops { get; set; }
    }
}
