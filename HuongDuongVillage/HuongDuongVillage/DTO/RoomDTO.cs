using System.Data;

namespace HuongDuongVillage.DTO
{
    public class RoomDTO
    {
        private int id;
        private int cusID;
        private string roomName;
        private string roomAddress;
        private int roomTypeID;
        private string roomStatus;

        public int ID { get => id; set => id = value; }
        public int CusID { get => cusID; set => cusID = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string RoomAddress { get => roomAddress; set => roomAddress = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public int RoomTypeID { get => roomTypeID; set => roomTypeID = value; }

        public RoomDTO()
        { }

        public RoomDTO(int id, int cusID, string roomName, string roomAddress, int roomTypeID, string roomStatus)
        {
            this.ID = id;
            this.CusID = cusID;
            this.RoomName = roomName;
            this.RoomAddress = roomAddress;
            this.RoomTypeID = roomTypeID;
            this.RoomStatus = roomStatus;
        }

        public RoomDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.CusID = (string.IsNullOrWhiteSpace(row["cusID"].ToString())) ? -1 : ((int)row["cusID"]);
            this.RoomName = row["roomName"].ToString();
            this.RoomAddress = row["roomAddress"].ToString();
            this.RoomTypeID = (int)row["roomTypeID"];
            this.RoomStatus = row["roomStatus"].ToString();
        }
    }
}