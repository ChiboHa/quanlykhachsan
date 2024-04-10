using System;
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
        }
    }
}
