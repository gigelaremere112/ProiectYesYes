using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_connection.Models;

namespace test_connection
{
    class MasterContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Car> Cars { get; set; }

        public MasterContext() : base("defaultConnection")
        {
            //Enable-Migrations
            //Add-Migration <migration_name>
            //Update-Database
        }
    }
}
