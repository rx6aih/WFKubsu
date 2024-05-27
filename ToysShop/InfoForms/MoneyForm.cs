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

namespace ToysShop.InfoForms
{
	public partial class MoneyForm : Form
	{
		public MoneyForm()
		{
			InitializeComponent();
		}

		private void Update()
		{
			using (var db = new Context())
				try
				{
					List<MoneyRatio> ratio = new List<MoneyRatio>();
					ratio.Add(new MoneyRatio(1, 1));
					dataGridView1.DataSource = ratio;
					dataGridView1.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}

		private void MoneyForm_Load(object sender, EventArgs e)
		{


			using (var db = new Context())
			{
				try
				{
					ProductGroupRepository pgr = new ProductGroupRepository(db);
					List<ProductGroup> productGroups = pgr.GetAll().ToList();
					comboBox1.DataSource = productGroups;
					comboBox1.DisplayMember = "Name";
					comboBox1.ValueMember = "Id";
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
					InvoicesRepository invRepository = new InvoicesRepository(db);
					ExpensesRepository expRepository = new ExpensesRepository(db);
					ProductRepository prodRepository = new ProductRepository(db);

					List<Product> necessaryProducts = prodRepository
						.GetAll()
						.Where(x => x.ProductGroupId == Convert.ToInt32(comboBox1.SelectedValue))
						.ToList();

					List<Invoices> invoices = invRepository
						.GetAll()
						.Where(x => necessaryProducts.Exists(y => x.ProductId == y.Id)).ToList();

					List<Expenses> expenses = expRepository
						.GetAll()
						.Where(x => necessaryProducts.Exists(y => x.ProductId == y.Id)).ToList();

					int invSum = 0;
					int expSum = 0;

					foreach (Invoices inv in invoices)
						invSum += (inv.TotalPrice - inv.Payed);
					foreach(Expenses exp in expenses)
					{
						expSum += (exp.TotalPrice - exp.Payed);
					}

					List<MoneyRatio> ratio = new List<MoneyRatio>();
					MoneyRatio someRatio = new MoneyRatio(invSum, expSum);
					if ((double)invSum / (double)expSum == 0) 
						someRatio.Ratio = -1;
					else if(expSum==0) 
						someRatio.Ratio = 1;
					else
						someRatio.Ratio = (double)invSum / (double)expSum;
					ratio.Add(someRatio);

					dataGridView1.DataSource = ratio;
					dataGridView1.Columns[0].HeaderText = "Сумма приходных";
					dataGridView1.Columns[1].HeaderText = "Сумма расходных";
					dataGridView1.Columns[2].HeaderText = "Соотношение";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}
	}
}
