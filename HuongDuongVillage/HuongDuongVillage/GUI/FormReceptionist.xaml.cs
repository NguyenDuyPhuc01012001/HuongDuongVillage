using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.UI.Booking;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for FormReceptionist.xaml
    /// </summary>
    public partial class FormReceptionist : Window
    {
        public FormReceptionist()
        {
            InitializeComponent();
        }

        public FormReceptionist(int id)
        {
            InitializeComponent();
            try
            {
                tblName.Text = StaffDAO.Instance.GetNameById(id);
                InfoButton.Tag = StaffDAO.Instance.GetStaffById(id);
                staffID = id;
                ListViewMenu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #region Reset
        private void ResetReportManager()
        {
            GridAssistant.Children.Clear();
        }

        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
        }

        private void ModifyCategory_Modify(object sender, EventArgs e)
        {
            //SetCategoryPage();
        }
        #endregion Reset

        #region Set
        private void SetGridAssistantToDefault()
        {
            ResetReportManager();
        }

        private void SetGridPrincipalToDefault()
        {
            ResetManagerFieldHolder();
        }

        private void SetGridPrincipal()
        {
            DisableGridAssistant();
            EnableGridPrincipal();

            SearchBoxContainer.Visibility = Visibility.Visible;
            AddButton.Visibility = Visibility.Visible;
        }

        private void SetGridAssistant()
        {
            DisableGridPrincipal();
            EnableGridAssistant();
        }

        private void SetBookingPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeBookingManager();
            IncludeBookingList();
            txbSearch.ToolTip = "Search with room name";
            AddButton.ToolTip = "Add new booking";
            sortCheckInCount = 0;
            sortCheckOutCount = 0;
            DisplayArea.Cursor = null;
        }

        private void SetCustomerPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeCustomerManager();
            IncludeCustomerList();
            txbSearch.ToolTip = "Search with customer name";
            AddButton.ToolTip = "Add new customer";
            sortCheckInCount = 0;
            DisplayArea.Cursor = null;
        }

        private void SetDocumentReportPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeDocumentReportManager();
            IncludeDocumentReportList();
            AddButton.ToolTip = "Add new report";
            SearchBoxContainer.Visibility = Visibility.Hidden;
            DisplayArea.Cursor = null;
        }

        private void SetRoomPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeRoomManager();
            IncludeRoomList();
            sortRoomStatusCount = 0;
            txbSearch.ToolTip = "Search with room name";
            AddButton.ToolTip = "Add new room";
            DisplayArea.Cursor = null;
        }

        private void SetServicePage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            ManagerFieldHolder.Children.Add(new ServiceManager());
            IncludeServiceList();
            AddButton.ToolTip = "Add new service";
            SearchBoxContainer.Visibility = Visibility.Hidden;
            DisplayArea.Cursor = null;
        }
        #endregion Set

        #region Include

        #region DocumentReport
        private void IncludeDocumentReportManager()
        {
            ManagerFieldHolder.Children.Add(new DocumentReportManager());
        }

        private void IncludeDocumentReportList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ReportDTO> reportList = ReportDAO.Instance.GetListReportByID(staffID);

                foreach (ReportDTO report in reportList)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(report.StaffID);
                    DocumentReportCard card = new DocumentReportCard(report.StaffID, staffID, report.ID);
                    card.setText(staff.Name, report.Message, report.Document);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion DocumentReport

        #region Booking
        private void IncludeBookingManager()
        {
            BookingManager card = new BookingManager();
            card.btnSortCheckIn.Click += BtnSortCheckIn_Click;
            card.btnSortCheckOut.Click += BtnSortCheckOut_Click;
            ManagerFieldHolder.Children.Add(card);
        }

        private void IncludeBookingList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<BookingDTO> bookingList = BookingDAO.Instance.GetListBooking();

                foreach (BookingDTO booking in bookingList)
                {
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(booking.RoomID);
                    string roomName = room.RoomName;
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(booking.CusID);
                    BookingCard card = new BookingCard(booking.ID, booking.RoomID);
                    card.setText(roomName, customer.CusName, customer.CusIDcard, booking.DateCheckIn.ToString(), booking.DateCheckOut.ToString());
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeBookingListByCheckIn(string searchRoomName, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<BookingDTO> bookingList = BookingDAO.Instance.GetListBookingByCheckIn(searchRoomName, function);
                if (bookingList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (BookingDTO booking in bookingList)
                {
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(booking.RoomID);
                    string roomName = room.RoomName;
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(booking.CusID);
                    BookingCard card = new BookingCard(booking.ID, booking.RoomID);
                    card.setText(roomName, customer.CusName, customer.CusIDcard, booking.DateCheckIn.ToString(), booking.DateCheckOut.ToString());
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeBookingListByCheckOut(string searchRoomName, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<BookingDTO> bookingList = BookingDAO.Instance.GetListBookingByCheckOut(searchRoomName, function);
                if (bookingList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (BookingDTO booking in bookingList)
                {
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(booking.RoomID);
                    string roomName = room.RoomName;
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(booking.CusID);
                    BookingCard card = new BookingCard(booking.ID, booking.RoomID);
                    card.setText(roomName, customer.CusName, customer.CusIDcard, booking.DateCheckIn.ToString(), booking.DateCheckOut.ToString());
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Booking

        #region Room
        private void IncludeRoomManager()
        {
            RoomManager card = new RoomManager();
            card.btnSortStatus.Click += BtnSortRoomStatus_Click;
            ManagerFieldHolder.Children.Add(card);
        }

        private void IncludeRoomList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomDTO> roomList = RoomDAO.Instance.GetRoomList();

                foreach (RoomDTO room in roomList)
                {
                    RoomCard card = new RoomCard(room.ID, room.RoomTypeID);
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
                    string cusIDCard = (customer == null) ? null : customer.CusIDcard;
                    RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeInfo(room.RoomTypeID);
                    card.setText(room.RoomName, cusIDCard, room.RoomAddress, roomType.RoomType, room.RoomStatus, roomType.RoomPrice);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeRoomListByStatus(string searchRoomName, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomDTO> roomList = RoomDAO.Instance.GetRoomListByStatus(searchRoomName, function);
                if (roomList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (RoomDTO room in roomList)
                {
                    RoomCard card = new RoomCard(room.ID, room.RoomTypeID);
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
                    string cusIDCard = (customer == null) ? null : customer.CusIDcard;
                    RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeInfo(room.RoomTypeID);
                    card.setText(room.RoomName, cusIDCard, room.RoomAddress, roomType.RoomType, room.RoomStatus, roomType.RoomPrice);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Room

        #region Customer
        private void IncludeCustomerManager()
        {
            CustomerManager card = new CustomerManager();
            card.btnSortCheckIn.Click += BtnSortCheckIn_Click;
            ManagerFieldHolder.Children.Add(card);
        }

        private void IncludeCustomerList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<CustomerDTO> cusList = CustomerDAO.Instance.GetListCustomer();

                foreach (CustomerDTO customer in cusList)
                {
                    CustomerCard card = new CustomerCard(customer.ID);
                    string dateCheckIn;
                    DateTime nullDate = new DateTime(1900, 1, 1);

                    if (customer.DateCheckIn == nullDate)
                        dateCheckIn = null;
                    else
                        dateCheckIn = customer.DateCheckIn.ToString();
                    card.setText(customer.CusName, customer.CusIDcard, customer.CusPhone, customer.CusEmail, dateCheckIn);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeCustomerListByCheckIn(string cusName, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<CustomerDTO> cusList = CustomerDAO.Instance.GetListCustomerByCheckIn(cusName, function);
                if (cusList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (CustomerDTO customer in cusList)
                {
                    CustomerCard card = new CustomerCard(customer.ID);
                    string dateCheckIn;
                    DateTime nullDate = new DateTime(1900, 1, 1);

                    if (customer.DateCheckIn == nullDate)
                        dateCheckIn = null;
                    else
                        dateCheckIn = customer.DateCheckIn.ToString();
                    card.setText(customer.CusName, customer.CusIDcard, customer.CusPhone, customer.CusEmail, dateCheckIn);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Customer

        #region Service
        private void IncludeServiceList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServicesDTO> services = ServiceDAO.Instance.GetListService();
                foreach (ServicesDTO service in services)
                {
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(service.RoomID);
                    string roomName = room.RoomName;
                    ServiceCard card = new ServiceCard(service.ID, service.RoomID);
                    ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(service.SerTypeID);
                    float totalPrice = serviceType.SerPrice * service.Quantity;
                    card.SetText(serviceType.SerName, serviceType.SerType, totalPrice, roomName, service.Status);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Service

        #endregion Include
        private void DisableGridPrincipal()
        {
            GridPrincipal.Visibility = Visibility.Collapsed;
        }

        private void EnableGridPrincipal()
        {
            GridPrincipal.Visibility = Visibility.Visible;
        }

        private void DisableGridAssistant()
        {
            GridAssistant.Visibility = Visibility.Collapsed;
        }

        private void EnableGridAssistant()
        {
            GridAssistant.Visibility = Visibility.Visible;
        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitioningContentSlide.OnApplyTemplate();
            //GridCursor.Margin = new Thickness(0, (150+(60 * index)), 0, 0);
        }

        #region Event
        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            DisplayArea.Cursor = Cursors.Hand;
        }
        private void ListViewItem_MouseLeave(object sender, MouseEventArgs e)
        {
            DisplayArea.Cursor = null;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = ListViewMenu.SelectedIndex;
                MoveCursorMenu(index);
                txbSearch.Clear();
                switch (index)
                {
                    case 0:
                        SetDocumentReportPage();
                        break;

                    case 1:
                        SetBookingPage();
                        break;

                    case 2:
                        SetRoomPage();
                        break;

                    case 3:
                        SetCustomerPage();
                        break;

                    case 4:
                        SetServicePage();
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txbSearch.Cursor = Cursors.Wait;
                int index = ListViewMenu.SelectedIndex;
                string function = null;
                switch (index)
                {
                    case 1:
                        if (sortCheckInCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeBookingListByCheckIn(txbSearch.Text.Replace("'", "''"), function);
                        break;

                    case 2:
                        if (sortRoomStatusCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeRoomListByStatus(txbSearch.Text.Replace("'", "''"), function);
                        break;

                    case 3:
                        if (sortCheckInCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeCustomerListByCheckIn(txbSearch.Text.Replace("'", "''"), function);
                        break;

                    default:
                        break;
                }
                txbSearch.Cursor = null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = ListViewMenu.SelectedIndex;
                switch (index)
                {
                    case 0:
                        ManageDocument insertDocument = new ManageDocument("Insert", staffID);
                        insertDocument.ReloadPage += ReloadPage;
                        insertDocument.ShowDialog();
                        //SetDocumentReportPage();
                        break;

                    case 1:
                        ManageRoom insertBooking = new ManageRoom("Insert", "Book");
                        insertBooking.ReloadPage += ReloadPage;
                        insertBooking.ShowDialog();
                        //SetBookingPage();
                        break;

                    case 2:
                        ManageRoom insertRoom = new ManageRoom("Insert", "Room");
                        insertRoom.ReloadPage += ReloadPage;
                        insertRoom.ShowDialog();
                        //SetRoomPage();
                        break;

                    case 3:
                        ManageCustomer insertCustomer = new ManageCustomer("Insert");
                        insertCustomer.ReloadPage += ReloadPage;
                        insertCustomer.ShowDialog();
                        //SetCustomerPage();
                        break;

                    case 4:
                        ManageService insertService = new ManageService("Insert");
                        insertService.ReloadPage += ReloadPage;
                        insertService.ShowDialog();
                        //SetServicePage();
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            try
            {
                int index = ListViewMenu.SelectedIndex;
                switch (index)
                {
                    case 0:
                        SetDocumentReportPage();
                        break;

                    case 1:
                        SetBookingPage();
                        break;

                    case 2:
                        SetRoomPage();
                        break;

                    case 3:
                        SetCustomerPage();
                        break;

                    case 4:
                        SetServicePage();
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword("Change", staffID);
            changePassword.ShowDialog();
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", staff);
            manage.ShowDialog();
        }

        private void BtnSortCheckIn_Click(object sender, RoutedEventArgs e)
        {
            //sortCheckInCount % 2 == 0 : sort ascending
            //sortCheckInCount % 2 != 0 : sort descending
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                int index = ListViewMenu.SelectedIndex;
                string function = null;
                switch (index)
                {
                    case 1:
                        if (sortCheckInCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeBookingListByCheckIn(txbSearch.Text.Replace("'", "''"), function);
                        sortCheckInCount++;
                        break;

                    case 3:
                        if (sortCheckInCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeCustomerListByCheckIn(txbSearch.Text.Replace("'", "''"), function);
                        sortCheckInCount++;
                        break;
                }
                DisplayArea.Cursor = null;
            }
            catch (Exception ex)
            {
                DisplayArea.Cursor = null;
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void BtnSortCheckOut_Click(object sender, RoutedEventArgs e)
        {
            //sortCheckOutCount % 2 == 0 : sort ascending
            //sortCheckOutCount % 2 != 0 : sort descending
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                string function = null;
                if (sortCheckOutCount % 2 == 0)
                    function = "asc";
                else
                    function = "desc";
                IncludeBookingListByCheckOut(txbSearch.Text.Replace("'", "''"), function);
                sortCheckOutCount++;
                DisplayArea.Cursor = null;
            }
            catch (Exception ex)
            {
                DisplayArea.Cursor = null;
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void BtnSortRoomStatus_Click(object sender, RoutedEventArgs e)
        {
            //sortRoomStatusCount % 2 == 0 : sort ascending
            //sortRoomStatusCount % 2 != 0 : sort descending
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                string function = null;
                if (sortRoomStatusCount % 2 == 0)
                    function = "asc";
                else
                    function = "desc";
                IncludeRoomListByStatus(txbSearch.Text.Replace("'", "''"), function);
                sortRoomStatusCount++;
                DisplayArea.Cursor = null;
            }
            catch (Exception ex)
            {
                DisplayArea.Cursor = null;
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Event

        #region Field
        public Func<ChartPoint, string> PointLabel { get; set; }
        private int staffID;
        private int sortCheckInCount;
        private int sortCheckOutCount;
        private int sortRoomStatusCount;
        #endregion Field
    }
}