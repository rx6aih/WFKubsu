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
    public class InvoiceRepository : IRepository<Invoice>
    {
        private Context db;
        public InvoiceRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Invoice> GetAll()
        {
            return db.Invoices;
        }
        public void Create(Invoice university)
        {
            db.Invoices.Add(university);
        }

        public Invoice Get(int id)
        {
            return db.Invoices.Find(id);
        }

        public void Update(Invoice university)
        {
            db.Entry(university).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Invoice university = db.Invoices.Find(id);
            if (university != null)
            {
                db.Invoices.Remove(university);
            }
        }

        public IEnumerable<Invoice> Find(Func<Invoice, bool> predicate)
        {
            return db.Invoices.Where(predicate).ToList();
        }
    }
}
