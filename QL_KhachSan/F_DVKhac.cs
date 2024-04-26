using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using ReaLTaiizor.Controls;
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
    public partial class F_DVKhac : Form
    {
        String id_KH, id_HDP;

        public F_DVKhac()
        {
            InitializeComponent();
        }

        private void b_ThanhToan_Click(object sender, EventArgs e)
        {
            F_CheckOut_Messages f = new F_CheckOut_Messages(id_HDP);
            f.ShowDialog();
            hoTenTTBox.Text = "";
            soPhongTTBox.Text = "";
        }

        private void b_searchTT_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataTable data = Bill_Room_DAO.Instance.searchBillRooms(searchTTBox.Text))
                { listKhachHang.DataSource = data; }
            }
            catch (Exception ex) { }
        }

      

        private void F_DVKhac_Load(object sender, EventArgs e)
        {
            listBillRoom();
        }

        private void b_Refresh_Click(object sender, EventArgs e)
        {
            listBillRoom();
        }

        // Sự kiện click vào để lấy ra thông tin phòng + khách hàng từ DataGridView
        private void listKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_HDP = listKhachHang.CurrentRow.Cells[0].Value.ToString();
            id_KH = listKhachHang.CurrentRow.Cells[1].Value.ToString();
            hoTenTTBox.Text = listKhachHang.CurrentRow.Cells[2].Value.ToString();
            //cccdBox.Text = listKhachHang.CurrentRow.Cells[3].Value.ToString();
            soPhongTTBox.Text = listKhachHang.CurrentRow.Cells[4].Value.ToString();
        }

        // Đưa danh sách các phòng chưa thanh toán lên DataGridView
        public void listBillRoom()
        {
            try
            { using (DataTable data = Bill_Room_DAO.Instance.GetBillRoomsWithStatus()) { listKhachHang.DataSource = data; } }
            catch (Exception ex) { }
        }

    }
}
