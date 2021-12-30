using System.Data;

namespace HuongDuongVillage.DTO
{
    public class ServicesDTO
    {
        private int id;
        private int serTypeID;
        private int roomID;
        private int quantity;
        private bool status;

        public int ID { get => id; set => id = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int SerTypeID { get => serTypeID; set => serTypeID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public bool Status { get => status; set => status = value; }

        public ServicesDTO()
        { }

        public ServicesDTO(int id, int serTypeID, int roomID, int quantity, bool status)
        {
            this.ID = id;
            this.SerTypeID = serTypeID;
            this.RoomID = roomID;
            this.Quantity = quantity;
            this.Status = status;
        }

        public ServicesDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SerTypeID = (int)row["serTypeID"];
            this.RoomID = (int)row["roomID"];
            this.Quantity = (int)row["quantity"];
            this.Status = (bool)row["status"];
        }
    }
}