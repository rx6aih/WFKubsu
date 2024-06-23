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
    public class ContractRepository : IRepository<Contract>
    {
        private Context db;
        public ContractRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Contract> GetAll()
        {
            return db.Contracts;
        }
        public void Create(Contract book)
        {
            db.Contracts.Add(book);
        }

        public Contract Get(int id)
        {
            return db.Contracts.Find(id);
        }

        public void Update(Contract book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Contract book = db.Contracts.Find(id);
            if (book != null)
            {
                db.Contracts.Remove(book);
            }
        }

        public IEnumerable<Contract> Find(Func<Contract, bool> predicate)
        {
            return db.Contracts.Where(predicate).ToList();
        }
    }
}
