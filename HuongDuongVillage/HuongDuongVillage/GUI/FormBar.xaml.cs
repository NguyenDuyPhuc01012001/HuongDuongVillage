using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.UI.Bar;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for FormBar.xaml
    /// </summary>
    public partial class FormBar : Window
    {
        private int staffID;

        public FormBar()
        {
            InitializeComponent();
            LoadListBar();
        }

        public FormBar(int id)
        {
            staffID = id;
            InitializeComponent();
            LoadListBar();
        }

        public void LoadListBar()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServicesDTO> listbar = ServiceDAO.Instance.GetListService();
                foreach (ServicesDTO bar in listbar)
                {
                    BarCard entertain = new BarCard();
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(bar.RoomID);
                    ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(bar.SerTypeID);
                    CustomerDTO cusname = CustomerDAO.Instance.GetCustomerById(room.CusID);
                    entertain.SetText(bar.ID, room.RoomName, serviceType.SerName, cusname.CusName);
                    if (serviceType.SerType == "bar")
                        ListHolder.Children.Add(entertain);
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
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
            catch(Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangePassword changePassword = new ChangePassword("Change", staffID);
                changePassword.ShowDialog();
            }
            catch(Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Reload.Cursor = Cursors.Wait;
                LoadListBar();
                Reload.Cursor = null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}