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

namespace Rossihin.ReportForms
{
    public partial class ReportOneForm : Form
    {
        public ReportOneForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    ProductRepository pr = new ProductRepository(db);
                    List<Contract> contracts = cr.GetAll().Where(x => x.PayStatus == false && x.Amount != 0 && x.Date.Day == dateTimePicker1.Value.Day).ToList();
                    if (contracts.Count > 0)
                    {
                        List<Product> products = new List<Product>();
                        foreach (var c in contracts)
                        {
                            Product prod = pr.GetAll().Where(x => x.Id == c.ProductId).FirstOrDefault();
                            products.Add(prod);
                        }
                        dataGridView1.DataSource = products;
                        dataGridView1.Columns[4].Visible = false;
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Refresh();
                    }
                    else MessageBox.Show("Таких товаров нет");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
        }

        private void ReportOneForm_Load(object sender, EventArgs e)
        {




        }
    }
}
