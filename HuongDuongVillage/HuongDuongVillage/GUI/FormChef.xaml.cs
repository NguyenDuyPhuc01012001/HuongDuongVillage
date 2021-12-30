using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            LoadListFood();
        }

        public void LoadListFood()
        {
            List<ChefDTO> listFood = ChefDAO.Instance.GetListFood();
            foreach (ChefDTO food in listFood)
            {
                MealCard meal = new MealCard();
                RoomDTO room = RoomDAO.Instance.GetRoomByID(food.RoomID);
                string RoomName = room.RoomName;
                meal.SetText(food.ID, RoomName, food.FoodName, food.Status);
                ListHolder.Children.Add(meal);
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadMealStatus()
        {
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", staff);
            manage.ShowDialog();
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
        }

        private void CbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword("Change", staffID);
            changePassword.ShowDialog();
        }
    }
}