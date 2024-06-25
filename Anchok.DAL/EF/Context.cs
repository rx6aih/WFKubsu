using Anchok.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anchok.DAL.EF
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=Anchokk;UserId=postgres;password=1957");
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipped> Shippeds { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
