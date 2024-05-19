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

namespace ToysShop.ProductForms
{
	public partial class ProductAddForm : Form
	{
		public ProductAddForm()
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

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = new Context())
			{
				try
				{
					ProductRepository pr = new ProductRepository(db);
					pr.Create(new Product
					{
						Name = tbName.Text,
						ProductGroupId = Convert.ToInt32(comboBox1.SelectedValue)
					});
					db.SaveChanges();
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
