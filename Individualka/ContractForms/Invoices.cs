using Individualka.DAL.EF;
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
    public partial class Invoices : Form
    {
        public Invoices()
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
                    InvoiceRepository br = new InvoiceRepository(db);

                    List<Individualka.DAL.Entites.Invoice> contracts = br.GetAll().ToList();
                    dataGridView1.DataSource = contracts;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
