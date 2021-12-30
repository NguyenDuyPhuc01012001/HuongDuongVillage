using HuongDuongVillage.DAO;
using System;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for TotalProfitCard.xaml
    /// </summary>
    public partial class TotalProfitCard : UserControl
    {
        public int currentMonth = DateTime.Now.Month;

        public TotalProfitCard()
        {
            InitializeComponent();
            SetCurrentMonthProfit();
        }

        public float GetCurrentMonthProfit()
        {
            float profit = PaymentDAO.Instance.GetCurrentMonthProfit();
            return profit; ;
        }

        public void SetCurrentMonthProfit()
        {
            float profit = GetCurrentMonthProfit();
            tbProfit.Text = profit.ToString() + " VND";
        }

        public float GetTotalProfitByMonthAndYear(int month, int year)
        {
            float profit = 0;
            profit = PaymentDAO.Instance.GetMonthProfit(month, year);
            return profit;
        }

        public void SetTotalProfitByMonthAndYear(int month, int year)
        {
            float totalProfit = 0;
            totalProfit = GetTotalProfitByMonthAndYear(month, year);
            tbProfit.Text = totalProfit.ToString() + " VND";
        }
    }
}