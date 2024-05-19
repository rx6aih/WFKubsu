using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class Invoices
	{
		public int Id { get; set; }
		public DateTime InvoiceDate { get; set; }
		public int TotalAmount {  get; set; }
		public int Price {  get; set; }
		public int Payed { get; set; }
		public int TotalPrice {  get; set; }

		public int ClientId {  get; set; }
		public Client Client { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
