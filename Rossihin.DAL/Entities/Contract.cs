using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossihin.DAL.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool PayStatus { get; set; }
        public bool ShipStatus { get; set; }
        public string Adress { get; set; }
        public DateTime ShipDate { get; set; }
        public int Amount { get; set; }
        public int Sum { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProductId { get; set; }
        public Product Procuct { get; set; }
    }
}
