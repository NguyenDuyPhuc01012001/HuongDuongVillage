using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class BookingDTO
    {
        private int iD;
        private int cusID;
        private int roomID;
        private DateTime dateCheckOut;
        private DateTime dateCheckIn;

        public int ID { get => iD; set => iD = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int CusID { get => cusID; set => cusID = value; }

        public BookingDTO(int id, int roomID, DateTime dateCheckIn, DateTime dateCheckOut, int cusIDcard)
        {
            this.ID = id;
            this.RoomID = roomID;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.cusID = cusIDcard;
        }

        public BookingDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.cusID = (int)row["cusID"];
            this.RoomID = (int)row["roomID"];
            var dobTemp = row["dateCheckIn"];
            if (dobTemp.ToString() != "")
            {
                this.DateCheckIn = (DateTime)dobTemp;
            }
            dobTemp = row["dateCheckOut"];
            if (dobTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime)dobTemp;
            }
        }
    }
}