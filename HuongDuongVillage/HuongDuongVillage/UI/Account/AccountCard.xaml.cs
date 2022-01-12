using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for AccountCard.xaml
    /// </summary>
    public partial class AccountCard : UserControl
    {
        private event EventHandler deleteAccount;

        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }

        private int idStaff;

        public AccountCard(int id)
        {
            InitializeComponent();
            idStaff = id;
        }

        private void resetPasswordButton_MouseEnter(object sender, MouseEventArgs e)
        {
            resetPasswordIcon.Foreground = Brushes.Green;
        }

        private void resetPasswordButton_MouseLeave(object sender, MouseEventArgs e)
        {
            resetPasswordIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string userName, string name, string Role)
        {
            try
            {
                tblUserName.Text = userName;
                tblName.Text = name;
                tblWorkingRole.Text = Role;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string staff = tblName.Text;
                if (CustomAlertBox.Show("Warning", "Delete account will also delete staff " + staff + ". Do you want to continue?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning) != MessageBoxResult.OK)
                {
                    return;
                }
                string username = tblUserName.Text;

                if (StaffDAO.Instance.DeleteStaff(idStaff))
                {
                    CustomAlertBox.Show("Delete account successful");
                    if (deleteAccount != null)
                    {
                        deleteAccount(this, new EventArgs());
                    }
                }
                else
                    CustomAlertBox.Show("Delete account fail");
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void resetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string userName = tblUserName.Text;
                string message = "Are you sure you want to reset password of username " + userName + "?";
                string title = "Reset Password";
                MessageBoxResult result = CustomAlertBox.Show(title, message, MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    if (AccountDAO.Instance.ResetPassword(userName))
                        CustomAlertBox.Show("Success", "Reset password successful\nYour password is A1234\nPlease login and change your password.", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.None);
                    else
                        CustomAlertBox.Show("Fail", "Reset password fail", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.None);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}