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
    internal class Rooms_DAO
    {
        private static Rooms_DAO instance;

        internal static Rooms_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Rooms_DAO();
                return instance;
            }
            private set => instance = value;
        }

        public static int RoomWidth = 100;
        public static int RoomHeight = 50;

        private Rooms_DAO() { }

        public List<DTO.Rooms> LoadRoomsList()
        {
            List<Rooms> roomlist = new List<DTO.Rooms>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Rooms");

            foreach (DataRow item in data.Rows)
            {
                Rooms rooms = new Rooms(item);
                roomlist.Add(rooms);
            }

            return roomlist;
        }
        public void AddRoom(Rooms newRoom)
        {
            string query = "insert into Rooms (roomNo, roomType, bedType, price) VALUES ( @roomNo , @roomType , @bedType , @price )";
            object[] parameters = { newRoom.RoomNo, newRoom.RoomType, newRoom.BedType, newRoom.Price };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm phòng thành công!");
            }
            else
            {
                MessageBox.Show("Thêm phòng không thành công!");
            }
        }
        public void DeleteRoom(Rooms room)
        {
            string query = "DELETE FROM Rooms WHERE roomNo = @RoomNo";
            object[] parameters = { room.RoomNo };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa phòng thành công!");
            }
            else
            {
                MessageBox.Show("Xóa phòng không thành công!");
            }
        }
        public void UpdateRoom(Rooms room)
        {
            string query = "UPDATE Rooms SET roomType = @RoomType , bedType = @BedType , price = @Price , booked = @Booked WHERE roomNo = @RoomNo";
            object[] parameters = { room.RoomType, room.BedType, room.Price, room.Booked, room.RoomNo };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thông tin phòng thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin phòng không thành công!");
            }
        }

        public List<String> getRoomNo(String RoomType, String BedType)
        {
            List<String> result = new List<String>();
            object[] parameters = { RoomType, BedType };

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT roomNo FROM Rooms WHERE roomType = @roomType AND bedType = @bedType", parameters);

            foreach (DataRow item in data.Rows)
            {
                result.Add(item["roomNo"].ToString());
            }

            return result;
        }

    }
}
