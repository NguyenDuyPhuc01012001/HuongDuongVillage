using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class BillInforDTO
    {
        private string serName;
        private float serPrice;
        private int serCount;
        private float subTotal;
        public string SerName
        { get { return serName; } set { serName = value; } }
        public float SerPrice
        { get { return serPrice; } set { serPrice = value; } }
        public int SerCount
        { get { return serCount; } set { serCount = value; } }
        public float SubTotal
        { get { return subTotal; } set { subTotal = value; } }

        public BillInforDTO(string serName, float serPrice, int serCount, float subTotal)
        {
            this.SerName = serName;
            this.SerPrice = serPrice;
            this.SerCount = serCount;
            this.SubTotal = subTotal;
        }

        public BillInforDTO(DataRow row)
        {
            this.SerName = row["serName"].ToString();
            this.SerPrice = (float)Convert.ToDouble(row["serPrice"].ToString());
            this.SerCount = (int)row["count"];
            this.SubTotal = (float)Convert.ToDouble(row["subTotal"].ToString());
        }
    }
}