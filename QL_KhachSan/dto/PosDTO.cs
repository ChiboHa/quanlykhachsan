using System;
using System.Data;

namespace QL_KhachSan.DTOs
{
    public class PosDTO
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int FoodCode { get; set; }
        public string FoodName { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

        // Public constructor
        public PosDTO() { }

        public PosDTO(int id, int BillID, int foodCode, string foodName, int cost, int quantity, int totalPrice)
        {
            this.ID = id;
            this.BillID = BillID;
            this.FoodCode = foodCode;
            this.FoodName = foodName;
            this.Cost = cost;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;

        }
        public PosDTO(DataRow item)
        {
            this.ID = Convert.ToInt32(item["ID"]);
            this.BillID = Convert.ToInt32(item["BillID"]);
            this.FoodCode = Convert.ToInt32(item["foodcode"]);
            this.FoodName = item["foodname"].ToString();
            this.Cost = Convert.ToInt32(item["cost"]);
            this.Quantity = Convert.ToInt32(item["qty"]);
            this.TotalPrice = Convert.ToInt32(item["totalprice"]);
        }
    }
}
