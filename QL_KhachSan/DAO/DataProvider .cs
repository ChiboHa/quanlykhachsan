using System;
using System.Data;
using System.Data.SqlClient;

namespace QL_KhachSan
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr;

        // Sử dụng singleton pattern để tạo instance của DataProvider
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }

        // Khai báo một thuộc tính hoặc phương thức công khai để truy cập thông tin kết nối
        public string ConnectionString
        {
            get { return connectionStr; }
            set { connectionStr = value; }
        }

        // Khởi tạo thông tin kết nối
        private DataProvider() =>
        // Đặt thông tin kết nối mặc định ở đây hoặc để trống
        // và set ConnectionString từ bên ngoài trước khi sử dụng
        //connectionStr = @"Data Source=DESKTOP-NT51Q2G\MSSQLSEVER2024;Initial Catalog=QL_KhachSan;Integrated Security=True;";
        connectionStr = @"Data Source=DESKTOP-VLFRITI\MSSQLSERVER2024;Initial Catalog=QL_KhachSan;Integrated Security=True;";
        //connectionStr = @"Data Source=MSI; Initial Catalog=QL_KhachSan; Integrated Security=true";


        // Trả về dữ liệu truy vấn
        public DataTable ExecuteQuery(String query, Object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
                catch (SqlException ex)
                {
                    // Xử lý ngoại lệ tại đây
                    Console.WriteLine("Lỗi SQL: " + ex.Message);
                }
                conn.Close();
            }
            return data;
        }


        // Trả về số lượng hàng bị ảnh hưởng bởi câu lệnh SQL
        public int ExecuteNonQuery(String query, Object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }


        // Trả về số lượng hàng trong bảng
        public object ExecuteScalar(String query, Object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();

                conn.Close();
            }
            return data;
        }
    }
}
