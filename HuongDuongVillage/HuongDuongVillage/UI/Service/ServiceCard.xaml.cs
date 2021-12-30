using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for CategoryCard.xaml
    /// </summary>
    public partial class ServiceCard : UserControl
    {
        private int idService;
        private int idRoom;
        private bool isCEOAccessing;
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public ServiceCard(int id, int idRoom, bool isCEOAccessing = false)
        {
            InitializeComponent();
            this.idService = id;
            this.idRoom = idRoom;
            this.isCEOAccessing = isCEOAccessing;
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string name, string type, float price, string roomName, bool status)
        {
            tblName.Text = name;
            tblType.Text = type;
            tblPrice.Text = price.ToString();
            tblRoomName.Text = roomName;
            tblStatus.Text = (status) ? "Done" : "Not done";
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            ManageService editService = new ManageService("Edit", idService, idRoom);
            editService.ReloadPage += reloadPage;
            editService.ShowDialog();
            //if (reloadPage != null)
            //    reloadPage(this, new EventArgs());
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            if (tblStatus.Text == "Done")
            {
                CustomAlertBox.Show("Error", "Can not delete this service because the status is Done", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this service.", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (ServiceDAO.Instance.DeleteService(idService))
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