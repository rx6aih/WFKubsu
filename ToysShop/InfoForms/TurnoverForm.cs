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

namespace ToysShop.InfoForms
{
	public partial class TurnoverForm : Form
	{
		public TurnoverForm()
		{
			InitializeComponent();
			Update();
		}
		private void Update()
		{
			using (var db = new Context())
				try
				{
					PaymentRepository pr = new PaymentRepository(db);

					List<Payment> payments = pr.GetAll().ToList();

					List<ClientTurnover> turnovers = new List<ClientTurnover>();


					foreach (Payment payment in payments)
					{
						if (turnovers.Find(x => x.ClientId == payment.ClientId) == null)
						{
							turnovers.Add(new ClientTurnover { ClientId = payment.ClientId, StartAmount = payment.PaymentAmount, EndAmount = payment.PaymentAmount });
						}
						else
						{
							turnovers.Find(x => x.ClientId == payment.ClientId).EndAmount += payment.PaymentAmount;
						}
					}

					foreach (ClientTurnover turnover in turnovers)
					{
						if (turnover.StartAmount < turnover.EndAmount)
							turnover.Direction = "Up";
						else
							turnover.Direction = "Down";
					}
					dataGridView1.DataSource = turnovers;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}
		private void btnYes_Click(object sender, EventArgs e)
		{
			using (var db = new Context())
				try
				{
					PaymentRepository pr = new PaymentRepository(db);

					List<Payment> payments = pr.GetAll().ToList();

					List<ClientTurnover> turnovers = new List<ClientTurnover>();

					if (payments.Any(x => x.PaymentDate > dateTimePicker1.Value && x.PaymentDate < dateTimePicker2.Value))
						foreach (Payment payment in payments)
						{
							if (turnovers.Find(x => x.ClientId == payment.ClientId) == null)
							{
								turnovers.Add(new ClientTurnover { ClientId = payment.ClientId, StartAmount = payment.PaymentAmount });
							}
							else
							{
								turnovers.Find(x => x.ClientId == payment.ClientId).EndAmount += payment.PaymentAmount;
							}
						}
					else MessageBox.Show("Записей за этм даты нет");

					foreach (ClientTurnover turnover in turnovers)
					{
						if (turnover.StartAmount < turnover.EndAmount)
							turnover.Direction = "Up";
						else
							turnover.Direction = "Down";
					}
					dataGridView1.DataSource = turnovers;
					dataGridView1.Columns[0].HeaderText = "Номер клиента";
					dataGridView1.Columns[1].HeaderText = "Начальное количество";
					dataGridView1.Columns[2].HeaderText = "Количество в конце";
					dataGridView1.Columns[3].HeaderText = "Направление";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					throw;
				}
		}

		private void TurnoverForm_Load(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].HeaderText = "Номер клиента";
			dataGridView1.Columns[1].HeaderText = "Начальное количество";
			dataGridView1.Columns[2].HeaderText = "Количество в конце";
			dataGridView1.Columns[3].HeaderText = "Направление";
		}
	}
}
