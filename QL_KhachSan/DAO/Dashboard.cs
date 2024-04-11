using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DAO
{
    public class Dashboard
    {
        private static Dashboard instance;

        public static Dashboard Instance
        {
            get
            {
                if (instance == null) instance = new Dashboard();
                return instance;
            }
            private set => instance = value;
        }

        public Dashboard() { }

        //Tổng khách hàng
        public int GetTotalCustomers()
        {
            string query = "SELECT COUNT(*) FROM Customer";
            int totalCustomers = (int)DataProvider.Instance.ExecuteScalar(query);
            return totalCustomers;
        }


        //Tổng bill food từ trước đến nay
        public decimal GetTotalFoodRevenue()
        {
            string query = "SELECT SUM(ISNULL(GrandToTal, 0)) AS TotalRevenue FROM BillFood";
            object result = DataProvider.Instance.ExecuteScalar(query);

            // Kiểm tra xem kết quả có phải là NULL không
            if (result != DBNull.Value)
            {
                // Ép kiểu kết quả sang decimal và trả về
                return Convert.ToDecimal(result);
            }
            else
            {
                // Trả về 0 nếu kết quả là NULL
                return 0;
            }
        }


        public decimal GetTotalRoomRevenue()
        {
            string query = @"SELECT SUM(ISNULL(Total, 0)) AS TotalRevenue 
            FROM (SELECT BillRoom.ID, (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * ISNULL(Rooms.price, 0) AS Total 
            FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID) AS RevenueData";
            object result = DataProvider.Instance.ExecuteScalar(query);

            // Kiểm tra xem kết quả có phải là NULL không
            if (result != DBNull.Value)
            {
                // Ép kiểu kết quả sang decimal và trả về
                return Convert.ToDecimal(result);
            }
            else
            {
                // Trả về 0 nếu kết quả là NULL
                return 0;
            }
        }

        //Tổng bill food hôm nay
        public decimal GetTotalFoodRevenueToday()
        {
            DateTime today = DateTime.Today;
            string query = @"SELECT SUM(GrandToTal) AS TotalRevenue FROM BillFood WHERE transdate = @date";
            decimal totalRevenue = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { today });
            return totalRevenue;
        }

        //Tổng doanh thu phòng và món ăn từ trước đến nay
        public decimal GetTotalRevenue()
        {
            return GetTotalFoodRevenue() + GetTotalRoomRevenue();
        }

        //Tổng bill room hôm nay theo số ngày thuê trả hôm nay
        public decimal GetTotalRoomRevenueToday()
        {
            DateTime today = DateTime.Today;
            string query = @"SELECT SUM(Total) AS TotalRevenue 
            FROM (SELECT BillRoom.ID, (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * Rooms.price AS Total FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID
            WHERE date_check_in = @date) AS RevenueData";
            decimal totalRevenue = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { today });
            return totalRevenue;
        }

        //Top 5 food bán chạy nhất hôm nay
        public List<KeyValuePair<string, int>> GetTop5MostOrderedFoodsToday()
        {
            DateTime today = DateTime.Today;
            string query = @"SELECT TOP 5 Food.Ten AS FoodName, SUM(Pos.qty) AS TotalQuantity
            FROM Pos
            INNER JOIN Food ON Pos.foodcode = Food.ID
            INNER JOIN BillFood ON BillFood.ID = Pos.BillID 
            WHERE BillFood.transdate = @date
            GROUP BY Food.Ten
            ORDER BY TotalQuantity DESC";
            List<KeyValuePair<string, int>> topFoods = new List<KeyValuePair<string, int>>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { today });
            foreach (DataRow row in data.Rows)
            {
                topFoods.Add(new KeyValuePair<string, int>(row["FoodName"].ToString(), (int)row["TotalQuantity"]));
            }
            return topFoods;
        }

        //Top 5 food bán chạy nhất từ trước đến nay
        public List<KeyValuePair<string, int>> GetTop5MostOrderedFoods()
        {
            string query = @"SELECT TOP 5 Food.Ten AS FoodName, SUM(Pos.qty) AS TotalQuantity
            FROM Pos
            INNER JOIN Food ON Pos.foodcode = Food.ID
            GROUP BY Food.Ten
            ORDER BY TotalQuantity DESC";
            List<KeyValuePair<string, int>> topFoods = new List<KeyValuePair<string, int>>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                topFoods.Add(new KeyValuePair<string, int>(row["FoodName"].ToString(), (int)row["TotalQuantity"]));
            }
            return topFoods;
        }

        //Tổng doanh thu gộp từ hóa đơn món ăn + hóa đơn phòng hôm nay
        public decimal GetTotalRevenueToday()
        {
            return GetTotalFoodRevenueToday() + GetTotalRoomRevenueToday();
        }

        //Tổng doanh thu gộp từ hóa đơn món ăn + hóa đơn phòng 30 ngày trước
        public decimal GetTotalRevenueLast30Days()
        {
            DateTime today = DateTime.Today;
            DateTime thirtyDaysAgo = today.AddDays(-30);
            string query = @"SELECT SUM(GrandToTal) AS TotalFoodRevenue
            FROM BillFood
            WHERE transdate BETWEEN @startDate AND @endDate
  
            UNION ALL
  
            SELECT SUM(Total) AS TotalRoomRevenue
            FROM (
                SELECT BillRoom.ID, 
                    (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * Rooms.price AS Total
            FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID
            WHERE date_check_in BETWEEN @startDate AND @endDate
            ) AS RevenueData";
            decimal totalRevenue = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { thirtyDaysAgo, today });
            return totalRevenue;
        }

        //Tổng doanh thu gộp từ hóa đơn món ăn + hóa đơn phòng 7 ngày trước
        public decimal GetTotalRevenueLast7Days()
        {
            DateTime today = DateTime.Today;
            DateTime sevenDaysAgo = today.AddDays(-7);
            string query = @"
            SELECT SUM(GrandToTal) AS TotalFoodRevenue
            FROM BillFood
            WHERE transdate BETWEEN @startDate AND @endDate
  
            UNION ALL
  
            SELECT SUM(Total) AS TotalRoomRevenue
            FROM (
            SELECT BillRoom.ID, 
                    (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * Rooms.price AS Total
            FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID
            WHERE date_check_in BETWEEN @startDate AND @endDate
            ) AS RevenueData";
            decimal totalRevenue = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { sevenDaysAgo, today });
            return totalRevenue;
        }

        //Tổng doanh thu gộp từ hóa đơn món ăn + hóa đơn phòng năm nay
        public decimal GetTotalRevenueThisYear()
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);
            string query = @"
            SELECT SUM(GrandToTal) AS TotalFoodRevenue
            FROM BillFood
            WHERE transdate BETWEEN @startDate AND @endDate
  
            UNION ALL
  
            SELECT SUM(Total) AS TotalRoomRevenue
            FROM (
            SELECT BillRoom.ID, 
                    (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * Rooms.price AS Total
            FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID
            WHERE date_check_in BETWEEN @startDate AND @endDate
            ) AS RevenueData";
            decimal totalRevenue = (decimal)DataProvider.Instance.ExecuteScalar(query, new object[] { firstDayOfYear, today });
            return totalRevenue;
        }
    }
}
