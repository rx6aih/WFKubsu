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
	public class ProductGroupRepository : IRepository<ProductGroup>
	{
		private Context db;
		public ProductGroupRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<ProductGroup> GetAll()
		{
			return db.ProductGroups;
		}
		public void Create(ProductGroup university)
		{
			db.ProductGroups.Add(university);
		}

		public ProductGroup Get(int id)
		{
			return db.ProductGroups.Find(id);
		}

		public void Update(ProductGroup university)
		{
			db.Entry(university).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			ProductGroup university = db.ProductGroups.Find(id);
			if (university != null)
			{
				db.ProductGroups.Remove(university);
			}
		}

		public IEnumerable<ProductGroup> Find(Func<ProductGroup, bool> predicate)
		{
			return db.ProductGroups.Where(predicate).ToList();
		}
	}
}
