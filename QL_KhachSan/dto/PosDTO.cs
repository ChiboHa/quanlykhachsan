using System;
using System.Data;

namespace QL_KhachSan.DTOs
{
    public class PosDTO
    {
        public int ID { get; set; }
        public int IdKhachHang { get; set; }
        public DateTime TransDate { get; set; }
        public string TransMonth { get; set; }
        public int FoodCode { get; set; }
        public string FoodName { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int GrandTotal { get; set; }

        // Public constructor
        public PosDTO() { }

        public PosDTO(int id, int idKhachHang, DateTime transDate, string transMonth, int foodCode, string foodName, int cost, int quantity, int totalPrice, int grandTotal)
        {
            this.ID = id;
            this.IdKhachHang = idKhachHang;
            this.TransDate = transDate;
            this.TransMonth = transMonth;
            this.FoodCode = foodCode;
            this.FoodName = foodName;
            this.Cost = cost;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;
            this.GrandTotal = grandTotal;
        }
        public PosDTO(DataRow item)
        {
           this.ID = Convert.ToInt32(item["ID"]);
           this.IdKhachHang = Convert.ToInt32(item["idkh"]);
           this.TransDate = Convert.ToDateTime(item["transdate"]);
           this.TransMonth = item["transmonth"].ToString();
            this.FoodCode = Convert.ToInt32(item["foodcode"]);
            this.FoodName = item["foodname"].ToString();
            this.Cost = Convert.ToInt32(item["cost"]);
            this.Quantity = Convert.ToInt32(item["qty"]);
            this.TotalPrice = Convert.ToInt32(item["totalprice"]);
           this.GrandTotal = Convert.ToInt32(item["grandtotal"]);
        }
    }
}
