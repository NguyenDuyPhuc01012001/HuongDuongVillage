using HuongDuongVillage.DAO;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for CartesianChart.xaml
    /// </summary>
    public partial class CartesianChart : UserControl
    {
        private bool collIsBusy = false;

        public CartesianChart()
        {
            InitializeComponent();

            try
            {
                SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(GetYearRevenue())
                }
            };

                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Formatter = value => value.ToString("N");
                DataContext = this;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        public CartesianChart(int year)
        {
            InitializeComponent();
            try
            {
                SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(PaymentDAO.Instance.GetSelectedYearProfit(year))
                }
            };
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Formatter = value => value.ToString("N");
                DataContext = this;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private List<float> GetYearRevenue()
        {
            List<float> list = new List<float>();
            try
            {
                for (int month = 1; month < 13; month++)
                {
                    float profit = PaymentDAO.Instance.GetMonthProfit(month, 2021);
                    list.Add(profit);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
            return list;
        }

        public SeriesCollection SeriesCollection
        {
            get;
            set;
        }

        public string[] Labels { get; set; }
        public Func<float, string> Formatter { get; set; }
    }
}