using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for MenuCard.xaml
    /// </summary>
    public partial class LaundryCard : UserControl
    {
        int serID;
        public LaundryCard(int serID)
        {
            InitializeComponent();
            this.serID = serID;
        }

        public void SetText(int id, string RoomName, bool status)
        {
            this.cleanID.Text = id.ToString();
            this.cleanRoomName.Text = RoomName;
            this.cleanStatus.SelectedIndex = Convert.ToInt32(status);
        }

        //private void addButton_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    addIcon.Foreground = Brushes.Green;
        //}

        //private void addButton_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    addIcon.Foreground = Brushes.White;
        //}

        //private void Grid_MouseEnter(object sender, MouseEventArgs e)
        //{
        //}

        //private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    deleteIcon.Foreground = Brushes.Red;
        //}

        //private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    deleteIcon.Foreground = Brushes.White;
        //}

        public void SetText(string mealName, string mealCategory, float mealPrice, int orderQuantity)
        {
        }

        private event EventHandler deleteMeal;

        public event EventHandler DeleteMeal
        {
            add { DeleteMeal += value; }
            remove { DeleteMeal -= value; }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    string name = mealName.Text;
            //    if (FoodDAO.Instance.DeleteMeal(name))
            //    {
            //        MessageBox.Show("Successfully");
            //        if (deleteMeal != null)
            //            deleteMeal(this, new EventArgs());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CustomAlertBox.Show(ex.Message);
            //}
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void mealStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CleanDAO.Instance.UpdateStatus(cleanStatus.SelectedIndex, cleanID.Text);
            ServiceDAO.Instance.UpdateStatus(serID, cleanStatus.SelectedIndex);
        }
    }
}