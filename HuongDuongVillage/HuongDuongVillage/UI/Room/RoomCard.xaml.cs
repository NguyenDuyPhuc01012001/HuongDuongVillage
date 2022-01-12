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
    /// Interaction logic for RoomCard.xaml
    /// </summary>
    public partial class RoomCard : UserControl
    {
        private int idRoom;
        private int roomTypeID;
        private bool isCEOAccessing;
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public RoomCard(int idRoom, int roomTypeID, bool isCEOAccessing = false)
        {
            InitializeComponent();
            this.idRoom = idRoom;
            this.roomTypeID = roomTypeID;
            this.isCEOAccessing = isCEOAccessing;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = new SolidColorBrush(Color.FromRgb(237, 33, 58));// Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void editButton_MouseEnter(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = new SolidColorBrush(Color.FromRgb(82, 194, 52)); //Brushes.Green;
        }

        private void editButton_MouseLeave(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.White;
        }

        private void checkoutBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            checkoutIcon.Foreground = new SolidColorBrush(Color.FromRgb(82, 194, 52)); //Brushes.Green;
        }

        private void checkoutBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            checkoutIcon.Foreground = Brushes.White;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            ManageRoom editRoom = new ManageRoom("Edit", "Room", idRoom);
            editRoom.ReloadPage += reloadPage;
            editRoom.ShowDialog();
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
            string idCustomer = tblCusID.Text;
            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this room?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (tblRoomStatus.Text != "Available")
                {
                    CustomAlertBox.Show("Delete failed because one customer is using our service.");
                    return;
                }
                if (RoomDAO.Instance.DeleteRoom(idRoom))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }

        private void checkoutBtn_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            if (tblRoomStatus.Text != "Available")
            {
                BillTemplate billTemplate = new BillTemplate(idRoom, this.roomTypeID, this.tblRoomName.Text);
                billTemplate.ShowDialog();
                if (reloadPage != null)
                    reloadPage(this, new EventArgs());
            }
            else
            {
                CustomAlertBox.Show("Error", "Can not checkout room with 'Available' status", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
        }

        public void setText(string roomName, string cusID, string roomAddress, string roomType, string roomStatus, float roomPrice)
        {
            tblRoomName.Text = roomName;
            tblAddress.Text = roomAddress;
            tblRoomType.Text = roomType;
            tblRoomStatus.Text = roomStatus;
            switch (roomStatus)
            {
                case "Unavailable":
                    tblRoomStatus.Foreground = new SolidColorBrush(Color.FromRgb(237, 33, 58));
                    break;

                case "Available":
                    tblRoomStatus.Foreground = Brushes.Green;
                    break;
            }
            tblRoomPrice.Text = roomPrice.ToString();
            if (roomStatus != "Available")
                tblCusID.Text = cusID.ToString();
            else
                tblCusID.Text = null;
        }
    }
}