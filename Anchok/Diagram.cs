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
using System.Windows.Forms.DataVisualization.Charting;
namespace Anchok
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
                List<Contract> all = cr.GetAll().Where(x => x.ProductId == id).ToList();
                int contracted = 0;
                int payed = 0;

                foreach (Contract contract in all)
                {
                    if (contract.Status == false)
                        contracted++;
                    else 
                        payed++;
                }
                // Создание нового объекта диаграммы
                Chart chart = new Chart
                {
                    Width = 600,
                    Height = 300
                };

                // Настройка области диаграммы
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Настройка оси X
                chartArea.AxisX.Interval = 1;

                // Добавление серии данных
                Series series = new Series
                {
                    Name = "Series1",
                    ChartType = SeriesChartType.Column
                };

                // Установка расстояния между столбцами
                series["PointWidth"] = "0.6"; // Ширина столбца (меньше 1, чтобы было расстояние между столбцами)
                series["PixelPointWidth"] = "10"; // Фиксированная ширина столбца в пикселях

                // Заполнение серии данными
                series.Points.AddXY(1, contracted);
                series.Points.AddXY(2, payed);


                // Добавление серии в диаграмму
                chart.Series.Add(series);

                // Добавление диаграммы на форму
                this.Controls.Add(chart);
            }
        }
    }

}
