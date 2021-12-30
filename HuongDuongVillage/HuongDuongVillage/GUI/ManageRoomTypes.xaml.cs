using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Linq;
using System.Windows;

namespace HuongDuongVillage.GUI
{
    /// <summary>
    /// Interaction logic for ManageRoomType.xaml
    /// </summary>
    public partial class ManageRoomTypes : Window
    {
        private string function = null;
        private int id;

        public ManageRoomTypes()
        {
            InitializeComponent();
        }

        public ManageRoomTypes(string function, RoomTypeDTO roomType = null)
        {
            InitializeComponent();
            this.function = function;

            if (roomType != null)
            {
                this.id = roomType.ID;
                txbRoomPrice.Text = roomType.RoomPrice.ToString();
                txbRoomType.Text = roomType.RoomType.ToString();
                btnConfirm.Content = "Update";
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            switch (function)
            {
                case "Insert":
                    InsertRoomType();
                    break;

                case "Edit":
                    EditRoomType();
                    break;
            }
        }

        private void EditRoomType()
        {
            try
            {
                string roomType = txbRoomType.Text;
                string roomPrice = txbRoomPrice.Text;
                if (!ValidatePrice(roomPrice))
                {
                    CustomAlertBox.Show("Error", "Price must not contains alphabet character", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (RoomTypeDAO.Instance.EditRoomType(this.id, roomType, float.Parse(roomPrice)))
                {
                    CustomAlertBox.Show("Edit room type successfully!");
                    this.Close();
                }
                else
                {
                    CustomAlertBox.Show("Edit room type failed");
                }
            }
            catch (NullReferenceException)
            {
                CustomAlertBox.Show("Error", "Please fill out the form first", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message, MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
        }

        private bool ValidatePrice(string price)
        {
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] >= 'a' && price[i] <= 'z' || price[i] >= 'A' && price[i] <= 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        private void InsertRoomType()
        {
            try
            {
                string roomType = txbRoomType.Text;
                string roomPrice = txbRoomPrice.Text;
                if (!ValidatePrice(roomPrice))
                {
                    CustomAlertBox.Show("Error", "Price must not contains alphabet character", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (RoomTypeDAO.Instance.GetRoomTypesByName(roomType).Count() > 0)
                {
                    CustomAlertBox.Show("Error", "This Room type is already existed", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (RoomTypeDAO.Instance.InsertRoomType(roomType, float.Parse(roomPrice)))
                {
                    CustomAlertBox.Show("Add new room type successfully!");
                    this.Close();
                }
                else
                {
                    CustomAlertBox.Show("Add new room type failed");
                }
            }
            catch (NullReferenceException)
            {
                CustomAlertBox.Show("Error", "Please fill out the form first", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message, MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}