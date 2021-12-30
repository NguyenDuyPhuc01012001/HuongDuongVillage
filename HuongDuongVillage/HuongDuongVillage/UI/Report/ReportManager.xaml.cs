using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class ReportManager : UserControl
    {
        private int month;
        private int year;

        public ReportManager()
        {
            InitializeComponent();
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayArea.Cursor = Cursors.Wait;
            month = datePicker.SelectedDate.Value.Month;
            year = datePicker.SelectedDate.Value.Year;
            totalProfitCard.SetTotalProfitByMonthAndYear(month, year);
            compareLastMonthCard.SetPercentageProfitWithSelectedDate(month, year);
            if (cartesianChartContainer.Children.Count > 0)
            {
                cartesianChartContainer.Children.Clear();
                cartesianChartContainer.Children.Add(new CartesianChart(year));
            }
            DisplayArea.Cursor = null;
        }
    }
}