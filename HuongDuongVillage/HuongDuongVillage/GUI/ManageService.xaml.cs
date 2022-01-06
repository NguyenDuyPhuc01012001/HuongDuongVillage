using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ManageService.xaml
    /// </summary>
    public partial class ManageService : Window
    {
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }
        private string function;
        private int idService;
        private int idRoom;

        public ManageService()
        {
            InitializeComponent();
        }

        public ManageService(string _function, int id = -1, int _idRoom = -1)
        {
            InitializeComponent();

            try
            {
                this.idRoom = idRoom;
                function = _function;
                List<String> serviceTypes = ServiceTypeDAO.Instance.GetSetServiceType();
                foreach (String serviceType in serviceTypes)
                {
                    cmbType.Items.Add(serviceType);
                }
                if (serviceTypes.Count > 0)
                    cmbType.SelectedIndex = 0;

                List<RoomDTO> rooms = RoomDAO.Instance.GetRoomListUnavailable();
                foreach (RoomDTO room in rooms)
                    cmbNameRoom.Items.Add(room);
                if (rooms.Count > 0)
                    cmbNameRoom.SelectedIndex = 0;

                if (function == "Edit")
                {
                    idService = id;
                    idRoom = _idRoom;

                    txbNameRoom.Visibility = Visibility.Visible;
                    cmbNameRoom.Visibility = Visibility.Hidden;
                    btnConfirm.Content = "Update";

                    ServicesDTO service = ServiceDAO.Instance.GetServiceByID(id);
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(service.RoomID);
                    ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(service.SerTypeID);
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);

                    txbNameRoom.Text = room.RoomName;
                    txbStatus.Text = (service.Status) ? "Done" : "Not done";
                    txbNameCus.Text = customer.CusName;
                    txbIDCard.Text = customer.CusIDcard;
                    cmbType.SelectedItem = serviceType.SerType;
                    cmbSerName.Text = serviceType.SerName;
                    iudQuantity.Value = service.Quantity;
                    txbPrice.Text = (iudQuantity.Value * serviceType.SerPrice).ToString();
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
                        EditService();
                        break;

                    case "Insert":
                        InsertService();
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

        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbType.Items.Count > 0)
                {
                    List<ServiceTypeDTO> listSerType = ServiceTypeDAO.Instance.GetServiceTypeListByType(cmbType.SelectedItem.ToString());
                    cmbSerName.Items.Clear();
                    if (listSerType.Count > 0)
                        foreach (ServiceTypeDTO serviceType in listSerType)
                            cmbSerName.Items.Add(serviceType);
                    if (cmbSerName.Items.Count > 0)
                        cmbSerName.SelectedIndex = 0;
                    if (cmbType.SelectedItem.Equals("bar"))
                        txbStatus.Text = "Done";
                    else
                        txbStatus.Text = "Not done";
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message);
            }
        }

        private void cmbSerName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ServiceTypeDTO serviceType = (ServiceTypeDTO)cmbSerName.SelectedItem;
                if (serviceType != null)
                    txbPrice.Text = (iudQuantity.Value * serviceType.SerPrice).ToString();
                if (cmbType.SelectedItem.Equals("bar"))
                    txbStatus.Text = "Done";
                else
                    txbStatus.Text = "Not done";
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message);
            }
        }

        private void cmbNameRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (cmbNameRoom.Items.Count > 0)
                {
                    RoomDTO room = (RoomDTO)cmbNameRoom.SelectedItem;
                    CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
                    txbNameCus.Text = customer.CusName;
                    txbIDCard.Text = customer.CusIDcard;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void IntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                if (cmbSerName.Items.Count > 0)
                {
                    ServiceTypeDTO serviceType = (ServiceTypeDTO)cmbSerName.SelectedItem;
                    txbPrice.Text = (iudQuantity.Value * serviceType.SerPrice).ToString();
                }
                if (cmbType.Items.Count > 0)
                {
                    if (cmbType.SelectedItem.Equals("bar"))
                        txbStatus.Text = "Done";
                    else
                        txbStatus.Text = "Not done";
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message);
            }
        }

        #endregion Event

        #region Method

        private void InsertService()
        {
            try
            {
                int idRoom = int.Parse(cmbNameRoom.SelectedValue.ToString());
                int idServiceType = int.Parse(cmbSerName.SelectedValue.ToString());
                if (!IsValid(iudQuantity.Value))
                    return;
                int quantity = int.Parse(iudQuantity.Value.ToString());
                int status = (txbStatus.Text == "Done") ? 1 : 0;
                if (ServiceDAO.Instance.InsertService(idRoom, idServiceType, quantity, status))
                {
                    CustomAlertBox.Show("Add new Service successfully!");

                    this.Close();
                }
                else
                    CustomAlertBox.Show("Add new Service failed");
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

        private void EditService()
        {
            try
            {
                int idServiceType = int.Parse(cmbSerName.SelectedValue.ToString());
                if (!IsValid(iudQuantity.Value))
                    return;
                int quantity = int.Parse(iudQuantity.Value.ToString());
                int status = (txbStatus.Text == "Done") ? 1 : 0;
                if (ServiceDAO.Instance.EditService(idService, idRoom, idServiceType, quantity, status))
                {
                    CustomAlertBox.Show("Edit Service successfully!");

                    this.Close();
                }
                else
                    CustomAlertBox.Show("Edit Service failed");
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

        #endregion Method

        #region Validate

        private bool IsValid(int? number)
        {
            try
            {
                if (number == null)
                {
                    CustomAlertBox.Show("Please fill all fields");
                    return false;
                }
                if (number < 1)
                {
                    CustomAlertBox.Show("Invalid quantity");
                    return false;
                }
                if (number > 100)
                {
                    CustomAlertBox.Show("Quantity must smaller than 100");
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
        #endregion Validate
    }
}