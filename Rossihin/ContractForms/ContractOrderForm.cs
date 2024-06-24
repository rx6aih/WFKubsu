using Rossihin.DAL.EF;
using Rossihin.DAL.Entities;
using Rossihin.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rossihin.ContractForms
{
    public partial class ContractOrderForm : Form
    {
        public int Id { get; set; }
        public ContractOrderForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    Contract contract = cr.GetAll().Where(x => x.Id == Id).FirstOrDefault();
                    ProductRepository pr = new ProductRepository(db);
                    Product product = pr.GetAll().Where(x => x.Id == contract.ProductId).FirstOrDefault();
                    if (product.Amount >= contract.Amount)
                    {
                        contract.Adress = textBox2.Text;
                        contract.ShipDate = dateTimePicker1.Value.ToUniversalTime();


                        product.OrderedSum -= (product.Price * contract.Amount);
                        product.DeliveredSum += (product.Price * contract.Amount);
                        product.Amount -= contract.Amount;
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Недостаточно товара на складе");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
