using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_DatPhong : Form
    {
        public F_DatPhong()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void setup()
        {
            loaiPhongBox.Items.AddRange(new String[] { "Phòng thường", "Phòng VIP" });
            loaiGiuongBox.Items.AddRange(new String[] { "Giường đơn", "Giường đôi" });
        }


        private void b_DatPhongTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;

        }

        private void b_ThanhToanTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

            //if (MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (hoTenBox.Text.Trim().Equals(""))
                txt_error1.Text = "Vui lòng nhập họ tên!";
            if (sdtBox.Text.Trim().Equals(""))
                txt_error2.Text = "Vui lòng nhập số điện thoại!";
            if (cccdBox.Text.Trim().Equals(""))
                txt_error3.Text = "Vui lòng nhập CCCD!";
            if (loaiPhongBox.Text == null || loaiPhongBox.Text.Equals(""))
                txt_error4.Text = "Vui lòng lựa chọn loại phòng!";
            if (loaiGiuongBox.Text == null || loaiPhongBox.Text.Equals(""))
                txt_error5.Text = "Vui lòng lựa chọn loại giường!";
            if (soPhongBox.Text == null || soPhongBox.Text.Equals(""))
                txt_error6.Text = "Vui lòng lựa chọn số phòng!";

            
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

        private void n_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void loaiPhongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_error4.Text = "";
            List<String> roomNo = Rooms_DAO.Instance.getRoomNo(loaiPhongBox.Text, loaiGiuongBox.Text);
            soPhongBox.Items.Clear();
            soPhongBox.Items.AddRange(roomNo.ToArray());
        }

        private void loaiGiuongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_error5.Text = "";
            List<String> roomNo = Rooms_DAO.Instance.getRoomNo(loaiPhongBox.Text, loaiGiuongBox.Text);
            soPhongBox.Items.Clear();
            soPhongBox.Items.AddRange(roomNo.ToArray());
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
    }
}
