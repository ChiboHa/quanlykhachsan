using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_KhachSan.DAO
{
    public class TongLuong_DAO
    {
        private static TongLuong_DAO instance;

        public static TongLuong_DAO Instance
        {
            get
            {
                if (instance == null) instance = new TongLuong_DAO();
                return instance;
            }
            private set => instance = value;
        }

        private TongLuong_DAO() { }

        public DataTable GetHotelTotalSalaries()
        {
            DataTable data = new DataTable();

            string query = "SELECT * FROM TongLuong";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }

        // Tính tổng lương của khách sạn từ các bản ghi lương của nhân viên theo tháng và năm
        public bool CalculateAndInsertHotelTotalSalary(int month, int year)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    // Tạo chuỗi tên bảng dựa trên tháng và năm
                    string tableName = $"Tổng lương tháng {month} năm {year}";
                    // Tạo câu lệnh SQL để tính tổng lương khách sạn từ các bản ghi lương của nhân viên trong tháng và năm cho trước
                    string query = "INSERT INTO TongLuong (thang, nam, ten, TongLuong) " +
                                   "SELECT @Month, @Year, @TableName, SUM(thanhTien) AS TongLuong " +
                                   "FROM Luong WHERE MONTH(time) = @Month AND YEAR(time) = @Year";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@TableName", tableName);
                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckExistingRecord(int month, int year)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM TongLuong WHERE Thang = @Month AND Nam = @Year";
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteExistingRecord(int month, int year)
        {
            try
            {
                string query = "DELETE FROM TongLuong WHERE Thang = @Month AND Nam = @Year";
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
