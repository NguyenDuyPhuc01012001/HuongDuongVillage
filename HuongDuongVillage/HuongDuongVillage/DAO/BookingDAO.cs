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
            try
            {
                List<BookingDTO> listBooking = new List<BookingDTO>();
                string query = "SELECT b.id, b.roomID, b.cusID, b.dateCheckIn, b.dateCheckOut "
                    + "FROM Booking b INNER JOIN dbo.Room ON Room.id = b.roomID "
                    + "WHERE GETDATE() <= dateCheckOut AND roomStatus = 'Booked'";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    BookingDTO booking = new BookingDTO(item);
                    listBooking.Add(booking);
                }

                return listBooking;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<BookingDTO> GetListBookingByCheckIn(string searchRoomName, string function)
        {
            try
            {
                List<BookingDTO> listBooking = new List<BookingDTO>();
                string order = "ORDER BY dateCheckIn " + function;
                string where = null;

                if (!string.IsNullOrWhiteSpace(searchRoomName))
                    where = " AND (roomName LIKE '%" + searchRoomName + "%') ";

                string query = "select b.id, roomID, b.cusID, dateCheckIn, dateCheckOut "
                    + "FROM booking b inner join room on b.roomID=room.id "
                    + "where (GETDATE() <= dateCheckOut OR dateCheckOut = '') AND roomStatus = 'Booked' " + where + order;

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    BookingDTO booking = new BookingDTO(item);
                    listBooking.Add(booking);
                }

                return listBooking;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public List<BookingDTO> GetListBookingByCheckOut(string searchRoomName, string function)
        {
            try
            {
                List<BookingDTO> listBooking = new List<BookingDTO>();
                string order = "ORDER BY dateCheckOut " + function;
                string where = null;

                if (!string.IsNullOrWhiteSpace(searchRoomName))
                    where = " AND (roomName LIKE '%" + searchRoomName + "%') ";

                string query = "select b.id, roomID, b.cusID, dateCheckIn, dateCheckOut "
                    + "FROM booking b inner join room on b.roomID=room.id "
                    + "where (GETDATE() <= dateCheckOut OR dateCheckOut = '') AND roomStatus = 'Booked' " + where + order;

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    BookingDTO booking = new BookingDTO(item);
                    listBooking.Add(booking);
                }
                return listBooking;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public BookingDTO GetBookedByID(int id)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return null;
            }
        }

        public bool DeleteBooking(int idBook, int idRoom)
        {
            try
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
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public bool InsertBooking(int roomID, int cusID, DateTime dateCheckIn, DateTime dateCheckOut)
        {
            try
            {
                string query = "EXEC USP_InsertBooking @roomID , @cusID , @dateCheckIn , @dateCheckOut";
                int isInsert = DataProvider.Instance.ExecuteNonQuery(query, new object[] { roomID, cusID, dateCheckIn.ToString("yyyy-MM-dd"), dateCheckOut.ToString("yyyy-MM-dd") });
                return isInsert > 0;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }

        public void CheckBooking()
        {
            try
            {
                string query = "SELECT b.id, b.roomID, b.cusID, b.dateCheckIn, b.dateCheckOut "
                    + "FROM Booking b INNER JOIN dbo.Room ON Room.id = b.roomID "
                    + "WHERE roomStatus = 'Booked'"
                    + "AND b.dateCheckOut = (SELECT MAX(dateCheckOut) FROM Booking WHERE b.roomID  = Booking.roomID)";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    BookingDTO booking = new BookingDTO(item);
                    if (booking.DateCheckOut < DateTime.Now)
                    {
                        RoomDAO.Instance.UpdateRoomStatusByID(booking.RoomID);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }
    }
}