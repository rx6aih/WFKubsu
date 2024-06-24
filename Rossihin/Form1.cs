using Rossihin.ClientForms;
using Rossihin.ContractForms;
using Rossihin.ProductForms;
using Rossihin.ReportForms;

namespace Rossihin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractForm form = new ContractForm();
            form.ShowDialog();
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoicesForm form = new InvoicesForm();
            form.ShowDialog();
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOneForm form = new ReportOneForm();
            form.ShowDialog();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTwoForm form = new ReportTwoForm();
            form.ShowDialog();
        }
    }
}
