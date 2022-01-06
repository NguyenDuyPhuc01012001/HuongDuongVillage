using HuongDuongVillage.DAO;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string password = Properties.Settings.Default.userPass;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                usernameContainer.Text = Properties.Settings.Default.userName;
                encryptedPasswordBox.Password = password;

                if (!string.IsNullOrWhiteSpace(password))
                {
                    ckbSaveAcc.IsChecked = true;
                    string userName = Properties.Settings.Default.userName;
                    if (Login(userName, password))
                    {
                        Authorization(userName);
                    }
                }
                else
                    ckbSaveAcc.IsChecked = false;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #region Method
        public void disableEncryptedPasswordBox()
        {
            encryptedPasswordBox.Visibility = Visibility.Collapsed;
        }

        private void disableDecryptedPasswordBox()
        {
            decryptedPasswordBox.Visibility = Visibility.Collapsed;
        }

        private void enableEncryptedPasswordBox()
        {
            encryptedPasswordBox.Visibility = Visibility.Visible;
        }

        private void enableDecryptedPasswordBox()
        {
            decryptedPasswordBox.Visibility = Visibility.Visible;
        }

        private void showDecryptPassword()
        {
            try
            {
                enableDecryptedPasswordBox();
                disableEncryptedPasswordBox();
                decryptedPasswordBox.Text = encryptedPasswordBox.Password;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void showEncryptPassword()
        {
            try
            {
                enableEncryptedPasswordBox();
                disableDecryptedPasswordBox();
                encryptedPasswordBox.Password = decryptedPasswordBox.Text;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private bool Login(string username, string password)
        { return AccountDAO.Instance.Login(username, password); }

        private string GetRole(string username)
        { return AccountDAO.Instance.GetRoleByUserName(username); }

        private int GetId(string username)
        { return AccountDAO.Instance.GetIDStaffByUserName(username); }

        private void saveAccount()
        {
            try
            {
                if ((bool)ckbSaveAcc.IsChecked)
                {
                    Properties.Settings.Default.userName = usernameContainer.Text;
                    Properties.Settings.Default.userPass = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.userPass = "";
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void Authorization(string userName)
        {
            try
            {
                string Role = GetRole(userName);
                int id = GetId(userName);
                switch (Role)
                {
                    case "CEO":
                        FormCEO formCEO = new FormCEO(id);
                        this.Hide();

                        formCEO.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "HR":
                        FormHR formHR = new FormHR(id);
                        this.Hide();

                        formHR.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Receptionist":
                        FormReceptionist formReceptionist = new FormReceptionist(id);
                        this.Hide();

                        formReceptionist.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Accountant":
                        FormAccountant formAccountant = new FormAccountant(id);
                        this.Hide();

                        formAccountant.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Sale":
                        FormSale formSale = new FormSale(id);
                        this.Hide();

                        formSale.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Chef":
                        FormChef formChef = new FormChef(id);
                        this.Hide();

                        formChef.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Cleaner":
                        FormLaundry formLaundry = new FormLaundry(id);
                        this.Hide();

                        formLaundry.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    case "Bar":
                        FormBar formBar = new FormBar(id);
                        this.Hide();

                        formBar.ShowDialog();
                        DisplayArea.Cursor = null;
                        this.Show();
                        break;

                    default:
                        CustomAlertBox.Show("Wrong username or password");
                        DisplayArea.Cursor = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private async void Login(string userName)
        {
            try
            {
                await Task.Delay(5000);
                saveAccount();
                Authorization(userName);
                pgbLoading.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Method

        #region Event

        private void showPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (togglePassStatusIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.Eye)
                {
                    togglePassStatusIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
                    showEncryptPassword();
                }
                else
                {
                    togglePassStatusIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
                    showDecryptPassword();
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pgbLoading.Visibility = Visibility.Visible;
                DisplayArea.Cursor = Cursors.Wait;
                string userName = usernameContainer.Text.Replace("'", "''");

                if (password == null)
                    return;

                if (Login(userName, password))
                {
                    Login(userName);
                }
                else
                {
                    DisplayArea.Cursor = null;
                    pgbLoading.Visibility = Visibility.Hidden;
                    CustomAlertBox.Show("Error", "Wrong username or password", CustomAlertBox.MessageBoxType.Error);
                }
            }
            catch (Exception ex)
            {
                DisplayArea.Cursor = null;
                pgbLoading.Visibility = Visibility.Hidden;
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void encryptedPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            password = encryptedPasswordBox.Password;
        }

        private void decryptedPasswordBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = decryptedPasswordBox.Text;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure to close this application.", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            DisplayArea.Cursor = Cursors.Hand;
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            DisplayArea.Cursor = null;
        }

        #endregion Event

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangePassword resetPassword = new ChangePassword("Reset");
                resetPassword.Show();
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}