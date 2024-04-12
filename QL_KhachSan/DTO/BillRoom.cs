using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DTO
{
    internal class BillRoom
    {
        public BillRoom(int ID, string roomNo, string customer_id, DateTime date_check_in, DateTime date_check_out, int status)
        {
            this.iD = ID;
            this.roomNo = roomNo;
            this.Customer_id = customer_id;
            this.Date_check_in = date_check_in;
            this.Date_check_out = date_check_out;
            //this.Status = status;
        }
        public BillRoom(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.roomNo = (string)row["roomNo"];
            this.customer_id = (string)row["customer_id"];
            this.Date_check_in = (DateTime)row["date_check_in"];
            this.Date_check_out = (DateTime)row["date_check_out"];
            //this.Status = (int)row["status"];
        }
        private int iD;
        private string roomNo;
        private string customer_id;
        private DateTime date_check_in;
        private DateTime date_check_out;
        //private int status;

        public int ID { get => iD; set => iD = value; }
        public string Room_No { get => roomNo; set => roomNo = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }
        public DateTime Date_check_in { get => date_check_in; set => date_check_in = value; }
        public DateTime Date_check_out { get => date_check_out; set => date_check_out = value; }
        //public int Status { get => status; set => status = value; }
    }
}
