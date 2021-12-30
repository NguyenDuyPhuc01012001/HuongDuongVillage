﻿using System.Windows.Controls;

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

        public void SetText(int id, int serID, string RoomName, string entertain)
        {
            this.barID.Text = id.ToString();
            this.barSerID.Text = serID.ToString();
            this.barRoomID.Text = RoomName;
            this.entertainName.Text = entertain;
        }
    }
}