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

namespace ToysShop.ProductForms
{
	public partial class ProductGroupAdd : Form
	{
		public ProductGroupAdd()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (Context db = new Context())
				{
					ProductGroupRepository pgr = new ProductGroupRepository(db);
					pgr.Create(new ProductGroup { Name = tbName.Text });
					db.SaveChanges();
					Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
