using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for PaymentCard.xaml
    /// </summary>
    public partial class PaymentCard : UserControl
    {
        public PaymentCard()
        {
            InitializeComponent();
        }

        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(int id, string cusName, float amount, DateTime paymentDate, string method)
        {
            this.idTxb.Text = id.ToString();
            this.cusNameTxb.Text = cusName.ToString();
            this.amountTxb.Text = amount.ToString();
            this.paymentDateTxb.Text = paymentDate.ToString();
            this.paymentMethodTxb.Text = method.ToString();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int paymentID = int.Parse(idTxb.Text);

            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete payment?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (PaymentDAO.Instance.DeletePayment(paymentID))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }
    }
}