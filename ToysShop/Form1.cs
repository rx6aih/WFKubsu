using System.Runtime.InteropServices;
using System.Windows.Forms;
using ToysShop.ClientForms;
using ToysShop.DAL.EF;
using Microsoft.Office.Interop.Excel;

using ToysShop.InfoForms;
using ToysShop.InvoiceForms;
using ToysShop.ProductForms;
using ToysShop.DAL.Repositories;
using ToysShop.DAL.Entities;

namespace ToysShop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void накладныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InvoiceForm form = new InvoiceForm();
			form.ShowDialog();
		}

		private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProductForm form = new ProductForm();
			form.ShowDialog();
		}

		private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClientForm form = new ClientForm();
			form.ShowDialog();
		}

		private void суммToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MoneyForm form = new MoneyForm();
			form.ShowDialog();
		}

		private void оборотToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TurnoverForm form = new TurnoverForm();
			form.ShowDialog();
		}

		private void расходныеНакладныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Context())
				{
					ExpensesRepository er = new ExpensesRepository(db);
					List<Expenses> expenses = er.GetAll().ToList();

					OpenFileDialog ofd = new OpenFileDialog();
					ofd.ShowDialog();
					string filename = ofd.FileName;

					Microsoft.Office.Interop.Excel.Application excelObj = new Microsoft
						.Office
						.Interop
						.Excel
						.Application();
					excelObj.Visible = true;
					Workbook wb = excelObj.Workbooks
						.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
					Worksheet worksheet = wb.Worksheets[1];

					worksheet.Cells[1, 1].Value = "Номер";
					worksheet.Cells[1, 2].Value = "Дата";
					worksheet.Cells[1, 3].Value = "Количество";
					worksheet.Cells[1, 4].Value = "Цена";
					worksheet.Cells[1, 5].Value = "Оплачено";
					worksheet.Cells[1, 6].Value = "Полная цена";
					worksheet.Cells[1, 7].Value = "Номер клиента";
					worksheet.Cells[1, 8].Value = "Номер продукта";

					for (int i = 2; i < expenses.Count + 2; i++)
					{
						worksheet.Cells[i, 1] = expenses[i - 2].Id;
						worksheet.Cells[i, 2] = expenses[i - 2].ExpenseDate.ToLongDateString();
						worksheet.Cells[i, 3] = expenses[i - 2].TotalAmount;
						worksheet.Cells[i, 4] = expenses[i - 2].Price;
						worksheet.Cells[i, 5] = expenses[i - 2].Payed;
						worksheet.Cells[i, 6] = expenses[i - 2].TotalPrice;
						worksheet.Cells[i, 7] = expenses[i - 2].ClientId;
						worksheet.Cells[i, 8] = expenses[i - 2].ProductId;
						wb.Save();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}

		}

		private void приходныеНакладныеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new Context())
				{
					InvoicesRepository er = new InvoicesRepository(db);
					List<Invoices> invoices = er.GetAll().ToList();

					OpenFileDialog ofd = new OpenFileDialog();
					ofd.ShowDialog();
					string filename = ofd.FileName;

					Microsoft.Office.Interop.Excel.Application excelObj = new Microsoft
						.Office
						.Interop
						.Excel
						.Application();
					excelObj.Visible = true;
					Workbook wb = excelObj.Workbooks
						.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
					Worksheet worksheet = wb.Worksheets[1];

					worksheet.Cells[1, 1].Value = "Номер";
					worksheet.Cells[1, 2].Value = "Дата";
					worksheet.Cells[1, 3].Value = "Количество";
					worksheet.Cells[1, 4].Value = "Цена";
					worksheet.Cells[1, 5].Value = "Оплачено";
					worksheet.Cells[1, 6].Value = "Полная цена";
					worksheet.Cells[1, 7].Value = "Номер клиента";
					worksheet.Cells[1, 8].Value = "Номер продукта";

					for (int i = 2; i < invoices.Count + 2; i++)
					{
						worksheet.Cells[i, 1] = invoices[i - 2].Id;
						worksheet.Cells[i, 2] = invoices[i - 2].InvoiceDate.ToLongDateString();
						worksheet.Cells[i, 3] = invoices[i - 2].TotalAmount;
						worksheet.Cells[i, 4] = invoices[i - 2].Price;
						worksheet.Cells[i, 5] = invoices[i - 2].Payed;
						worksheet.Cells[i, 6] = invoices[i - 2].TotalPrice;
						worksheet.Cells[i, 7] = invoices[i - 2].ClientId;
						worksheet.Cells[i, 8] = invoices[i - 2].ProductId;
						wb.Save();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}

