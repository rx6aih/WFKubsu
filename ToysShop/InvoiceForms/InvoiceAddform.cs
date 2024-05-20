using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ToysShop.DAL.EF;
using ToysShop.DAL.Entities;
using ToysShop.DAL.Repositories;

namespace ToysShop.InvoiceForms
{
	public partial class InvoiceAddform : Form
	{
		public InvoiceAddform()
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
					if (comboBox3.SelectedIndex == 0)
					{
						InvoicesRepository ir = new InvoicesRepository(db);
						PaymentRepository pr = new PaymentRepository(db);
						ir.Create(new DAL.Entities.Invoices
						{
							InvoiceDate = DateTime.UtcNow,
							TotalAmount = Convert.ToInt32(tbAmount.Text),
							Price = Convert.ToInt32(tbPrice.Text),
							Payed = Convert.ToInt32(tbFirstPayment.Text),
							ProductId = Convert.ToInt32(comboBox1.SelectedValue),
							ClientId = Convert.ToInt32(comboBox2.SelectedValue),
							TotalPrice = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text),
							Status = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text) < Convert.ToInt32(tbFirstPayment.Text) ? "Оплачено" : "Не оплачено"
						});
						pr.Create(new DAL.Entities.Payment
						{
							PaymentAmount = Convert.ToInt32(tbAmount.Text),
							PaymentDate = DateTime.UtcNow,
							ClientId = Convert.ToInt32(comboBox2.SelectedValue),
						});
						db.SaveChanges();
						Close();
					}
					else
					{
						ExpensesRepository ir = new ExpensesRepository(db);
						PaymentRepository pr = new PaymentRepository(db);

						ir.Create(new DAL.Entities.Expenses
						{
							ExpenseDate = DateTime.UtcNow,
							TotalAmount = Convert.ToInt32(tbAmount.Text),
							Price = Convert.ToInt32(tbPrice.Text),
							Payed = Convert.ToInt32(tbFirstPayment.Text),
							ProductId = Convert.ToInt32(comboBox1.SelectedValue),
							ClientId = Convert.ToInt32(comboBox2.SelectedValue),
							TotalPrice = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text),
							Status = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbAmount.Text) < Convert.ToInt32(tbFirstPayment.Text) ? "Не оплачено" : "Оплачено"
						});
						pr.Create(new DAL.Entities.Payment
						{
							PaymentAmount = Convert.ToInt32(tbAmount.Text),
							PaymentDate = DateTime.UtcNow,
							ClientId = Convert.ToInt32(comboBox2.SelectedValue),
						});
						db.SaveChanges();
						Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
