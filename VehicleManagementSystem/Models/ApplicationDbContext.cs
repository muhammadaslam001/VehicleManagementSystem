using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VehicleManagementSystem.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() :base("MySQLiteConnection1")
        { }
        public DbSet<Car> Cars { get; set; }
    }
}