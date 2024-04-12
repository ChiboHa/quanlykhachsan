using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
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

        public Boolean InsertKhachHang(KhachHang kh)
        {
            string query = "INSERT INTO Customer (ID, name, phoneNumber, CCCD) VALUES ( @ID , @name , @phoneNumber , @CCCD )";
            object[] parameters = { kh.Id, kh.Name, kh.PhoneNumber, kh.Cccd };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}
