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
					ProductRepository pr = new ProductRepository(db);
					ClientRepository cr = new ClientRepository(db);

					List<InvoiceViewModel> invoiceViewModels = new List<InvoiceViewModel>();
					List<ExpenseViewModel> expenseViewModels = new List<ExpenseViewModel>();

					InvoicesRepository ir = new InvoicesRepository(db);

					List<Invoices> invoices = ir.GetAll().ToList();
					foreach(Invoices inv in invoices)
					{
						InvoiceViewModel viewModel = new InvoiceViewModel
						{
							Client = inv.Client,
							TotalAmount = inv.TotalAmount,
							ClientId = inv.ClientId,
							ClientName = cr.Get(inv.ClientId).Name,
							Id = inv.Id,
							InvoiceDate = inv.InvoiceDate,
							Payed = inv.Payed,
							Price = inv.Price,
							Product = inv.Product,
							ProductId = inv.ProductId,
							ProductName = pr.Get(inv.ProductId).Name,
							Status = inv.Status,
							TotalPrice = inv.TotalPrice
						};
						invoiceViewModels.Add(viewModel);
					}
					dataGridView1.DataSource = invoiceViewModels;
					dataGridView1.Refresh();


					ExpensesRepository er = new ExpensesRepository(db);

					List<Expenses> expenses = er.GetAll().ToList();
					foreach (Invoices inv in invoices)
					{
						ExpenseViewModel viewModel = new ExpenseViewModel
						{
							Client = inv.Client,
							TotalAmount = inv.TotalAmount,
							ClientId = inv.ClientId,
							ClientName = cr.Get(inv.ClientId).Name,
							Id = inv.Id,
							ExpenseDate = inv.InvoiceDate,
							Payed = inv.Payed,
							Price = inv.Price,
							Product = inv.Product,
							ProductId = inv.ProductId,
							ProductName = pr.Get(inv.ProductId).Name,
							Status = inv.Status,
							TotalPrice = inv.TotalPrice
						};
						expenseViewModels.Add(viewModel);
					}
					dataGridView2.DataSource = expenseViewModels;
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

			InvoicePayForm form = new InvoicePayForm(InvClId, InvId, null, null, 0);
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

		private void InvoiceForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Имя клиента";
			dataGridView1.Columns[1].HeaderText = "Название продукта";
			dataGridView1.Columns[2].HeaderText = "Номер";
			dataGridView1.Columns[3].HeaderText = "Дата";
			dataGridView1.Columns[4].HeaderText = "Общее количество";
			dataGridView1.Columns[5].HeaderText = "Цена";
			dataGridView1.Columns[6].HeaderText = "Уплочено";
			dataGridView1.Columns[7].HeaderText = "Полная цена";
			dataGridView1.Columns[8].HeaderText = "Статус";
			dataGridView1.Columns[9].Visible = false;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;

			dataGridView2.Columns[0].HeaderText = "Имя клиента";
			dataGridView2.Columns[1].HeaderText = "Название продукта";
			dataGridView2.Columns[2].HeaderText = "Номер";
			dataGridView2.Columns[3].HeaderText = "Дата";
			dataGridView2.Columns[4].HeaderText = "Общее количество";
			dataGridView2.Columns[5].HeaderText = "Цена";
			dataGridView2.Columns[6].HeaderText = "Уплочено";
			dataGridView2.Columns[7].HeaderText = "Полная цена";
			dataGridView2.Columns[8].HeaderText = "Статус";
			dataGridView2.Columns[9].Visible = false;
			dataGridView2.Columns[10].Visible = false;
			dataGridView2.Columns[11].Visible = false;
			dataGridView2.Columns[12].Visible = false;

		}
	}
}
