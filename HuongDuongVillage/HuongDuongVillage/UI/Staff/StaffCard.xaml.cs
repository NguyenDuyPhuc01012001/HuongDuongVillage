using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class StaffCard : UserControl
    {
        private event EventHandler reloadPage;
        private bool isCEOAccessing;
        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public StaffCard()
        {
            InitializeComponent();
        }
        public StaffCard(bool isCEOAccessing = false)
        {
            InitializeComponent();
            this.isCEOAccessing = isCEOAccessing;
        }
        private void editButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void editButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(int id, string name, string DOB, bool isMale, string mail, string role)
        {
            try
            {
                tblID.Text = id.ToString();
                tblName.Text = name;
                tblDOB.Text = DOB.Split(" ")[0];
                if (isMale)
                    tblGender.Text = "Male";
                else
                    tblGender.Text = "Female";
                tblMail.Text = mail;
                tblRole.Text = role;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            StaffDTO staff = new StaffDTO();
            staff.ID = int.Parse(tblID.Text);
            staff.Name = tblName.Text;
            staff.Mail = tblMail.Text;
            staff.DateOfBirth = Convert.ToDateTime(tblDOB.Text);
            if (tblGender.Text == "Male")
                staff.Gender = true;
            else
                staff.Gender = false;
            staff.Role = tblRole.Text;

            ManageStaff editStaff = new ManageStaff("Edit", staff);
            editStaff.ShowDialog();
            if (reloadPage != null)
                reloadPage(this, new EventArgs());
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            int idStaff = int.Parse(tblID.Text);

            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this Account? It will also delete staff.", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (StaffDAO.Instance.DeleteStaff(idStaff))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }
    }
}