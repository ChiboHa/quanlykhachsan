using QL_KhachSan;
using QL_KhachSan.DTO;
using QL_KhachSan.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.DAO
{
    public class PosDAO
    {
        private static PosDAO instance;

        public static PosDAO Instance
        {
            get { if (instance == null) instance = new PosDAO(); return PosDAO.instance; }
            private set { PosDAO.instance = value; }
        }

        private PosDAO() { }

        public List<PosDTO> GetListBillF()
        {
            List<PosDTO> list = new List<PosDTO>();
            string query = string.Format("Select * From Pos");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows) 
            {
                PosDTO pos = new PosDTO();
                list.Add(pos);
            }

            return list;
        }

        public bool AddBill(int idKhachHang, DateTime transDate, string transMonth, int foodCode, string foodName, int cost, int quantity, int totalPrice, int grandTotal)
        {
            try
            {
                string query = string.Format("INSERT INTO dbo.Pos (idkh, transdate, transmonth, foodcode, foodname, cost, qty, totalPrice, grandTotal) " +
                    "VALUES   ({0}, '{1}', '{2}', {3}, N'{4}', {5}, {6}, {7}, {8})", idKhachHang, transDate, transMonth, foodCode, foodName, cost, quantity, totalPrice, grandTotal);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
