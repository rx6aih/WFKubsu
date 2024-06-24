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

namespace Rossihin.ProductForms
{
    public partial class ProductOrderForm : Form
    {
        public int Id { get; set; }
        public ProductOrderForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    ProductRepository pr = new ProductRepository(db);
                    InvoiceRepository ir = new InvoiceRepository(db);

                    Product product = pr.GetAll().Where(x=>x.Id == Id).FirstOrDefault();
                    List<Contract> contracts = cr.GetAll().Where(x=>x.ProductId == Id).ToList();

                    if (contracts != null)
                    {
                        int sum = 0;
                        foreach (var c in contracts)
                            sum += c.Amount;
                        if (product.Amount + Convert.ToInt32(textBox2.Text) <= sum)
                        {
                            product.Amount = sum;
                            product.OrderedSum += product.Amount * product.Price;
                            Invoice invoice = new Invoice
                            {
                                Amount = Convert.ToInt32(textBox2.Text),
                                Date = DateTime.UtcNow,
                                ProductId = Id
                            };
                            ir.Create(invoice);
                            db.SaveChanges();
                            Close();
                        }
                        else MessageBox.Show("Слишком большое количество");
                        
                    }
                    else MessageBox.Show("На данный продукт нет заказа");    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
