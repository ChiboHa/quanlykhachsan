using QL_KhachSan.DAO;
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
    public partial class F_Home : Form
    {
        F_KhachHang fKhachHang;
        F_ThuePhong fThuePhong;
        F_DVKhac fDVKhac;
        F_MonAn fFoodQL;
        F_DoUong fDoUong;
        F_NhanVien fNhanVien;
        F_Dashboard fDashboard;
        F_BangLuong fBangLuong;
        F_DatPhong fDatPhong;

        bool drag = false;
        Point start_point = new Point(0, 0);
        bool menuExpand = false,
             menuExpand2 = false,
             menuExpand3 = false,
             menuExpand4 = false,
             sidebarExpand = false;
        private string username;
        private string password;

        public F_Home(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            lXinChao.Hide();
            lDisplayName.Hide();

            fDashboard = new F_Dashboard();
            fDashboard.MdiParent = this;
            fDashboard.Dock = DockStyle.Fill;
            fDashboard.Show();
        }

        private void pHome_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pHome_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                mQLDV.Height += 20;
                if (mQLDV.Height >= 145)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                mQLDV.Height -= 20;
                if (mQLDV.Height <= 46)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void bQLDV_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                mQLTD.Height += 20;
                if (mQLTD.Height >= 145)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                mQLTD.Height -= 20;
                if (mQLTD.Height <= 46)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }


        private void menuTransition3_Tick(object sender, EventArgs e)
        {
            if (menuExpand3 == false)
            {
                mQLNV.Height += 20;
                if (mQLNV.Height >= 145)
                {
                    menuTransition3.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                mQLNV.Height -= 20;
                if (mQLNV.Height <= 46)
                {
                    menuTransition3.Stop();
                    menuExpand3 = false;
                }
            }
        }

        private void bQLTD_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width += 55;
                if (sidebar.Width >= 243)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pDashboard.Width = sidebar.Width;
                    pQLKH.Width = sidebar.Width;
                    pQLTD.Width = sidebar.Width;
                    pQLDV.Width = sidebar.Width;
                    pQLNV.Width = sidebar.Width;
                    pDangXuat.Width = sidebar.Width;

                    lXinChao.Show();
                    lDisplayName.Show();
                }
            }
            else
            {
                sidebar.Width -= 55;
                if (sidebar.Width <= 53)
                {

                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pDashboard.Width = sidebar.Width;
                    pQLKH.Width = sidebar.Width;
                    pQLTD.Width = sidebar.Width;
                    pQLDV.Width = sidebar.Width;
                    pQLNV.Width = sidebar.Width;
                    pDangXuat.Width = sidebar.Width;

                    lXinChao.Hide();
                    lDisplayName.Hide();
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            if (fDashboard == null)
            {
                fDashboard = new F_Dashboard();
                fDashboard.FormClosed += FDashboard_FormClosed;
                fDashboard.MdiParent = this;
                fDashboard.Dock = DockStyle.Fill;
                fDashboard.Show();
            }
            else
            {
                fDashboard.Activate();
            }
        }

        private void FDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDashboard = null;
        }

        private void bDVThuePhong_Click(object sender, EventArgs e)
        {
            if (fThuePhong == null)
            {
                fThuePhong = new F_ThuePhong();
                fThuePhong.FormClosed += FThuePhong_FormClosed;
                fThuePhong.MdiParent = this;
                fThuePhong.Dock = DockStyle.Fill;
                fThuePhong.Show();
            }
            else
            {
                fThuePhong.Activate();
            }
        }

        private void FThuePhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            fThuePhong = null;
        }

        private void bDVKhac_Click(object sender, EventArgs e)
        {
            if (fDVKhac == null)
            {
                fDVKhac = new F_DVKhac();
                fDVKhac.FormClosed += FDVKhac_FormClosed;
                fDVKhac.MdiParent = this;
                fDVKhac.Dock = DockStyle.Fill;
                fDVKhac.Show();
            }
            else
            {
                fDVKhac.Activate();
            }
        }

        private void FDVKhac_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDVKhac = null;
        }

        private void bQLKH_Click(object sender, EventArgs e)
        {
            menuTransition4.Start();
        }

        private void fKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            fKhachHang = null;
        }

        

        private void FNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            fNhanVien = null;
        }

        private void bMonAn_Click(object sender, EventArgs e)
        {
            if (fFoodQL == null)
            {
                fFoodQL = new F_MonAn();
                fFoodQL.FormClosed += fFoodQL_FormClosed;
                fFoodQL.MdiParent = this;
                fFoodQL.Dock = DockStyle.Fill;
                fFoodQL.Show();
            }
            else
            {
                fFoodQL.Activate();
            }
        }

        private void fFoodQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            fFoodQL = null;
        }

        private void bDoUong_Click(object sender, EventArgs e)
        {
            if (fDoUong == null)
            {
                fDoUong = new F_DoUong();
                fDoUong.FormClosed += FFood_FormClosed;
                fDoUong.MdiParent = this;
                fDoUong.Dock = DockStyle.Fill;
                fDoUong.Show();
            }
            else
            {
                fDoUong.Activate();
            }
        }

        private void FFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDoUong = null;
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
            string displayName = Account_DAO.Instance.getDisplayName(username, password);

            if (!string.IsNullOrEmpty(displayName))
            {
                lDisplayName.Text = displayName;
            }
            else
            {
                lDisplayName.Text = "Không có DisplayName";
            }
        }

        private void bDangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị form đăng nhập và ẩn form hiện tại
            F_Login fLogin = new F_Login();
            fLogin.Show();
            this.Hide();
        }


        private void FBangLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            fBangLuong = null;
        }

        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void b_QuanLyNV_Click(object sender, EventArgs e)
        {
            menuTransition3.Start();
        }

        private void bQLNV_Click(object sender, EventArgs e)
        {
            if (fNhanVien == null)
            {
                fNhanVien = new F_NhanVien();
                fNhanVien.FormClosed += FNhanVien_FormClosed;
                fNhanVien.MdiParent = this;
                fNhanVien.Dock = DockStyle.Fill;
                fNhanVien.Show();
            }
            else
            {
                fNhanVien.Activate();
            }
        }

        private void bBangLuong_Click(object sender, EventArgs e)
        {
            if (fBangLuong == null)
            {
                fBangLuong = new F_BangLuong();
                fBangLuong.FormClosed += FBangLuong_FormClosed;
                fBangLuong.MdiParent = this;
                fBangLuong.Dock = DockStyle.Fill;
                fBangLuong.Show();
            }
            else
            {
                fBangLuong.Activate();
            }
        }

        private void menuTransition4_Tick(object sender, EventArgs e)
        {
            if (menuExpand4 == false)
            {
                mQLKH.Height += 20;
                if (mQLKH.Height >= 145)
                {
                    menuTransition4.Stop();
                    menuExpand4 = true;
                }
            }
            else
            {
                mQLKH.Height -= 20;
                if (mQLKH.Height <= 46)
                {
                    menuTransition4.Stop();
                    menuExpand4 = false;
                }
            }
        }

        private void bDatPhong_Click(object sender, EventArgs e)
        {
            if (fDatPhong == null)
            {
                fDatPhong = new F_DatPhong();
                fDatPhong.FormClosed += fDatPhong_FormClosed;
                fDatPhong.MdiParent = this;
                fDatPhong.Dock = DockStyle.Fill;
                fDatPhong.Show();
            }
            else
            {
                fDatPhong.Activate();
            }
        }

        private void bTTDatPhong_Click(object sender, EventArgs e)
        {
            if (fKhachHang == null)
            {
                fKhachHang = new F_KhachHang();
                fKhachHang.FormClosed += fKhachHang_FormClosed;
                fKhachHang.MdiParent = this;
                fKhachHang.Dock = DockStyle.Fill;
                fKhachHang.Show();
            }
            else
            {
                fKhachHang.Activate();
            }
        }

        private void fDatPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDatPhong = null;
        }
    }
}
