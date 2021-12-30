using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for StaffManager.xaml
    /// </summary>
    public partial class StaffManager : UserControl
    {
        public StaffManager()
        {
            InitializeComponent();
        }

        public void btnSortName_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(nameSortIcon, btnSortName);
        }

        public void btnSortRole_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(RoleSortIcon, btnSortRole);
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