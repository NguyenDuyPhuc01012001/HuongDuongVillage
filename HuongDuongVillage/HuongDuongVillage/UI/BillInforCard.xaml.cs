using System.Windows.Controls;

namespace HuongDuongVillage.UI
{
    /// <summary>
    /// Interaction logic for BillInforCard.xaml
    /// </summary>
    public partial class BillInforCard : UserControl
    {
        public BillInforCard()
        {
            InitializeComponent();
        }

        public void SetText(string serviceName, float servicePrice, int serviceCount, float subTotal)
        {
            serviceNameTbl.Text = serviceName;
            servicePriceTbl.Text = servicePrice.ToString();
            serviceCountTbl.Text = serviceCount.ToString();
            serviceTotalTbl.Text = subTotal.ToString();
        }
    }
}