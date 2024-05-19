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
	public class PaymentRepository : IRepository<Payment>
	{
		private Context db;
		public PaymentRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Payment> GetAll()
		{
			return db.Payments;
		}
		public void Create(Payment university)
		{
			db.Payments.Add(university);
		}

		public Payment Get(int id)
		{
			return db.Payments.Find(id);
		}

		public void Update(Payment university)
		{
			db.Entry(university).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Payment university = db.Payments.Find(id);
			if (university != null)
			{
				db.Payments.Remove(university);
			}
		}

		public IEnumerable<Payment> Find(Func<Payment, bool> predicate)
		{
			return db.Payments.Where(predicate).ToList();
		}
	}
}
