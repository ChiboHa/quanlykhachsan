﻿using QL_KhachSan.DAO;
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
        F_Customers fCustomers;
        F_ThuePhong fThuePhong;
        F_DVKhac fDVKhac;
        F_MonAn fMonAn;
        F_DoUong fDoUong;
        F_NhanVien fNhanVien;
        F_Dashboard fDashboard;

        bool drag = false;
        Point start_point = new Point(0, 0);
        bool menuExpand = false;
        bool menuExpand2 = false;
        bool sidebarExpand = true;

        private string username;
        private string password;

        public F_Home(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
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

        private void bQLTD_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
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

                }
            }
            else
            {
                sidebar.Width += 20;
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
            if (fCustomers == null)
            {
                fCustomers = new F_Customers();
                fCustomers.FormClosed += FCustomers_FormClosed;
                fCustomers.MdiParent = this;
                fCustomers.Dock = DockStyle.Fill;
                fCustomers.Show();
            }
            else
            {
                fCustomers.Activate();
            }
        }

        private void FCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            fCustomers = null;
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

        private void FNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            fNhanVien = null;
        }

        private void bMonAn_Click(object sender, EventArgs e)
        {
            if (fMonAn == null)
            {
                fMonAn = new F_MonAn();
                fMonAn.FormClosed += FMonAn_FormClosed;
                fMonAn.MdiParent = this;
                fMonAn.Dock = DockStyle.Fill;
                fMonAn.Show();
            }
            else
            {
                fMonAn.Activate();
            }
        }

        private void FMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMonAn = null;
        }

        private void bDoUong_Click(object sender, EventArgs e)
        {
            if (fDoUong == null)
            {
                fDoUong = new F_DoUong();
                fDoUong.FormClosed += FDoUong_FormClosed;
                fDoUong.MdiParent = this;
                fDoUong.Dock = DockStyle.Fill;
                fDoUong.Show();
            }
            else
            {
                fDoUong.Activate();
            }
        }

        private void FDoUong_FormClosed(object sender, FormClosedEventArgs e)
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

    }
}
