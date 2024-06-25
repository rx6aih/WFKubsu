using Individualka.DAL.EF;
using Individualka.DAL.Entites;
using Individualka.DAL.Repositories;
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

namespace Individualka.ContractForms
{
    public partial class ContractExportForm : Form
    {
        public ContractExportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    using (var db = new Context())
                    {
                        ContractRepository cr = new ContractRepository(db);
                        List<Contract> expenses = cr.GetAll().ToList(); 
                        List<ContractProductVM> cpVM = new List<ContractProductVM>();

                        foreach (Contract contract in expenses)
                    {
                        if (cpVM.Any(x => x.ProductId == contract.ProductId))
                        {
                            if (contract.Status == true) 
                            {
                                cpVM.FirstOrDefault(x => x.ProductId == contract.ProductId).AllSum += contract.Sum;
                            }
                            else
                            {
                                cpVM.FirstOrDefault(x => x.ProductId == contract.ProductId).PayedSum += contract.Sum;
                            }
                        }
                        else
                        {
                            int first = 0;
                            int second = 0;
                            if (contract.Status == true)
                            {
                                first += contract.Sum;
                            }
                            else
                            {
                                second += contract.Sum;
                            }
                            cpVM.Add(new ContractProductVM
                            {
                                ProductId = contract.ProductId,
                                AllSum = first,
                                PayedSum = second
                            });
                        }
                    }
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
                        worksheet.Cells[1, 2].Value = "Общая сумма";
                        worksheet.Cells[1, 3].Value = "Оплаченная сумма";

                        for (int i = 2; i < cpVM.Count + 2; i++)
                        {
                            worksheet.Cells[i, 1] = cpVM[i - 2].ProductId;
                            worksheet.Cells[i, 2] = cpVM[i - 2].AllSum;
                            worksheet.Cells[i, 3] = cpVM[i - 2].PayedSum;

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
        
    }
}
