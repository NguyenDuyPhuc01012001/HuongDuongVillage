using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.UI.Bar;
using System.Collections.Generic;
using System.Windows;

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
            InitializeComponent();
            staffID = id;
            LoadListBar();
        }

        public void LoadListBar()
        {
            List<BarDTO> listbar = BarDAO.Instance.GetListBar();
            foreach (BarDTO bar in listbar)
            {
                BarCard entertain = new BarCard();
                RoomDTO room = RoomDAO.Instance.GetRoomByID(bar.RoomID);
                string RoomName = room.RoomName;
                entertain.SetText(bar.ID, bar.SerID, RoomName, bar.Entertain);
                ListHolder.Children.Add(entertain);
            }
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDTO staff = StaffDAO.Instance.GetStaffById(staffID);
            ManageStaff manage = new ManageStaff("View", staff);
            manage.ShowDialog();
        }

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword("Change", staffID);
            changePassword.ShowDialog();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}