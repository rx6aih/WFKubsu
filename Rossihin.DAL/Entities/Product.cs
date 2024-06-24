using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossihin.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public int OrderedSum { get; set; }
        public int PayedSum { get; set; }
        public int DeliveredSum { get; set; }
    }
}
