using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage.UI.Booking
{
    /// <summary>
    /// Interaction logic for BookingCard.xaml
    /// </summary>
    public partial class BookingCard : UserControl
    {
        private int idBook;
        private int idRoom;

        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public BookingCard(int idBook, int idRoom)
        {
            InitializeComponent();
            this.idBook = idBook;
            this.idRoom = idRoom;
        }

        public BookingCard()
        {
            InitializeComponent();
        }

        private void viewButton_MouseEnter(object sender, MouseEventArgs e)
        {
            viewIcon.Foreground = Brushes.Green;
        }

        private void viewButton_MouseLeave(object sender, MouseEventArgs e)
        {
            viewIcon.Foreground = Brushes.White;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            ManageRoom book = new ManageRoom("View", "Book", idBook);
            book.ShowDialog();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string idCustomer = tblCusID.Text;
            MessageBoxResult result = CustomAlertBox.Show("Warning", "Are you sure you want to delete this book?", MessageBoxButton.OKCancel, CustomAlertBox.MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                if (BookingDAO.Instance.DeleteBooking(idBook, idRoom))
                {
                    CustomAlertBox.Show("Delete successful");
                    if (reloadPage != null)
                        reloadPage(this, new EventArgs());
                }
                else
                    CustomAlertBox.Show("Delete failed");
            }
        }

        public void setText(string roomName, string customerName, string customerID, string dateCheckIn, string dateCheckOut)
        {
            tblRoomName.Text = roomName;
            tblCusName.Text = customerName;
            tblCusID.Text = customerID;
            tblDateCheckIn.Text = dateCheckIn.Split(" ")[0];
            tblDateCheckOut.Text = dateCheckOut.Split(" ")[0];
        }
    }
}