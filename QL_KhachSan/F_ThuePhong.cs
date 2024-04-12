using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            LoadRooms();
            btn_addroom.MouseEnter += new EventHandler(btn_addroom_MouseEnter);
            btn_addroom.MouseLeave += new EventHandler(btn_addroom_MouseLeave);
            btt_removeRoom.MouseEnter += new EventHandler(btn_removeRoom_MouseEnter);
            btt_removeRoom.MouseLeave += new EventHandler(btn_removeRoom_MouseLeave);
            btn_updateRoom.MouseEnter += new EventHandler(btn_updateRoom_MouseEnter);
            btn_updateRoom.MouseLeave += new EventHandler(btn_updateRoom_MouseLeave);
        }
        void LoadRooms()
        {
            List<Rooms> rooms = Rooms_DAO.Instance.LoadRoomsList();
            foreach (Rooms item in rooms)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Height = Rooms_DAO.RoomHeight;
                btn.Width = Rooms_DAO.RoomWidth;
                btn.Text = item.RoomNo;
                btn.Tag = item;
                btn.Font = new Font("Arial", 12, FontStyle.Regular);
                btn.ForeColor = Color.Black;
                btn.Click += (sender, e) =>
                {
                    Rooms room = (Rooms)btn.Tag;
                    panel_properties.Visible = false;
                    ClearRoomDetails();
                    panel_properties.Visible = true;
                    DisplayRoomDetails(room);
                };
                /*
                switch (item.Booked)
                {
                    case "NO":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.SpringGreen;
                        break;
                }*/
                if (item.RoomType == "Phòng VIP")
                {
                    layoutpanel_vip.Controls.Add(btn);
                }
                else if (item.RoomType == "Phòng thường")
                {
                    layoutpanel_normal.Controls.Add(btn);
                }
            }
        }

        private void ClearRoomDetails()
        {
            txt_roomNumber.Text = string.Empty;
            txt_roomType.Text = string.Empty;
            txt_bedType.Text = string.Empty;
            txt_roomPrice.Text = string.Empty;
        }

        private void DisplayRoomDetails(Rooms room)
        {
            // Hiển thị thông tin phòng trên các control tương ứng
            txt_roomNumber.Text = room.RoomNo;
            txt_roomType.Text = room.RoomType;
            txt_bedType.Text = room.BedType;
            txt_roomPrice.Text = room.Price.ToString();
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

        private void btn_removeRoom_MouseEnter(object sender, EventArgs e)
        {
            // Đổi màu của icon khi con trỏ chuột vào
            btt_removeRoom.Image = Properties.Resources.delete_hover;
        }

        private void btn_removeRoom_MouseLeave(object sender, EventArgs e)
        {
            // Đổi lại màu của icon khi con trỏ chuột rời đi
            btt_removeRoom.Image = Properties.Resources.delete;
        }

        private void btn_updateRoom_MouseEnter(object sender, EventArgs e)
        {
            // Đổi màu của icon khi con trỏ chuột vào
            btn_updateRoom.Image = Properties.Resources.update_hover;
        }

        private void btn_updateRoom_MouseLeave(object sender, EventArgs e)
        {
            // Đổi lại màu của icon khi con trỏ chuột rời đi
            btn_updateRoom.Image = Properties.Resources.update;
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            using (var f_addRoom = new F_AddRoom())
                if (f_addRoom.ShowDialog() == DialogResult.OK)
                {
                    ReloadRooms();
                }
        }

        private void btt_removeRoom_Click(object sender, EventArgs e)
        {
            // Lấy thông tin phòng đang được chọn
            string roomNo = txt_roomNumber.Text;

            // Xác nhận xóa phòng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Tạo đối tượng Room từ mã phòng
                Rooms roomToDelete = new Rooms(roomNo);

                // Gọi phương thức xóa phòng từ DAO
                Rooms_DAO.Instance.DeleteRoom(roomToDelete);

                // Xóa nút căn phòng tương ứng khỏi FlowLayoutPanel
                RemoveRoomButton(roomNo);
            }
        }

        private void ReloadRooms()
        {
            // Xóa hết các control phòng hiện có trong FlowLayoutPanel
            layoutpanel_vip.Controls.Clear();
            layoutpanel_normal.Controls.Clear();

            // Tải lại danh sách phòng
            LoadRooms();
        }

        private void RemoveRoomButton(string roomNo)
        {
            foreach (Control control in layoutpanel_vip.Controls)
            {
                if (control is System.Windows.Forms.Button button && ((Rooms)button.Tag).RoomNo == roomNo)
                {
                    layoutpanel_vip.Controls.Remove(button);
                    return;
                }
            }

            foreach (Control control in layoutpanel_normal.Controls)
            {
                if (control is System.Windows.Forms.Button button && ((Rooms)button.Tag).RoomNo == roomNo)
                {
                    layoutpanel_normal.Controls.Remove(button);
                    return;
                }
            }
        }

        private void btn_updateRoom_Click(object sender, EventArgs e)
        {
            if (panel_properties.Controls.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một căn phòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var f_updateRoom = new F_UpdateRoom())
                if (f_updateRoom.ShowDialog() == DialogResult.OK)
                {
                    ReloadRooms();
                }
        }
    }
}
