using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.GUI;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for TableCard.xaml
    /// </summary>
    public partial class RoomTypeCard : UserControl
    {
        public RoomTypeCard()
        {
            InitializeComponent();
        }

        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = int.Parse(tblRoomID.Text);
                string type = tblRoomType.Text;
                float price = float.Parse(tblRoomPrice.Text);
                RoomTypeDTO roomType = new RoomTypeDTO(id, type, price);
                ManageRoomTypes manageRoomTypes = new ManageRoomTypes("Edit", roomType);
                manageRoomTypes.ShowDialog();
                if (this.reloadPage != null)
                {
                    reloadPage(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(tblRoomID.Text);
            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this Room type?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (RoomDAO.Instance.GetRoomListByType(ID).Count > 0)
                {
                    CustomAlertBox.Show("Error", "There is at least one room belongs to this room type", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                if (RoomTypeDAO.Instance.DeleteRoomType(ID))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }

        public void setText(int id, string type, int roomCount, float price)
        {
            tblRoomID.Text = id.ToString();
            tblRoomType.Text = type;
            tblRoomCount.Text = roomCount.ToString();
            tblRoomPrice.Text = price.ToString();
        }
    }
}