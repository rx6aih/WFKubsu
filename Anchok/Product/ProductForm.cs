using Anchok.DAL.EF;
using Anchok.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchok.Product
{
    public partial class ProductForm : Form
    {
        public ProductForm()
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
                    ProductRepository br = new ProductRepository(db);

                    List<Anchok.DAL.Entites.Product> products = br.GetAll().ToList();
                    dataGridView1.DataSource = products;
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
            ProductAddForm form = new ProductAddForm();
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
                    ProductRepository pr = new ProductRepository(db);
                    pr.Delete(id);
                    db.SaveChanges();
                    Update();
                }
            }
        }

    }
}
