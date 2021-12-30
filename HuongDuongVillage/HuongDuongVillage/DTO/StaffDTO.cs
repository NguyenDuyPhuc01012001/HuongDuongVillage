using System;
using System.Data;

namespace HuongDuongVillage.DTO
{
    public class StaffDTO
    {
        private int id;
        private string name;
        private string mail;
        private DateTime dateOfBirth;
        private bool gender;
        private string role;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Role { get => role; set => role = value; }

        public StaffDTO()
        { }

        public StaffDTO(int id, string name, string mail, DateTime dob, bool gender, string role)
        {
            this.ID = id;
            this.Name = name;
            this.Mail = mail;
            this.DateOfBirth = dob;
            this.Gender = gender;
            this.Role = role;
        }

        public StaffDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["staffName"].ToString();
            this.Mail = row["staffMail"].ToString();
            var dobTemp = row["staffDOB"];
            if (dobTemp.ToString() != "")
            {
                this.DateOfBirth = (DateTime)dobTemp;
            }
            this.Gender = (bool)row["staffGender"];
            this.Role = row["staffRole"].ToString();
        }
    }
}