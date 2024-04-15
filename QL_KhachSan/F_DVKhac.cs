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
            hoTenTTBox.Text = "";
            soPhongTTBox.Text = "";
            checkOut();
            listBillRoom();
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

        private void checkOut()
        {
            String room_id = Bill_Room_DAO.Instance.GetRoomID(id_HDP);
            Rooms_DAO.Instance.setBooked("NO", room_id);
            Bill_Room_DAO.Instance.checkOut(id_HDP);

            string totalDays = Bill_Room_DAO.Instance.getTotalDays(id_HDP);

            double pricePerDay = Rooms_DAO.Instance.GetPrice(room_id);

            double totalAmount = Convert.ToDouble(totalDays) * pricePerDay;

            MessageBox.Show("Số tiền phải trả là: " + totalDays + " Ngày * " + pricePerDay + " = " + totalAmount + " VND", "Hóa đơn", MessageBoxButtons.OK);
        }

        private void F_DVKhac_Load(object sender, EventArgs e)
        {
            listBillRoom();
        }

        private void b_Refresh_Click(object sender, EventArgs e)
        {
            listBillRoom();
        }

        private void listKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_HDP = listKhachHang.CurrentRow.Cells[0].Value.ToString();
            id_KH = listKhachHang.CurrentRow.Cells[1].Value.ToString();
            hoTenTTBox.Text = listKhachHang.CurrentRow.Cells[2].Value.ToString();
            //cccdBox.Text = listKhachHang.CurrentRow.Cells[3].Value.ToString();
            soPhongTTBox.Text = listKhachHang.CurrentRow.Cells[4].Value.ToString();
        }

        private void listBillRoom()
        {
            try
            { using (DataTable data = Bill_Room_DAO.Instance.GetBillRoomsWithStatus()) { listKhachHang.DataSource = data; } }
            catch (Exception ex) { }
        }

    }
}
