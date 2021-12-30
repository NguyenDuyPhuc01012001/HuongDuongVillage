using HuongDuongVillage.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HuongDuongVillage.DAO
{
    public class BookingDAO
    {
        private static BookingDAO instance;

        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BookingDAO()
        { }

        public List<BookingDTO> GetListBooking()
        {
            List<BookingDTO> listBooking = new List<BookingDTO>();
            string query = "select * from booking where GETDATE() <= dateCheckOut";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BookingDTO booking = new BookingDTO(item);
                listBooking.Add(booking);
            }

            return listBooking;
        }

        public List<BookingDTO> GetListBookingByCheckIn(string searchRoomName, string function)
        {
            List<BookingDTO> listBooking = new List<BookingDTO>();
            string order = "ORDER BY dateCheckIn " + function;
            string where = null;

            if (!string.IsNullOrWhiteSpace(searchRoomName))
                where = " AND (roomName LIKE '%" + searchRoomName + "%') ";

            string query = "select b.id, roomID, b.cusIDcard, dateCheckIn, dateCheckOut "
                + "FROM booking b inner join room on b.roomID=room.id "
                + "where (GETDATE() <= dateCheckOut OR dateCheckOut = '') " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BookingDTO booking = new BookingDTO(item);
                listBooking.Add(booking);
            }

            return listBooking;
        }

        public List<BookingDTO> GetListBookingByCheckOut(string searchRoomName, string function)
        {
            List<BookingDTO> listBooking = new List<BookingDTO>();
            string order = "ORDER BY dateCheckOut " + function;
            string where = null;

            if (!string.IsNullOrWhiteSpace(searchRoomName))
                where = " AND (roomName LIKE '%" + searchRoomName + "%') ";

            string query = "select b.id, roomID, b.cusIDcard, dateCheckIn, dateCheckOut "
                + "FROM booking b inner join room on b.roomID=room.id "
                + "where (GETDATE() <= dateCheckOut OR dateCheckOut = '') " + where + order;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BookingDTO booking = new BookingDTO(item);
                listBooking.Add(booking);
            }
            return listBooking;
        }

        public BookingDTO GetBookedByID(int id)
        {
            string query = "select * from booking where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                BookingDTO booking = new BookingDTO(data.Rows[0]);
                return booking;
            }

            return null;
        }

        public bool DeleteBooking(int idBook, int idRoom)
        {
            int isChangeStatus = DataProvider.Instance.ExecuteNonQuery("UPDATE Room SET roomStatus = 'Available' WHERE id = " + idRoom);
            if (isChangeStatus > 0)
            {
                int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Booking WHERE id = " + idBook);

                return result > 0;
            }
            else
                return false;
        }

        public bool InsertBooking(int roomID, int cusID, DateTime dateCheckIn, DateTime dateCheckOut)
        {
            string query = "EXEC USP_InsertBooking @roomID, @cusID, @dateCheckIn, @dateCheckOut";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { roomID, cusID, dateCheckIn.ToString("yyyy-MM-dd"), dateCheckOut.ToString("yyyy-MM-dd") });
            return result.Rows.Count > 0;
        }
    }
}