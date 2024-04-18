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

        public List<PosDTO> GetListBillF(int id)
        {
            List<PosDTO> list = new List<PosDTO>();
            string query = string.Format("Select * From Pos Where billID = {0}",id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PosDTO pos = new PosDTO(item);
                list.Add(pos);
            }

            return list;
        }

        public bool AddPos(int billID, int foodCode, string foodName, int cost, int quantity, int totalPrice)
        {
            string query = string.Format("INSERT INTO dbo.Pos (billID, foodcode, foodname, cost, qty, totalPrice) " +
                                         "VALUES ({0}, {1}, N'{2}', {3}, {4}, {5})", billID, foodCode, foodName, cost, quantity, totalPrice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetPosByBillID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Pos Where ID = {0}", new object[] {id});
        }

    }
}
