using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_KhachSan.DAO
{
    public class Luong_DAO
    {
        private static Luong_DAO instance;

        public static Luong_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Luong_DAO();
                return instance;
            }
            private set => instance = value;
        }

        private Luong_DAO() { }

        // Lấy lương của nhân viên theo tháng và năm
        public DataTable GetLuongByMonthAndYear(int month, int year)
        {
            DataTable data = new DataTable();

            string query = "SELECT Luong.ID, Luong.ID_nv, NhanVien.Ho, NhanVien.Ten, NhanVien.GioiTinh, NhanVien.Role, SUM(luong1h * soGioLam) AS TongLuong " +
                           "FROM Luong " +
                           "INNER JOIN NhanVien ON Luong.ID_nv = NhanVien.ID " +
                           "WHERE MONTH(time) = @Month AND YEAR(time) = @Year " +
                           "GROUP BY Luong.ID, Luong.ID_nv, NhanVien.Ho, NhanVien.Ten, NhanVien.GioiTinh, NhanVien.Role";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }



        // Thêm một bản ghi lương mới
        public bool InsertLuong(string ID_nv, DateTime time, decimal soGioLam)
        {
            string query = "INSERT INTO Luong (ID_nv, time, soGioLam, thanhTien) " +
                           "VALUES (@ID_nv, @Time, @SoGioLam, @ThanhTien)";

            try
            {
                // Lấy giá trị của lương 1 giờ từ cơ sở dữ liệu
                decimal luong1h = GetLuong1hFromDatabase(ID_nv);

                // Tính toán giá trị của thanhTien
                decimal thanhTien = luong1h * soGioLam;

                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_nv", ID_nv);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@SoGioLam", soGioLam);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien); // Sử dụng giá trị đã tính toán
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Phương thức để lấy giá trị của lương 1 giờ từ cơ sở dữ liệu
        private decimal GetLuong1hFromDatabase(string employeeID)
        {
            string query = "SELECT luong1h FROM NhanVien WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    // Ép kiểu giá trị lấy được về decimal
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToDecimal(result);
                    }
                    return 0; // Trả về 0 nếu không có dữ liệu
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }



        // Xóa bản ghi lương
        public bool DeleteLuong(int luongID)
        {
            string query = "DELETE FROM Luong WHERE ID = @LuongID";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LuongID", luongID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Cập nhật thông tin lương
        public bool UpdateLuong(int luongID, decimal soGioLam, decimal thanhTien)
        {
            string query = "UPDATE Luong SET soGioLam = @SoGioLam, thanhTien = @ThanhTien " +
                           "WHERE ID = @LuongID";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoGioLam", soGioLam);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@LuongID", luongID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Kiểm tra xem nhân viên đã có lương trong tháng và năm đã cho hay chưa
        public bool CheckSalaryExists(string employeeID, DateTime time)
        {
            string query = "SELECT COUNT(*) FROM Luong WHERE ID_nv = @EmployeeID AND MONTH(time) = @Month AND YEAR(time) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@Month", time.Month);
                    cmd.Parameters.AddWithValue("@Year", time.Year);
                    int count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
