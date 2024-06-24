using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossihin.DAL.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
