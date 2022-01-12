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
    /// Interaction logic for FormAccountant.xaml
    /// </summary>
    public partial class FormAccountant : Window
    {
        private int staffID;
        private int listViewIndex;
        private string function = "asc";
        private string functionPaymentDate = "asc";
        private int sortAmountPaymentCount = 0;
        private int sortDatePaymentCount = 0;

        public FormAccountant()
        {
            InitializeComponent();
            listViewIndex = 1;
            SetDocumentReportPage();
        }

        public FormAccountant(int id)
        {
            InitializeComponent();
            tblName.Text = StaffDAO.Instance.GetNameById(id);
            staffID = id;
            listViewIndex = 1;
            SetDocumentReportPage();
        }

        private void BtnSortAmount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                switch (listViewIndex)
                {
                    case 2:
                        if (sortAmountPaymentCount % 2 == 0)
                        {
                            function = "asc";
                        }
                        else
                        {
                            function = "desc";
                        }
                        IncludePaymentListByAmount(txbSearch.Text, function);
                        sortAmountPaymentCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void BtnSortPaymentDate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listViewIndex = ListViewMenu.SelectedIndex;
                switch (listViewIndex)
                {
                    case 2:
                        if (sortDatePaymentCount % 2 == 0)
                        {
                            functionPaymentDate = "asc";
                        }
                        else
                        {
                            functionPaymentDate = "desc";
                        }
                        IncludePaymentListByDate(txbSearch.Text, functionPaymentDate);
                        sortDatePaymentCount++;
                        break;
                }
            }
            catch
            {
            }
        }

        private void IncludePaymentListByAmount(string text, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<PaymentDTO> payments = PaymentDAO.Instance.GetPaymentsByAmount(text, function);

                foreach (PaymentDTO payment in payments)
                {
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(payment.CusID);
                    PaymentCard paymentCard = new PaymentCard();
                    paymentCard.SetText(payment.ID, customer.CusName, payment.Amount, payment.PaymentDate, payment.Method);
                    ListHolder.Children.Add(paymentCard);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IncludePaymentListByDate(string text, string function)
        {
            try
            {
                ListHolder.Children.Clear();
                List<PaymentDTO> payments = PaymentDAO.Instance.GetPaymentsByDate(text, function);

                foreach (PaymentDTO payment in payments)
                {
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(payment.CusID);
                    PaymentCard paymentCard = new PaymentCard();
                    paymentCard.SetText(payment.ID, customer.CusName, payment.Amount, payment.PaymentDate, payment.Method);
                    ListHolder.Children.Add(paymentCard);
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
                switch (listViewIndex)
                {
                    case 1:
                    case -1:
                        SetDocumentReportPage();
                        break;

                    case 2:
                        SetPaymentPage();
                        break;
                }
            }
            catch
            {
            }
        }

        private void ResetReportManager()
        {
            GridAssistant.Children.Clear();
        }

        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
        }

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

        private void SetReportPage()
        {
            DisplayArea.Cursor = Cursors.Wait;
            SetGridAssistantToDefault();
            SetGridAssistant();
            IncludeReportManager();
            DisplayArea.Cursor = null;
        }

        private void IncludeReportManager()
        {
            GridAssistant.Children.Add(new ReportManager());
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
                        SetReportPage();
                        break;

                    case 1:
                        SetDocumentReportPage();
                        txbSearch.Text = "";

                        break;

                    case 2:
                        SetPaymentPage();
                        txbSearch.Text = "";

                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void SetPaymentPage()
        {
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                SetGridPrincipalToDefault();
                SetGridPrincipal();
                AddButton.Visibility = Visibility.Hidden;
                IncludePaymentManager();
                IncludePaymentList();
                DisplayArea.Cursor = null;
            }
            catch
            {

            }
        }

        private void IncludePaymentManager()
        {
            try
            {
                PaymentManager paymentManager = new PaymentManager();
                paymentManager.btnSortAmount.Click += BtnSortAmount_Click;
                paymentManager.btnSortPaymentDate.Click += BtnSortPaymentDate_Click;
                ManagerFieldHolder.Children.Add(paymentManager);
            }
            catch
            {

            }
        }

        private void IncludePaymentList()
        {
            try
            {
                ListHolder.Children.Clear();
                List<PaymentDTO> payments = PaymentDAO.Instance.GetPayments();
                if (payments.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "Payment list is empty";
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (PaymentDTO payment in payments)
                {
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(payment.CusID);
                    PaymentCard paymentCard = new PaymentCard();
                    paymentCard.SetText(payment.ID, customer.CusName, payment.Amount, payment.PaymentDate, payment.Method);
                    ListHolder.Children.Add(paymentCard);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void SetDocumentReportPage()
        {
            try
            {
                DisplayArea.Cursor = Cursors.Wait;
                SetGridPrincipalToDefault();
                SetGridPrincipal();
                AddButton.Visibility = Visibility.Visible;
                ManagerFieldHolder.Children.Add(new DocumentReportManager());
                AddButton.Visibility = Visibility.Visible;
                IncludeDocumentReportList();

                DisplayArea.Cursor = null;
            }
            catch
            {

            }
        }

        public void IncludeDocumentReportList()
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

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                txbSearch.Cursor = Cursors.Wait;
                switch (listViewIndex)
                {
                    case 1:
                    case -1:
                        IncludeDocumentReportListByStaffIDAndInput(staffID, txbSearch.Text);
                        break;

                    case 2:
                        IncludePaymentListByInput(txbSearch.Text);
                        break;
                }

                txbSearch.Cursor = null;
            }
            catch
            {

            }
        }

        private void IncludePaymentListByInput(string input)
        {
            try
            {
                ListHolder.Children.Clear();
                List<PaymentDTO> payments = PaymentDAO.Instance.GetPaymentsByInput(input);
                if (payments.Count == 0)
                {
                    TextBlock textBox = new TextBlock();
                    textBox.Text = "No payments match your search";
                    textBox.Margin = new Thickness(5, 0, 0, 0);
                    textBox.FontSize = 20;
                    ListHolder.Children.Add(textBox);
                    return;
                }
                foreach (PaymentDTO payment in payments)
                {
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(payment.CusID);
                    PaymentCard paymentCard = new PaymentCard();
                    paymentCard.SetText(payment.ID, customer.CusName, payment.Amount, payment.PaymentDate, payment.Method);
                    ListHolder.Children.Add(paymentCard);
                }
            }
            catch
            {
            }
        }

        private void IncludeDocumentReportListByStaffIDAndInput(int staffID, string input)
        {
            try
            {
                ListHolder.Children.Clear();
                List<ReportDTO> reportList = ReportDAO.Instance.GetListReportByStaffAndInput(staffID, input);

                if (reportList.Count == 0)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = "No document match your seach";
                    textBlock.FontSize = 20;
                    ListHolder.Children.Add(textBlock);
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
                switch (listViewIndex)
                {
                    case 1:
                    case -1:
                        ManageDocument manageDocument = new ManageDocument("Insert", staffID);
                        manageDocument.ShowDialog();
                        SetDocumentReportPage();
                        break;
                }
            }
            catch
            {

            }
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

        private void BtnConfirm_Click1(object sender, RoutedEventArgs e)
        {
        }

        public Func<ChartPoint, string> PointLabel { get; set; }
    }
}