using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		
		public int ProductGroupId {  get; set; }
		public ProductGroup ProductGroup { get; set; }
	}
}
