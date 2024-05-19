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

namespace ToysShop.ClientForms
{
	public partial class ClientForm : Form
	{
		public ClientForm()
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
					ClientRepository cr = new ClientRepository(db);

					List<Client> clients = cr.GetAll().ToList();
					dataGridView1.DataSource = clients;
					dataGridView1.Refresh();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClientAddForm form = new ClientAddForm();
			form.ShowDialog();
			Update();
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
			DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				using (Context db = new Context())
				{
					ClientRepository cr = new ClientRepository(db);
					cr.Delete(id);
					db.SaveChanges();
					Update();
				}
			}
		}
	}
}
