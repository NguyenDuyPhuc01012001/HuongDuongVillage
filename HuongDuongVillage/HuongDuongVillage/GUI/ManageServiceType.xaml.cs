using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for AddNewMeal.xaml
    /// </summary>
    public partial class ManageServiceType : Window
    {
        private string function = null;
        private int serviceID;
        private string serviceType;

        public ManageServiceType()
        {
            InitializeComponent();
        }

        public ManageServiceType(ServiceTypeDTO serviceType, string function)
        {
            InitializeComponent();
            this.function = function;
            if (this.function == "Edit")
            {
                txbSerName.Text = serviceType.SerName;
                this.serviceType = serviceType.SerType;
                switch (this.serviceType)
                {
                    case "food":
                        cmbCategory.SelectedIndex = 0;
                        break;

                    case "bar":
                        cmbCategory.SelectedIndex = 1;
                        break;

                    case "cleaner":
                        cmbCategory.SelectedIndex = 2;
                        break;
                }
                txbSerPrice.Text = serviceType.SerPrice.ToString();
                this.serviceID = serviceType.ID;
                btnConfirm.Content = "Update";
            }
        }

        public ManageServiceType(string function)
        {
            InitializeComponent();
            this.function = function;
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.serviceType = cmbCategory.SelectedValue.ToString();
        }

        private void Search_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool ValidatePrice(string price)
        {
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] >= 'a' && price[i] <= 'z' || price[i] >= 'A' && price[i] <= 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        private void EditService()
        {
            try
            {
                string serName = txbSerName.Text.Replace("'", "''");
                string serPrice = txbSerPrice.Text.Replace("'", "''");
                if (!ValidatePrice(serPrice))
                {
                    CustomAlertBox.Show("Error", "Price must not contains alphabet character", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (ServiceTypeDAO.Instance.EditServiceType(serviceID, serName, this.serviceType, float.Parse(serPrice)))
                {
                    CustomAlertBox.Show("Edit service type successfully!");
                    this.Close();
                }
                else
                {
                    CustomAlertBox.Show("Edit service type failed");
                }
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

        private void InsertService()
        {
            try
            {
                string serName = txbSerName.Text.Replace("'", "''");
                string serPrice = txbSerPrice.Text.Replace("'", "''");
                string serCategory = cmbCategory.Text.Replace("'", "''");
                if (!ValidatePrice(serPrice))
                {
                    CustomAlertBox.Show("Error", "Price must not contains alphabet character", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (ServiceTypeDAO.Instance.GetServiceWithNameAndType(serName, serviceType).Count > 0)
                {
                    CustomAlertBox.Show("Error", "This Service type is already existed", MessageBoxButton.OK, CustomAlertBox.MessageBoxImage.Error);
                    return;
                }
                else if (ServiceTypeDAO.Instance.InsertServiceType(serName, serCategory, float.Parse(serPrice)))
                {
                    CustomAlertBox.Show("Add new service type successfully!");
                    this.Close();
                }
                else
                {
                    CustomAlertBox.Show("Add new service type failed");
                }
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

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            switch (this.function)
            {
                case "Insert":
                    InsertService();
                    break;

                case "Edit":
                    EditService();
                    break;
            }
        }
    }
}