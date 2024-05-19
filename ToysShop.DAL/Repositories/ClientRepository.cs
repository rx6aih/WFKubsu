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
	public class ClientRepository : IRepository<Client>
	{
		private Context db;
		public ClientRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Client> GetAll()
		{
			return db.Clients;
		}
		public void Create(Client book)
		{
			db.Clients.Add(book);
		}

		public Client Get(int id)
		{
			return db.Clients.Find(id);
		}

		public void Update(Client book)
		{
			db.Entry(book).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Client book = db.Clients.Find(id);
			if (book != null)
			{
				db.Clients.Remove(book);
			}
		}

		public IEnumerable<Client> Find(Func<Client, bool> predicate)
		{
			return db.Clients.Where(predicate).ToList();
		}
	}
}

