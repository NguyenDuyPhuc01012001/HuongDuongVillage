using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDuongVillage.DAO
{
    internal class RoomTypeDAO
    {
        private static RoomTypeDAO instance;

        public static RoomTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomTypeDAO();
                return instance;
            }
            private set => instance = value;
        }
        private RoomTypeDAO() { }

        public List<RoomTypeDTO> GetRoomTypeList()
        {
            List<RoomTypeDTO> listRoom = new List<RoomTypeDTO>();

            string query = "SELECT * FROM RoomType where isDelete = 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomTypeDTO room = new RoomTypeDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public RoomTypeDTO GetRoomTypeInfo(int id)
        {
            string query = "SELECT * FROM RoomType where isDelete = 0 AND id=" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                RoomTypeDTO roomType = new RoomTypeDTO(data.Rows[0]);
                return roomType;
            }
            return null;
        }
        public bool InsertRoomType(string type, float price)
        {
            string query = string.Format("INSERT INTO dbo.RoomType(roomType, roomPrice) "
                + "values ('{0}', '{1}')", type, price);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteRoomType(int id)
        {
            string query = string.Format("UPDATE RoomType "
               + "SET isDelete = 1 "
               + "WHERE id = '{0}'", id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditRoomType(int id, string type, float price)
        {
            string query = string.Format(
                "UPDATE RoomType "
               + "SET roomType = '{0}', roomPrice = '{1}' "
               + "WHERE id = '{2}'", type, price.ToString(), id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<RoomTypeDTO> GetRoomTypeListByType(string searchText, string function)
        {
            List<RoomTypeDTO> listRoom = new List<RoomTypeDTO>();
            string order = "ORDER BY roomType " + function;
            string where = "WHERE isDelete = 0 ";

            if (!String.IsNullOrWhiteSpace(searchText))
            {
                where += string.Format(" AND (roomType like N'%{0}%' or roomPrice like '%{0}%') ", searchText);
            }
            string query = "SELECT * FROM RoomType " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomTypeDTO room = new RoomTypeDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }
        public List<RoomTypeDTO> GetRoomTypeListByPrice(string searchText, string function)
        {
            List<RoomTypeDTO> listRoom = new List<RoomTypeDTO>();
            string order = "ORDER BY roomPrice " + function;
            string where = "WHERE isDelete = 0 ";

            if (!String.IsNullOrWhiteSpace(searchText))
            {
                where += string.Format("AND (roomType like N'%{0}%' or roomPrice like '%{0}%') ", searchText);
            }
            string query = "SELECT * FROM RoomType " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomTypeDTO room = new RoomTypeDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }
        public List<RoomTypeDTO> GetRoomTypeListByInput(string input)
        {
            List<RoomTypeDTO> listRoom = new List<RoomTypeDTO>();
            string where = null;
            if (!String.IsNullOrWhiteSpace(input))
            {
                where = string.Format("AND (roomType like N'%{0}%' or roomPrice like '%{0}%') ", input);
            }
            string query = "SELECT * FROM RoomType WHERE isDelete=0 " + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                RoomTypeDTO roomType = new RoomTypeDTO(item);
                listRoom.Add(roomType);
            }
            return listRoom;
        }
        public List<RoomTypeDTO> GetRoomTypesByName(string name)
        {
            List<RoomTypeDTO> roomTypes = new List<RoomTypeDTO>();
            string query = "SELECT * FROM RoomType where isDelete = 0 AND roomType= '" + name + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                RoomTypeDTO roomType = new RoomTypeDTO(item);
                roomTypes.Add(roomType);
            }
            return roomTypes;

        }
        public int GetRoomCountByRoomType(int id)
        {
            int count = 0;
            string query = "select COUNT(*) from Room inner join RoomType on Room.roomTypeID = RoomType.id where RoomType.id = " + id.ToString();
            count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count;
        }
        public RoomTypeDTO GetRoomTypeByID(int id)
        {
            string query = "Select * from RoomType where id = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                RoomTypeDTO roomType = new RoomTypeDTO(data.Rows[0]);
                return roomType;
            }
            return null;
        }
    }
}
