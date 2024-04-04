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
    public partial class F_AddRoom : Form
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }
        public string RoomPrice { get; set; }

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
            RoomNumber = txtBox_roomNumber.Text; // Lưu thông tin đã nhập vào thuộc tính của Form phụ
            RoomType = comboBox_roomType.Text;
            BedType = comboBox_bedType.Text;
            RoomPrice = txtBox_roomPrice.Text;
            this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK để thông báo việc nhập đã hoàn thành
        }
    }
}
