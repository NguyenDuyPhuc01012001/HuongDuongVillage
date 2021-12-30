using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    internal class PaymentDAO
    {
        private int currentMonth = DateTime.Now.Month;
        private int currentYear = DateTime.Now.Year;
        private static PaymentDAO instance;

        public static PaymentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PaymentDAO();
                return instance;
            }
            set { instance = value; }
        }

        public List<PaymentDTO> GetPayments()
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();
            string query = "select * from Payment";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PaymentDTO payment = new PaymentDTO(row);
                payments.Add(payment);
            }
            return payments;
        }

        public List<PaymentDTO> GetPaymentsByInput(string input)
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();
            string query;
            string where = null;
            if (!string.IsNullOrWhiteSpace(input))
            {
                where = string.Format("WHERE (amount like N'%{0}%') or (method like N'%{0}%') ", input);
            }
            query = "SELECT * FROM Payment " + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PaymentDTO payment = new PaymentDTO(item);
                payments.Add(payment);
            }
            return payments;
        }

        public float GetCurrentMonthProfit()
        {
            string query = "Select SUM(amount) FROM Payment where MONTH(paymentDate) =" + currentMonth;
            float profit = 0;
            if (DataProvider.Instance.ExecuteScalar(query) is DBNull)
                return 0;
            profit = (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar(query));
            return profit;
        }

        public float GetPreMonthProfit()
        {
            string query = "Select SUM(amount) FROM Payment where MONTH(paymentDate) =" + (currentMonth - 1);
            float profit = 0;
            if (DataProvider.Instance.ExecuteScalar(query) is DBNull)
                return 0;
            profit = (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar(query));
            return profit;
        }

        internal bool DeletePayment(int paymentID)
        {
            string query = "DELETE FROM Payment where id = " + paymentID;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        internal List<PaymentDTO> GetPaymentsByAmount(string input, string function)
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();
            string order = " ORDER BY amount " + function;
            string query;
            string where = null;
            if (!string.IsNullOrWhiteSpace(input))
            {
                where = string.Format(" WHERE (amount like N'%{0}%') or (method like N'%{0}%') ", input);
            }
            query = "SELECT * FROM Payment " + where + order;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PaymentDTO payment = new PaymentDTO(item);
                payments.Add(payment);
            }
            return payments;
        }

        internal List<PaymentDTO> GetPaymentsByDate(string input, string function)
        {
            List<PaymentDTO> payments = new List<PaymentDTO>();
            string order = " ORDER BY paymentDate " + function;
            string query;
            string where = null;
            if (!string.IsNullOrWhiteSpace(input))
            {
                where = string.Format(" WHERE (amount like N'%{0}%') or (method like N'%{0}%') ", input);
            }
            query = "SELECT * FROM Payment " + where + order;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PaymentDTO payment = new PaymentDTO(item);
                payments.Add(payment);
            }
            return payments;
        }

        public float GetPercentageBetweenCurrentAndPreProfit()
        {
            float currentProfit = GetCurrentMonthProfit();
            float preProfit = GetPreMonthProfit();
            if (preProfit == 0)
                return 100;
            else
            {
                float percetage = (float)100 * (currentProfit / preProfit);
                return (float)Math.Round(percetage, 2);
            }
        }

        public float GetPercentageBetweenSelectedAndPreProfit(int month, int year)
        {
            float currentProfit = GetMonthProfit(month, year);
            float preProfit = 0;
            if (month == 1)
            {
                preProfit = GetMonthProfit(12, year - 1);
            }
            else
            {
                preProfit = GetMonthProfit(month - 1, year);
            }
            if (preProfit == 0)
            {
                return 100;
            }
            if (currentProfit == 0)
            {
                return 0;
            }
            else
            {
                float percentage = (float)100 * (currentProfit / preProfit);
                return (float)Math.Round(percentage, 2);
            }
        }

        public float GetMonthProfit(int month, int year)
        {
            string query = "Select SUM(amount) FROM Payment where MONTH(paymentDate) = " + month + " And YEAR(paymentDate) = " + year;
            float profit = 0;
            if (DataProvider.Instance.ExecuteScalar(query) is DBNull)
                return 0;
            profit = (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar(query));

            return profit;
        }

        public List<PaymentDTO> GetYearProfit()
        {
            List<PaymentDTO> monthlyPayment = new List<PaymentDTO>();
            string query = "SELECT * FROM Payment";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PaymentDTO payment = new PaymentDTO(row);
                monthlyPayment.Add(payment);
            }
            return monthlyPayment;
        }

        public List<float> GetSelectedYearProfit(int year)
        {
            List<float> yearProfit = new List<float>();
            for (int i = 1; i < 13; i++)
            {
                float monthProfit = GetMonthProfit(i, year);
                yearProfit.Add(monthProfit);
            }
            return yearProfit;
        }

        public bool InsertPayment(int cusID, float amount, DateTime date, string method)
        {
            string query = string.Format("SET DATEFORMAT DMY; INSERT INTO dbo.Payment(cusID,amount,paymentDate,method) "
               + "values('{0}','{1}','{2}','{3}')", cusID, amount.ToString(), date.ToString("dd/MM/yyyy"), method);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}