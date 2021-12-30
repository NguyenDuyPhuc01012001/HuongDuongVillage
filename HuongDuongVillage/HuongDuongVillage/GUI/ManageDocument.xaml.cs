using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Windows;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ManageDocument.xaml
    /// </summary>
    public partial class ManageDocument : Window
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }
        private string function;
        private int idStaff;
        private int idReport;

        public ManageDocument()
        {
            InitializeComponent();
        }

        public ManageDocument(string _function, int _idStaff, int id = -1)
        {
            InitializeComponent();

            try
            {
                function = _function;
                idStaff = _idStaff;
                if (function != "Insert")
                {
                    ReportDTO report = ReportDAO.Instance.GetReportById(id);
                    idReport = id;
                    txbDocument.Text = report.Document;
                    txbMessage.Text = report.Message;
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
            switch (function)
            {
                case "Edit":
                    EditOrViewDocument(sender);
                    break;

                case "Insert":
                    InsertDocument(sender);
                    break;
            }
            if (reloadPage != null)
                reloadPage(this, new EventArgs());
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion Event

        #region Method

        private void InsertDocument(object sender)
        {
            try
            {
                string message = txbMessage.Text;
                string document = txbDocument.Text;

                if (string.IsNullOrWhiteSpace(message) || string.IsNullOrWhiteSpace(document))
                {
                    CustomAlertBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }

                if (ReportDAO.Instance.InsertDocument(idStaff, message, document))
                {
                    CustomAlertBox.Show("Add new report successfully!");
                    this.Close();
                }
                else
                    MessageBox.Show("Add new report failed!");
            }
            catch (NullReferenceException)
            {
                CustomAlertBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void EditOrViewDocument(object sender)
        {
            try
            {
                string message = txbMessage.Text;
                string document = txbDocument.Text;

                if (string.IsNullOrWhiteSpace(message) || string.IsNullOrEmpty(document))
                {
                    CustomAlertBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                if (ReportDAO.Instance.EditDocument(idReport, message, document))
                {
                    CustomAlertBox.Show("Edit report successfully!");
                    this.Close();
                }
                else
                    CustomAlertBox.Show("Edit report failed!");
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Method
    }
}