using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class ClientTurnover
	{
		public int ClientId { get; set; }
		public int StartAmount {  get; set; }
		public int EndAmount { get; set; }
		public string Direction {  get; set; }
	}
}
