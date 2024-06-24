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
    public partial class ReportTwoForm : Form
    {
        public ReportTwoForm()
        {
            InitializeComponent();
            Update();
        }
        private void Update()
        {
            using (var db = new Context())
            {
                try
                {
                    ProductRepository br = new ProductRepository(db);

                    List<Product> products = br.GetAll().ToList();
                    dataGridView1.DataSource = products;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
                try
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                    ProductRepository pr = new ProductRepository(db);

                    List<ProdAvgVM> avgs = new List<ProdAvgVM>();

                    ContractRepository cr = new ContractRepository(db);
                    List<Contract> contracts = cr.GetAll().ToList();
                    string name = "";
                    int ordsum = 0;
                    int shipsum = 0;
                    foreach(Contract contract in contracts)
                    {
                        if (contract.Date.Day >= dateTimePicker1.Value.Day && contract.Date.Day <= dateTimePicker2.Value.Day && contract.ProductId == id)
                        {
                            Product product = pr.GetAll().Where(x => x.Id == contract.ProductId).FirstOrDefault();
                            ProdAvgVM avg = new ProdAvgVM
                            {
                                Name = product.Name,
                                OrdSum = product.OrderedSum,
                                ShipSum = product.DeliveredSum
                            };
                            if (!avgs.Any(x => x.Name == product.Name))
                            {
                                avgs.Add(avg);
                                if (product.OrderedSum != 0)
                                    avgs.Find(x => x.Name == product.Name).Ratio = (product.DeliveredSum / product.OrderedSum);
                                else
                                    avgs.Find(x => x.Name == product.Name).Ratio = 0;
                            }
                            

                        }
                    }
                    dataGridView2.DataSource = avgs;
                    dataGridView2.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
        }
    }
}
