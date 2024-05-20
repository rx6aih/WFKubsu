using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class Expenses
	{
		public int Id { get; set; }
		public DateTime ExpenseDate { get; set; }
		public int TotalAmount { get; set; }
		public int Price { get; set; }
		public int Payed {  get; set; }
		public int TotalPrice {  get; set; }
		public string Status { get; set; }

		public int ClientId { get; set; }
		public Client Client { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
