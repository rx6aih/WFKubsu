using Anchok.DAL.EF;
using Anchok.DAL.Entites;
using Anchok.DAL.Repositories;
using Anchok.Product;
using Microsoft.Office.Interop.Excel;
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
    public partial class ContractForm : Form
    {
        public ContractForm()
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
                    ContractRepository br = new ContractRepository(db);

                    List<Anchok.DAL.Entites.Contract> contracts = br.GetAll().ToList();
                    dataGridView1.DataSource = contracts;
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
            ContractAddForm form = new ContractAddForm();
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
                    ContractRepository pr = new ContractRepository(db);
                    pr.Delete(id);
                    db.SaveChanges();
                    Update();
                }
            }
        }

        private void отгрузитьЧастичноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            ContractShipForm form = new ContractShipForm(id);
            form.ShowDialog();
        }
        private void отгрузитьПолностьюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            using (Context db = new Context())
            {
                ShippedRepository sr = new ShippedRepository(db);
                ContractRepository cr = new ContractRepository(db);
                InvoiceRepository inv = new InvoiceRepository(db);
                Shipped ship = sr.GetAll().Where(x => x.ContractId == id).FirstOrDefault();
                if (ship == null)
                {
                    sr.Create(new Shipped
                    {
                        AllAmount = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().Amount,
                        CurrentAmount = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().Amount,
                        ContractId = id,
                        CurrentSum = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().Sum
                    });
                    inv.Create(new Invoice
                    {
                        ClientId = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().ClientId,
                        Date = DateTime.UtcNow,
                        Amount = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().Amount,
                        ContractId = id
                    });
                    db.SaveChanges();
                    MessageBox.Show("Товар успешно отгружен");
                }
                else
                {
                    inv.Create(new Invoice
                    {
                        ClientId = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().ClientId,
                        Date = DateTime.UtcNow,
                        Amount = cr.GetAll().Where(x => x.Id == id).FirstOrDefault().Amount - ship.CurrentAmount,
                        ContractId = id
                    });
                    ship.CurrentAmount = ship.AllAmount;
                    db.SaveChanges();
                    MessageBox.Show("Товар успешно отгружен");
                }
            }
        }
        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Context())
                {
                    InvoiceRepository er = new InvoiceRepository(db);
                    List<Invoice> expenses = er.GetAll().ToList();

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
                    worksheet.Cells[1, 4].Value = "Номер клиениа";
                    worksheet.Cells[1, 5].Value = "Номер договора";


                    for (int i = 2; i < expenses.Count + 2; i++)
                    {
                        worksheet.Cells[i, 1] = expenses[i - 2].Id;
                        worksheet.Cells[i, 2] = expenses[i - 2].Date.ToLongDateString();
                        worksheet.Cells[i, 3] = expenses[i - 2].Amount;
                        worksheet.Cells[i, 4] = expenses[i - 2].ClientId;
                        worksheet.Cells[i, 5] = expenses[i - 2].ContractId;
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

        private void ContractForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                ids.Add((int)selectedCell.Value);
            }
            using (var db = new Context())
            {
                ContractRepository cr = new ContractRepository(db);
                ShippedRepository sr = new ShippedRepository(db);

                List<ContractShipViewModel> clients = new List<ContractShipViewModel>();

                foreach (int id in ids)
                {
                    int num1 = 0;
                    int num2 = 0;
                    List<Contract> contracts = cr.GetAll().Where(x => x.ClientId == id).ToList();

                    List<Shipped> some = sr.GetAll().ToList();

                    foreach (Contract contract in contracts)
                    {
                        if (contract.Status == true)
                            num1 += contract.Amount;
                        if (sr.GetAll().Where(x => x.ContractId == contract.Id).FirstOrDefault() != null)
                            num2 += sr.GetAll().Where(x => x.ContractId == contract.Id).FirstOrDefault().CurrentAmount;

                    }
                    ContractShipViewModel client = new ContractShipViewModel
                    {
                        ClientId = id,
                        Contracted = num1,
                        Shiped = num2
                    };
                    if (clients.Any(x => x.ClientId == client.ClientId) == false)
                        clients.Add(client);
                }
                dataGridView2.DataSource = clients;
                dataGridView2.Refresh();
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoices form = new Invoices();
            form.ShowDialog();
        }
    }
}
