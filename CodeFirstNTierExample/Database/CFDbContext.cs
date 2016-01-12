using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Database
{
    public class CFDbContext : DbContext
    {
        public CFDbContext()
            : base("MyConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Art> Arts { get; set; }

        //If we have to update the database with Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
