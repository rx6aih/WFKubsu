using Anchok.DAL.EF;
using Anchok.DAL.Entites;
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

namespace Anchok.CleintForms
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
                        Name = tbName.Text,
                        Surname = textBox1.Text
                    });
                    db.SaveChanges();
                    Close();
                }
                catch (Exception ex)
                {
                    throw;
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
