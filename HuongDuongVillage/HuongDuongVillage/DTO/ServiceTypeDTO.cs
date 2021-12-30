using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class ServiceTypeDTO
    {
        private int id;
        private string serName;
        private string serType;
        private float serPrice;

        public int ID { get => id; set => id = value; }
        public string SerName { get => serName; set => serName = value; }
        public string SerType { get => serType; set => serType = value; }
        public float SerPrice { get => serPrice; set => serPrice = value; }

        public ServiceTypeDTO()
        { }

        public ServiceTypeDTO(int id, string serName, string serType, float serPrice)
        {
            this.ID = id;
            this.SerName = serName;
            this.SerType = serType;
            this.SerPrice = serPrice;
        }

        public ServiceTypeDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SerName = row["serName"].ToString();
            this.SerType = row["serType"].ToString();
            this.SerPrice = (float)Convert.ToDouble(row["serPrice"]);
        }
    }
}