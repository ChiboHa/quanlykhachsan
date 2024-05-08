using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DTO
{
    public class Rooms
    {
        public Rooms(int id, string roomNo, string roomType, string bedType, int price, string booked)
        {
            this.ID = id;
            this.roomNo = roomNo;
            this.roomType = roomType;
            this.bedType = bedType;
            this.price = price;
            this.booked = booked;
        }

        public Rooms(DataRow row)
        {
            this.iD = (int)row["id"];
            this.roomNo = row["roomNo"].ToString();
            this.roomType = row["roomType"].ToString();
            this.bedType = row["bedType"].ToString();
            this.price = (int)row["price"];
            this.booked = row["booked"].ToString();
        }

        public Rooms(string roomNo)
        {
            this.roomNo = roomNo;
        }

        private string booked;
        private int price;
        private string bedType;
        private string roomType;
        private string roomNo;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string RoomNo { get => roomNo; set => roomNo = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string BedType { get => bedType; set => bedType = value; }
        public int Price { get => price; set => price = value; }
        public string Booked { get => booked; set => booked = value; }
    }
}
