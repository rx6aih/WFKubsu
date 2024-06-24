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

namespace Rossihin
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
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

                    List<Invoice> invoices = br.GetAll().ToList();
                    dataGridView1.DataSource = invoices;
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
