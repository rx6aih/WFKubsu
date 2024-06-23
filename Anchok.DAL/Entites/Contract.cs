using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anchok.DAL.Entites
{
    public class Contract
    {
        public int Id {  get; set; }
        public DateTime Date {  get; set; }
        public bool Status { get; set; }
        public int Sum {  get; set; }
        public int Amount { get; set; }

        public int ClientId {  get; set; }
        public Client Client {  get; set; }
        public int ProductId {  get; set; }
        public Product Product { get; set; }
    }
}
