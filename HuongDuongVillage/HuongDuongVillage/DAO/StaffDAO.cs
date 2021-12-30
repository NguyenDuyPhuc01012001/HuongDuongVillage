using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDuongVillage.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set => instance = value;
        }
        private StaffDAO() { }

        public List<StaffDTO> GetListStaff()
        {
            List<StaffDTO> listStaff = new List<StaffDTO>();

            string query = "SELECT * FROM Staff WHERE isDelete=0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                StaffDTO staff = new StaffDTO(item);
                listStaff.Add(staff);
            }

            return listStaff;
        }

        public List<StaffDTO> GetListStaffByName(string name, string function)
        {
            List<StaffDTO> listStaff = new List<StaffDTO>();
            string order = " ORDER BY staffName " + function;
            string where = null;

            if (!string.IsNullOrWhiteSpace(name))
            {
                where = string.Format("AND (staffName like N'%{0}%' or staffMail like '%{0}%') ", name);
                //where = "WHERE staffName like N'%" + name + "%' or staffMail like N'%" + name + "%' or staffDOB like N'%" + name + "%' or staffGender like N'%" + name + "%' or staffRole like N'%" + name + "%'";

            }
            //where = "WHERE staffName LIKE N'%" + name+ "%' ";

            string query = "SELECT * FROM Staff WHERE isDelete=0 " + where + order;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StaffDTO staff = new StaffDTO(item);
                listStaff.Add(staff);
            }
            return listStaff;
        }

        public List<StaffDTO> GetListStaffByRole(string name, string function)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            string order = " ORDER BY staffRole " + function;
            string where = null;

            if (!string.IsNullOrWhiteSpace(name))
                where = string.Format("AND (staffName like N'%{0}%' or staffMail like '%{0}%') ", name);
            //where = "WHERE staffName LIKE N'%" + name + "%' ";

            string query = "SELECT * FROM Staff WHERE isDelete=0 " + where + order;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StaffDTO staff = new StaffDTO(item);
                staffs.Add(staff);
            }
            return staffs;
        }

        public StaffDTO GetStaffById(int id)
        {
            string query = "SELECT * FROM Staff where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                return staff;
            }
            return null;
        }

        public bool DeleteStaff(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Staff SET isDelete=1 where id = " + id);

            return result > 0;
        }

        public bool EditStaff(int id, string name, string mail, DateTime dob, int gender, string role)
        {
            string query = string.Format("SET DATEFORMAT DMY; "
                + "UPDATE Staff "
                + "SET staffName = '{0}', staffGender = '{1}' , staffMail = '{2}' , staffDOB = '{3}' , staffRole = '{4}' "
                + "WHERE id = '{5}'", name, gender.ToString(), mail, dob.ToString("dd-MM-yyyy").Split(" ")[0], role, id.ToString());
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertStaff(string name, string mail, DateTime dob, int gender, string role)
        {
            string query = string.Format("SET DATEFORMAT DMY; "
                + "INSERT INTO dbo.Staff(staffName, staffMail, staffDOB, staffGender, staffRole) "
                + "values('{0}','{1}','{2}','{3}','{4}')", name, mail, dob.ToString("dd-MM-yyyy").Split(" ")[0], gender, role);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int CheckEmailExist(string email)
        {
            string query = string.Format("SELECT * FROM Staff where staffMail = '{0}'", email);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                return staff.ID;
            }
            return -1;
        }

        public string GetNameById(int id)
        {
            string query = "SELECT staffName FROM Staff WHERE id = " + id;
            string name = DataProvider.Instance.ExecuteScalar(query).ToString();
            return name;
        }
    }
}
