using System.Data;

namespace HuongDuongVillage.DTO
{
    public class AccountDTO
    {
        private string userName;
        private int staffID;
        private string userPass;
        private int iD;

        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public int ID { get => iD; set => iD = value; }
        public int StaffID { get => staffID; set => staffID = value; }

        public AccountDTO(string userName, int idStaff, int id, string userPass = null)
        {
            this.UserName = userName;
            this.StaffID = idStaff;
            this.UserPass = userPass;
            this.ID = id;
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.StaffID = (int)row["staffID"];
            this.UserPass = row["userPass"].ToString();
            this.ID = (int)row["id"];
        }
    }
}