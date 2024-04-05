using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QL_KhachSan.DAO;

namespace QL_KhachSan
{
    public partial class F_NhanVienCRUD : Form
    {
        private NhanVien_DAO selectedEmployee;

        public F_NhanVienCRUD(NhanVien_DAO employee)
        {
            InitializeComponent();
            selectedEmployee = employee;

            // Hiển thị thông tin của nhân viên đã chọn
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
                txt_Luong.Text = selectedEmployee.Luong1h.ToString();
                txt_ChucVu.Text = selectedEmployee.Role;

                // Hiển thị hình ảnh của nhân viên
                if (selectedEmployee.Image != null && selectedEmployee.Image.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(selectedEmployee.Image))
                    {
                        pb_image.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Nếu không có hình ảnh, hiển thị hình ảnh mặc định
                    string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "user.jpg");
                    pb_image.Image = Image.FromFile(defaultImagePath);
                }
            }
        }

        private Image selectedImage;

        /*private void pb_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);

                // Mở CropForm và truyền ảnh đã chọn vào
                using (CropForm cropForm = new CropForm(image))
                {
                    if (cropForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedImage = cropForm.CroppedImage;
                        pb_image.Image = selectedImage;
                    }
                }
            }
        }*/

        private void pb_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);

                // Resize ảnh
                int newWidth, newHeight;
                if (image.Width > image.Height)
                {
                    newWidth = 512;
                    newHeight = (int)(((double)image.Height / image.Width) * 512);
                }
                else
                {
                    newWidth = (int)(((double)image.Width / image.Height) * 512);
                    newHeight = 512;
                }

                Image resizedImage = new Bitmap(image, newWidth, newHeight);

                // Mở CropForm và truyền ảnh đã thay đổi kích thước vào
                using (CropForm cropForm = new CropForm(resizedImage))
                {
                    if (cropForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedImage = cropForm.CroppedImage;
                        pb_image.Image = selectedImage;
                    }
                }
            }
        }


        private string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /*private void btn_save_Click(object sender, EventArgs e)
        {
            if (selectedImage != null)
            {
                // Tạo một đối tượng của lớp BLL để truy cập các chức năng
                classBLL objbll = new classBLL();

                // Chuyển đổi ảnh sang mảng byte[] trước khi lưu
                byte[] imageData = ImageToByteArray(selectedImage);

                // Tạo ID ngẫu nhiên
                string ID = GenerateRandomID(10);

                // Pass các giá trị cần thiết tới phương thức SaveItems của lớp BLL
                if (objbll.SaveItems(ID, txt_Ho.Text, txt_Ten.Text, txt_GioiTinh.Text, bDP_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_MaSoThue.Text, txt_Sdt.Text, txt_Luong.Text, imageData, txt_ChucVu.Text))
                {
                    MessageBox.Show("Success!!!");

                    // Đóng form sau khi lưu thành công
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        */

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (selectedImage != null)
            {
                // Tạo một đối tượng của lớp BLL để truy cập các chức năng
                classBLL objbll = new classBLL();

                // Chuyển đổi ảnh sang mảng byte[] trước khi lưu
                byte[] imageData = ImageToByteArray(selectedImage);

                if (selectedEmployee == null)
                {
                    // Thêm mới nhân viên
                    // Tạo ID ngẫu nhiên
                    string ID = GenerateRandomID(10);

                    // Pass các giá trị cần thiết tới phương thức SaveItems của lớp BLL để thêm mới nhân viên
                    if (objbll.SaveItems(ID, txt_Ho.Text, txt_Ten.Text, txt_GioiTinh.Text, bDP_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_MaSoThue.Text, txt_Sdt.Text, txt_Luong.Text, imageData, txt_ChucVu.Text))
                    {
                        MessageBox.Show("Success!!!");

                        // Đóng form sau khi lưu thành công
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
                else
                {
                    // Cập nhật thông tin nhân viên
                    // Pass các giá trị cần thiết tới phương thức UpdateItems của lớp BLL để cập nhật thông tin nhân viên
                    if (objbll.UpdateItems(selectedEmployee.ID, txt_Ho.Text, txt_Ten.Text, txt_GioiTinh.Text, bDP_NgaySinh.Value, txt_CCCD.Text, txt_Email.Text, txt_MaSoThue.Text, txt_Sdt.Text, txt_Luong.Text, imageData, txt_ChucVu.Text))
                    {
                        MessageBox.Show("Employee information updated successfully!");

                        // Đóng form sau khi cập nhật thành công
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update employee information!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Hàm chuyển đổi ảnh sang mảng byte[]
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg); // Lưu dưới định dạng JPEG, bạn có thể thay đổi nếu muốn
                return ms.ToArray();
            }
        }
    }
}
