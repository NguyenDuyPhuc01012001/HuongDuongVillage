using System;
using System.Data;
using System.Data.SqlClient;

namespace HuongDuongVillage.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        //private static IConfiguration config = new ConfigurationBuilder()
        //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //    .AddJsonFile("appsettings.json")
        //    .AddUserSecrets<DataProvider>()
        //    .Build();
        //string ConnectionString = config.GetConnectionString("ConnectionString");

        private string ConnectionString = @"Server=tcp:hdvillage.database.windows.net,1433;Initial Catalog=HD;Persist Security Info=False;User ID=freeuser;Password=A12345678*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DataProvider()
        { }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }
            private set => instance = value;
        }

        //trả về trường dữ liệu được thực thi (Select)
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        //Trả về số trường dữ liệu được thực thi (insert,update,delete)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                int data = 0;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();

                    connection.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show("Error", ex.Message);
                return -1;
            }
        }

        //Trả về giá trị trong ô đầu tiên (VD: count(*))
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}