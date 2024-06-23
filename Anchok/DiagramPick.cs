﻿using Anchok.DAL.EF;
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

namespace Anchok
{
    public partial class DiagramPick : Form
    {
        public DiagramPick()
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
                    ProductRepository pgr = new ProductRepository(db);
                    List<Anchok.DAL.Entites.Product> product = pgr.GetAll().ToList();
                    comboBox1.DataSource = product;
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
            DateTime StartDate = dateTimePicker1.Value;
            DateTime EndDate = dateTimePicker2.Value;
            int Id = Convert.ToInt32(comboBox1.SelectedValue);
            Diagram form = new Diagram(StartDate, EndDate, Id);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
