using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class ExpenseViewModel : Expenses
	{
		public string ClientName { get; set; }
		public string ProductName { get; set; }
	}
}
