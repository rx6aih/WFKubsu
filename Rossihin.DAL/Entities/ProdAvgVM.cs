using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossihin.DAL.Entities
{
    public class ProdAvgVM
    {
        public string Name { get; set; }
        public int OrdSum { get; set; }
        public int ShipSum { get; set; }
        public double Ratio { get; set; }
    }
}
