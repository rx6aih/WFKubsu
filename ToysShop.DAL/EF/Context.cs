using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToysShop.DAL.Entities;

namespace ToysShop.DAL.EF
{
	public class Context : DbContext
	{
		public Context()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=ToysShop;UserId=postgres;password=1957");
		}
		
		public DbSet<Client> Clients { get; set; }
		public DbSet<Expenses> Expenses { get; set; }
		public DbSet<Invoices> Invoices { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductGroup> ProductGroups { get; set; }
	}
}
