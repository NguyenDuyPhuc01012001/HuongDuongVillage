using HuongDuongVillage.DAO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for DiscountField.xaml
    /// </summary>
    public partial class DocumentReportCard : UserControl
    {
        private int ownerID;
        private int staffID;
        private int reportID;
        private bool isCEOAccessing;
        private event EventHandler reloadPage;

        public event EventHandler ReloadPage
        {
            add { reloadPage += value; }
            remove { reloadPage -= value; }
        }

        public DocumentReportCard(int ownerID, int staffID, int reportID, bool isCEOAccessing = false)
        {
            InitializeComponent();
            this.ownerID = ownerID;
            this.staffID = staffID;
            this.reportID = reportID;
            this.isCEOAccessing = isCEOAccessing;
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void setText(string owner, string message, string document)
        {
            tblOwner.Text = owner;
            tblMessage.Text = message;
            tblDocument.Text = document;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            if (staffID == ownerID)
            {
                ManageDocument editDocument = new ManageDocument("Edit", ownerID, reportID);
                editDocument.ReloadPage += reloadPage;
                editDocument.ShowDialog();
                //if (reloadPage != null)
                //{
                //    reloadPage(this, new EventArgs());
                //}
            }
            else
                MessageBox.Show("You don't have permission to edit this report");
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (isCEOAccessing)
            {
                CustomAlertBox.Show("Error", "CEO cannot modify item", CustomAlertBox.MessageBoxType.Error);
                return;
            }
            if (staffID == ownerID)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this report?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    if (ReportDAO.Instance.DeleteDocument(reportID))
                    {
                        MessageBox.Show("Delete successful");
                        if (reloadPage != null)
                        {
                            reloadPage(this, new EventArgs());
                        }
                    }
                    else
                        MessageBox.Show("Delete failed");
                }
            }
            else
                MessageBox.Show("You don't have permission to edit this report");
        }
    }
}