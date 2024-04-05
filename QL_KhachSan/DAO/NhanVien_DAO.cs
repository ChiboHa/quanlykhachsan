using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.DAO
{
    public class NhanVien_DAO
    {
        private static NhanVien_DAO instance;
        public NhanVien_DAO() { }
        public static NhanVien_DAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien_DAO();
                return instance;
            }
            private set => instance = value;

        }

        public string ID { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string MaSoThue { get; set; }
        public string SoDienThoai { get; set; }
        public decimal Luong1h { get; set; }
        public byte[] Image { get; set; }
        public string Role { get; set; }

        public List<NhanVien_DAO> GetNhanViens()
        {
            List<NhanVien_DAO> nhanViens = new List<NhanVien_DAO>();

            // Viết câu truy vấn SQL để lấy dữ liệu từ bảng nhân viên
            string query = "SELECT * FROM NhanVien";

            // Sử dụng DataProvider để thực hiện truy vấn
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            // Duyệt qua từng dòng dữ liệu và thêm vào danh sách nhân viên
            // Trong phương thức GetNhanViens của lớp NhanVien_DAO
            foreach (DataRow row in data.Rows)
            {
                NhanVien_DAO nhanVien = new NhanVien_DAO();
                // Gán các giá trị từ dòng dữ liệu vào đối tượng nhân viên
                nhanVien.ID = row["ID"].ToString();
                nhanVien.Ho = row["ho"].ToString();
                nhanVien.Ten = row["ten"].ToString();
                nhanVien.GioiTinh = row["gioiTinh"].ToString();
                nhanVien.NgaySinh = Convert.ToDateTime(row["ngaySinh"]);
                nhanVien.CCCD = row["CCCD"].ToString();
                nhanVien.Email = row["email"].ToString();
                nhanVien.MaSoThue = row["maSoThue"].ToString();
                nhanVien.SoDienThoai = row["soDienThoai"].ToString();
                nhanVien.Luong1h = Convert.ToDecimal(row["luong1h"]);

                if (!(row["image"] is DBNull))
                {
                    nhanVien.Image = (byte[])row["image"];
                }
                else
                {
                    // Sử dụng đường dẫn tương đối để truy cập tệp hình ảnh mặc định "user.jpg"
                    string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "user.jpg");
                    nhanVien.Image = File.ReadAllBytes(defaultImagePath);
                }

                nhanVien.Role = row["role"].ToString();

                nhanViens.Add(nhanVien);
            }

            return nhanViens;

        }

        public NhanVien_DAO GetEmployeeByID(string employeeID)
        {
            // Lấy danh sách nhân viên từ cơ sở dữ liệu
            List<NhanVien_DAO> nhanViens = GetNhanViens();

            // Tìm nhân viên có ID tương ứng
            return nhanViens.FirstOrDefault(emp => emp.ID == employeeID);
        }

        public void DeleteEmployeeByID(string employeeID)
        {
            // Viết câu truy vấn SQL để xóa nhân viên có ID tương ứng
            string query = string.Format("DELETE FROM NhanVien WHERE ID = '{0}'", employeeID);

            // Sử dụng DataProvider để thực hiện truy vấn không trả về dữ liệu (UPDATE, DELETE)
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool AddItemsToTable(string ID, string ho, string ten, string gioiTinh, DateTime ngaySinh, string CCCD, string email, string maSoThue, string soDienThoai, string luong1h, byte[] imgData, string role)
        {
            // Sử dụng kết nối từ lớp DataProvider
            SqlConnection connect = new SqlConnection(DataProvider.Instance.ConnectionString);

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string query = "INSERT INTO NhanVien(ID, ho, ten, gioiTinh, ngaySinh, CCCD, email, maSoThue, soDienThoai, luong1h, image, role) " +
                           "VALUES(@ID, @Ho, @Ten, @GioiTinh, @NgaySinh, @CCCD, @Email, @MaSoThue, @SoDienThoai, @Luong1h, @Image, @Role)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Ho", ho);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", CCCD);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MaSoThue", maSoThue);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Luong1h", luong1h);
                    cmd.Parameters.AddWithValue("@Image", imgData);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding items to the table: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        public bool UpdateItemsInTable(string ID, string ho, string ten, string gioiTinh, DateTime ngaySinh, string CCCD, string email, string maSoThue, string soDienThoai, string luong1h, byte[] imgData, string role)
        {
            // Sử dụng kết nối từ lớp DataProvider
            SqlConnection connect = new SqlConnection(DataProvider.Instance.ConnectionString);

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string query = "UPDATE NhanVien SET ho = @Ho, ten = @Ten, gioiTinh = @GioiTinh, ngaySinh = @NgaySinh, CCCD = @CCCD, email = @Email, maSoThue = @MaSoThue, soDienThoai = @SoDienThoai, luong1h = @Luong1h, image = @Image, role = @Role WHERE ID = @ID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Ho", ho);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", CCCD);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MaSoThue", maSoThue);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Luong1h", luong1h);
                    cmd.Parameters.AddWithValue("@Image", imgData);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if rows were affected, indicating successful update
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the employee: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }



    }

}
