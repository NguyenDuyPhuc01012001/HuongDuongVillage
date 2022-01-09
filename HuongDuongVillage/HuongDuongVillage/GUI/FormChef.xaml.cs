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
    /// Interaction logic for FormChef.xaml
    /// </summary>
    public partial class FormChef : Window
    {
        private int staffID;

        public FormChef()
        {
            InitializeComponent();
            LoadListFood();
        }

        public FormChef(int id)
        {
            InitializeComponent();
            staffID = id;
            LoadListFood();
        }

        public void LoadListFood()
        {
            try
            {
                List<ServicesDTO> listFood = ServiceDAO.Instance.GetListService();
                foreach (ServicesDTO food in listFood)
                {
                    MealCard meal = new MealCard(food.ID);
                    RoomDTO room = RoomDAO.Instance.GetRoomByID(food.RoomID);
                    string RoomName = room.RoomName;
                    ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(food.SerTypeID);
                    meal.SetText(food.ID, RoomName, serviceType.SerName, food.Status);
                    if (serviceType.SerType == "food")
                        ListHolder.Children.Add(meal);
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }

        }

        private void LoadMealStatus()
        {
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
        }

        private void CbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Reload.Cursor = Cursors.Wait;
                LoadListFood();
                Reload.Cursor = null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}