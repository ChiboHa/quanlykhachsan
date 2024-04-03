using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace QL_KhachSan
{
    public partial class CropForm : Form
    {

        private Rectangle selectedRectangle;
        private Point startPoint;

        public CropForm(Image image)
        {
            InitializeComponent();
            pb_Image.Image = image;
            pb_Image.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public Image CroppedImage // Add this property to get the cropped image
        {
            get
            {
                Bitmap bmp = new Bitmap(selectedRectangle.Width, selectedRectangle.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(pb_Image.Image, 0, 0, selectedRectangle, GraphicsUnit.Pixel);
                g.Dispose();
                return bmp;
            }
        }


        public CropForm()
        {
            InitializeComponent();
        }

        private void pb_Image_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            Cursor = Cursors.Cross;
        }

        private void pb_Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int width = e.X - startPoint.X;
                int height = e.Y - startPoint.Y;

                // Đảm bảo kích thước của hình crop là tỉ lệ 1:1
                int size = Math.Min(width, height);
                if (width < 0)
                    startPoint.X -= Math.Abs(width = size);
                if (height < 0)
                    startPoint.Y -= Math.Abs(height = size);

                selectedRectangle = new Rectangle(startPoint.X, startPoint.Y, size, size);
                pb_Image.Refresh();
            }
        }

        private void pb_Image_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
            }
        }

        private void pb_Image_Paint(object sender, PaintEventArgs e)
        {
            if (pb_Image.Image != null)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, selectedRectangle);
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (selectedRectangle.Width > 0 && selectedRectangle.Height > 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a valid region to crop.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
