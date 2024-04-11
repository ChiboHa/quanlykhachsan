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
            setup();
        }

        private void setup()
        {
            List<Rooms> list = Rooms_DAO.Instance.LoadRoomsList();
            List<String> roomNo = new List<String>();
            HashSet<String> roomType = new HashSet<String>(),
                            bedType = new HashSet<String>();

            foreach (var item in list)
            {
                roomNo.Add(item.RoomNo);
                roomType.Add(item.RoomType);
                bedType.Add(item.BedType);
            }

            loaiPhongBox.Items.AddRange(roomType.ToArray());
            loaiGiuongBox.Items.AddRange(bedType.ToArray());
            soPhongBox.Items.AddRange(roomNo.ToArray());
        }


        private void b_DatPhongTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;

        }

        private void b_ThanhToanTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã chọn tiếp tục.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn đã chọn hủy bỏ.", "Thông báo");
            }*/

            if (hoTenBox.Text.Trim().Equals(""))
                txt_error1.Text = "Vui lòng nhập họ tên!";
            if (sdtBox.Text.Trim().Equals(""))
                txt_error2.Text = "Vui lòng nhập số điện thoại!";
            if (cccdBox.Text.Trim().Equals(""))
                txt_error3.Text = "Vui lòng nhập CCCD!";

            /* if (loaiPhongBox.SelectedItem.ToString().Trim().Equals(""))
                 txt_error4.Text = "Vui lòng nhập loại phòng!";
             if (loaiGiuongBox.SelectedItem.ToString().Trim().Equals(""))
                 txt_error5.Text = "Vui lòng nhập loại giường!";
             if (soPhongBox.SelectedItem.ToString().Trim().Equals(""))
                 txt_error6.Text = "Vui lòng nhập số phòng!";*/
        }
    }
}
