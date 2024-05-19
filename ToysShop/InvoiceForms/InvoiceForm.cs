using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToysShop.DAL.EF;
using ToysShop.DAL.Entities;
using ToysShop.DAL.Repositories;

namespace ToysShop.InvoiceForms
{
	public partial class InvoiceForm : Form
	{
		public InvoiceForm()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			Update();
		}
		private void Update()
		{
			using (var db = new Context())
				try
				{
					InvoicesRepository ir = new InvoicesRepository(db);

					List<Invoices> invoices = ir.GetAll().ToList();
					dataGridView1.DataSource = invoices;
					dataGridView1.Refresh();


					ExpensesRepository er = new ExpensesRepository(db);

					List<Expenses> expenses = er.GetAll().ToList();
					dataGridView2.DataSource = expenses;
					dataGridView2.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			InvoiceAddform form = new InvoiceAddform();
			form.ShowDialog();
			Update();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int? InvId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			int? InvClId = (int)dataGridView1.CurrentRow.Cells["ClientId"].Value;

			InvoicePayForm form = new InvoicePayForm(InvClId,InvId, null, null, 0);
			form.ShowDialog();
			Update();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int ExpId = (int)dataGridView2.CurrentRow.Cells["ID"].Value;
			int ExpClId = (int)dataGridView2.CurrentRow.Cells["ClientId"].Value;

			InvoicePayForm form = new InvoicePayForm(null, null, ExpClId, ExpId, 1);
			form.ShowDialog();
			Update();
		}
	}
}
