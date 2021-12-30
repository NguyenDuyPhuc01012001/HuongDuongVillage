using HuongDuongVillage.DAO;
using System;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for MealStatusCard.xaml
    /// </summary>
    public partial class MealCard : UserControl
    {
        public MealCard()
        {
            InitializeComponent();
        }

        public void SetText(int id, string RoomName, string name, bool status)
        {
            this.mealID.Text = id.ToString();
            this.mealRoomName.Text = RoomName;
            this.mealName.Text = name;
            this.mealStatus.SelectedIndex = Convert.ToInt32(status);
        }

        private void mealStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChefDAO.Instance.UpdateStatus(mealStatus.SelectedIndex, mealID.Text);
        }
    }
}