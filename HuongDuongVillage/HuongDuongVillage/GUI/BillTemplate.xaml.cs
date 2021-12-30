using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using HuongDuongVillage.UI;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for BillTemplate.xaml
    /// </summary>
    public partial class BillTemplate : Window
    {
        private int roomID;
        private int roomTypeID;
        private string roomName;
        private float roomPrice;
        private float total = 0;
        private CustomerDTO customer;
        private bool isPrintBillClick = false;

        public BillTemplate()
        {
            InitializeComponent();
        }

        public BillTemplate(int roomID, int roomTypeID, string roomName)
        {
            InitializeComponent();
            this.roomID = roomID;
            this.roomTypeID = roomTypeID;
            this.roomName = roomName;
            SetBillInfor(this.roomID);
            totalTbl.Text = "$" + total.ToString();
            dateCheckOutTbl.Text = DateTime.Now.ToString();
            customer = GetCustomer(roomID);
            SetCustomer(customer);
            cmbMethod.SelectedIndex = 0;
        }

        public void GetRoomPrice()
        {
            RoomTypeDTO roomType = RoomTypeDAO.Instance.GetRoomTypeByID(this.roomTypeID);
            this.roomPrice = roomType.RoomPrice;
        }

        public void SetBillInfor(int roomID)
        {
            List<BillInforDTO> billInfors = ServiceDAO.Instance.GetListBillInforByRoomID(roomID);
            GetRoomPrice();
            BillInforCard card = new BillInforCard();
            card.SetText(this.roomName, this.roomPrice, 1, this.roomPrice);
            lvBillInfo.Items.Add(card);
            total += this.roomPrice;
            foreach (BillInforDTO billInfor in billInfors)
            {
                BillInforCard billInforCard = new BillInforCard();
                billInforCard.SetText(billInfor.SerName, billInfor.SerPrice, billInfor.SerCount, billInfor.SubTotal);
                total += billInfor.SubTotal;
                lvBillInfo.Items.Add(billInforCard);
            }
        }

        public CustomerDTO GetCustomer(int roomID)
        {
            RoomDTO room = RoomDAO.Instance.GetRoomByID(roomID);
            CustomerDTO customer = CustomerDAO.Instance.GetCustomerById(room.CusID);
            return customer;
        }

        public void SetCustomer(CustomerDTO customer)
        {
            customerNameTbl.Text = customer.CusName;
            dateCheckInTbl.Text = customer.DateCheckIn.ToString();
        }

        private void PrintBillBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmbMethod.Visibility = Visibility.Hidden;
                tblMethod.Visibility = Visibility.Visible;
                tblMethod.Text = cmbMethod.Text;
                PrintBillBtn.Visibility = Visibility.Hidden;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");
                    MessageBox.Show(printDialog.ToString());
                }
            }
            finally
            {
                isPrintBillClick = true;
                PrintBillBtn.Visibility = Visibility.Visible;
                cmbMethod.Visibility = Visibility.Visible;
                tblMethod.Visibility = Visibility.Hidden;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (isPrintBillClick)
            {
                ServiceDAO.Instance.DeleteServiceByRoomID(roomID);
                RoomDAO.Instance.UpdateRoomStatusByID(roomID);
                PaymentDAO.Instance.InsertPayment(customer.ID, total, DateTime.Now, tblMethod.Text);
            }
            this.Close();
        }
    }
}