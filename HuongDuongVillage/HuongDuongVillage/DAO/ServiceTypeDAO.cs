using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    internal class ServiceTypeDAO
    {
        private static ServiceTypeDAO instance;

        public static ServiceTypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceTypeDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ServiceTypeDAO()
        { }

        public bool DeleteServiceType(int id)
        {
            string query = string.Format("UPDATE ServiceType "
               + "SET isDelete = 1 "
               + "WHERE id = '{0}'", id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool EditServiceType(int id, string name, string type, float price)
        {
            string query = string.Format(
                "UPDATE ServiceType "
               + "SET serName = '{0}', serType = '{1}' , serPrice = '{2}' "
               + "WHERE id = '{3}'", name, type, price.ToString(), id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertServiceType(string name, string type, float price)
        {
            string query = string.Format("INSERT INTO dbo.ServiceType(serName, serType, serPrice) "
                + "values ('{0}', '{1}', '{2}')", name, type, price);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<ServiceTypeDTO> GetListServiceType()
        {
            List<ServiceTypeDTO> services = new List<ServiceTypeDTO>();
            string query = "SELECT * FROM ServiceType WHERE isDelete = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                services.Add(service);
            }
            return services;
        }
        public ServiceTypeDTO GetServicebyserTypeID(int id)
        {
            string query = "Select * from ServiceType where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count>0)
            {
                ServiceTypeDTO servicetype = new ServiceTypeDTO(data.Rows[0]);
                return servicetype;
            }
            return null;
        }
        public List<ServiceTypeDTO> GetServiceWithNameAndType(string name, string type)
        {
            List<ServiceTypeDTO> services = new List<ServiceTypeDTO>();
            string query = "SELECT * FROM ServiceType WHERE isDelete = 0 and serName = '" + name + "' AND serType = '" + type + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                services.Add(service);
            }
            return services;
        }

        public List<ServiceTypeDTO> GetServiceTypeListByName(string searchText, string function)
        {
            List<ServiceTypeDTO> listService = new List<ServiceTypeDTO>();
            string order = "ORDER BY serName " + function;
            string where = "WHERE isDelete = 0";

            if (!String.IsNullOrWhiteSpace(searchText))
            {
                where += string.Format(" AND ( serName like N'%{0}%' or serType like N'%{0}%' or serPrice like '%{0}%') ", searchText);
            }
            string query = "SELECT * FROM ServiceType " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                listService.Add(service);
            }

            return listService;
        }

        public List<ServiceTypeDTO> GetServiceTypeListByPrice(string searchText, string function)
        {
            List<ServiceTypeDTO> listService = new List<ServiceTypeDTO>();
            string order = "ORDER BY serPrice " + function;
            string where = "WHERE isDelete = 0";

            if (!String.IsNullOrWhiteSpace(searchText))
            {
                where += string.Format(" AND ( serName like N'%{0}%' or serType like N'%{0}%' or serPrice like '%{0}%') ", searchText);
            }
            string query = "SELECT * FROM ServiceType " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                listService.Add(service);
            }

            return listService;
        }

        public List<ServiceTypeDTO> GetServiceTypeListByType(string searchText, string function)
        {
            List<ServiceTypeDTO> listService = new List<ServiceTypeDTO>();
            string order = "ORDER BY serType " + function;
            string where = "WHERE isDelete = 0";

            if (!String.IsNullOrWhiteSpace(searchText))
            {
                where += string.Format(" AND ( serName like N'%{0}%' or serType like N'%{0}%' or serPrice like '%{0}%') ", searchText);
            }
            string query = "SELECT * FROM ServiceType " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                listService.Add(service);
            }

            return listService;
        }

        public List<ServiceTypeDTO> GetServiceTypeListByType(string serType)
        {
            List<ServiceTypeDTO> listService = new List<ServiceTypeDTO>();
            string select = "SELECT * FROM ServiceType ";
            string order = "ORDER BY serName asc";
            string where = "WHERE isDelete = 0 AND serType = '" + serType + "' ";
            string query = select + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                listService.Add(service);
            }

            return listService;
        }

        public ServiceTypeDTO GetServiceTypeInfo(int id)
        {
            string query = "SELECT * FROM ServiceType where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(data.Rows[0]);
                return service;
            }
            return null;
        }

        public List<String> GetSetServiceType()
        {
            List<String> serviceTypes = new List<String>();
            string query = "SELECT DISTINCT serType FROM ServiceType WHERE isDelete = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            for (int i = 0; i < data.Rows.Count; i++)
                serviceTypes.Add(data.Rows[i]["serType"].ToString());

            return serviceTypes;
        }

        public List<ServiceTypeDTO> GetListServiceTypeByInput(string input)
        {
            List<ServiceTypeDTO> services = new List<ServiceTypeDTO>();
            string where = null;
            if (!String.IsNullOrWhiteSpace(input))
            {
                where = string.Format("AND ( serName like N'%{0}%' or serType like N'%{0}%' or serPrice like '%{0}%') ", input);
            }
            string query = "SELECT * FROM ServiceType WHERE isDelete=0 " + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ServiceTypeDTO service = new ServiceTypeDTO(item);
                services.Add(service);
            }
            return services;
        }
    }
}