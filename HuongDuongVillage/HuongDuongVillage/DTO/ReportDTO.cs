using System.Data;

namespace HuongDuongVillage.DTO
{
    public class ReportDTO
    {
        private int id;
        private string message;
        private int staffID;
        private string document;

        public int ID { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public int StaffID { get => staffID; set => staffID = value; }
        public string Document { get => document; set => document = value; }

        public ReportDTO()
        { }

        public ReportDTO(int id, string message, int staffID, string document)
        {
            this.ID = id;
            this.Message = message;
            this.StaffID = staffID;
            this.Document = document;
        }

        public ReportDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Message = row["message"].ToString();
            this.StaffID = (int)row["staffID"];
            this.Document = row["document"].ToString();
        }
    }
}