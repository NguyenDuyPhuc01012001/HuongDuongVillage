using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for PaymentManager.xaml
    /// </summary>
    public partial class PaymentManager : UserControl
    {
        public PaymentManager()
        {
            InitializeComponent();
        }

        private void btnSortAmount_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(iconSortAmount, btnSortAmount);
        }

        private void btnSortPaymentDate_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(iconSortPaymentDate, btnSortPaymentDate);
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