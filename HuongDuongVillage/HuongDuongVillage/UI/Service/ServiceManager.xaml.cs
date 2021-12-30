using System.Windows;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for CategoryManager.xaml
    /// </summary>
    public partial class ServiceManager : UserControl
    {
        //event click chuyen
        public RoutedEventHandler RouteEventClick;

        public ServiceManager()
        {
            InitializeComponent();
        }

        public ServiceManager(RoutedEventHandler eventClick)
        {
            this.RouteEventClick = eventClick;
            InitializeComponent();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus();

            if (RouteEventClick != null)
            {
                RouteEventClick(this, e);
            }
        }

        private void ToggleIconStatus()
        {
        }
    }
}