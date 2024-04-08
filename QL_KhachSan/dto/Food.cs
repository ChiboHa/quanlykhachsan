using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.DTO
{
    public class Food
    {
        public Food(int id, string ten, string muc, int gia)
        {
            this.ID = id;
            this.Ten = ten;
            this.Muc = muc;
            this.Gia = gia;
        }

        public Food(DataRow item)
        {
            this.ID = Convert.ToInt32(item["ID"]);
            this.Ten = item["Ten"].ToString();
            this.Muc = item["Muc"].ToString();
            this.Gia = Convert.ToInt32(item["Gia"]);
        }

        private string ten;
        private string muc;
        private int gia;
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Muc
        {
            get { return muc; }
            set { muc = value; }
        }

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}