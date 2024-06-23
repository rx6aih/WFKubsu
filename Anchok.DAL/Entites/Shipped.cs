using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anchok.DAL.Entites
{
    public class Shipped
    {
        public int Id {  get; set; }
        public int AllAmount { get; set; }
        public int CurrentAmount { get; set; }
        public int CurrentSum {  get; set; }

        public int ContractId { get; set; }
        public Contract Contract { get; set; }
    }
}
