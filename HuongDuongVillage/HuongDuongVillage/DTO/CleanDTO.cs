using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class CleanDTO
    {
        private int iD;
        private int serID;
        private int roomID;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public int SerID { get => serID; set => serID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public bool Status { get => status; set => status = value; }

        public CleanDTO(int id, int serID, int roomID, bool status)
        {
            this.ID = id;
            this.SerID = serID;
            this.RoomID = roomID;
            this.Status = status;
        }

        public CleanDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SerID = (int)row["serID"];
            this.RoomID = (int)row["roomID"];
            this.Status = Convert.ToBoolean(row["Cleanstatus"]);
        }
    }
}