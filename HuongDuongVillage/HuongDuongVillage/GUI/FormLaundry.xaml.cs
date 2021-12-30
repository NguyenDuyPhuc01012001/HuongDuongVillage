using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            LoadListClean();
            tblName.Text = StaffDAO.Instance.GetNameById(id);
            //InfoButton.Tag = StaffDAO.Instance.GetStaffById(id);
            staffID = id;
        }

        public void LoadListClean()
        {
            List<CleanDTO> listClean = CleanDAO.Instance.GetListClean();
            foreach (CleanDTO clean in listClean)
            {
                LaundryCard laundry = new LaundryCard();
                RoomDTO room = RoomDAO.Instance.GetRoomByID(clean.RoomID);
                string RoomName = room.RoomName;
                laundry.SetText(clean.ID, RoomName, clean.Status);
                ListHolder.Children.Add(laundry);
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", staff);
            manage.ShowDialog();
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
    }
}