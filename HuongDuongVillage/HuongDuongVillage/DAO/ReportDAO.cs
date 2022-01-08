using HuongDuongVillage.DTO;
using System;
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
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<ReportDTO> GetListReportByID(int staffID)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<ReportDTO> GetListReportByInput(string input)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<ReportDTO> GetListReportByStaffAndInput(int staffID, string input)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public ReportDTO GetReportById(int id)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public bool InsertDocument(int idStaff, string message, string document)
        {
            try
            {
                string query = string.Format(
                    "INSERT INTO dbo.Report(staffID, message, document) "
                    + "values({0},'{1}','{2}')", idStaff, message, document);
                int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditDocument(int idReport, string message, string document)
        {
            try
            {
                string query = string.Format(
                    "UPDATE dbo.Report "
                    + "SET message = '{0}', document = '{1}' "
                    + "WHERE id = {2}", message, document, idReport);
                int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteDocument(int id)
        {
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("Delete FROM Report WHERE id = " + id);

                return result > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }
    }
}