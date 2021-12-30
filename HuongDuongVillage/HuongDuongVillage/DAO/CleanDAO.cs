using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    internal class CleanDAO
    {
        private static CleanDAO instance;

        public static CleanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CleanDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CleanDAO()
        { }

        public List<CleanDTO> GetListClean()
        {
            List<CleanDTO> listClean = new List<CleanDTO>();

            string query = "SELECT * FROM Clean";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CleanDTO clean = new CleanDTO(item);
                listClean.Add(clean);
            }

            return listClean;
        }

        public bool UpdateStatus(int status, string id)
        {
            string query = "Update Clean set Cleanstatus = " + status.ToString() + " where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}