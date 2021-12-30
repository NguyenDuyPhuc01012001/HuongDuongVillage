using HuongDuongVillage.DTO;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    public class ReportDAO
    {
        private static ReportDAO instance;

        public static ReportDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReportDAO();
                return instance;
            }
            private set => instance = value;
        }

        private ReportDAO()
        { }

        public List<ReportDTO> GetListReport()
        {
            List<ReportDTO> listReport = new List<ReportDTO>();

            string query = "SELECT * FROM Report ORDER BY id desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ReportDTO report = new ReportDTO(item);
                listReport.Add(report);
            }

            return listReport;
        }

        public List<ReportDTO> GetListReportByID(int staffID)
        {
            List<ReportDTO> listReport = new List<ReportDTO>();

            string query = "SELECT * FROM Report WHERE staffID = " + staffID + " ORDER BY id desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ReportDTO report = new ReportDTO(item);
                listReport.Add(report);
            }

            return listReport;
        }

        public List<ReportDTO> GetListReportByInput(string input)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query;
            string where = null;
            if (!string.IsNullOrWhiteSpace(input))
            {
                where = string.Format("WHERE (message like N'%{0}%') or (document like N'%{0}%') ", input);
            }
            query = "SELECT * FROM Report " + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ReportDTO report = new ReportDTO(item);
                reports.Add(report);
            }
            return reports;
        }

        internal List<ReportDTO> GetListReportByStaffAndInput(int staffID, string input)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query;
            string where = "WHERE staffID = " + staffID.ToString();
            string where1 = null;
            if (!string.IsNullOrWhiteSpace(input))
            {
                where1 = string.Format(" AND (message like N'%{0}%' or document like N'%{0}%') ", input);
            }
            where += where1;
            query = "SELECT * FROM Report " + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ReportDTO report = new ReportDTO(item);
                reports.Add(report);
            }
            return reports;
        }

        public ReportDTO GetReportById(int id)
        {
            string query = "SELECT * FROM Report WHERE id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                ReportDTO report = new ReportDTO(data.Rows[0]);
                return report;
            }
            return null;
        }

        public bool InsertDocument(int idStaff, string message, string document)
        {
            string query = string.Format(
                "INSERT INTO dbo.Report(staffID, message, document) "
                + "values({0},'{1}','{2}')", idStaff, message, document);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool EditDocument(int idReport, string message, string document)
        {
            string query = string.Format(
                "UPDATE dbo.Report "
                + "SET message = '{0}', document = '{1}' "
                + "WHERE id = {2}", message, document, idReport);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDocument(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Delete FROM Report WHERE id = " + id);

            return result > 0;
        }
    }
}