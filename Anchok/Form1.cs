using Anchok.CleintForms;
using Anchok.ContractForms;
using Anchok.Product;

namespace Anchok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContractForm form = new ContractForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DiagramPick form = new DiagramPick();
            form.ShowDialog();
        }
    }
}
