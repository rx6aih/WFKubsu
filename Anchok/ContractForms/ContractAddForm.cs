using Anchok.DAL.EF;
using Anchok.DAL.Entites;
using Anchok.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchok.ContractForms
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
                    List<Anchok.DAL.Entites.Product> products = pr.GetAll().ToList();
                    comboBox1.DataSource = products;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Id";

                    ClientRepository cr = new ClientRepository(db);
                    List<Client> clients = cr.GetAll().ToList();
                    comboBox2.DataSource = clients;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "Id";
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
                    Contract cont = new Contract
                    {
                        Date = DateTime.UtcNow,
                        Status = checkBox1.Checked,
                        Sum = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text),
                        Amount = Convert.ToInt32(tbAmount.Text),
                        ClientId = Convert.ToInt32(comboBox2.SelectedValue),
                        ProductId = Convert.ToInt32(comboBox1.SelectedValue)
                    };
                    cr.Create(new Contract
                    {
                        Date = DateTime.UtcNow,
                        Status = checkBox1.Checked,
                        Sum = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text),
                        Amount = Convert.ToInt32(tbAmount.Text),
                        ClientId = Convert.ToInt32(comboBox2.SelectedValue),
                        ProductId = Convert.ToInt32(comboBox1.SelectedValue)
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
