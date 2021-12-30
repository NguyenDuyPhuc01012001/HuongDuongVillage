using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Net.Mail;
using System.Windows;
using static HuongDuongVillage.CustomAlertBox;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ManageStaff.xaml
    /// </summary>
    public partial class ManageStaff : Window
    {
        #region Field

        private string function;
        private int idStaff;
        private string name;
        private string email;
        private DateTime birthdate;
        private int sex = 1;
        private string role;

        #endregion Field

        public ManageStaff()
        {
            InitializeComponent();
        }

        public ManageStaff(string function, StaffDTO staff = null)
        {
            InitializeComponent();
            try
            {
                this.function = function;
                if (function != "Insert")
                {
                    AccountDTO account = AccountDAO.Instance.GetAccountByIdUser(staff.ID);
                    txbUserName.Text = account.UserName;
                    this.btnConfirm.Content = "Update";
                    idStaff = staff.ID;
                    txbName.Text = staff.Name;
                    txbEmail.Text = staff.Mail;
                    dpkDOB.Text = staff.DateOfBirth.ToString();
                    if (staff.Gender == true)
                        rdoMale.IsChecked = true;
                    else
                        rdoFemale.IsChecked = true;
                    cmbRole.Text = staff.Role;

                    txbUserName.IsEnabled = false;
                    if (function == "View")
                        cmbRole.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.ToString());
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
                        EditOrViewStaff();
                        break;

                    case "Insert":
                        InsertStaff();
                        break;

                    case "View":
                        EditOrViewStaff();
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.ToString(), MessageBoxType.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion Event

        #region Method

        private void InsertStaff()
        {
            try
            {
                string name = txbName.Text.Replace("'", "''");
                string UserName = txbUserName.Text.Replace("'", "''");
                string email = txbEmail.Text.Replace("'", "''");
                DateTime DOB = DateTime.Now;
                string position = null;
                int sex = Convert.ToInt32(rdoMale.IsChecked.Value);

                if (dpkDOB.SelectedDate != null)
                    DOB = dpkDOB.SelectedDate.Value.Date;
                if (cmbRole.SelectedValue != null)
                    position = cmbRole.SelectedValue.ToString();

                if (!ValidateInfo(name, email, DOB, sex, position, UserName))
                    return;
                if (CheckExist(email, UserName))
                    return;

                if (StaffDAO.Instance.InsertStaff(name, email, DOB, sex, position))
                {
                    if (AccountDAO.Instance.InsertAccount(UserName))
                    {
                        CustomAlertBox.Show("Add new staff successfully!\nYour password is A1234\nPlease login and change your password.");

                        this.Close();
                    }
                    else
                        CustomAlertBox.Show("Add new staff failed");
                }
                else
                    CustomAlertBox.Show("Add new staff failed");
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

        private void EditOrViewStaff()
        {
            try
            {
                string name = txbName.Text.Replace("'", "''");
                string UserName = txbUserName.Text.Replace("'", "''");
                string email = txbEmail.Text.Replace("'", "''");
                DateTime DOB = DateTime.Now;
                string position = null;
                int sex = Convert.ToInt32(rdoMale.IsChecked.Value);

                if (dpkDOB.SelectedDate != null)
                    DOB = dpkDOB.SelectedDate.Value.Date;
                if (cmbRole.SelectedValue != null)
                    position = cmbRole.SelectedValue.ToString();

                if (!ValidateInfo(name, email, DOB, sex, position, UserName))
                    return;

                if (StaffDAO.Instance.EditStaff(idStaff, name, email, DOB, sex, position))
                {
                    CustomAlertBox.Show("Edit staff successfully");
                    this.Close();
                }
                else
                    CustomAlertBox.Show("Edit new staff failed");
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message, MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
            }
        }

        #endregion Method

        #region Validate

        private bool IsValid(string emailAddress, string UserName)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                if (UserName.Length != UserName.Trim().Length)
                {
                    MessageBox.Show("Password is invalid.\nPassword shouldn't have any space.");
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

        private bool ValidateDOB(DateTime DOB)
        {
            try
            {
                if (DOB >= DateTime.Now)
                {
                    MessageBox.Show("Date of Birth is invalid. You should choose date smaller than today");
                    return false;
                }
                DateTime zeroTime = new DateTime(1, 1, 1);

                TimeSpan span = DateTime.Now - DOB;
                // Because we start at year 1 for the Gregorian calendar, we must subtract a year here.
                int years = (zeroTime + span).Year - 1;

                if (years < 18)
                {
                    CustomAlertBox.Show("Date of Birth is invalid.\nYou must be over 18 years old!");
                    return false;
                }
                if (years > 65)
                {
                    CustomAlertBox.Show("Date of Birth is invalid.\nYou mustn't be over 65 years old!");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message, MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                return false;
            }
        }

        private bool ValidateInfo(string name, string email, DateTime DOB, int sex, string position, string userName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email))
                {
                    CustomAlertBox.Show("Error", "Please fill out the form first", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return false;
                }
                if (DOB == DateTime.Now || position == null)
                {
                    CustomAlertBox.Show("Error", "Please fill out the form first", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return false;
                }
                if (!ValidateDOB(DOB))
                    return false;
                if (!IsValid(email, userName))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message, "Error", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                return false;
            }
        }

        private bool CheckExist(string email, string userName)
        {
            try
            {
                if (StaffDAO.Instance.CheckEmailExist(email) != -1)
                {
                    CustomAlertBox.Show("Email is exist");
                    return true;
                }
                if (AccountDAO.Instance.CheckUsernamelExist(userName) != -1)
                {
                    CustomAlertBox.Show("Username is exist");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message, "Error", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                return true;
            }
        }

        #endregion Validate
    }
}