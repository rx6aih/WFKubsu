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

namespace Anchok.ContractForms
{
    public partial class Invoices : Form
    {
        public Invoices()
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
                    InvoiceRepository br = new InvoiceRepository(db);

                    List<Anchok.DAL.Entites.Invoice> contracts = br.GetAll().ToList();
                    dataGridView1.DataSource = contracts;
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
