using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;

namespace TransportApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                Database.EnsureCreated();
        }

        public DbSet <Street> Streets { get; set; }
        
        public DbSet<BusStop> BusStops { get; set; }

        public DbSet<Route> Routes { get; set; }
        
        public DbSet<House> Houses { get; set; }
    }
}
