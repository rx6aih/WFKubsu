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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rossihin.ContractForms
{
    public partial class ContractAddForm : Form
    {
        public ContractAddForm()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            using (var db = new Context())
            {
                try
                {
                    ProductRepository pr = new ProductRepository(db);
                    List<Product> products = pr.GetAll().ToList();
                    comboBoxProd.DataSource = products;
                    comboBoxProd.DisplayMember = "Name";
                    comboBoxProd.ValueMember = "Id";

                    ClientRepository cr = new ClientRepository(db);
                    List<Client> clients = cr.GetAll().ToList();
                    comboBoxClient.DataSource = clients;
                    comboBoxClient.DisplayMember = "Name";
                    comboBoxClient.ValueMember = "Id";
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
            {
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    ProductRepository pr = new ProductRepository(db);
                    cr.Create(new Contract
                    {
                        Date = DateTime.UtcNow,
                        Sum = pr.GetAll().Where(x=>x.Id == Convert.ToInt32(comboBoxProd.SelectedValue)).FirstOrDefault().Price * Convert.ToInt32(tbAmount.Text),
                        Amount = Convert.ToInt32(tbAmount.Text),
                        Adress ="",
                        ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                        ProductId = Convert.ToInt32(comboBoxProd.SelectedValue)
                    });
                    db.SaveChanges();
                    Close();
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
