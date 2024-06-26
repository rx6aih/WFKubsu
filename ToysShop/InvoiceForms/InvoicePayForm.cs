﻿using System;
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
	public partial class InvoicePayForm : Form
	{
		public int? InvClientId { get; set; }
		public int? InvoiceId { get; set; }

		public int? ExpClientId { get; set; }
		public int? ExpenseId { get; set; }

		public int Type { get; set; }
		public InvoicePayForm(int? id1, int? id2, int? id3, int? id4, int type)
		{
			InitializeComponent();

			InvClientId = id1;
			InvoiceId = id2;

			ExpClientId = id3;
			ExpenseId = id4;

			Type = type;
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			using (var db = new Context())
			{
				try
				{
					if (Type == 0)
					{
						InvoicesRepository ir = new InvoicesRepository(db);
						PaymentRepository pr = new PaymentRepository(db);

						List<Invoices> invoices = ir.GetAll().ToList();
						Invoices invoice = invoices.Where(x => x.Id == ((int)InvoiceId)).FirstOrDefault();
						invoice.Payed += Convert.ToInt32(tbAmount.Text);

						if (invoice.Payed >= invoice.TotalPrice)
						{
							string messg = "Полностью оплочено, лишнее:" + (invoice.Payed - invoice.TotalPrice).ToString();
							invoice.Payed = invoice.TotalPrice;
							invoice.Status = "Оплачено";
							MessageBox.Show(messg);
						}
						else
							pr.Create(new DAL.Entities.Payment
							{
								PaymentAmount = Convert.ToInt32(tbAmount.Text),
								PaymentDate = DateTime.UtcNow,
								ClientId = (int)InvClientId,
								InvoicesId = (int)InvoiceId,
							});
						db.SaveChanges();
						Close();
					}
					else
					{
						ExpensesRepository er = new ExpensesRepository(db);
						PaymentRepository pr = new PaymentRepository(db);

						List<Expenses> expenses = er.GetAll().ToList();
						Expenses expense = expenses.Where(x => x.Id == ((int)ExpenseId)).FirstOrDefault();
						expense.Payed += Convert.ToInt32(tbAmount.Text);

						if (expense.Payed >= expense.TotalPrice)
						{
							string messg = "Полностью оплочено, лишнее:" + (expense.Payed - expense.TotalPrice).ToString();
							expense.Payed = expense.TotalPrice;
							expense.Status = "Оплачено";
							MessageBox.Show(messg);
							pr.Create(new Payment
							{
								PaymentAmount = Convert.ToInt32(expense.TotalPrice) - Convert.ToInt32(tbAmount.Text),
								PaymentDate = DateTime.UtcNow,
								ClientId = (int)ExpClientId,
								ExpensesId = (int)ExpenseId
							});
						}
						else
							pr.Create(new DAL.Entities.Payment
							{
								PaymentAmount = Convert.ToInt32(tbAmount.Text),
								PaymentDate = DateTime.UtcNow,
								ClientId = (int)ExpClientId,
								ExpensesId = (int)ExpenseId,
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

		private void InvoicePayForm_Load(object sender, EventArgs e)
		{
			if (Type == 0)
			{
				using (var db = new Context())
				{
					InvoicesRepository ir = new InvoicesRepository(db);
					List<Invoices> invoices = ir.GetAll().ToList();

					Invoices invoice = invoices.Where(x => x.Id == ((int)InvoiceId)).FirstOrDefault();
					string left = (invoice.TotalPrice - invoice.Payed).ToString();
					label2.Text += " " + left;
				}
			}
			else
			{
				using (var db = new Context())
				{
					ExpensesRepository er = new ExpensesRepository(db);
					List<Expenses> expenses = er.GetAll().ToList();

					Expenses expense = expenses.Where(x => x.Id == ((int)ExpenseId)).FirstOrDefault();

					string left = (expense.TotalPrice - expense.Payed).ToString();
					label2.Text += " " + left;
				}
			}
		}
	}
}
