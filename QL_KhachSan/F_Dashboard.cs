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
        private Dashboard _dashboard = new Dashboard(); // Create Dashboard instance

        public F_Dashboard()
        {
            InitializeComponent();
            LoadDashboardData(); // Call method to load data on form load
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
            txt_DoanhThu.Text = totalRevenue.ToString("C");  // Format as currency
            txt_MonAn.Text = totalFoodRevenue.ToString("C");
            txt_Phong.Text = totalRoomRevenue.ToString("C");

            // Handle cases where values might be 0
            if (totalCustomers == 0)
            {
                txt_KhachHang.Text = "0";
            }
            if (totalRevenue == 0)
            {
                txt_DoanhThu.Text = "0 đ";  // Display "0 đ" for total revenue
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
    }
}
