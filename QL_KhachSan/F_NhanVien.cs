using Microsoft.SqlServer.Server;
using QL_KhachSan.DAO;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_NhanVien : Form
    {
        public F_NhanVien()
        {
            InitializeComponent();
            //LoadEmployeeInformation();

            //sample data
            /*for (int i = 0; i < 100; i++)
            {
                grid.Rows.Add(new object[]
                {

                });
            }*/

            // Gọi phương thức để lấy danh sách nhân viên từ cơ sở dữ liệu
            List<NhanVien_DAO> nhanViens = NhanVien_DAO.Instance.GetNhanViens();

            // Hiển thị dữ liệu trên grid
            int stt = 1; // Biến số thứ tự bắt đầu từ 1
            foreach (NhanVien_DAO nhanVien in nhanViens)
            {
                grid.Rows.Add(new object[]
                {
                stt++,
                nhanVien.ID, // Thêm giá trị ID nhưng ẩn cột đi
                nhanVien.Ho,
                nhanVien.Ten,
                nhanVien.NgaySinh.ToShortDateString(), // Hiển thị ngày sinh dưới dạng ngày/tháng/năm
                nhanVien.GioiTinh,
                nhanVien.Role, // Chức vụ
                nhanVien.Luong1h // Lương
                });
            }
            grid.Columns["ID"].Visible = false;

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
            }
            catch (Exception ex)
            {

            }
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception ex)
            {

            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception ex)
            {

            }
        }




        bool p_ThongtinExpand = false;
        private void p_ThongtinTransition_Tick_1(object sender, EventArgs e)
        {
            if (p_ThongtinExpand == false)
            {
                p_Thongtin.Width += 20;
                if (p_Thongtin.Width >= 325)
                {

                    p_ThongtinExpand = true;
                    p_ThongtinTransition.Stop();
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                string employeeID = row.Cells["ID"].Value.ToString();

                // Gọi phương thức để lấy thông tin của nhân viên dựa trên ID
                NhanVien_DAO selectedEmployee = NhanVien_DAO.Instance.GetEmployeeByID(employeeID);

                // Hiển thị thông tin nhân viên trong các thành phần tương ứng
                if (selectedEmployee != null)
                {
                    txt_Ho.Text = selectedEmployee.Ho;
                    txt_Ten.Text = selectedEmployee.Ten;
                    txt_GioiTinh.Text = selectedEmployee.GioiTinh;
                    bDP_NgaySinh.Value = selectedEmployee.NgaySinh;
                    txt_CCCD.Text = selectedEmployee.CCCD;
                    txt_Email.Text = selectedEmployee.Email;
                    txt_MaSoThue.Text = selectedEmployee.MaSoThue;
                    txt_Sdt.Text = selectedEmployee.SoDienThoai;
                    txt_Luong1h.Text = selectedEmployee.Luong1h.ToString();
                    txt_ChucVu.Text = selectedEmployee.Role;

                    // Hiển thị hình ảnh của nhân viên (giả sử bạn có một PictureBox có tên là pb_Image)
                    if (selectedEmployee.Image != null && selectedEmployee.Image.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(selectedEmployee.Image))
                        {
                            pb_Image.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Nếu không có hình ảnh, hiển thị hình ảnh mặc định
                        string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "user.jpg");
                        pb_Image.Image = Image.FromFile(defaultImagePath);
                    }

                    // Đặt thuộc tính ReadOnly của các TextBox thành true
                    txt_Ho.Enabled = false;
                    txt_Ten.Enabled = false;
                    txt_GioiTinh.Enabled = false;
                    bDP_NgaySinh.Enabled = false; // Không cho chỉnh sửa ngày sinh
                    txt_CCCD.Enabled = false;
                    txt_Email.Enabled = false;
                    txt_MaSoThue.Enabled = false;
                    txt_Sdt.Enabled = false;
                    txt_Luong1h.Enabled = false;
                    txt_ChucVu.Enabled = false;
                    // Tạm thời gỡ bỏ xử lý sự kiện click cho pb_Image
                }

                p_ThongtinTransition.Start();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong grid không
            if (grid.SelectedRows.Count > 0)
            {
                // Lấy ID của nhân viên từ hàng được chọn
                string employeeID = grid.SelectedRows[0].Cells["ID"].Value.ToString();

                // Xóa nhân viên dựa trên ID
                NhanVien_DAO.Instance.DeleteEmployeeByID(employeeID);

                // Sau khi xóa, làm mới lại danh sách nhân viên và grid
                LoadEmployeeData();
            }
        }

        private void LoadEmployeeData()
        {
            // Xóa tất cả các hàng trong grid
            grid.Rows.Clear();

            // Gọi phương thức để lấy danh sách nhân viên từ cơ sở dữ liệu và hiển thị trên grid
            List<NhanVien_DAO> nhanViens = NhanVien_DAO.Instance.GetNhanViens();
            int stt = 1; // Biến số thứ tự bắt đầu từ 1
            foreach (NhanVien_DAO nhanVien in nhanViens)
            {
                grid.Rows.Add(new object[]
                {
            stt++,
            nhanVien.ID, // Thêm giá trị ID nhưng ẩn cột đi
            nhanVien.Ho,
            nhanVien.Ten,
            nhanVien.NgaySinh.ToShortDateString(), // Hiển thị ngày sinh dưới dạng ngày/tháng/năm
            nhanVien.GioiTinh,
            nhanVien.Role, // Chức vụ
            nhanVien.Luong1h // Lương
                });
            }
            grid.Columns["ID"].Visible = false;
            p_ThongtinTransition.Start();
        }

        bool p_ThongtinExpand2 = true;
        private void p_ThongtinTransitionClose_Tick(object sender, EventArgs e)
        {
            if (p_ThongtinExpand2)
            {
                p_Thongtin.Width -=20;
                if (p_Thongtin.Width <= 0)
                {

                    p_ThongtinExpand = false;
                    p_ThongtinTransitionClose.Stop();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            F_NhanVienCRUD nhanVienCRUD = new F_NhanVienCRUD();
            nhanVienCRUD.ShowDialog();
            LoadEmployeeData();
        }
    }
}
