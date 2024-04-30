using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

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


        /*public decimal GetTotalRoomRevenue()
        {
            string query = @"SELECT SUM(ISNULL(Total, 0)) AS TotalRevenue 
            FROM (SELECT BillRoom.ID, (DATEDIFF(DAY, date_check_in, date_check_out) + 1) * ISNULL(Rooms.price, 0) AS Total 
            FROM BillRoom
            INNER JOIN Rooms ON BillRoom.room_ID = Rooms.ID
            WHERE BillRoom.status = '1'
            ) AS RevenueData";
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
        }*/
        public decimal GetTotalRoomRevenue()
        {
            string query = "SELECT SUM(ISNULL(GrandToTal, 0)) AS TotalRevenue FROM BillRoom WHERE status = '1'";
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


        //Tổng doanh thu phòng và món ăn từ trước đến nay
        public decimal GetTotalRevenue()
        {
            return GetTotalFoodRevenue() + GetTotalRoomRevenue();
        }

        public DataTable GetTop5BestSellingFood()
        {
            string query = @"
            SELECT TOP(5) f.Ten AS FoodName, SUM(p.qty) AS TotalSold
            FROM Food f
            INNER JOIN Pos p ON f.ID = p.foodcode
            GROUP BY f.Ten
            ORDER BY TotalSold DESC;
            ";

            return DataProvider.Instance.ExecuteQuery(query);
        }



        public DataTable GetTop5BestSellingFood(string date)
        {
            // Chỉ trích xuất phần ngày từ chuỗi ngày giờ
            DateTime parsedDate;
            if (!DateTime.TryParse(date, out parsedDate))
            {
                // Xử lý trường hợp không thể chuyển đổi chuỗi ngày thành kiểu DateTime
                Console.WriteLine("Invalid date format!");
                return null;
            }

            // Chỉ sử dụng phần ngày trong parsedDate
            string dateString = parsedDate.ToString("yyyy-MM-dd");

            string query = @"
        SELECT TOP(5) f.Ten AS FoodName, SUM(p.qty) AS TotalSold
        FROM Food f
        INNER JOIN Pos p ON f.ID = p.foodcode
        INNER JOIN BillFood bf ON bf.ID = p.BillID
        WHERE CONVERT(date, bf.transdate) = @date
        GROUP BY f.Ten
        ORDER BY TotalSold DESC;
    ";

            // Trước khi thực hiện truy vấn
            Console.WriteLine($"Query: {query}, Date: {dateString}");

            DataTable top5FoodData = null;

            try
            {
                // Thực hiện truy vấn
                top5FoodData = DataProvider.Instance.ExecuteQuery(query, new object[] { dateString });

                // Sau khi thực hiện truy vấn
                Console.WriteLine($"Rows returned: {top5FoodData.Rows.Count}");
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ và ghi log thông tin về chúng
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return top5FoodData;
        }

        // Lấy top 5 món ăn bán chạy nhất trong ngày
        public DataTable GetTop5BestSellingFoodToday(string date)
        {
            string query =
    @"SELECT TOP(5) f.Ten AS FoodName, SUM(p.qty) AS TotalSold
    FROM Food f
    INNER JOIN Pos p ON f.ID = p.foodcode
    INNER JOIN BillFood bf ON bf.ID = p.BillID
    WHERE CONVERT(date, bf.transdate) = '" + date + "' GROUP BY f.Ten ORDER BY TotalSold DESC";
            // Trước khi thực hiện truy vấn
            Console.WriteLine($"Query: {query}, Date: {date}");

            DataTable top5FoodData = null;

            try
            {
                // Thực hiện truy vấn
                top5FoodData = DataProvider.Instance.ExecuteQuery(query);

                // Sau khi thực hiện truy vấn
                Console.WriteLine($"Rows returned: {top5FoodData.Rows.Count}");
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ và ghi log thông tin về chúng
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return top5FoodData;
        }

    }
}
