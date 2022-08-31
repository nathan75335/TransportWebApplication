
using System.ComponentModel.DataAnnotations;


namespace TransportApp.Domain
{
    public class Street
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int HouseId { get; set; }

        public House House { get; set; }
        
        public List<BusStop> BusStops { get; set; }
    }
}
