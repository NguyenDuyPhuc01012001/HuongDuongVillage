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
    /// Interaction logic for FormHR.xaml
    /// </summary>
    public partial class FormHR : Window
    {
        public FormHR()
        {
            InitializeComponent();
        }

        public FormHR(int id)
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
        }

        private void SetGridAssistant()
        {
            DisableGridPrincipal();
            EnableGridAssistant();
        }

        private void SetDocumentReportManagerPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeDocumentReportManager();
            IncludeDocumentReportList();
            AddButton.ToolTip = "Add new report";
            DisplayArea.Cursor = null;
        }

        private void SetStaffManagerPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeStaffManagerTable();
            IncludeStaffList();
            DisplayArea.Cursor = null;
            sortNameClickCount = 0;
            sortRoleClickCount = 0;
            AddButton.ToolTip = "Add new staff";
            txbSearch.ToolTip = "Search by name or email";
        }

        private void SetAccountManagerPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeAccountManager();
            IncludeAccountList();
            DisplayArea.Cursor = null;
            sortNameClickCount = 0;
            sortRoleClickCount = 0;
            txbSearch.ToolTip = "Search by name";
        }

        #endregion Set

        #region Include

        #region Staff

        private void IncludeStaffManagerTable()
        {
            try
            {
                StaffManager staffManager = new StaffManager();
                ManagerFieldHolder.Children.Add(staffManager);
                sortNameClickCount = 0;
                sortRoleClickCount = 0;
                staffManager.btnSortName.Click += BtnSortName_Click;
                staffManager.btnSortRole.Click += BtnSortRole_Click;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeStaffList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffList = StaffDAO.Instance.GetListStaff();
                foreach (StaffDTO staff in staffList)
                {
                    StaffCard card = new StaffCard();
                    card.SetText(staff.ID, staff.Name, staff.DateOfBirth.ToString(), staff.Gender, staff.Mail, staff.Role);
                    card.ReloadPage += ReloadPage;

                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeStaffListByName(string name, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffList = StaffDAO.Instance.GetListStaffByName(name, function);
                if (staffList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (StaffDTO staff in staffList)
                {
                    StaffCard card = new StaffCard();
                    card.SetText(staff.ID, staff.Name, staff.DateOfBirth.ToString(), staff.Gender, staff.Mail, staff.Role);
                    card.ReloadPage += ReloadPage;

                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeStaffListByRole(string name, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<StaffDTO> staffList = StaffDAO.Instance.GetListStaffByRole(name, function);
                if (staffList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (StaffDTO staff in staffList)
                {
                    StaffCard card = new StaffCard();
                    card.SetText(staff.ID, staff.Name, staff.DateOfBirth.ToString(), staff.Gender, staff.Mail, staff.Role);
                    card.ReloadPage += ReloadPage;

                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Staff

        #region Account

        private void IncludeAccountManager()
        {
            try
            {
                AccountManager accountManager = new AccountManager();
                ManagerFieldHolder.Children.Add(accountManager);
                sortNameClickCount = 0;
                sortRoleClickCount = 0;
                accountManager.btnSortName.Click += BtnSortName_Click;
                accountManager.btnSortRole.Click += BtnSortRole_Click;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeAccountList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<AccountDTO> accountList = AccountDAO.Instance.GetListAccount();

                foreach (AccountDTO acc in accountList)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(acc.StaffID);
                    AccountCard card = new AccountCard(acc.StaffID);

                    card.SetText(acc.UserName, staff.Name, staff.Role);
                    card.DeleteAccount += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeAccountListByName(string name, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<AccountDTO> accountList = AccountDAO.Instance.GetAccountListByName(name, function);
                if (accountList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (AccountDTO acc in accountList)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(acc.StaffID);
                    AccountCard card = new AccountCard(acc.StaffID);
                    card.SetText(acc.UserName, staff.Name, staff.Role);
                    card.DeleteAccount += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludeAccountListByRole(string name, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<AccountDTO> accountList = AccountDAO.Instance.GetAccountListByRole(name, function);
                if (accountList.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Margin = new Thickness(20, 0, 0, 0);
                    textBox.Text = "No item match your search";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (AccountDTO acc in accountList)
                {
                    StaffDTO staff = StaffDAO.Instance.GetStaffById(acc.StaffID);
                    AccountCard card = new AccountCard(acc.StaffID);
                    card.SetText(acc.UserName, staff.Name, staff.Role);
                    card.DeleteAccount += ReloadPage;
                    ListHolder.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Account

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

        //private void IncludeDocumentReportListByName(string text)
        //{
        //    ListHolder.Children.Clear();
        //    List<ReportDTO> reportList = ReportDAO.Instance.GetListReport();

        //    foreach (ReportDTO item in reportList)
        //    {
        //        StaffDTO staff = StaffDAO.Instance.GetStaffById(item.StaffID);
        //        DocumentReportCard report = new DocumentReportCard();
        //        report.setText(staff.Name, item.Message, item.Document);
        //        report.editButton.Tag = item;
        //        report.deleteButton.Tag = item;

        //        report.editButton.Click += EditButton_Click;
        //        report.deleteButton.Click += DeleteButton_Click;
        //        ListHolder.Children.Add(report);
        //    }
        //}

        #endregion DocumentReport

        #endregion Include

        #endregion Method

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
                SearchBoxContainer.Visibility = Visibility.Visible;
                AddButton.Visibility = Visibility.Visible;
                switch (index)
                {
                    case 0:
                        SearchBoxContainer.Visibility = Visibility.Hidden;
                        SetDocumentReportManagerPage();
                        break;

                    case 1:
                        SetStaffManagerPage();
                        break;

                    case 2:
                        AddButton.Visibility = Visibility.Hidden;
                        SetAccountManagerPage();
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
                    //case 0:
                    //    IncludeDocumentReportListByName(txbSearch.Text);
                    //    txbSearch.Cursor = null;
                    //    break;
                    case 1:
                        if (sortNameClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeStaffListByName(txbSearch.Text.Replace("'", "''"), function);
                        break;

                    case 2:
                        if (sortNameClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeAccountListByName(txbSearch.Text.Replace("'", "''"), function);
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
                        //SetDocumentReportManagerPage();
                        break;

                    case 1:
                        ManageStaff insertStaff = new ManageStaff("Insert");
                        insertStaff.ShowDialog();
                        SetStaffManagerPage();
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
                        SetDocumentReportManagerPage();
                        break;

                    case 1:
                        SetStaffManagerPage();
                        break;

                    case 2:
                        SetAccountManagerPage();
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
            StaffDTO HR = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", HR);
            manage.ShowDialog();
        }

        private void BtnSortRole_Click(object sender, RoutedEventArgs e)
        {
            //sortRoleClickCount % 2 == 0 : sort ascending
            //sortRoleClickCount % 2 != 0 : sort descending
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                int index = ListViewMenu.SelectedIndex;
                string function = null;
                switch (index)
                {
                    case 1:
                        if (sortRoleClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeStaffListByRole(txbSearch.Text.Replace("'", "''"), function);
                        sortRoleClickCount++;
                        break;

                    case 2:
                        if (sortRoleClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeAccountListByRole(txbSearch.Text.Replace("'", "''"), function);
                        sortRoleClickCount++;
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

        private void BtnSortName_Click(object sender, RoutedEventArgs e)
        {
            //sortNameClickCount % 2 == 0 : sort ascending
            //sortNameClickCount % 2 != 0 : sort descending
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                string function = null;
                int index = ListViewMenu.SelectedIndex;
                switch (index)
                {
                    case 1:
                        if (sortNameClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeStaffListByName(txbSearch.Text.Replace("'", "''"), function);
                        sortNameClickCount++;
                        break;

                    case 2:
                        if (sortNameClickCount % 2 == 0)
                            function = "asc";
                        else
                            function = "desc";
                        IncludeAccountListByName(txbSearch.Text.Replace("'", "''"), function);
                        sortNameClickCount++;
                        break;
                }
                DisplayArea.Cursor = null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Event

        #region Field

        public Func<ChartPoint, string> PointLabel { get; set; }

        private int sortNameClickCount;
        private int sortRoleClickCount;
        private int staffID;

        #endregion Field
    }
}