using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class CustomerDTO
    {
        private int iD;
        private string cusName;
        private string cusIDcard;
        private string cusPhone;
        private string cusEmail;
        private DateTime dateCheckIn;

        public int ID { get => iD; set => iD = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusIDcard { get => cusIDcard; set => cusIDcard = value; }
        public string CusPhone { get => cusPhone; set => cusPhone = value; }
        public string CusEmail { get => cusEmail; set => cusEmail = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }

        public CustomerDTO(int id, string cusName, string cusIDcard, string cusPhone, string cusEmail, DateTime dateCheckIn)
        {
            this.ID = id;
            this.CusName = cusName;
            this.CusIDcard = cusIDcard;
            this.CusPhone = cusPhone;
            this.CusEmail = cusEmail;
            this.DateCheckIn = dateCheckIn;
        }

        public CustomerDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.CusName = row["cusName"].ToString();
            this.CusIDcard = row["cusIDcard"].ToString();
            this.CusPhone = row["cusPhone"].ToString();
            this.CusEmail = row["cusEmail"].ToString();
            var paymentTemp = row["dateCheckIn"];
            if (paymentTemp.ToString() != "")
            {
                this.DateCheckIn = (DateTime)paymentTemp;
            }
        }
    }
}