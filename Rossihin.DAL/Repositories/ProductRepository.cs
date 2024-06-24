using Microsoft.EntityFrameworkCore;
using Rossihin.DAL.EF;
using Rossihin.DAL.Entities;
using Rossihin.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossihin.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private Context db;
        public ProductRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }
        public void Create(Product university)
        {
            db.Products.Add(university);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public void Update(Product university)
        {
            db.Entry(university).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product university = db.Products.Find(id);
            if (university != null)
            {
                db.Products.Remove(university);
            }
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            return db.Products.Where(predicate).ToList();
        }
    }
}
