using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    internal class BarDAO
    {
        private static BarDAO instance;

        public static BarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BarDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BarDAO()
        { }

        public List<BarDTO> GetListBar()
        {
            List<BarDTO> listBar = new List<BarDTO>();

            string query = "SELECT * FROM Bar";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BarDTO bar = new BarDTO(item);
                listBar.Add(bar);
            }

            return listBar;
        }
    }
}