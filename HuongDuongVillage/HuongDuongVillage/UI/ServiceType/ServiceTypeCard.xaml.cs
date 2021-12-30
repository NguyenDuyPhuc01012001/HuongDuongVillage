using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ServiceTypeCard.xaml
    /// </summary>
    public partial class ServiceTypeCard : UserControl
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public ServiceTypeCard()
        {
            InitializeComponent();
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        public void SetText(int id, string name, string type, float price)
        {
            tbkID.Text = id.ToString();
            tbkName.Text = name;
            tbkType.Text = type;
            tbkPrice.Text = price.ToString();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(tbkID.Text);
            string name = tbkName.Text;
            string type = tbkType.Text;
            float price = float.Parse(tbkPrice.Text);
            ServiceTypeDTO serviceType = new ServiceTypeDTO(ID, name, type, price);
            ManageServiceType manageServiceType = new ManageServiceType(serviceType, "Edit");
            manageServiceType.ShowDialog();
            if (this.reloadPage != null)
            {
                reloadPage(this, new EventArgs());
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(tbkID.Text);
            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this Service type?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (ServiceDAO.Instance.GetServiceListByType(ID).Count > 0)
                {
                    CustomAlertBox.Show("Error", "There is at least one Service belongs to this Service type", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                if (ServiceTypeDAO.Instance.DeleteServiceType(ID))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }
    }
}