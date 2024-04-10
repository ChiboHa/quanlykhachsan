using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DTO
{
    public class BillFood
    {
        public int ID { get; set; }
        public string IdKhachHang { get; set; }
        public DateTime TransDate { get; set; }
        public string TransMonth { get; set; }
        public int GrandTotal { get; set; }
        public string TrangThai { get; set; }
        // Public constructor
        public BillFood() { }

        public BillFood(int id, string idKhachHang, DateTime transDate, string transMonth, int grandTotal, string trangThai)
        {
            this.ID = id;
            this.IdKhachHang = idKhachHang;
            
            this.TransDate = transDate;
            this.TransMonth = transMonth;
            this.GrandTotal = grandTotal;
            this.TrangThai = trangThai;
        }
        public BillFood(DataRow item)
        {
            this.ID = Convert.ToInt32(item["ID"]);
            this.IdKhachHang = item["idkh"].ToString();
            this.TransDate = Convert.ToDateTime(item["transdate"]);
            this.TransMonth = item["transmonth"].ToString();
            this.GrandTotal = Convert.ToInt32(item["grandtotal"]);
            this.TrangThai = item["trangthai"].ToString();
        }
    }
}
