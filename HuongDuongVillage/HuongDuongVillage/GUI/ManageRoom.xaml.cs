using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ManageRoom.xaml
    /// </summary>
    public partial class ManageRoom : Window
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }
        private string function;
        private string manage;
        private int id;
        private bool flag = false;

        public ManageRoom()
        {
            InitializeComponent();
        }

        public ManageRoom(string _function, string _manage, int _id = -1)
        {
            InitializeComponent();

            try
            {
                List<RoomTypeDTO> listType = RoomTypeDAO.Instance.GetRoomTypeList();
                foreach (RoomTypeDTO type in listType)
                {
                    cmbType.Items.Add(type);
                }
                cmbType.SelectedIndex = 0;
                function = _function;
                manage = _manage;
                if (manage == "Room")
                {
                    LoadFormRoomManage(function, _id);
                }
                if (manage == "Book")
                {
                    LoadFormBookingManage(function, _id);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #region Event

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            switch (manage)
            {
                case "Room":
                    switch (function)
                    {
                        case "Edit":
                            if (btnConfirm.Content == "Confirm")
                                this.Close();
                            else
                            {
                                if (btnConfirm.Content == "Update")
                                {
                                    EditRoom();
                                    if (flag)
                                        CustomerDAO.Instance.MakeCheckIn(txbIDCard.Text, DateTime.Now);
                                }
                                else if (CheckInfo())
                                    btnConfirm.Content = "Update";
                            }
                            break;

                        case "Insert":
                            InsertRoom();
                            break;
                    }
                    break;

                case "Book":
                    switch (function)
                    {
                        case "View":
                            this.Close();
                            break;

                        case "Insert":
                            if (btnConfirm.Content == "Confirm")
                            {
                                InsertBooking();
                                if (flag)
                                    CustomerDAO.Instance.MakeCheckIn(txbIDCard.Text, dpkDateCheckIn.SelectedDate.Value.Date);
                            }
                            else
                            if (CheckInfo())
                                btnConfirm.Content = "Confirm";
                            break;
                    }
                    break;
            }
            if (reloadPage != null)
                reloadPage(this, new EventArgs());
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RoomTypeDTO roomType = (RoomTypeDTO)cmbType.SelectedItem;
            txbPrice.Text = roomType.RoomPrice.ToString();

            if (manage == "Room" && function == "Insert")
                return;
            List<RoomDTO> listRoom = RoomDAO.Instance.GetRoomListByType(roomType.ID);
            cmbNameRoom.Items.Clear();
            foreach (RoomDTO room in listRoom)
                cmbNameRoom.Items.Add(room);
            if (cmbNameRoom.Items.Count > 0)
                cmbNameRoom.SelectedIndex = 0;
        }
        private void cmbNameRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbNameRoom.Items.Count > 0)
            {
                RoomDTO room = (RoomDTO)cmbNameRoom.SelectedItem;
                txbAddress.Text = room.RoomAddress;
                txbStatus.Text = room.RoomStatus;
            }
        }
        private void txbIDCard_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnConfirm.Content = "Check";
        }
        private void dpkDate_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            btnConfirm.Content = "Check";
        }
        #endregion Event

        #region Method
        private void LoadFormBookingManage(string function, int id)
        {
            try
            {
                txbNameRoom.Visibility = Visibility.Hidden;
                int idRoomType = int.Parse(cmbType.SelectedValue.ToString());
                List<RoomDTO> listRoom = RoomDAO.Instance.GetRoomListByType(idRoomType);
                foreach (RoomDTO room in listRoom)
                    cmbNameRoom.Items.Add(room);
                if (cmbNameRoom.Items.Count > 0)
                    cmbNameRoom.SelectedIndex = 0;
                if (function == "View")
                {
                    cmbNameRoom.Visibility = Visibility.Hidden;
                    txbNameRoom.Visibility = Visibility.Visible;
                    cmbType.Visibility = Visibility.Hidden;
                    txbType.Visibility = Visibility.Visible;
                    btnConfirm.Visibility = Visibility.Hidden;

                    BookingDTO booked = BookingDAO.Instance.GetBookedByID(id);
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(booked.RoomID);
                    RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeInfo(room.RoomTypeID);
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);

                    txbNameRoom.Text = room.RoomName;
                    txbAddress.Text = room.RoomAddress;
                    txbStatus.Text = room.RoomStatus;
                    txbIDCard.Text = customer.CusIDcard;
                    txbNameCus.Text = customer.CusName;
                    txbType.Text = roomType.RoomType;
                    txbPrice.Text = roomType.RoomPrice.ToString();
                    dpkDateCheckIn.SelectedDate = booked.DateCheckIn;
                    dpkDateCheckOut.SelectedDate = booked.DateCheckOut;

                    txbIDCard.IsReadOnly = true;
                    txbNameRoom.IsReadOnly = true;
                    txbAddress.IsReadOnly = true;
                    dpkDateCheckIn.IsEnabled = false;
                    dpkDateCheckOut.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void LoadFormRoomManage(string function, int id)
        {
            lblDateCheckIn.Visibility = Visibility.Collapsed;
            lblDateCheckOut.Visibility = Visibility.Collapsed;
            grdDateCheckIn.Visibility = Visibility.Collapsed;
            grdDateCheckOut.Visibility = Visibility.Collapsed;
            cmbNameRoom.Visibility = Visibility.Hidden;
            txbStatus.Text = "Available";
            txbAddress.Clear();
            grdCusInfo.Visibility = Visibility.Collapsed;
            if (function == "Edit")
            {
                RoomDTO room = RoomDAO.Instance.GetRoomByID(id);
                RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeInfo(room.RoomTypeID);
                CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
                this.id = id;

                txbNameRoom.Text = room.RoomName;
                txbAddress.Text = room.RoomAddress;
                txbStatus.Text = room.RoomStatus;
                txbNameCus.Text = null;
                if (customer != null)
                {
                    txbIDCard.Text = customer.CusIDcard;
                    if (txbStatus.Text != "Available")
                        txbNameCus.Text = customer.CusName;
                }

                cmbType.SelectedItem = roomType.RoomType;
                txbPrice.Text = roomType.RoomPrice.ToString();

                if (txbStatus.Text != "Available")
                {
                    txbIDCard.IsReadOnly = true;
                    txbNameRoom.IsReadOnly = true;
                    txbAddress.IsReadOnly = true;
                    cmbType.IsEnabled = false;
                    flag = false;
                }
                else
                    txbIDCard.Clear();
                if (txbStatus.Text == "Unavailable")
                {
                    btnConfirm.Content = "Confirm";
                }
                if (txbStatus.Text == "Booked")
                {
                    btnConfirm.Content = "Update";
                }
                grdCusInfo.Visibility = Visibility.Visible;
            }
        }

        private void InsertRoom()
        {
            try
            {
                string name = txbNameRoom.Text.Replace("'", "''");
                string address = txbAddress.Text.Replace("'", "''");
                int idRoomType = int.Parse(cmbType.SelectedValue.ToString());

                if (!ValidateInfo(name, address))
                    return;
                string status = txbStatus.Text;

                if (RoomDAO.Instance.InsertRoom(name, address, idRoomType))
                {
                    MessageBox.Show("Add new Room successfully!");

                    this.Close();
                }
                else
                    MessageBox.Show("Add new Room failed");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void EditRoom()
        {
            try
            {
                MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to change this room to unavailable?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
                if (result != MessageBoxResult.OK)
                    return;

                string name = txbNameRoom.Text.Replace("'", "''");
                string address = txbAddress.Text.Replace("'", "''");
                int idRoomType = int.Parse(cmbType.SelectedValue.ToString());
                string idCard = txbIDCard.Text;
                string status = "Unavailable";
                CustomerDTO customer = CustomerDAO.Instance.GetCustomerByIdCard(idCard);
                int idCus = customer.ID;
                if (txbStatus.Text == "Available")
                    flag = true;

                if (RoomDAO.Instance.EditRoom(id, name, address, idCus, status, idRoomType))
                {
                    MessageBox.Show("Edit room successfully!");

                    this.Close();
                }
                else
                    MessageBox.Show("Edit room failed");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void InsertBooking()
        {
            try
            {
                string name = cmbNameRoom.Text.Replace("'", "''");
                string address = txbAddress.Text.Replace("'", "''");
                int idRoomType = int.Parse(cmbType.SelectedValue.ToString());
                int idRoom = int.Parse(cmbNameRoom.SelectedValue.ToString());
                string idCard = txbIDCard.Text;
                string status = txbStatus.Text;
                DateTime dateCheckIn = dpkDateCheckIn.SelectedDate.Value.Date;
                DateTime dateCheckOut = dpkDateCheckOut.SelectedDate.Value.Date;
                CustomerDTO customer = CustomerDAO.Instance.GetCustomerByIdCard(idCard);
                flag = true;
                if (BookingDAO.Instance.InsertBooking(idRoom, customer.ID, dateCheckIn, dateCheckOut))
                {
                    MessageBox.Show("Insert booking successfully!");

                    this.Close();
                }
                else
                    MessageBox.Show("Insert booking failed");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private bool CheckInfo()
        {
            try
            {
                string name = cmbNameRoom.Text.Replace("'", "''");
                string address = txbAddress.Text.Replace("'", "''");
                string idCard = txbIDCard.Text;
                string status = txbStatus.Text;

                if (!ValidateInfo(name, address))
                    return false;
                if (status == "Available")
                {
                    if (!IsValid(idCard))
                        return false;
                    else
                    {
                        flag = true;
                        CustomerDTO customer = CustomerDAO.Instance.GetCustomerByIdCard(idCard);
                        txbNameCus.Text = customer.CusName;
                    }
                }
                if (manage == "Book")
                {
                    DateTime dateCheckIn = dpkDateCheckIn.SelectedDate.Value.Date;
                    DateTime dateCheckOut = dpkDateCheckOut.SelectedDate.Value.Date;
                    if (!ValidateDate(dateCheckIn, dateCheckOut))
                        return false;
                }

                MessageBox.Show("All is good!");
                return true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        #endregion Method

        #region Validate
        private bool IsValid(string idCard)
        {
            try
            {
                if (idCard.Trim().Length != 9 && idCard.Trim().Length != 12)
                {
                    MessageBox.Show("ID card is invalid.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                if (CustomerDAO.Instance.CheckIDCardExist(idCard) == null)
                {
                    MessageBox.Show("ID card is not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Email is invalid");
                return false;
            }
        }

        private bool ValidateInfo(string name, string address)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Name or address is mustn't empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void OnlyNumber(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private bool ValidateDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            if (dateCheckIn > dateCheckOut)
            {
                CustomAlertBox.Show("Error", "Date check in must be smaller than date check out", CustomAlertBox.MessageBoxType.Error);
                return false;
            }
            if (dateCheckIn < DateTime.Now)
            {
                CustomAlertBox.Show("Error", "Date check in mustn't be smaller than today", CustomAlertBox.MessageBoxType.Error);
                return false;
            }
            DateTime zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = dateCheckOut - dateCheckIn;
            // Because we start at year 1 for the Gregorian calendar, we must subtract a year here.
            int months = (zeroTime + span).Month - 1;

            if (span.TotalDays > 31)
            {
                CustomAlertBox.Show("You only be booked room at here in 1 month");
                return false;
            }
            return true;
        }
        #endregion Validate        
    }
}