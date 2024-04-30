using QL_KhachSan.DAO;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_CheckOut_Messages : Form
    {
        string id_KH, id_HDP, room_id;

        string roomNo; // Số phòng

        string totalDays; // Số ngày ở

        double pricePerDay; // Đơn giá

        double totalAmount; // Tổng phải trả

        String roomType;

        public F_CheckOut_Messages(String id_HDP)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.id_HDP = id_HDP;
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            checkThanhToan();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            checkThanhToan();
        }

        private void bt_continue_Click_1(object sender, EventArgs e)
        {
            if (dropdown_pttt.SelectedIndex == 0)
            {
                txt_totalAmount_2.Text = totalAmount.ToString("N0") + " VND";
                bunifuPages1.PageIndex = 2;
            }
            else if (dropdown_pttt.SelectedIndex == 1)
            {
                string GetRoomNo = Rooms_DAO.Instance.GetRoomNo(room_id);
                getQR("Thanh toan tien phong " + GetRoomNo, totalAmount + "");
                checkOut(totalAmount);
                bunifuPages1.PageIndex = 1;
            }
        }

        private void F_CheckOut_Messages_Load(object sender, EventArgs e)
        {
            getInfo();
            txt_roomNo.Text = "Phòng " + roomNo;
            txt_roomType.Text = roomType;
            txt_totalDay.Text = totalDays;
            txt_pricePerDay.Text = pricePerDay.ToString("N0") + " VND";
            txt_totalAmount.Text = totalAmount.ToString("N0") + " VND";
        }

        // Hàm thanh toán
        /*private void checkOut()
        {
            Rooms_DAO.Instance.setBooked("NO", room_id);
            Bill_Room_DAO.Instance.checkOut(id_HDP);
        }*/

        // Hàm thanh toán
        private void checkOut(double totalAmount)
        {
            Rooms_DAO.Instance.setBooked("NO", room_id);
            Bill_Room_DAO.Instance.checkOut(id_HDP, totalAmount);
        }

        private void getQR(String noidung, String soTien)
        {
            string
                bank_ID = "BIDV",
                stk = "3711059531",
                template = "compact2",
                amount = soTien,
                description = HttpUtility.UrlEncode(noidung),
                accountName = HttpUtility.UrlEncode("Nguyễn Thành Long");

            string imageUrl = "https://img.vietqr.io/image/" + bank_ID + "-" + stk + "-" + template + ".png?amount=" + amount + "&addInfo=" + description + "&accountName=" + accountName;

            // Tải ảnh từ đường link trang web
            WebClient webClient = new WebClient();
            byte[] imageData = webClient.DownloadData(imageUrl);
            webClient.Dispose();

            // Chuyển đổi dữ liệu byte thành hình ảnh
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image img = Image.FromStream(ms);

                // Hiển thị hình ảnh trên PictureBox
                pictureBox_QRcode.SizeMode = PictureBoxSizeMode.StretchImage; // Đổi size ảnh tự động theo PictureBox
                pictureBox_QRcode.Image = img;
            }
        }

        private void b_DatPhong_Click(object sender, EventArgs e)
        {
            checkThanhToan();
        }

        private void checkThanhToan()
        {
            DialogResult result = MessageBox.Show("Xác nhận khách hàng đã thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                checkOut(totalAmount);
                this.Close();
            }
        }

        private void getInfo()
        {
            // Lấy ra id phòng từ khóa ngoại HĐP
            room_id = Bill_Room_DAO.Instance.GetRoomID(id_HDP);

            roomNo = Rooms_DAO.Instance.GetRoomNo(room_id);

            totalDays = Bill_Room_DAO.Instance.getTotalDays(id_HDP); // Số ngày ở

            pricePerDay = Rooms_DAO.Instance.GetPrice(room_id); // Đơn giá

            totalAmount = Convert.ToDouble(totalDays) * pricePerDay; // Tổng phải trả

            roomType = Rooms_DAO.Instance.GetRoomType(room_id); // Kiểu phòng

        }
    }
}
