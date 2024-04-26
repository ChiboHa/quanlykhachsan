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


        private void b_Today_Click(object sender, EventArgs e)
        {
            
        }

        private void b_7DaysAgo_Click(object sender, EventArgs e)
        {
           
        }

        private void b_30DaysAgo_Click(object sender, EventArgs e)
        {
            
        }

        private void b_ThisYear_Click(object sender, EventArgs e)
        {
           
        }

        private void b_TodayFood_Click(object sender, EventArgs e)
        {
            // Get today's date without time
            string dateOnly = DateTime.Now.Date.ToString("yyyy-MM-dd");

            // Load top 5 best-selling food data for today
            DataTable top5FoodData = _dashboard.GetTop5BestSellingFood(dateOnly);

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
                // Show message if no data found
                MessageBox.Show("Không có dữ liệu về món ăn bán chạy hôm nay!");
            }
        }




        private void b_AllFood_Click(object sender, EventArgs e)
        {

        }
    }
}
