using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string query = "SELECT br.ID, r.roomNo, br.customer_id, br.date_check_in, br.date_check_out\r\nFROM BillRoom br\r\nINNER JOIN Rooms r ON br.room_ID = r.id\r\nWHERE br.status = 0;";
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

    }
}
