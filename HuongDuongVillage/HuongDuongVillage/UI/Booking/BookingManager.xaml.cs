using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage.UI.Booking
{
    /// <summary>
    /// Interaction logic for BookingManager.xaml
    /// </summary>
    public partial class BookingManager : UserControl
    {
        public BookingManager()
        {
            InitializeComponent();
        }

        public void btnSortCheckIn_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(SortCheckInIcon, btnSortCheckIn);
        }

        public void btnSortCheckOut_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(SortCheckOutIcon, btnSortCheckOut);
        }

        private void ToggleIconStatus(MaterialDesignThemes.Wpf.PackIcon btnIcon, Button btn)
        {
            btn.Cursor = Cursors.Wait;
            if (btnIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                btnIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                btnIcon.Foreground = Brushes.Green;
            }
            else
            {
                btnIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                btnIcon.Foreground = Brushes.Red;
            }
            btn.Cursor = null;
        }
    }
}