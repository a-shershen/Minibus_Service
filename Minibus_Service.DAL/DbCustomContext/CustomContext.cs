using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.DbCustomContext
{
    class CustomContext:DbContext
    {
        public CustomContext(string connectionString)
            :base(connectionString)
        {
            Database.SetInitializer<CustomContext>(new DbInitializer());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
    }
}
