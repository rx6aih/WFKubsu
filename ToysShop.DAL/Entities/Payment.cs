using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class Payment
	{
		public int Id { get; set; }
	    public int PaymentAmount {  get; set; }
		public DateTime PaymentDate { get; set; }

		public int? InvoicesId { get; set; }
		public Invoices? Invoices { get; set; }

		public int? ExpensesId { get; set; }
		public Expenses Expenses { get; set; }

		public int ClientId { get; set; }
		public Client Client {  get; set; }
	}
}
