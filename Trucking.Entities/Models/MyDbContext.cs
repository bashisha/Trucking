using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trucking.Entities.Models
{
    public class MyDbContext
    {
        public class TruckingDbContext : DbContext
        {
            //string  connection = @".\SQLEXPRESS;Initial Catalog=Trucking;Integrated Security=True";
            //services.AddDbContext<TruckingDbContext>(options => options.UseSqlServer(connection));

            //DbContextOptions<TruckingDbContext> options = new DbContextOptions<TruckingDbContext>("");

            public TruckingDbContext(DbContextOptions<TruckingDbContext> options) : base(options) { }
            public virtual DbSet<Customer> Customers { get; set; }
            public virtual DbSet<Freight> Freights { get; set; }
            public virtual DbSet<Owner> Owners { get; set; }
            public virtual DbSet<Truck> Trucks { get; set; }
            public virtual DbSet<Address> Addresses { get; set; }
            public virtual DbSet<Driver> Drivers { get; set; }
        }
    }
}
