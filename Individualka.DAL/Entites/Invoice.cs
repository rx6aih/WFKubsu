using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anchok.DAL.Entites
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ContractId { get; set; }
        public Contract Contract {  get; set; }
    }
}
