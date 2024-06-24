using Microsoft.Office.Interop.Excel;
using Rossihin.DAL.EF;
using Rossihin.DAL.Entities;
using Rossihin.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rossihin.ContractForms
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

                    List<Contract> contracts = br.GetAll().ToList();
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

        private void buttonPay_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            using (Context db = new Context())
            {
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    Contract contract = cr.GetAll().Where(x => x.Id == id).FirstOrDefault();

                    ProductRepository pr = new ProductRepository(db);
                    Product product = pr.GetAll().Where(x => x.Id == contract.ProductId).FirstOrDefault();

                    if (contract.PayStatus == false)
                    {
                        contract.PayStatus = true;
                        product.OrderedSum -= (product.Price * contract.Amount);
                        product.PayedSum += (contract.Amount * product.Price);

                        db.SaveChanges();
                        MessageBox.Show("Заказ успешно оплачен");
                        Update();
                    }
                    else MessageBox.Show("Заказ уже оплачен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void buttonDeliv_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            using (Context db = new Context())
            {
                try
                {
                    ContractRepository cr = new ContractRepository(db);
                    Contract contract = cr.GetAll().Where(x => x.Id == id).FirstOrDefault();
                    if (contract.PayStatus != false)
                    {
                        if (contract.ShipStatus == false)
                        {
                            ContractOrderForm form = new ContractOrderForm(id);
                            List<Contract> contracts = cr.GetAll().ToList();
                            foreach (Contract c in contracts)
                            {
                                if (c.ShipDate.Day <= DateTime.Today.Day&&c.ShipDate !=DateTime.MinValue)
                                    c.ShipStatus = true;
                            }
                            db.SaveChanges();
                            form.ShowDialog();
                            Update();
                        }
                        else MessageBox.Show("Товар уже доставлен");
                    }
                    else MessageBox.Show("Товар не оплачен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                try {
                    ContractRepository cr = new ContractRepository(db);
                    List<Contract> contracts = cr.GetAll().ToList();

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
                    worksheet.Cells[1, 3].Value = "Статус оплаты";
                    worksheet.Cells[1, 4].Value = "Статус доставки";
                    worksheet.Cells[1, 5].Value = "Адрес";
                    worksheet.Cells[1, 6].Value = "Дата доставки";
                    worksheet.Cells[1, 7].Value = "Количество";
                    worksheet.Cells[1, 8].Value = "Сумма";

                    for (int i = 2; i < contracts.Count + 2; i++)
                    {
                        worksheet.Cells[i, 1] = contracts[i - 2].Id;
                        worksheet.Cells[i, 2] = contracts[i - 2].Date.ToLongDateString();
                        worksheet.Cells[i, 3] = contracts[i - 2].PayStatus;
                        worksheet.Cells[i, 4] = contracts[i - 2].ShipStatus;
                        worksheet.Cells[i, 5] = contracts[i - 2].Adress;
                        worksheet.Cells[i, 6] = contracts[i - 2].ShipDate.ToLongDateString();
                        worksheet.Cells[i, 7] = contracts[i - 2].Amount;
                        worksheet.Cells[i, 8] = contracts[i - 2].Sum;
                        wb.Save();
                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
        } 
        
        }
    }
}
