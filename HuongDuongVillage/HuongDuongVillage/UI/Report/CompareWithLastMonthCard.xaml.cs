using HuongDuongVillage.DAO;
using System;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for CompareWithLastMonthCard.xaml
    /// </summary>
    public partial class CompareWithLastMonthCard : UserControl
    {
        private int currentMonth = DateTime.Now.Month;
        private int currentYear = DateTime.Now.Year;

        public CompareWithLastMonthCard()
        {
            InitializeComponent();
            SetPercentProfitWithLastMonth();
        }

        private void SetPercentProfitWithLastMonth()
        {
            float percentage = PaymentDAO.Instance.GetPercentageBetweenCurrentAndPreProfit();
            tbPercent.Text = percentage.ToString() + "%";
        }

        public void SetPercentageProfitWithSelectedDate(int month, int year)
        {
            float percentage = PaymentDAO.Instance.GetPercentageBetweenSelectedAndPreProfit(month, year);
            tbPercent.Text = percentage.ToString() + "%";
        }
    }
}