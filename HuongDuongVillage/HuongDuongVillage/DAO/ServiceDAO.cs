using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ServiceDAO()
        { }

        public List<ServicesDTO> GetServiceListByType(int sertypeID)
        {
            List<ServicesDTO> services = new List<ServicesDTO>();

            string query = "SELECT * FROM Service WHERE isDelete = 0 and serTypeID = " + sertypeID;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServicesDTO service = new ServicesDTO(item);
                services.Add(service);
            }

            return services;
        }

        public List<ServicesDTO> GetListService()
        {
            List<ServicesDTO> services = new List<ServicesDTO>();
            string query = "SELECT * FROM Service WHERE isDelete=0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServicesDTO service = new ServicesDTO(item);
                services.Add(service);
            }
            return services;
        }

        public ServicesDTO GetServiceByID(int id)
        {
            string query = "SELECT * FROM Service where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                ServicesDTO service = new ServicesDTO(data.Rows[0]);
                return service;
            }
            return null;
        }

        public bool DeleteService(int id)
        {
            string query = string.Format("UPDATE Service "
               + "SET isDelete = 1 "
               + "WHERE id = '{0}'", id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool EditService(int id, int roomID, int serviceTypeId, int quantity, int status)
        {
            string query = string.Format(
                "UPDATE Service "
               + "SET roomID = '{0}', serTypeID = '{1}' , quantity = '{2}' , status='{3}'"
               + "WHERE id = '{4}'", roomID, serviceTypeId, quantity, status, id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertService(int roomID, int serviceTypeId, int quantity, int status)
        {
            string query = string.Format("INSERT INTO dbo.Service(serTypeID,roomID,quantity, status) "
                + "values ('{0}', '{1}', '{2}','{3}')", serviceTypeId, roomID, quantity, status);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<BillInforDTO> GetListBillInforByRoomID(int roomID)
        {
            List<BillInforDTO> billInfors = new List<BillInforDTO>();
            string query = string.Format("SELECT ServiceType.serName,ServiceType.serPrice,SUM(Service.quantity) as count, ServiceType.serPrice * SUM(Service.quantity) as subTotal from Service join ServiceType on Service.serTypeID = ServiceType.id where Service.roomID = '{0}' AND Service.status = '1' AND Service.isDelete = 0 group by ServiceType.serName, ServiceType.serPrice order by ServiceType.serName asc", roomID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInforDTO billInfor = new BillInforDTO(row);
                billInfors.Add(billInfor);
            }
            return billInfors;
        }

        public bool DeleteServiceByRoomID(int roomID)
        {
            string query = string.Format("UPDATE Service "
              + "SET isDelete = 1 "
              + "WHERE roomID = '{0}'", roomID);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}