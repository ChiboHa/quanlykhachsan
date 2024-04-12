using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_DatPhong : Form
    {
        String id_KH, id_HDP;

        public F_DatPhong()
        {
            InitializeComponent();
        }

        private void b_DatPhongTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;

        }

        private void b_ThanhToanTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void b_DatPhong_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string ID_KhachHang = "KH" + Guid.NewGuid().ToString().Substring(0, 8);
                Item selectedItem = soPhongBox.SelectedItem as Item;
                try
                {
                    if (KhachHang_DAO.Instance.InsertKhachHang(new KhachHang(ID_KhachHang, hoTenBox.Text, sdtBox.Text, cccdBox.Text)))
                    {
                        Bill_Room_DAO.Instance.InsertBillRoom("" + selectedItem.Value, ID_KhachHang);
                        Rooms_DAO.Instance.setBooked("YES", "" + selectedItem.Value);
                        MessageBox.Show("Đặt phòng thành công!");
                        reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void n_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void loaiPhongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRoomNo();
        }

        private void loaiGiuongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRoomNo();
        }

        private void soPhongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_error6.Text = "";
        }

        private void hoTenBox_TextChanged(object sender, EventArgs e)
        {
            txt_error1.Text = "";
        }

        private void sdtBox_TextChanged(object sender, EventArgs e)
        {
            txt_error2.Text = "";
        }

        private void cccdBox_TextChanged(object sender, EventArgs e)
        {
            txt_error3.Text = "";
        }

        private void b_ThanhToan_Click(object sender, EventArgs e)
        {
            checkOut();
            listBillRoom();
        }

        private void F_DatPhong_Load(object sender, EventArgs e)
        {
            listBillRoom();
        }

        private void b_Refresh_Click(object sender, EventArgs e)
        {
            hoTenTTBox.Text = "";
            soPhongTTBox.Text = "";
            listBillRoom();
        }
        private void listKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_HDP = listKhachHang.CurrentRow.Cells[0].Value.ToString();
            id_KH = listKhachHang.CurrentRow.Cells[1].Value.ToString();
            hoTenTTBox.Text = listKhachHang.CurrentRow.Cells[2].Value.ToString();
            soPhongTTBox.Text = listKhachHang.CurrentRow.Cells[3].Value.ToString();
        }

        private void listBillRoom()
        {
            try
            { using (DataTable data = Bill_Room_DAO.Instance.GetBillRoomsWithStatus()) { listKhachHang.DataSource = data; } }
            catch (Exception ex) { }
        }

        private bool validate()
        {
            bool status = true;
            if (hoTenBox.Text.Trim().Equals(""))
            {
                txt_error1.Text = "Vui lòng nhập họ tên!";
                status = false;
            }
            if (sdtBox.Text.Trim().Equals(""))
            {
                txt_error2.Text = "Vui lòng nhập số điện thoại!";
                status = false;
            }
            if (cccdBox.Text.Trim().Equals(""))
            {
                txt_error3.Text = "Vui lòng nhập CCCD!";
                status = false;
            }
            if (loaiPhongBox.Text == null || loaiPhongBox.Text.Trim().Equals(""))
            {
                txt_error4.Text = "Vui lòng lựa chọn loại phòng!";
                status = false;
            }
            if (loaiGiuongBox.Text == null || loaiPhongBox.Text.Trim().Equals(""))
            {
                txt_error5.Text = "Vui lòng lựa chọn loại giường!";
                status = false;
            }
            if (soPhongBox.Text == null || soPhongBox.Text.Trim().Equals(""))
            {
                txt_error6.Text = "Vui lòng lựa chọn số phòng!";
                status = false;
            }
            return status;
        }

        private void reset()
        {
            hoTenBox.Text = "";
            sdtBox.Text = "";
            cccdBox.Text = "";
            loaiPhongBox.Text = "";
            loaiGiuongBox.Text = "";
            soPhongBox.Text = "";
            txt_error1.Text = "";
            txt_error2.Text = "";
            txt_error3.Text = "";
            txt_error4.Text = "";
            txt_error5.Text = "";
            txt_error6.Text = "";
            soPhongBox.Items.Clear();
        }

        // Theo dõi lựa chọn loại phòng, giường lấy ra số phòng
        private void getRoomNo()
        {
            txt_error4.Text = "";
            List<Rooms> roomNo = Rooms_DAO.Instance.getRooms(loaiPhongBox.Text, loaiGiuongBox.Text);
            soPhongBox.Items.Clear();
            foreach (var item in roomNo)
            {
                soPhongBox.Items.Add(new Item() { Text = item.RoomNo, Value = item.ID });
            }
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
            double TotalHours = Convert.ToDouble(Bill_Room_DAO.Instance.getTotalHours(id_HDP)),
                price = Rooms_DAO.Instance.GetPrice(room_id);
            double result = TotalHours * price;

            MessageBox.Show("Số tiền phải trả là: " + TotalHours + " Giờ * " + price + " = " + result + " VND", "Hóa đơn", MessageBoxButtons.OK);
        }
    }
    public class Item
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
