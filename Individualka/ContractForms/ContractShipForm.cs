using Individualka.DAL.EF;
using Individualka.DAL.Entites;
using Individualka.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individualka.ContractForms
{
    public partial class ContractShipForm : Form
    {
        public int id { get; set; }
        public ContractShipForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void отгрузитьПолностьюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                ContractRepository cr = new ContractRepository(db);
                Contract contract = cr.GetAll().Where(x => x.Id == id).FirstOrDefault();

                ShippedRepository pr = new ShippedRepository(db);
                InvoiceRepository inv = new InvoiceRepository(db);
                if (pr.GetAll().Where(x => x.ContractId == id).FirstOrDefault() == null)
                {
                    pr.Create(new DAL.Entites.Shipped { AllAmount = contract.Amount, CurrentAmount = Convert.ToInt32(textBox1.Text), CurrentSum = contract.Sum, ContractId = contract.Id });
                    inv.Create(new Invoice { Amount = Convert.ToInt32(textBox1.Text),ClientId = contract.ClientId, ContractId = contract.Id, Date = DateTime.UtcNow });
                    db.SaveChanges();
                }
                else
                {
                    Shipped ship = pr.GetAll().Where(x=>x.ContractId == id).FirstOrDefault();
                    if (ship.CurrentAmount + Convert.ToInt32(textBox1.Text) < ship.AllAmount)
                    {
                        ship.CurrentAmount += Convert.ToInt32(textBox1.Text);
                        inv.Create(new Invoice { Amount = Convert.ToInt32(textBox1.Text),ClientId = contract.ClientId, ContractId = contract.Id, Date = DateTime.UtcNow });
                        db.SaveChanges();
                    }
                    else if (ship.CurrentAmount == ship.AllAmount)
                    {
                        MessageBox.Show("Товар уже был полностью выгружен");
                    }
                    else
                    {
                        ship.CurrentSum = ship.AllAmount;
                        inv.Create(new Invoice { Amount = ship.AllAmount-Convert.ToInt32(textBox1.Text), ClientId = contract.ClientId, ContractId = contract.Id, Date = DateTime.UtcNow });

                        MessageBox.Show("Товар полностью выгружен");
                        db.SaveChanges();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
