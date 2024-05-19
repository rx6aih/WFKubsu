using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToysShop.DAL.EF;
using ToysShop.DAL.Entities;
using ToysShop.DAL.Repositories;

namespace ToysShop.ClientForms
{
	public partial class ClientAddForm : Form
	{
		public ClientAddForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = new Context())
			{
				try
				{
					ClientRepository cr = new ClientRepository(db);
					cr.Create(new Client
					{
						Name = tbName.Text
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
