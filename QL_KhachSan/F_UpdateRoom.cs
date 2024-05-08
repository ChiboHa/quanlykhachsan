using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
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
    public partial class F_UpdateRoom : Form
    {
        private Rooms selectedRoom;

        public F_UpdateRoom(Rooms room)
        {
            InitializeComponent();
            if (room != null)
            {
                selectedRoom = room;
                DisplaySelectedRoom();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một căn phòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_update_Click(object sender, EventArgs e)
        {
            if (txtBox_roomNumber.Text != "" && comboBox_roomType.Text != "" && comboBox_bedType.Text != "" && txtBox_roomPrice.Text != "")
            {
                string roomNo = txtBox_roomNumber.Text;
                string roomType = comboBox_roomType.SelectedItem.ToString();
                string bedType = comboBox_bedType.SelectedItem.ToString();
                int price = int.Parse(txtBox_roomPrice.Text);
                string booked = comboBox_booked.SelectedItem.ToString();
                Rooms updatedRoom = new Rooms(0, roomNo, roomType, bedType, price, booked);
                Rooms_DAO.Instance.UpdateRoom(updatedRoom);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DisplaySelectedRoom()
        {
            if (selectedRoom != null)
            {
                txtBox_roomNumber.Text = selectedRoom.RoomNo;
                comboBox_roomType.SelectedItem = selectedRoom.RoomType;
                comboBox_bedType.SelectedItem = selectedRoom.BedType;
                txtBox_roomPrice.Text = selectedRoom.Price.ToString();
                comboBox_booked.SelectedItem = selectedRoom.Booked;
            }
        }

    }
}
