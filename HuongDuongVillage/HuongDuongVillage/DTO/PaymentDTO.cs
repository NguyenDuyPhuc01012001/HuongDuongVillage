using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class PaymentDTO
    {
        private int iD;
        private int cusID;
        private float amount;
        private DateTime paymentDate;
        private string method;

        public int ID { get => iD; set => iD = value; }
        public int CusID { get => cusID; set => cusID = value; }
        public float Amount { get => amount; set => amount = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public string Method { get => method; set => method = value; }

        public PaymentDTO(int id, int cusID, float amount, DateTime paymentDate, string method)
        {
            this.ID = id;
            this.CusID = cusID;
            this.Amount = amount;
            this.PaymentDate = paymentDate;
            this.Method = method;
        }

        public PaymentDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.CusID = (int)row["cusID"];
            this.Amount = (float)Convert.ToDouble(row["amount"]);
            var paymentTemp = row["paymentDate"];
            if (paymentTemp.ToString() != "")
            {
                this.PaymentDate = (DateTime)paymentTemp;
            }
            this.Method = row["method"].ToString();
        }
    }
}