using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.GUI;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for FormSale.xaml
    /// </summary>
    public partial class FormSale : Window
    {
        private int staffID;
        private int listViewIndex = 0;
        private int sortRoomPriceCount = 0;
        private int sortRoomTypeCount = 0;
        private int sortServiceNameCount = 0;
        private int sortServiceTypeCount = 0;
        private int sortServicePriceCount = 0;
        private string functionSortRoomPrice = "asc";
        private string functionSortRoomType = "asc";
        private string functionSortSerName = "asc";
        private string functionSortSerPrice = "asc";

        private void BtnSortRoomPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;

                switch (listViewIndex)
                {
                    case 1:
                        if (sortRoomPriceCount % 2 == 0)
                        {
                            functionSortRoomPrice = "asc";
                        }
                        else
                        {
                            functionSortRoomPrice = "desc";
                        }
                        IncludeRoomTypeListByPrice(txbSearch.Text, functionSortRoomPrice);
                        sortRoomPriceCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortRoomType_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                functionSortRoomType = null;
                switch (listViewIndex)
                {
                    case 1:
                        if (sortRoomTypeCount % 2 == 0)
                        {
                            functionSortRoomType = "asc";
                        }
                        else
                        {
                            functionSortRoomType = "desc";
                        }
                        IncludeRoomTypeListByType(txbSearch.Text, functionSortRoomType);
                        sortRoomTypeCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortServiceName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                functionSortSerName = null;
                switch (listViewIndex)
                {
                    case 2:
                        if (sortServiceNameCount % 2 == 0)
                        {
                            functionSortSerName = "asc";
                        }
                        else
                        {
                            functionSortSerName = "desc";
                        }
                        IncludeServiceTypeListByName(txbSearch.Text, functionSortSerName);
                        sortServiceNameCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortServicePrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                functionSortSerPrice = null;
                switch (listViewIndex)
                {
                    case 2:
                        if (sortServicePriceCount % 2 == 0)
                        {
                            functionSortSerPrice = "asc";
                        }
                        else
                        {
                            functionSortSerPrice = "desc";
                        }
                        IncludeServiceTypeListByPrice(txbSearch.Text, functionSortSerPrice);
                        sortServicePriceCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortServiceType_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                string function = null;
                switch (listViewIndex)
                {
                    case 2:
                        if (sortServiceTypeCount % 2 == 0)
                        {
                            function = "asc";
                        }
                        else
                        {
                            function = "desc";
                        }
                        IncludeServiceTypeListByType(txbSearch.Text, function);
                        sortServiceTypeCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            listViewIndex = ListViewMenu.SelectedIndex;
            switch (listViewIndex)
            {
                case 0:
                case -1:
                    SetDocumentReportPage();
                    break;

                case 1:
                    SetRoomTypePage();
                    break;

                case 2:
                    SetServiceTypePage();
                    break;
            }
        }

        private void IncludeServiceTypeListByType(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServiceTypeDTO> serviceTypes = ServiceTypeDAO.Instance.GetServiceTypeListByType(searchText, function);
                foreach (ServiceTypeDTO serviceType in serviceTypes)
                {
                    ServiceTypeCard serviceTypeCard = new ServiceTypeCard();
                    serviceTypeCard.SetText(serviceType.ID, serviceType.SerName, serviceType.SerType, serviceType.SerPrice);
                    serviceTypeCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(serviceTypeCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeServiceTypeListByPrice(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServiceTypeDTO> serviceTypes = ServiceTypeDAO.Instance.GetServiceTypeListByPrice(searchText, function);
                foreach (ServiceTypeDTO serviceType in serviceTypes)
                {
                    ServiceTypeCard serviceTypeCard = new ServiceTypeCard();
                    serviceTypeCard.SetText(serviceType.ID, serviceType.SerName, serviceType.SerType, serviceType.SerPrice);
                    serviceTypeCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(serviceTypeCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeServiceTypeListByName(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServiceTypeDTO> serviceTypes = ServiceTypeDAO.Instance.GetServiceTypeListByName(searchText, function);
                foreach (ServiceTypeDTO serviceType in serviceTypes)
                {
                    ServiceTypeCard serviceTypeCard = new ServiceTypeCard();
                    serviceTypeCard.SetText(serviceType.ID, serviceType.SerName, serviceType.SerType, serviceType.SerPrice);
                    serviceTypeCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(serviceTypeCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeRoomTypeListByType(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomTypeDTO> roomTypes = RoomTypeDAO.Instance.GetRoomTypeListByType(searchText, function);
                foreach (RoomTypeDTO roomType in roomTypes)
                {
                    RoomTypeCard roomTypeCard = new RoomTypeCard();
                    int roomCount = RoomTypeDAO.Instance.GetRoomCountByRoomType(roomType.ID);
                    roomTypeCard.setText(roomType.ID, roomType.RoomType, roomCount, roomType.RoomPrice);
                    roomTypeCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(roomTypeCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeRoomTypeListByPrice(string searchText, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomTypeDTO> roomTypes = RoomTypeDAO.Instance.GetRoomTypeListByPrice(searchText, function);
                foreach (RoomTypeDTO roomType in roomTypes)
                {
                    RoomTypeCard roomTypeCard = new RoomTypeCard();
                    int roomCount = RoomTypeDAO.Instance.GetRoomCountByRoomType(roomType.ID);
                    roomTypeCard.setText(roomType.ID, roomType.RoomType, roomCount, roomType.RoomPrice);
                    roomTypeCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(roomTypeCard);
                }
            }
            catch
            {
            }
        }

        public FormSale()
        {
            InitializeComponent();
            listViewIndex = 0;
            SetDocumentReportPage();
        }

        public FormSale(int id)
        {
            InitializeComponent();
            staffID = id;
            listViewIndex = 0;
            SetDocumentReportPage();
        }

        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
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
                listViewIndex = ListViewMenu.SelectedIndex;
                MoveCursorMenu(listViewIndex);
                switch (listViewIndex)
                {
                    case 0:
                    case -1:
                        SetDocumentReportPage();
                        txbSearch.Text = "";

                        break;

                    case 1:
                        SetRoomTypePage();
                        txbSearch.Text = "";

                        break;

                    case 2:
                        SetServiceTypePage();
                        txbSearch.Text = "";

                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void SetRoomTypePage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeRoomTypeManager();
            IncludeRoomTypeList();
            DisplayArea.Cursor = null;
        }

        private void IncludeRoomTypeManager()
        {
            RoomTypeManager roomTypeManager = new RoomTypeManager();
            roomTypeManager.sortTypeButton.Click += BtnSortRoomType_Click;
            roomTypeManager.sortPriceButton.Click += BtnSortRoomPrice_Click;
            ManagerFieldHolder.Children.Add(roomTypeManager);
        }

        private void IncludeRoomTypeList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<RoomTypeDTO> roomList = RoomTypeDAO.Instance.GetRoomTypeList();
                if (roomList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Room type list is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (RoomTypeDTO roomType in roomList)
                {
                    RoomTypeCard room = new RoomTypeCard();
                    int roomCount = RoomTypeDAO.Instance.GetRoomCountByRoomType(roomType.ID);
                    room.setText(roomType.ID, roomType.RoomType, roomCount, roomType.RoomPrice);
                    room.ReloadPage += ReloadPage;
                    //report.DeleteAccount += Acc_DeleteAccount;
                    ListHolder.Children.Add(room);
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
                List<ReportDTO> reportList = ReportDAO.Instance.GetListReportByID(staffID);
                if (reportList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "You don't have any document yet";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
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

        private void SetServiceTypePage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeServiceTypeManager();

            IncludeServiceTypeList();
            DisplayArea.Cursor = null;
        }

        private void IncludeServiceTypeManager()
        {
            ServiceTypeManager serviceTypeManager = new ServiceTypeManager();
            serviceTypeManager.sortNameButton.Click += BtnSortServiceName_Click;
            serviceTypeManager.sortPriceButton.Click += BtnSortServicePrice_Click;
            serviceTypeManager.sortTypeButton.Click += BtnSortServiceType_Click;
            ManagerFieldHolder.Children.Add(serviceTypeManager);
        }

        private void IncludeServiceTypeList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServiceTypeDTO> services = ServiceTypeDAO.Instance.GetListServiceType();
                if (services.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Services type is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (ServiceTypeDTO service in services)
                {
                    ServiceTypeCard serviceCard = new ServiceTypeCard();
                    serviceCard.SetText(service.ID, service.SerName, service.SerType, service.SerPrice);
                    serviceCard.ReloadPage += ReloadPage;
                    ListHolder.Children.Add(serviceCard);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            txbSearch.Cursor = Cursors.Wait;
            switch (listViewIndex)
            {
                case 0:
                case -1:
                    IncludeDocumentReportListByInput(txbSearch.Text.Replace("'", "''"));
                    break;

                case 1:
                    IncludeRoomTypeListByInput(txbSearch.Text.Replace("'", "''"));
                    break;

                case 2:
                    IncludeServiceTypeListByInput(txbSearch.Text.Replace("'", "''"));
                    break;
            }
            txbSearch.Cursor = null;
        }

        private void IncludeServiceTypeListByInput(string input)
        {
            ListHolder.Children.Clear();
            List<ServiceTypeDTO> services = ServiceTypeDAO.Instance.GetListServiceTypeByInput(input);
            if (services.Count == 0)
            {
                TextBlock textBox = new TextBlock();
                textBox.Margin = new Thickness(20, 0, 0, 0);
                textBox.Text = "No item match your search";
                textBox.FontSize = 20;
                ListHolder.Children.Add(textBox);
                return;
            }
            foreach (ServiceTypeDTO service in services)
            {
                ServiceTypeCard serviceTypeCard = new ServiceTypeCard();
                serviceTypeCard.SetText(service.ID, service.SerName, service.SerType, service.SerPrice);
                serviceTypeCard.ReloadPage += ReloadPage;
                ListHolder.Children.Add(serviceTypeCard);
            }
        }

        private void IncludeRoomTypeListByInput(string input)
        {
            ListHolder.Children.Clear();
            List<RoomTypeDTO> roomTypes = RoomTypeDAO.Instance.GetRoomTypeListByInput(input);
            if (roomTypes.Count == 0)
            {
                TextBlock textBox = new TextBlock();
                textBox.Text = "No item match your search";
                textBox.FontSize = 20;
                ListHolder.Children.Add(textBox);
                return;
            }
            foreach (RoomTypeDTO roomType in roomTypes)
            {
                RoomTypeCard roomTypeCard = new RoomTypeCard();
                int roomCount = RoomTypeDAO.Instance.GetRoomCountByRoomType(roomType.ID);
                roomTypeCard.setText(roomType.ID, roomType.RoomType, roomCount, roomType.RoomPrice);
                roomTypeCard.ReloadPage += ReloadPage;
                ListHolder.Children.Add(roomTypeCard);
            }
        }

        private void IncludeDocumentReportListByInput(string input)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ReportDTO> reports = ReportDAO.Instance.GetListReportByStaffAndInput(staffID, input);
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
                    DocumentReportCard reportCard = new DocumentReportCard(report.StaffID, staffID, report.ID);
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

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            listViewIndex = ListViewMenu.SelectedIndex;
            switch (listViewIndex)
            {
                case 0:
                case -1:
                    ManageDocument manageDocument = new ManageDocument("Insert", staffID);
                    manageDocument.ShowDialog();
                    SetDocumentReportPage();
                    break;

                case 1:
                    ManageRoomTypes manageRoomType = new ManageRoomTypes("Insert");
                    manageRoomType.ShowDialog();
                    SetRoomTypePage();
                    break;

                case 2:
                    ManageServiceType manageServiceType = new ManageServiceType("Insert");
                    manageServiceType.ShowDialog();
                    SetServiceTypePage();
                    break;
            }
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", staff);
            manage.ShowDialog();
        }

        private void BtnConfirm_Click1(object sender, RoutedEventArgs e)
        {
        }
    }
}