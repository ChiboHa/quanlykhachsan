using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QL_KhachSan.DAO
{
     class classBLL
    {
        public bool SaveItems(string ID, string ho, string ten, string gioiTinh, DateTime ngaySinh, string CCCD, string email, string maSoThue, string soDienThoai, string luong1h, byte[] imgData, string role)
        {
            try
            {
                NhanVien_DAO objdal = new NhanVien_DAO();
                return objdal.AddItemsToTable(ID, ho, ten, gioiTinh, ngaySinh, CCCD, email, maSoThue, soDienThoai, luong1h, imgData, role);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool UpdateItems(string ID, string ho, string ten, string gioiTinh, DateTime ngaySinh, string CCCD, string email, string maSoThue, string soDienThoai, string luong1h, byte[] imgData, string role)
        {
            try
            {
                NhanVien_DAO objdal = new NhanVien_DAO();
                return objdal.UpdateItemsInTable(ID, ho, ten, gioiTinh, ngaySinh, CCCD, email, maSoThue, soDienThoai, luong1h, imgData, role);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
