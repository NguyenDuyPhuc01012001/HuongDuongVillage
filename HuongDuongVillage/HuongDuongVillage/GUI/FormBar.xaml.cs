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
            LoadListBar();
        }

        public void LoadListBar()
        {
            List<ServicesDTO> listbar = ServiceDAO.Instance.GetListService();
            foreach (ServicesDTO bar in listbar)
            {
                BarCard entertain = new BarCard();
                RoomDTO room = RoomDAO.Instance.GetRoomByID(bar.RoomID);
                string RoomName = room.RoomName;
                ServiceTypeDTO serviceType = ServiceTypeDAO.Instance.GetServiceTypeInfo(bar.SerTypeID);
                entertain.SetText(bar.ID, RoomName, serviceType.SerName);
                if (serviceType.SerType == "bar")
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