using Individualka.DAL.EF;
using Individualka.DAL.Entites;
using Individualka.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Individualka
{
    public partial class Diagram : Form
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int Id { get; set; }
        public Diagram(DateTime startDate, DateTime endDate, int id)
        {
            InitializeComponent();
            StartDate = startDate;
            EndDate = endDate;
            Id = id;
            CreateChart(StartDate,EndDate,Id);
        }
        private void CreateChart(DateTime startDate, DateTime endDate, int id)
        {
            using (var db = new Context())
            {
                ContractRepository cr = new ContractRepository(db);
                List<Contract> all = cr.GetAll().Where(x => x.ClientId == id).ToList();
                int contracted = 0;
                int payed = 0;

                foreach (Contract contract in all)
                {
                    if (contract.Status == false)
                        payed+=1;
                    else
                        contracted++;
                }
                Chart chart = new Chart
                {
                    Width = 600,
                    Height = 300
                };

                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                chartArea.AxisX.Interval = 1;

                Series series = new Series
                {
                    Name = "Series1",
                    ChartType = SeriesChartType.Pie
                };

                series["PointWidth"] = "0.6"; 
                series["PixelPointWidth"] = "10"; 

                series.Points.AddXY(1, contracted);
                series.Points.AddXY(2, payed);


                chart.Series.Add(series);

                this.Controls.Add(chart);
            }
        }
    }

}
