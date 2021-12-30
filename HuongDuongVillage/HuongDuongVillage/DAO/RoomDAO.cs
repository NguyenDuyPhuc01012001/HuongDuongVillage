using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomDAO();
                return instance;
            }
            private set => instance = value;
        }

        private RoomDAO()
        { }

        public List<RoomDTO> GetRoomList()
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();

            string query = "SELECT * FROM Room WHERE isDelete=0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public List<RoomDTO> GetRoomListUnavailable()
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();

            string query = "SELECT * FROM Room WHERE isDelete=0 AND roomStatus='Unavailable'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public List<RoomDTO> GetRoomListByStatus(string name, string function)
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();
            string order = "ORDER BY roomStatus " + function;
            string where = null;
            if (!string.IsNullOrWhiteSpace(name))
                where = "AND (roomName LIKE N'%" + name + "%') ";

            string query = "SELECT * FROM Room WHERE isDelete=0 " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public RoomDTO GetRoomByID(int id)
        {
            string query = "SELECT * FROM Room where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                RoomDTO room = new RoomDTO(data.Rows[0]);
                return room;
            }
            return null;
        }

        internal List<RoomDTO> GetRoomListByType(int roomTypeID)
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();

            string query = "SELECT * FROM Room WHERE isDelete = 0 AND roomStatus='Available' and roomTypeID=" + roomTypeID;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                listRoom.Add(room);
            }

            return listRoom;
        }

        public bool DeleteRoom(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Room SET isDelete=1 WHERE id = " + id);

            return result > 0;
        }

        public bool EditRoom(int id, string name, string address, int cusID, string status, int idRoomType)
        {
            string query;
            if (cusID == -1)
                query = string.Format("UPDATE dbo.Room "
                + "SET RoomName = '{0}', roomAddress = '{1}' , roomTypeID = '{2}' , roomStatus = 'Unavailable' "
                + "WHERE id = {4}", name, address, idRoomType.ToString(), status, id.ToString());
            else
                query = string.Format("UPDATE dbo.Room "
                + "SET RoomName = '{0}', cusID = '{1}' , roomAddress = '{2}' , roomTypeID = '{3}' , roomStatus = '{4}' "
                + "WHERE id = {5}", name, cusID.ToString(), address, idRoomType.ToString(), status, id.ToString());
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertRoom(string name, string address, int idRoomType)
        {
            string query = string.Format("INSERT INTO dbo.Room(roomName,roomAddress,roomTypeID,roomStatus) "
                + "values('{0}','{1}','{2}','Available')", name, address, idRoomType.ToString());
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateRoomStatusByID(int roomID)
        {
            string query = "UPDATE Room SET roomStatus = 'Available' WHERE id = " + roomID.ToString();
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}