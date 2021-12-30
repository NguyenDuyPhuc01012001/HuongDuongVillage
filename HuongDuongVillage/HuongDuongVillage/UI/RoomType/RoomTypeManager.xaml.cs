using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for TableManager.xaml
    /// </summary>
    public partial class RoomTypeManager : UserControl
    {
        public RoutedEventHandler eventHandler;

        public RoomTypeManager()
        {
            InitializeComponent();
        }

        public RoomTypeManager(RoutedEventHandler eventHandler)
        {
            this.eventHandler = eventHandler;
            InitializeComponent();
        }

        private void ToggleIconStatus()
        {
            //if (buttonSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            //{
            //    buttonSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
            //    buttonSortIcon.Foreground = Brushes.Green;
            //}
            //else
            //{
            //    buttonSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
            //    buttonSortIcon.Foreground = Brushes.Red;
            //}
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