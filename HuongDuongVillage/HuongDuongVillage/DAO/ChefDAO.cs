using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    internal class ChefDAO
    {
        private static ChefDAO instance;

        public static ChefDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChefDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ChefDAO()
        { }

        public List<ChefDTO> GetListFood()
        {
            List<ChefDTO> listFood = new List<ChefDTO>();

            string query = "SELECT * FROM Chef";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChefDTO food = new ChefDTO(item);
                listFood.Add(food);
            }

            return listFood;
        }

        public bool UpdateStatus(int status, string id)
        {
            string query = "Update Chef set Foodstatus = " + status.ToString() + " where id = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}