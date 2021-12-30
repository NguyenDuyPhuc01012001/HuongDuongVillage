using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class ChefDTO
    {
        private int iD;
        private int serID;
        private int roomID;
        private string foodName;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public int SerID { get => serID; set => serID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public bool Status { get => status; set => status = value; }

        public ChefDTO(int id, int serID, int roomID, string foodName, bool status)
        {
            this.ID = id;
            this.SerID = serID;
            this.RoomID = roomID;
            this.FoodName = foodName;
            this.Status = status;
        }

        public ChefDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.SerID = (int)row["serID"];
            this.RoomID = (int)row["roomID"];
            this.FoodName = row["foodName"].ToString();
            this.Status = Convert.ToBoolean(row["Foodstatus"]);
        }
    }
}