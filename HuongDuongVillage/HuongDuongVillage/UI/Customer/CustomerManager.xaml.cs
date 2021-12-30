using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for BillTable.xaml
    /// </summary>
    public partial class CustomerManager : UserControl
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            btnSortCheckIn.Cursor = Cursors.Wait;
            if (SortCheckInIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                SortCheckInIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                SortCheckInIcon.Foreground = Brushes.Green;
            }
            else
            {
                SortCheckInIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                SortCheckInIcon.Foreground = Brushes.Red;
            }
            btnSortCheckIn.Cursor = null;
        }
    }
}