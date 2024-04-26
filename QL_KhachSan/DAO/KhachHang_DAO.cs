using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.DAO
{
    internal class KhachHang_DAO
    {

        private static KhachHang_DAO instance;
        public KhachHang_DAO() { }
        public static KhachHang_DAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHang_DAO();
                return instance;
            }
            private set => instance = value;
        }

        public List<KhachHang> GetListKH()
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "select * from Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);
                list.Add(kh);
            }
            
            return list;
        }

        public Boolean InsertKhachHang(KhachHang kh)
        {
            string query = "INSERT INTO Customer (ID, name, CCCD) VALUES ( @ID , @name , @CCCD )";
            object[] parameters = { kh.Id, kh.Name, kh.Cccd };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool EditKH(string name, string CCCD, string id)
        {
            string query = string.Format("UPDATE dbo.Customer SET Name = N'{0}', CCCD = '{1}' WHERE ID = '{2}'", name, CCCD, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DelKH(string id)
        {
            string query = string.Format("DELETE dbo.Customer WHERE ID = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<KhachHang> SearchKH(string searchTerm)
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "SELECT * FROM dbo.Customer WHERE name LIKE N'%" + searchTerm + "%' OR ID LIKE '%" + searchTerm + "%' OR CCCD LIKE '%" + searchTerm + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);
                list.Add(kh);
            }
            return list;
        }
        public KhachHang GetCustomerById(string customerId)
        {
            string query = "SELECT * FROM Customer WHERE ID = @customerId";
            object[] parameters = { customerId };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                KhachHang customer = new KhachHang(
                    row["ID"].ToString(),
                    row["name"].ToString(),
                    row["CCCD"].ToString()
                );
                return customer;
            }
            return null;
        }

    }
}
