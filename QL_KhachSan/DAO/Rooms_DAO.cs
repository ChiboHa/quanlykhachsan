using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

        /*public List<Rooms> getRooms(String RoomType, String BedType)
        {
            List<Rooms> result = new List<Rooms>();
            object[] parameters = { RoomType, BedType };

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Rooms WHERE roomType = @roomType AND bedType = @bedType AND booked = 'NO'", parameters);

            foreach (DataRow item in data.Rows)
            {
                Rooms room = new Rooms(Convert.ToInt32(item["ID"]), item["roomNo"].ToString(), item["roomType"].ToString(), item["bedType"].ToString(), Convert.ToInt32(item["price"]), item["booked"].ToString());
                result.Add(room);
            }

            return result;
        }*/

        public List<Rooms> getRooms(string roomType, string bedType)
        {
            List<Rooms> rooms = new List<Rooms>();
            string query = "SELECT * FROM Rooms WHERE roomType = @roomType AND bedType = @bedType AND booked = 'NO'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { roomType, bedType });
            foreach (DataRow item in data.Rows)
            {
                Rooms room = new Rooms(item);
                rooms.Add(room);
            }
            return rooms;
        }


        public bool setBooked(String status, String id)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE Rooms SET booked = @booked WHERE id = @id ", new object[] { status, id }) > 0;
        }

        public double GetPrice(String id)
        {
            string query = "SELECT price FROM Rooms WHERE id = @id";
            return Convert.ToDouble(DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows[0][0].ToString());
        }

    }
}
