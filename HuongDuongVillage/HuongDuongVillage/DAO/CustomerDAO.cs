using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set => instance = value;
        }

        private CustomerDAO()
        { }

        public List<CustomerDTO> GetListCustomer()
        {
            List<CustomerDTO> listCus = new List<CustomerDTO>();

            string query = "SELECT * FROM Customer WHERE isDelete=0 ORDER BY dateCheckIn desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CustomerDTO cus = new CustomerDTO(item);
                listCus.Add(cus);
            }

            return listCus;
        }

        public List<CustomerDTO> GetListCustomerByCheckIn(string name, string function)
        {
            List<CustomerDTO> listCus = new List<CustomerDTO>();
            string order = "ORDER BY dateCheckIn " + function;
            string where = null;

            if (!string.IsNullOrWhiteSpace(name))
                where = "AND (cusName LIKE N'%" + name + "%') ";
            string query = "SELECT * FROM Customer WHERE isDelete=0 " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CustomerDTO cus = new CustomerDTO(item);
                listCus.Add(cus);
            }

            return listCus;
        }

        public CustomerDTO GetCustomerById(int id)
        {
            string query = "SELECT * FROM Customer WHERE id = " + id.ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                CustomerDTO cus = new CustomerDTO(data.Rows[0]);
                return cus;
            }
            return null;
        }

        internal CustomerDTO GetCustomerByIdCard(string cusIDcard)
        {
            string query = "SELECT * FROM Customer WHERE cusIDcard = '" + cusIDcard + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                CustomerDTO cus = new CustomerDTO(data.Rows[0]);
                return cus;
            }
            return null;
        }

        public string CheckIDCardExist(string idCard)
        {
            string query = string.Format("SELECT * FROM Customer where cusIDcard = '{0}'", idCard);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                CustomerDTO cus = new CustomerDTO(data.Rows[0]);
                return cus.CusIDcard;
            }
            return null;
        }

        public bool IsUsingService(int id)
        {
            string query = string.Format("SELECT * FROM room where cusID = '{0}' and roomStatus<>'Available'", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public bool MakeCheckIn(string idCard, DateTime dateTime)
        {
            string query = "SET DATEFORMAT DMY; "
                + "UPDATE dbo.Customer "
                + "SET dateCheckIn = '" + dateTime.ToString("dd/MM/yyyy") + "' "
                + "WHERE cusIDcard = '" + idCard + "'";
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCustomer(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Customer SET isDelete=1 WHERE id = " + id);

            return result > 0;
        }

        public bool EditCustomer(int id, string name, string mail, DateTime dateCheckIn, string idCard, string phone)
        {
            string query = string.Format("SET DATEFORMAT DMY; "
                + "UPDATE dbo.Customer "
                + "SET cusName = '{0}', cusPhone = '{1}' , cusEmail = '{2}' , dateCheckIn = '{3}',cusIDcard = '{4}' "
                + "WHERE id = {4}", name, phone, mail, dateCheckIn.ToString("dd/MM/yyyy").Split(" ")[0], idCard, id);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertCustomer(string name, string mail, DateTime dateCheckIn, string idCard, string phone)
        {
            string query = string.Format("SET DATEFORMAT DMY; "
                + "INSERT INTO dbo.Customer(cusName,cusIDcard,cusPhone,cusEmail,dateCheckIn) "
                + "values('{0}','{1}','{2}','{3}','{4}')", name, idCard, phone, mail, dateCheckIn.ToString("dd/MM/yyyy").Split(" ")[0]);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}