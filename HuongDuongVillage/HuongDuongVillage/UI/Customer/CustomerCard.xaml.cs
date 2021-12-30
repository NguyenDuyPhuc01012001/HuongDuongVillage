using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for MealStatusCard.xaml
    /// </summary>
    public partial class CustomerCard : UserControl
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        private int idCus;

        public CustomerCard(int id)
        {
            InitializeComponent();
            this.idCus = id;
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void setText(string cusName, string cusIDCard, string cusPhone, string cusEmail, string dateCheckIn)
        {
            tblName.Text = cusName;
            tblCusIDCard.Text = cusIDCard;
            tblCusPhone.Text = cusPhone;
            tblCusEmail.Text = cusEmail;
            tblDateCheckIn.Text = (dateCheckIn == null) ? null : dateCheckIn.Split(" ")[0];
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomer editCustomer = new ManageCustomer("Edit", idCus);
            editCustomer.ReloadPage += reloadPage;
            editCustomer.ShowDialog();
            //if (reloadPage != null)
            //    reloadPage(this, new EventArgs());
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (CustomerDAO.Instance.IsUsingService(idCus))
                {
                    MessageBox.Show("Delete failed because this customer is using our service.");
                    return;
                }
                if (CustomerDAO.Instance.DeleteCustomer(idCus))
                {
                    MessageBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    MessageBox.Show("Delete failed");
            }
        }
    }
}