using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysShop.DAL.Entities
{
	public class MoneyRatio
	{
		public int InvSum {  get; set; }
		public int ExpSum {  get; set; }
		public double Ratio {  get; set; }
		public MoneyRatio(int invSum, int exmSum) 
		{
			InvSum = invSum;
			ExpSum = exmSum;
			Ratio = InvSum/ ExpSum;
		}

	}
}
