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
    public partial class F_ThuePhong : Form
    {
        public F_ThuePhong()
        {
            InitializeComponent();
            btn_addroom.MouseEnter += new EventHandler(btn_addroom_MouseEnter);
            btn_addroom.MouseLeave += new EventHandler(btn_addroom_MouseLeave);
        }
        private void btn_addroom_MouseEnter(object sender, EventArgs e)
        {
            // Đổi màu của icon khi con trỏ chuột vào
            btn_addroom.Image = Properties.Resources.plus_holder;
        }

        private void btn_addroom_MouseLeave(object sender, EventArgs e)
        {
            // Đổi lại màu của icon khi con trỏ chuột rời đi
            btn_addroom.Image = Properties.Resources.plus;
        }

        // Tạo danh sách lưu trữ roomNumber đã tồn tại
        List<string> existingRoomNumbers = new List<string>();

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            using (var f_addRoom = new F_AddRoom())
                if (f_addRoom.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thông tin đã nhập từ Form phụ
                    string roomNumber = f_addRoom.RoomNumber;
                    string roomType = f_addRoom.RoomType;
                    string bedType = f_addRoom.BedType;
                    string roomPrice = f_addRoom.RoomPrice;

                    if (existingRoomNumbers.Contains(roomNumber))
                    {
                        MessageBox.Show("Số phòng đã tồn tại. Vui lòng chọn số phòng khác.");
                    }
                    else
                    {
                        // Thêm button vào LayoutPanel của Form chính
                        AddButtonToMainForm(roomNumber, roomType, bedType, roomPrice);

                        // Cập nhật danh sách các roomNumber đã tồn tại
                        existingRoomNumbers.Add(roomNumber);
                    }
                }

        }
        private void AddButtonToMainForm(string roomNumber, string roomType, string bedType, string roomPrice)
        {
            // Tạo button mới
            SkyButton btnNew = new SkyButton();
            btnNew.Text = roomNumber;

            btnNew.Size = new Size(100, 50); // Kích thước 100x50 (width x height)

            // Thêm sự kiện Click cho button
            btnNew.Click += (sender, e) =>
            {
                panel_properties.Visible = false;
                ClearRoomDetails();
                panel_properties.Visible = true;
                DisplayRoomDetails(roomNumber, roomType, bedType, roomPrice);
            };

            if (roomType == "Phòng VIP")
            {
                layoutpanel_vip.Controls.Add(btnNew);
            }
            else if (roomType == "Phòng thường")
            {
                layoutpanel_normal.Controls.Add(btnNew);
            }
        }
        private void ClearRoomDetails()
        {
            txt_roomNumber.Text = string.Empty;
            txt_roomType.Text = string.Empty;
            txt_bedType.Text = string.Empty;
            txt_roomPrice.Text = string.Empty;
        }
        private void DisplayRoomDetails(string roomNumber, string roomType, string bedType, string roomPrice)
        {
            txt_roomNumber.Text = roomNumber;
            txt_roomType.Text = roomType;
            txt_bedType.Text = bedType;
            txt_roomPrice.Text = roomPrice;
        }
    }
}
