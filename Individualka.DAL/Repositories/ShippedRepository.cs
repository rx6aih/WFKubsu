using Anchok.DAL.EF;
using Anchok.DAL.Entites;
using Anchok.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anchok.DAL.Repositories
{
    public class ShippedRepository : IRepository<Shipped>
    {
        private Context db;
        public ShippedRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Shipped> GetAll()
        {
            return db.Shippeds;
        }
        public void Create(Shipped book)
        {
            db.Shippeds.Add(book);
        }

        public Shipped Get(int id)
        {
            return db.Shippeds.Find(id);
        }

        public void Update(Shipped book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shipped book = db.Shippeds.Find(id);
            if (book != null)
            {
                db.Shippeds.Remove(book);
            }
        }

        public IEnumerable<Shipped> Find(Func<Shipped, bool> predicate)
        {
            return db.Shippeds.Where(predicate).ToList();
        }
    }
}
