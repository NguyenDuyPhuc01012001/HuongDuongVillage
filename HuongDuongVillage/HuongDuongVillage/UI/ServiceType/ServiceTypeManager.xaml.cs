using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ServiceTypeManager.xaml
    /// </summary>
    public partial class ServiceTypeManager : UserControl
    {
        public ServiceTypeManager()
        {
            InitializeComponent();
        }

        private void sortNameButton_Click(object sender, RoutedEventArgs e)
        {
            if (buttonSortNameIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                buttonSortNameIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                buttonSortNameIcon.Foreground = Brushes.Green;
            }
            else
            {
                buttonSortNameIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                buttonSortNameIcon.Foreground = Brushes.Red;
            }
        }

        private void sortTypeButton_Click(object sender, RoutedEventArgs e)
        {
            if (buttonSortTypeIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                buttonSortTypeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                buttonSortTypeIcon.Foreground = Brushes.Green;
            }
            else
            {
                buttonSortTypeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                buttonSortTypeIcon.Foreground = Brushes.Red;
            }
        }

        private void sortPriceButton_Click(object sender, RoutedEventArgs e)
        {
            if (buttonSortPriceIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                buttonSortPriceIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                buttonSortPriceIcon.Foreground = Brushes.Green;
            }
            else
            {
                buttonSortPriceIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                buttonSortPriceIcon.Foreground = Brushes.Red;
            }
        }
    }
}