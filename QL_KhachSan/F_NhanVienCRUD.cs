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
        public F_NhanVienCRUD()
        {
            InitializeComponent();
        }

        private Image selectedImage;

        private void pb_image_Click(object sender, EventArgs e)
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
        }

        private string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_save_Click(object sender, EventArgs e)
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
