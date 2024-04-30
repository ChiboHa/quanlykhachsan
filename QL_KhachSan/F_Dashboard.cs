using QL_KhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_KhachSan
{
    public partial class F_Dashboard : Form
    {
        private Dashboard _dashboard = new Dashboard();
        private Timer _refreshTimer;

        public F_Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            LoadTop5BestSellingFood();

            // Initialize and start the timer
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 5000; // Refresh every 5 seconds (5000 milliseconds)
            _refreshTimer.Tick += _refreshTimer_Tick;
            _refreshTimer.Start();

            b_Today_Click(null, EventArgs.Empty);
        }

        private void _refreshTimer_Tick(object sender, EventArgs e)
        {
            UpdateDashboardData();
        }

        public void UpdateDashboardData()
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            int totalCustomers = _dashboard.GetTotalCustomers();
            decimal totalRevenue = _dashboard.GetTotalRevenue();
            decimal totalFoodRevenue = _dashboard.GetTotalFoodRevenue();
            decimal totalRoomRevenue = _dashboard.GetTotalRoomRevenue();

            txt_KhachHang.Text = totalCustomers.ToString();

            //định dạng số mà không có dấu phẩy và không có số thập phân.
            txt_DoanhThu.Text = totalRevenue.ToString("N0") + " đ";
            txt_MonAn.Text = totalFoodRevenue.ToString("N0") + " đ";
            txt_Phong.Text = totalRoomRevenue.ToString("N0") + " đ";

            // Handle cases where values might be 0
            if (totalCustomers == 0)
            {
                txt_KhachHang.Text = "0";
            }
            if (totalRevenue == 0)
            {
                txt_DoanhThu.Text = "0 đ";
            }
            if (totalFoodRevenue == 0)
            {
                txt_MonAn.Text = "0 đ";
            }
            if (totalRoomRevenue == 0)
            {
                txt_Phong.Text = "0 đ";
            }
        }

        private void b_TodayFood_Click(object sender, EventArgs e)
        {
            // Get today's date without time
            string dateOnly = DateTime.Now.Date.ToString("yyyy-MM-dd");

            // Load top 5 best-selling food data for today
            DataTable top5FoodData = _dashboard.GetTop5BestSellingFoodToday(dateOnly);

            // Check if there is data to display
            if (top5FoodData.Rows.Count > 0)
            {
                // Clear existing data in chart2
                chart2.Series["chart2"].Points.Clear();

                // Loop through data and add points to chart2
                foreach (DataRow row in top5FoodData.Rows)
                {
                    string foodName = row["FoodName"].ToString();
                    decimal totalSold = Convert.ToDecimal(row["TotalSold"]);

                    chart2.Series["chart2"].Points.AddXY(foodName, totalSold);
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu về món ăn bán chạy hôm nay!");
            }
        }


        private void LoadTop5BestSellingFood()
        {

            // Xóa dữ liệu cũ trong chart2
            chart2.Series["chart2"].Points.Clear();

            DataTable top5FoodData = _dashboard.GetTop5BestSellingFood();

            if (top5FoodData != null && top5FoodData.Rows.Count > 0)
            {
                // Hiển thị dữ liệu mới
                foreach (DataRow row in top5FoodData.Rows)
                {
                    //Lấy giá trị FoodName trong bảng pos chuyển thành string
                    string foodName = row["FoodName"].ToString();
                    //Lấy giá trị totalsold trong bảng pos chuyển thành decimal
                    decimal totalSold = Convert.ToDecimal(row["TotalSold"]);

                    //Thêm một điểm trên biểu đồ (chart2). Trục x là tên món ăn (foodName) và trục y là tổng số lượng đã bán (totalSold).
                    chart2.Series["chart2"].Points.AddXY(foodName, totalSold);
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu về món ăn bán chạy hôm nay!");
            }
        }

        private void b_AllFood_Click(object sender, EventArgs e)
        {
            LoadTop5BestSellingFood ();
        }

        private void b_7DaysAgo_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các ngày có hóa đơn phòng hoặc đồ ăn trong 7 ngày trước
            List<string> datesWithBill = _dashboard.GetDistinctDatesWithBill();

            // Lọc ra danh sách các ngày trong 7 ngày trước
            DateTime startDate = DateTime.Today.AddDays(-7);
            DateTime endDate = DateTime.Today;
            List<string> filteredDates = new List<string>();
            foreach (string date in datesWithBill)
            {
                DateTime billDate = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                if (billDate >= startDate && billDate <= endDate)
                {
                    filteredDates.Add(date);
                }
            }

            // Lấy dữ liệu thống kê tổng doanh thu phòng và món ăn trong các ngày có hóa đơn trong 7 ngày trước
            decimal totalRoomRevenue7DaysAgo = 0;
            decimal totalFoodRevenue7DaysAgo = 0;
            foreach (string date in filteredDates)
            {
                decimal roomRevenue = Dashboard.Instance.GetTotalRoomRevenue7days(date);
                decimal foodRevenue = Dashboard.Instance.GetTotalFoodRevenue7days(date);
                totalRoomRevenue7DaysAgo += roomRevenue;
                totalFoodRevenue7DaysAgo += foodRevenue;
            }

            // Cập nhật dữ liệu lên biểu đồ
            UpdateChartData(totalRoomRevenue7DaysAgo, totalFoodRevenue7DaysAgo, filteredDates, filteredDates);
        }


        private void b_Today_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu thống kê tổng doanh thu phòng và món ăn trong ngày hôm nay
            DateTime today = DateTime.Today;
            string todayString = today.ToString("yyyy-MM-dd");

            decimal totalRoomRevenueToday = Dashboard.Instance.GetTotalRoomRevenueToday(todayString);
            decimal totalFoodRevenueToday = Dashboard.Instance.GetTotalFoodRevenueToday(todayString);

            // Tạo danh sách chứa ngày hôm nay để cập nhật biểu đồ
            List<string> dateLabels = new List<string>();
            dateLabels.Add(today.ToString("dd/MM/yyyy"));

            // Cập nhật dữ liệu lên chart1
            UpdateChartDataToday(totalRoomRevenueToday, totalFoodRevenueToday, dateLabels);
        }

        private void b_30DaysAgo_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các ngày có hóa đơn phòng hoặc đồ ăn trong 30 ngày trước
            List<string> datesWithBill = _dashboard.GetDistinctDatesWithBill();

            // Lọc ra danh sách các ngày trong 30 ngày trước
            DateTime startDate = DateTime.Today.AddDays(-30);
            DateTime endDate = DateTime.Today;
            List<string> filteredDates = new List<string>();
            foreach (string date in datesWithBill)
            {
                DateTime billDate = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                if (billDate >= startDate && billDate <= endDate)
                {
                    filteredDates.Add(date);
                }
            }

            // Lấy dữ liệu thống kê tổng doanh thu phòng và món ăn trong các ngày có hóa đơn trong 30 ngày trước
            decimal totalRoomRevenue30DaysAgo = 0;
            decimal totalFoodRevenue30DaysAgo = 0;
            foreach (string date in filteredDates)
            {
                decimal roomRevenue = Dashboard.Instance.GetTotalRoomRevenue30days(date);
                decimal foodRevenue = Dashboard.Instance.GetTotalFoodRevenue30days(date);
                totalRoomRevenue30DaysAgo += roomRevenue;
                totalFoodRevenue30DaysAgo += foodRevenue;
            }

            // Cập nhật dữ liệu lên biểu đồ
            UpdateChartData(totalRoomRevenue30DaysAgo, totalFoodRevenue30DaysAgo, filteredDates, filteredDates);
        }


        private void UpdateChartData(decimal totalRoomRevenue, decimal totalFoodRevenue, List<string> dateLabels, List<string> filteredDates)
        {
            // Xóa dữ liệu cũ của các series trước khi cập nhật dữ liệu mới
            chart1.Series["Room"].Points.Clear();
            chart1.Series["Food"].Points.Clear();

            // Thêm dữ liệu mới cho các series và cập nhật giá trị trục X
            for (int i = 0; i < dateLabels.Count; i++)
            {
                // Lấy ngày hiện tại từ danh sách dateLabels
                string currentDate = dateLabels[i];

                // Tính tổng doanh thu phòng và món ăn của ngày hiện tại
                decimal roomRevenue = 0;
                decimal foodRevenue = 0;

                // Kiểm tra xem ngày hiện tại có trong danh sách filteredDates không
                if (filteredDates.Contains(currentDate))
                {
                    // Nếu có, lấy tổng doanh thu phòng và món ăn tương ứng với ngày hiện tại
                    roomRevenue = Dashboard.Instance.GetTotalRoomRevenueToday(currentDate);
                    foodRevenue = Dashboard.Instance.GetTotalFoodRevenueToday(currentDate);
                }

                // Thêm điểm dữ liệu cho loại phòng
                DataPoint roomDataPoint = new DataPoint(i, (double)roomRevenue);
                roomDataPoint.AxisLabel = currentDate;
                roomDataPoint.Label = roomRevenue.ToString("N0") + " đ";
                chart1.Series["Room"].Points.Add(roomDataPoint);

                // Thêm điểm dữ liệu cho loại món ăn
                DataPoint foodDataPoint = new DataPoint(i, (double)foodRevenue);
                foodDataPoint.AxisLabel = currentDate;
                foodDataPoint.Label = foodRevenue.ToString("N0") + " đ";
                chart1.Series["Food"].Points.Add(foodDataPoint);
            }

            // Cập nhật lại giao diện của chart1
            chart1.DataBind();
        }


        private void UpdateChartDataToday(decimal totalRoomRevenue, decimal totalFoodRevenue, List<string> dateLabels)
        {
            // Xóa dữ liệu cũ của các series trước khi cập nhật dữ liệu mới
            chart1.Series["Room"].Points.Clear();
            chart1.Series["Food"].Points.Clear();

            // Thêm dữ liệu mới cho các series và cập nhật giá trị trục X
            for (int i = 0; i < dateLabels.Count; i++)
            {
                // Thêm điểm dữ liệu cho loại phòng
                DataPoint roomDataPoint = new DataPoint(i, (double)totalRoomRevenue); // Chuyển đổi kiểu decimal sang double
                roomDataPoint.AxisLabel = dateLabels[i];
                roomDataPoint.Label = totalRoomRevenue.ToString("N0") + " đ"; // Định dạng và gán giá trị nhãn
                chart1.Series["Room"].Points.Add(roomDataPoint);

                // Thêm điểm dữ liệu cho loại món ăn
                DataPoint foodDataPoint = new DataPoint(i, (double)totalFoodRevenue); // Chuyển đổi kiểu decimal sang double
                foodDataPoint.AxisLabel = dateLabels[i];
                foodDataPoint.Label = totalFoodRevenue.ToString("N0") + " đ"; // Định dạng và gán giá trị nhãn
                chart1.Series["Food"].Points.Add(foodDataPoint);
            }

            // Cập nhật lại giao diện của chart1
            chart1.DataBind();
        }


    }
}
