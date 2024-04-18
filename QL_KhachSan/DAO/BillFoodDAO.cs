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
    public class BillFoodDAO
    {
        private static BillFoodDAO instance;

        public static BillFoodDAO Instance
        {
            get { if (instance == null) instance = new BillFoodDAO(); return BillFoodDAO.instance; }
            private set { BillFoodDAO.instance = value; }
        }

        private BillFoodDAO() { }
        public List<BillFood> GetDsBill()
        {
            List<BillFood> list = new List<BillFood>();

            string query = "Select * From BillFood";
            
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow item in data.Rows)
            {
                BillFood pos = new BillFood(item);
                list.Add(pos);
            }

            return list;
        }
        
        public bool AddBill(string idKhachHang, DateTime transDate, string transMonth, int grandTotal, string trangthai)
        {
            string query = string.Format("INSERT INTO dbo.BillFood (idkh, transdate, transmonth, grandTotal, trangthai) " +
                              "VALUES ('{0}', '{1}', '{2}', {3}, '{4}');",
                              idKhachHang, transDate.ToString("yyyy-MM-dd"), transMonth, grandTotal, trangthai);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
           
            return result > 0;
        }
        public int GetUncheckBillID()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP 1 * FROM dbo.BillFood ORDER BY ID DESC;");

            if (data.Rows.Count > 0)
            {
                BillFood bill = new BillFood(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }



    }
}
