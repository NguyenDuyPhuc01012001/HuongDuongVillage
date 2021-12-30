using System.Windows.Controls;

namespace HuongDuongVillage.UI.Meal
{
    /// <summary>
    /// Interaction logic for MealButton.xaml
    /// </summary>
    public partial class MealButton : UserControl
    {
        public MealButton()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            mealName.Text = name;
        }
    }
}