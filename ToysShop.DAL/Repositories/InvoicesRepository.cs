using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToysShop.DAL.EF;
using ToysShop.DAL.Entities;
using ToysShop.DAL.Interfaces;

namespace ToysShop.DAL.Repositories
{
	public class InvoicesRepository : IRepository<Invoices>
	{
		private Context db;
		public InvoicesRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Invoices> GetAll()
		{
			return db.Invoices;
		}
		public void Create(Invoices university)
		{
			db.Invoices.Add(university);
		}

		public Invoices Get(int id)
		{
			return db.Invoices.Find(id);
		}

		public void Update(Invoices university)
		{
			db.Entry(university).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Invoices university = db.Invoices.Find(id);
			if (university != null)
			{
				db.Invoices.Remove(university);
			}
		}

		public IEnumerable<Invoices> Find(Func<Invoices, bool> predicate)
		{
			return db.Invoices.Where(predicate).ToList();
		}
	}
}
