using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for FormCEO.xaml
    /// </summary>
    public partial class FormCEO : Window
    {
        private int staffID;
        private int sortStaffNameCount = 0;
        private int sortStaffRoleCount = 0;
        private string functionSortName = "asc";
        private string functionSortRole = "asc";
        private int listViewIndex;

        public FormCEO()
        {
            InitializeComponent();
            SetReportPage();
            listViewIndex = 1;
            SetUserManagerPage();
        }

        public FormCEO(int id)
        {
            InitializeComponent();
            tblName.Text = StaffDAO.Instance.GetNameById(id);
            staffID = id;
            listViewIndex = 1;
            SetUserManagerPage();
        }

        #region Method

        #region Reset

        private void ResetReportManager()
        {
            GridAssistant.Children.Clear();
        }

        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
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
        }

        private void SetGridAssistant()
        {
            DisableGridPrincipal();
            EnableGridAssistant();
        }

        private void SetReportPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridAssistantToDefault();
            SetGridAssistant();
            IncludeReportManager();
            DisplayArea.Cursor = null;
        }

        private void SetUserManagerPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            ProgressBarContainer.Visibility = Visibility.Visible;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeStaffManager();
            IncludeStaffList();
            ProgressBarContainer.Visibility = Visibility.Hidden;
            DisplayArea.Cursor = null;
        }

        #endregion Set

        private void BtnSortStaffName_Click(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            try
            {
                switch (index)
                {
                    case 1:
                    case -1:
                        if (sortStaffNameCount % 2 == 0)
                        {
                            functionSortName = "asc";
                        }
                        else
                        {
                            functionSortName = "desc";
                        }
                        IncludeStaffListByName(txbSearch.Text, functionSortName);
                        sortStaffNameCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortStaffRole_Click(object sender, EventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            try
            {
                switch (index)
                {
                    case 1:
                    case -1:
                        if (sortStaffRoleCount % 2 == 0)
                        {
                            functionSortRole = "asc";
                        }
                        else
                        {
                            functionSortRole = "desc";
                        }
                        IncludeStaffListByRole(txbSearch.Text, functionSortRole);
                        sortStaffRoleCount++;
                        break;
                }
            }
            catch
            {
            }
        }
        private void IncludeStaffListByRole(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffs = StaffDAO.Instance.GetListStaffByRole(searchText, function);
                if (staffs.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Staff list is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (StaffDTO staff in staffs)
                {
                    StaffCard staffCard = new StaffCard(true);
                    staffCard.SetText(staff.ID, staff.Name, staff.DateOfBirth.ToString(), staff.Gender, staff.Mail, staff.Role);
                    staffCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(staffCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeStaffManager()
        {
            try
            {
                StaffManager staffManager = new StaffManager();
                staffManager.btnSortName.Click += BtnSortStaffName_Click;
                staffManager.btnSortRole.Click += BtnSortStaffRole_Click;
                ManagerFieldHolder.Children.Add(staffManager);
            }
            catch
            {

            }

        }

        #region Include

        #region Report

        private void IncludeReportManager()
        {
            GridAssistant.Children.Add(new ReportManager());
        }

        #endregion Report       

        #region Staff

        private void IncludeStaffList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffList = StaffDAO.Instance.GetListStaff();
                if (staffList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Staff list is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (StaffDTO item in staffList)
                {
                    StaffCard staffCard = new StaffCard(true);
                    staffCard.SetText(item.ID, item.Name, item.DateOfBirth.ToString(), item.Gender, item.Mail, item.Role);
                    staffCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(staffCard);
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
                    case 1:
                    case -1:
                        IncludeStaffList();
                        break;

                    case 2:
                        IncludeDocumentReportList();
                        break;
                    case 3:
                        SetRoomPage();
                        break;
                    case 4:
                        SetServicePage();
                        break;
                }
            }
            catch
            {

            }

        }

        private void IncludeStaffListByName(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffs = StaffDAO.Instance.GetListStaffByName(searchText, function);
                if (staffs.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (StaffDTO staff in staffs)
                {
                    StaffCard staffCard = new StaffCard(true);
                    staffCard.SetText(staff.ID, staff.Name, staff.DateOfBirth.ToString(), staff.Gender, staff.Mail, staff.Role);
                    staffCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(staffCard);
                }
            }
            catch
            {
            }
        }

        #endregion Staff

        #endregion Include

        #region Sort

        private void TableSort(object sender, RoutedEventArgs eventArgs)
        {
        }

        private void CategoryNameSort(object sender, RoutedEventArgs e)
        {
        }

        #region Account

        private void Account_UserNameSort(object sender, RoutedEventArgs e)
        {
        }

        private void Account_OwnerSort(object sender, RoutedEventArgs e)
        {
        }

        private void Account_RoleSort(object sender, RoutedEventArgs e)
        {
        }

        #endregion Account

        #endregion Sort

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

        #endregion Method

        #region Event

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
                switch (index)
                {
                    case 0:
                        SetReportPage();
                        break;

                    case 1:
                    case -1:
                        SetUserManagerPage();
                        txbSearch.Text = "";
                        break;

                    case 2:
                        SetDocumentReportPage();
                        txbSearch.Text = "";

                        break;
                    case 3:
                        SetRoomPage();
                        txbSearch.Text = "";

                        break;
                    case 4:
                        SetServicePage();
                        txbSearch.Text = "";

                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
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
            DisplayArea.Cursor = null;
        }
        private void IncludeRoomManager()
        {
            RoomManager card = new RoomManager();
            card.btnSortStatus.Click += BtnSortRoomStatus_Click;
            ManagerFieldHolder.Children.Add(card);
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
        private void IncludeRoomListByStatus(string searchRoomName, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomDTO> roomList = RoomDAO.Instance.GetRoomListByStatus(searchRoomName, function);

                foreach (RoomDTO room in roomList)
                {
                    RoomCard card = new RoomCard(room.ID, room.RoomTypeID, true);
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
                    RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeInfo(room.RoomTypeID);
                    card.setText(room.RoomName, customer.CusIDcard, room.RoomAddress, roomType.RoomType, room.RoomStatus, roomType.RoomPrice);
                    card.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void IncludeRoomList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomDTO> roomList = RoomDAO.Instance.GetRoomList();

                foreach (RoomDTO room in roomList)
                {
                    RoomCard card = new RoomCard(room.ID, room.RoomTypeID, true);
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
        private void SetServicePage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            ManagerFieldHolder.Children.Add(new ServiceManager());
            IncludeServiceList();
            SearchBoxContainer.Visibility = Visibility.Hidden;
            DisplayArea.Cursor = null;
        }
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
                    ServiceCard card = new ServiceCard(service.ID, service.RoomID, true);
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
        private void SetDocumentReportPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            ManagerFieldHolder.Children.Add(new DocumentReportManager());
            IncludeDocumentReportList();
            DisplayArea.Cursor = null;
        }

        private void IncludeDocumentReportList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ReportDTO> reportList = ReportDAO.Instance.GetListReport();
                if (reportList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Document list is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (ReportDTO report in reportList)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(report.StaffID);
                    DocumentReportCard card = new DocumentReportCard(report.StaffID, staffID, report.ID, true);
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

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txbSearch.Cursor = Cursors.Wait;
                int index = ListViewMenu.SelectedIndex;
                string functionRoom = null;
                switch (index)
                {
                    case 1:
                    case -1:
                        IncludeStaffListByName(txbSearch.Text.Replace("'", "''"), functionSortName);
                        break;

                    case 2:
                        IncludeDocumentReportListByInput(txbSearch.Text.Replace("'", "''"));
                        break;
                    case 3:
                        if (sortRoomStatusCount % 2 == 0)
                            functionRoom = "asc";
                        else
                            functionRoom = "desc";
                        IncludeRoomListByStatus(txbSearch.Text.Replace("'", "''"), functionRoom);
                        break;
                }

                txbSearch.Cursor = null;
            }
            catch (Exception ex)
            {

            }
        }

        private void IncludeDocumentReportListByInput(string input)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ReportDTO> reports = ReportDAO.Instance.GetListReportByInput(input);
                if (reports.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "No document match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (ReportDTO report in reports)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(report.StaffID);
                    DocumentReportCard reportCard = new DocumentReportCard(report.StaffID, staffID, report.ID, true);
                    reportCard.setText(staff.Name, report.Message, report.Document);
                    reportCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(reportCard);
                }
            }
            catch
            {
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = ListViewMenu.SelectedIndex;
                switch (index)
                {
                    case 1:
                    case -1:
                        ManageStaff manageStaff = new ManageStaff("Insert");
                        manageStaff.ShowDialog();
                        //manageStaff.Close();
                        break;

                    case 2:
                        ManageDocument insertDocument = new ManageDocument("Insert", staffID);
                        insertDocument.ShowDialog();
                        SetDocumentReportPage();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnSortMealQuantity_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortMealPrice_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortMealCategory_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortMealName_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortRole_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortSalary_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSortName_Click(object sender, RoutedEventArgs e)
        {
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
                ManageStaff manage = new ManageStaff("View", staff);
                manage.ShowDialog();
            }
            catch
            {

            }

        }
        private int sortRoomStatusCount;
        private void BtnConfirm_Click1(object sender, RoutedEventArgs e)
        {
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MealBtnConfirm_Click(object sender, RoutedEventArgs e)
        {
        }

        private void TableBtnConfirm_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Acc_DeleteAccount(object sender, EventArgs e)
        {
        }

        #endregion Event

        public Func<ChartPoint, string> PointLabel { get; set; }
    }
}