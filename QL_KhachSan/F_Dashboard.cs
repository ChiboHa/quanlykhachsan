using QL_KhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Initialize and start the timer
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 5000; // Refresh every 5 seconds (5000 milliseconds)
            _refreshTimer.Tick += _refreshTimer_Tick;
            _refreshTimer.Start();

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

        private void UpdateChartToday()
        {
            // Xóa dữ liệu cũ trước khi cập nhật mới
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();

            // Lấy dữ liệu và cập nhật biểu đồ cho ngày hôm nay
            decimal totalRevenueToday = _dashboard.GetTotalRevenueToday();

            // Cập nhật dữ liệu cho biểu đồ c_ThongKeDoanhThu
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.AddXY("Today", totalRevenueToday);
        }

        private void UpdateChart7DaysAgo()
        {
            // Xóa dữ liệu cũ trước khi cập nhật mới
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();

            // Lấy dữ liệu và cập nhật biểu đồ cho 7 ngày trước
            decimal totalRevenue7DaysAgo = _dashboard.GetTotalRevenueLast7Days();

            // Cập nhật dữ liệu cho biểu đồ c_ThongKeDoanhThu
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.AddXY("7 Days Ago", totalRevenue7DaysAgo);
        }

        private void UpdateChart30DaysAgo()
        {
            // Xóa dữ liệu cũ trước khi cập nhật mới
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();

            // Lấy dữ liệu và cập nhật biểu đồ cho 30 ngày trước
            decimal totalRevenue30DaysAgo = _dashboard.GetTotalRevenueLast30Days();

            // Cập nhật dữ liệu cho biểu đồ c_ThongKeDoanhThu
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.AddXY("30 Days Ago", totalRevenue30DaysAgo);
        }

        private void UpdateChartThisYear()
        {
            // Xóa dữ liệu cũ trước khi cập nhật mới
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();

            // Lấy dữ liệu và cập nhật biểu đồ cho năm nay
            decimal totalRevenueThisYear = _dashboard.GetTotalRevenueThisYear();

            // Cập nhật dữ liệu cho biểu đồ c_ThongKeDoanhThu
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.AddXY("This Year", totalRevenueThisYear);
        }

        private void b_Today_Click(object sender, EventArgs e)
        {
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();
            UpdateChartToday();
        }

        private void b_7DaysAgo_Click(object sender, EventArgs e)
        {
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();
            UpdateChart7DaysAgo();
        }

        private void b_30DaysAgo_Click(object sender, EventArgs e)
        {
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();
            UpdateChart30DaysAgo();
        }

        private void b_ThisYear_Click(object sender, EventArgs e)
        {
            c_ThongKeDoanhThu.Series["TotalRevenue"].Points.Clear();
            UpdateChartThisYear();
        }
    }
}
