using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class RoomTypeDTO
    {
        private int id;
        private string roomType;
        private float roomPrice;

        public int ID { get => id; set => id = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public float RoomPrice { get => roomPrice; set => roomPrice = value; }

        public RoomTypeDTO()
        { }

        public RoomTypeDTO(int id, string roomType, float roomPrice)
        {
            this.ID = id;
            this.RoomType = roomType;
            this.RoomPrice = roomPrice;
        }

        public RoomTypeDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.RoomType = row["roomType"].ToString();
            this.RoomPrice = (float)Convert.ToDouble(row["roomPrice"]);
        }
    }
}