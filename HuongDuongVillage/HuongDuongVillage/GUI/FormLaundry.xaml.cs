using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for FormLaundry.xaml
    /// </summary>
    public partial class FormLaundry : Window
    {
        private int staffID;

        public FormLaundry()
        {
            InitializeComponent();
            LoadListClean();
        }

        public FormLaundry(int id)
        {
            InitializeComponent();
            staffID = id;
            LoadListClean();
        }

        public void LoadListClean()
        {
            try
            {
                ListHolder.Children.Clear();
                List<ServicesDTO> listClean = ServiceDAO.Instance.GetListService();
                foreach (ServicesDTO clean in listClean)
                {
                    LaundryCard laundry = new LaundryCard(clean.ID);
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(clean.RoomID);
                    string RoomName = room.RoomName;
                    ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(clean.SerTypeID);
                    laundry.SetText(clean.ID, RoomName, clean.Status);
                    if (serviceType.SerType == "cleaner")
                        ListHolder.Children.Add(laundry);
                }
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

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaffDTO staff = (sender as Button).Tag as StaffDTO;
                tblName.Text = StaffDAO.Instance.GetNameById(staff.ID);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void CbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
            //    int idBillInfo = ((sender as ComboBox).Tag as BillInfoDTO).Id;
            //    int status = (sender as ComboBox).SelectedIndex;
            //    BillInfoDAO.Instance.UpdateStatus(idBillInfo, status);
            //}
            //catch (Exception ex)
            //{
            //    CustomAlertBox.Show(ex.Message);
            //}
        }

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangePassword changePassword = new ChangePassword("Change", staffID);
                changePassword.ShowDialog();
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Reload.Cursor = Cursors.Wait;
                LoadListClean();
                Reload.Cursor = null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}