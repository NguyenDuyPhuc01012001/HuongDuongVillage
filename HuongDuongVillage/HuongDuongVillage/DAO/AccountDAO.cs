using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace HuongDuongVillage.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        private AccountDAO()
        { }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => instance = value;
        }

        private string HashPassword(string password)
        {
            try
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hasPass = "";

                foreach (byte item in hasData)
                {
                    hasPass += item;
                }
                return hasPass;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                string hasPass = HashPassword(password);

                string query = "EXEC USP_Login @UserName , @PassWord";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hasPass });
                return result.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public AccountDTO GetAccountByIdUser(int id)
        {
            try
            {
                string query = "SELECT * FROM Account WHERE StaffID = " + id;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {
                    AccountDTO account = new AccountDTO(data.Rows[0]);
                    return account;
                }
                return null;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public string GetRoleByUserName(string userName)
        {
            try
            {
                string query = "exec USP_GetPositionByUserName @userName";
                string Role = DataProvider.Instance.ExecuteScalar(query, new object[] { userName }).ToString();
                return Role;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public bool ChangePassword(string userName, string password)
        {
            try
            {
                string hasPass = HashPassword(password);

                string query = string.Format("Update Account Set userPass = '{0}' Where username = '{1}' ", hasPass, userName);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public List<AccountDTO> GetListAccount()
        {
            try
            {
                List<AccountDTO> accounts = new List<AccountDTO>();
                string query = string.Format("SELECT * FROM Account INNER JOIN Staff ON Account.StaffID=Staff.id where isDelete=0");
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    AccountDTO account = new AccountDTO(item);
                    accounts.Add(account);
                }
                return accounts;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<AccountDTO> GetAccountListByRole(string name, string function)
        {
            try
            {
                List<AccountDTO> accountList = new List<AccountDTO>();
                string order = "ORDER BY sta.staffRole " + function;
                string where = null;

                if (!string.IsNullOrWhiteSpace(name))
                    where = "AND (sta.staffName LIKE N'%" + name + "%') ";

                string query = "SELECT acc.id,acc.staffID,acc.userName,acc.userPass "
                    + "FROM Account acc INNER JOIN Staff sta ON sta.id = acc.staffID "
                    + "where isDelete=0 " + where + order;

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    AccountDTO account = new AccountDTO(item);
                    accountList.Add(account);
                }
                return accountList;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<AccountDTO> GetAccountListByName(string name, string function)
        {
            try
            {
                List<AccountDTO> accountList = new List<AccountDTO>();
                string order = "ORDER BY sta.staffName " + function;
                string where = null;

                if (!string.IsNullOrWhiteSpace(name))
                    where = "AND (sta.staffName LIKE N'%" + name + "%') ";

                string query = "SELECT acc.id,acc.staffID,acc.userName,acc.userPass "
                    + "FROM Account acc INNER JOIN Staff sta ON sta.id = acc.staffID "
                    + "where isDelete=0 " + where + order;

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    AccountDTO account = new AccountDTO(item);
                    accountList.Add(account);
                }
                return accountList;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public int GetIDStaffByUserName(string username)
        {
            try
            {
                string query = "exec USP_GetIdByUserName @userName";
                int id = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { username });
                return id;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return -1;
            }
        }

        public bool InsertAccount(string userName)
        {
            try
            {
                int idStaff = (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Staff");
                string hasPass = HashPassword("A1234");
                string query = string.Format("INSERT dbo.Account( userName,userPass, staffID) VALUES ('{0}','{1}', {2})", userName, hasPass, idStaff);
                int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public bool ResetPassword(string userName)
        {
            try
            {
                string hasPass = HashPassword("A1234");
                string query = string.Format("UPDATE dbo.Account SET userPass = '{1}' where userName = '{0}'", userName, hasPass);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public int CheckUsernamelExist(string username)
        {
            try
            {
                string query = string.Format("SELECT * FROM Account where username = '{0}'", username);

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count > 0)
                {
                    AccountDTO account = new AccountDTO(data.Rows[0]);
                    return account.StaffID;
                }
                return -1;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return -1;
            }
        }
    }
}