using Microsoft.EntityFrameworkCore;

namespace Trucking.Entities.Models
{
    public class TruckingDbContext : DbContext
    {
        public TruckingDbContext(DbContextOptions<TruckingDbContext> options) : base(options) { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Freight> Freights { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
    }
}
