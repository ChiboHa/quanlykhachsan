using QL_KhachSan;
using QL_KhachSan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DAO
{
    public class Food_DAO
    {
        private static Food_DAO instance;

        public static Food_DAO Instance
        {
            get { if (instance == null) instance = new Food_DAO(); return Food_DAO.instance; }
            private set { Food_DAO.instance = value; }
        }

        private Food_DAO() { }

       
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            list = list.OrderBy(f => f.Muc).ToList();

            return list;
        }

        public bool AddFood(string name, string category, int cost )
        {
            string query = string.Format("INSERT INTO dbo.Food (Ten, Muc, Gia) VALUES   (N'{0}', '{1}', {2})", name, category, cost);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditFood(string name, string category, int cost)
        {
            string query = string.Format("UPDATE dbo.Food SET Ten = N'{0}', Muc = '{1}', Gia = {2} WHERE ID = {3}",name,category,cost,name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DelFood(string name)
        {
            string query = string.Format("DELETE dbo.Food WHERE ID = {0}", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Food> SearchFood(string searchTerm)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM dbo.Food WHERE Ten LIKE N'%" + searchTerm + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public Food GetFoodByID(int id)
        {
            Food food = null;
            string query = string.Format("SELECT * FROM Food WHERE ID = {0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                food = new Food(item);
                return food;
            }

            return food;


        }
    }
}
