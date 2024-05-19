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
	public class ExpensesRepository : IRepository<Expenses>
	{
		private Context db;
		public ExpensesRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Expenses> GetAll()
		{
			return db.Expenses;
		}
		public void Create(Expenses university)
		{
			db.Expenses.Add(university);
		}

		public Expenses Get(int id)
		{
			return db.Expenses.Find(id);
		}

		public void Update(Expenses university)
		{
			db.Entry(university).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Expenses university = db.Expenses.Find(id);
			if (university != null)
			{
				db.Expenses.Remove(university);
			}
		}

		public IEnumerable<Expenses> Find(Func<Expenses, bool> predicate)
		{
			return db.Expenses.Where(predicate).ToList();
		}
	}
}
