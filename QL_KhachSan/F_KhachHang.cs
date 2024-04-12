using QL_KhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_KhachHang : Form
    {
        public F_KhachHang()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_Search.SelectedIndex == 0)
            {
                showAllCus();
            }
            else if (dropDown_Search.SelectedIndex == 1)
            {
                showAllCusInside();
            }
            else if (dropDown_Search.SelectedIndex == 2)
            {
                showAllCusOutside();
            }
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
            showAllCus();
        }

        private void showAllCus()
        {
            listInfo.DataSource = Bill_Room_DAO.Instance.GetAllBillRooms();
        }
        private void showAllCusInside()
        {
            listInfo.DataSource = Bill_Room_DAO.Instance.GetAllBillRoomsInside();
        }
        private void showAllCusOutside()
        {
            listInfo.DataSource = Bill_Room_DAO.Instance.GetAllBillRoomsOutside();
        }
    }
}
