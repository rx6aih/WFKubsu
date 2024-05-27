using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class InvoiceViewModel : Invoices
	{
		public string ClientName {  get; set; }
		public string ProductName {  get; set; }
	}
}
