using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ManageCustomer.xaml
    /// </summary>
    public partial class ManageCustomer : Window
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }
        private string function;
        private int idCustomer;

        public ManageCustomer()
        {
            InitializeComponent();
        }

        public ManageCustomer(string _function, int id = -1)
        {
            InitializeComponent();

            try
            {
                function = _function;
                if (function != "Insert")
                {
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(id);
                    DateTime nullDate = new DateTime(1900, 1, 1);
                    idCustomer = id;
                    txbNameCustomer.Text = customer.CusName;
                    txbIDCard.Text = customer.CusIDcard;
                    txbPhone.Text = customer.CusPhone;
                    txbEmail.Text = customer.CusEmail;
                    dpkdateCheckIn.SelectedDate = (customer.DateCheckIn == nullDate) ? null : customer.DateCheckIn;

                    txbIDCard.IsReadOnly = true;
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
            try
            {
                switch (function)
                {
                    case "Edit":
                        EditCustomer(sender);
                        break;

                    case "Insert":
                        InsertCustomer(sender);
                        break;
                }
                if (reloadPage != null)
                    reloadPage(this, new EventArgs());
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion Event

        #region Method
        private void InsertCustomer(object sender)
        {
            try
            {
                string name = txbNameCustomer.Text.Replace("'", "''");
                string phone = txbPhone.Text;
                string email = txbEmail.Text.Replace("'", "''");
                string idCard = txbIDCard.Text;
                DateTime dateCheckIn = new DateTime(1900, 1, 1);

                if (dpkdateCheckIn.SelectedDate != null)
                    dateCheckIn = dpkdateCheckIn.SelectedDate.Value.Date;

                if (!ValidateInfo(name, email, dateCheckIn, phone, idCard))
                    return;
                if (CheckExist(idCard))
                    return;

                if (CustomerDAO.Instance.InsertCustomer(name, email, dateCheckIn, idCard, phone))
                {
                    CustomAlertBox.Show("Add new customer successfully!");

                    this.Close();
                }
                else
                    CustomAlertBox.Show("Add new customer failed");
            }
            catch (NullReferenceException)
            {
                CustomAlertBox.Show("Error", "Please fill out the form first", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void EditCustomer(object sender)
        {
            try
            {
                string name = txbNameCustomer.Text.Replace("'", "''");
                string phone = txbPhone.Text;
                string email = txbEmail.Text.Replace("'", "''");
                string idCard = txbIDCard.Text;
                DateTime dateCheckIn = new DateTime(1900, 1, 1);

                if (dpkdateCheckIn.SelectedDate != null)
                    dateCheckIn = dpkdateCheckIn.SelectedDate.Value.Date;

                if (!ValidateInfo(name, email, dateCheckIn, phone, idCard))
                    return;

                if (CustomerDAO.Instance.EditCustomer(idCustomer, name, email, dateCheckIn, idCard, phone))
                {
                    CustomAlertBox.Show("Edit customer successfully!");

                    this.Close();
                }
                else
                    CustomAlertBox.Show("Edit customer failed");
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Method

        #region Validate
        private bool IsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                Regex rEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!rEmail.IsMatch(emailAddress))
                {
                    CustomAlertBox.Show("Email is invalid");
                    return false;
                }
                return true;
            }
            catch (FormatException)
            {
                CustomAlertBox.Show("Email is invalid");
                return false;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        private bool ValidateDateCheckIn(DateTime dateCheckIn)
        {
            try
            {
                if (dateCheckIn > DateTime.Now)
                {
                    CustomAlertBox.Show("Date check in is invalid. You should choose date smaller than today");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        private bool ValidateInfo(string name, string email, DateTime dateCheckIn, string phone, string idCard)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    CustomAlertBox.Show("Error", "Please fill name of customer", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return false;
                }
                if (phone.Trim().Length != 10)
                {
                    CustomAlertBox.Show("Error", "Phone number muts have 10 characters", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return false;
                }
                if (idCard.Trim().Length != 9 && idCard.Trim().Length != 12)
                {
                    CustomAlertBox.Show("Error", "ID card is invalid", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return false;
                }
                if (!ValidateDateCheckIn(dateCheckIn))
                    return false;
                if (!string.IsNullOrWhiteSpace(email))
                    if (!IsValid(email))
                        return false;
                return true;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        private bool CheckExist(string IDcard)
        {
            try
            {
                if (CustomerDAO.Instance.CheckIDCardExist(IDcard) != null)
                {
                    CustomAlertBox.Show("ID card is exist");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return true;
            }
        }

        private void OnlyNumber(object sender, TextCompositionEventArgs e)
        {
            try
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        #endregion Validate
    }
}