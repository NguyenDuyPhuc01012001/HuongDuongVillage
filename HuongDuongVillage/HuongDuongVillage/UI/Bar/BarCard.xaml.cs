using System.Windows.Controls;

namespace HuongDuongVillage.UI.Bar
{
    /// <summary>
    /// Interaction logic for BarCard.xaml
    /// </summary>
    public partial class BarCard : UserControl
    {
        public BarCard()
        {
            InitializeComponent();
        }

        public void SetText(int id, string RoomName, string entertain, string CusName)
        {
            this.barID.Text = id.ToString();
            this.barRoomID.Text = RoomName;
            this.barCusName.Text = CusName;
            this.entertainName.Text = entertain;
        }
    }
}