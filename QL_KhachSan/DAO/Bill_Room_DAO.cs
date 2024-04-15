using QL_KhachSan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_KhachSan.DAO
{
    internal class Bill_Room_DAO
    {
        private static Bill_Room_DAO instance;
        public static Bill_Room_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Bill_Room_DAO();
                return instance;
            }
            private set => instance = value;
        }
        private Bill_Room_DAO() { }
        public List<BillRoom> GetBillRoomsByStatus0()
        {
            List<BillRoom> billRooms = new List<BillRoom>();

            string query = "SELECT ID, room_No, customer_id, date_check_in, date_check_out FROM BillRoom WHERE status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillRoom billRoom = new BillRoom(item);
                billRooms.Add(billRoom);
            }

            return billRooms;
        }
        public bool UpdateStatus(int ID)
        {
            string query = "UPDATE BillRoom SET status = 1 WHERE ID = @ID";

            // Sử dụng DataProvider để thực hiện câu lệnh SQL
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });

            // Kiểm tra xem có hàng nào bị ảnh hưởng (cập nhật thành công) hay không
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*public bool InsertBillRoom(String room_ID, String customer_id)
        {
            string query = "INSERT INTO BillRoom(room_ID,customer_id,status) VALUES( @room_ID , @customer_id , '0' )";
            return (DataProvider.Instance.ExecuteNonQuery(query, new object[] { room_ID, customer_id })) > 0;
        }*/
        public bool InsertBillRoom(string roomID, string customerID, DateTime checkInDate, DateTime checkOutDate)
        {
            string query = "INSERT INTO BillRoom (room_ID, customer_id, date_check_in, date_check_out,status) VALUES (@roomID, @customerID, @checkInDate, @checkOutDate, '0' )";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@checkInDate", checkInDate);
                    command.Parameters.AddWithValue("@checkOutDate", checkOutDate);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting room bill: " + ex.Message);
                return false;
            }
        }




        /*public DataTable GetBillRoomsWithStatus()
        {
            List<BillRoom> billRooms = new List<BillRoom>();
            string query = "SELECT BillRoom.ID, BillRoom.customer_id as 'Mã khách hàng', Customer.name as 'Họ tên', Customer.cccd as 'Căn cước', Rooms.roomNo as 'Số phòng', Rooms.roomType as 'Loại phòng', BillRoom.date_check_in as 'Ngày checkin' "
                + "FROM BillRoom INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id "
                + "INNER JOIN Customer ON BillRoom.customer_id = Customer.ID "
                + "WHERE BillRoom.status=0";
            return DataProvider.Instance.ExecuteQuery(query);
        }*/

        public DataTable GetBillRoomsWithStatus()
        {
            List<BillRoom> billRooms = new List<BillRoom>();
            string query = "SELECT BillRoom.ID, BillRoom.customer_id as 'Mã khách hàng', Customer.name as 'Họ tên', Customer.cccd as 'Căn cước', Rooms.roomNo as 'Số phòng', Rooms.roomType as 'Loại phòng', BillRoom.date_check_in as 'Ngày checkin', BillRoom.date_check_out as 'Ngày checkout' "
                + "FROM BillRoom INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id "
                + "INNER JOIN Customer ON BillRoom.customer_id = Customer.ID "
                + "WHERE BillRoom.status=0";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllBillRooms()
        {
            string query = @"
        SELECT 
            Customer.ID as 'Số điện thoại', 
            Customer.name as 'Họ và tên', 
            Customer.CCCD as 'Căn cước công dân', 
            Rooms.roomNo as 'Số phòng', 
            BillRoom.date_check_in as 'Check In', 
            BillRoom.date_check_out as 'Check Out' 
        FROM 
            BillRoom 
        INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id 
        INNER JOIN Customer ON BillRoom.customer_id = Customer.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllBillRoomsInside()
        {
            string query = @"
        SELECT 
            Customer.ID as 'Số điện thoại', 
            Customer.name as 'Họ và tên', 
            Customer.CCCD as 'Căn cước công dân', 
            Rooms.roomNo as 'Số phòng', 
            BillRoom.date_check_in as 'Check In', 
            BillRoom.date_check_out as 'Check Out' 
        FROM 
            BillRoom 
        INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id 
        INNER JOIN Customer ON BillRoom.customer_id = Customer.ID 
        WHERE BillRoom.status = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllBillRoomsOutside()
        {
            string query = @"
        SELECT 
            Customer.ID as 'Số điện thoại', 
            Customer.name as 'Họ và tên', 
            Customer.CCCD as 'Căn cước công dân', 
            Rooms.roomNo as 'Số phòng', 
            BillRoom.date_check_in as 'Check In', 
            BillRoom.date_check_out as 'Check Out' 
        FROM 
            BillRoom 
        INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id 
        INNER JOIN Customer ON BillRoom.customer_id = Customer.ID 
        WHERE BillRoom.status = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /*public bool checkOut(String id)
        {
            string query = "UPDATE BillRoom SET date_check_out = GETDATE() ,status = 1 WHERE id = @id ";
            return (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id })) > 0;
        }*/

        public bool checkOut(String id)
        {
            string query = "UPDATE BillRoom SET status = 1 WHERE id = @id ";
            return (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id })) > 0;
        }

        public string GetRoomID(String id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT room_id FROM BillRoom WHERE id = " + id);
            return data.Rows[0][0] + "";
        }

        public String getTotalHours(String id)
        {
            id = "1";
            string query = "SELECT DATEDIFF(HOUR, date_check_in, date_check_out) AS TotalHours FROM BillRoom WHERE id = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return data.Rows[0][0] + "";
        }

        public DataTable searchBillRooms(String name)
        {
            List<BillRoom> billRooms = new List<BillRoom>();
            string query = "SELECT BillRoom.ID as 'Mã HĐ Phòng', BillRoom.customer_id as 'Mã khách hàng', Customer.name as 'Họ tên', Customer.cccd as 'Căn cước', Rooms.roomNo as 'Số phòng', BillRoom.date_check_in as 'Ngày checkin', BillRoom.date_check_out as 'Check Out'  "
                + "FROM BillRoom INNER JOIN Rooms ON BillRoom.room_ID = Rooms.id "
                + "INNER JOIN Customer ON BillRoom.customer_id = Customer.ID "
                + "WHERE BillRoom.status=0 AND (Customer.name LIKE '%" + name + "%' OR Customer.cccd LIKE '%" + name + "%')";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string getTotalDays(String id)
        {
            string query = "SELECT DATEDIFF(DAY, date_check_in, date_check_out) + 1 AS TotalDays FROM BillRoom WHERE ID = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["TotalDays"].ToString();
            }
            return "0";
        }


    }
}
