using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for RoomManager.xaml
    /// </summary>
    public partial class RoomManager : UserControl
    {
        public RoomManager()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            btnSortStatus.Cursor = Cursors.Wait;
            if (SortStatusIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                SortStatusIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                SortStatusIcon.Foreground = Brushes.Green;
            }
            else
            {
                SortStatusIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                SortStatusIcon.Foreground = Brushes.Red;
            }
            btnSortStatus.Cursor = null;
        }
    }
}