using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for AccountManager.xaml
    /// </summary>
    public partial class AccountManager : UserControl
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void sortOwner_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(buttonSortOwner, btnSortName);
        }

        private void sortRole_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(buttonSortRole, btnSortRole);
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