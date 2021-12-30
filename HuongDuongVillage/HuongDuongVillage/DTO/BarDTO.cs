using System.Data;

namespace HuongDuongVillage.DTO
{
    internal class BarDTO
    {
        private int id;
        private int serID;
        private int roomID;
        private string entertain;

        public int ID { get => id; set => id = value; }
        public int SerID { get => serID; set => serID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public string Entertain { get => entertain; set => entertain = value; }

        public BarDTO()
        { }

        public BarDTO(int id, int serID, int roomID, string entertain)
        {
            this.ID = id;
            this.SerID = serID;
            this.RoomID = roomID;
            this.Entertain = entertain;
        }

        public BarDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SerID = (int)row["serID"];
            this.RoomID = (int)row["roomID"];
            this.Entertain = row["Entertain"].ToString();
        }
    }
}