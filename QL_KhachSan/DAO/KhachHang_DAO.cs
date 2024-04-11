using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
