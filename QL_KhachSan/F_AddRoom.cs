using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_KhachSan
{
    public partial class F_AddRoom : Form
    {
        public F_AddRoom()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (txtBox_roomNumber.Text != "" && comboBox_roomType.Text != "" && comboBox_bedType.Text != "" && txtBox_roomPrice.Text != "")
            {
                string roomNo = txtBox_roomNumber.Text;
                string roomType = comboBox_roomType.SelectedItem.ToString();
                string bedType = comboBox_bedType.SelectedItem.ToString();
                int price = int.Parse(txtBox_roomPrice.Text);
                string booked = "No";
                Rooms newRoom = new Rooms(0, roomNo, roomType, bedType, price, booked);
                Rooms_DAO.Instance.AddRoom(newRoom);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
