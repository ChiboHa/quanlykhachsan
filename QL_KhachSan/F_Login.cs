using QL_KhachSan.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void F_Login_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void F_Login_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void F_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        // Nút đăng nhập
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private Boolean Login()
        {
            String
                username = usernameBox.Text,
                password = passwordBox.Text;

            if (Account_DAO.Instance.getLogin(username, password))
            {
                F_Home f = new F_Home(username,password);
                this.Hide();
                f.ShowDialog();
                //this.Show();
                usernameBox.Clear();
                passwordBox.Clear();
                return true;
            }
            else
            {
                if (usernameBox.Text.Trim().Equals(""))
                    txt_error_1.Text = "Vui lòng nhập tên đăng nhập!";
                if (passwordBox.Text.Trim().Equals(""))
                    txt_error_2.Text = "Vui lòng nhập mật khẩu!";
                else txt_error_2.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                return false;
            }
        }


        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_ForgotPassword f = new F_ForgotPassword();
            f.ShowDialog();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            usernameBox.Clear();
            passwordBox.Clear();
            txt_error_1.Text = "";
            txt_error_2.Text = "";
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            txt_error_1.Text = "";
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            txt_error_2.Text = "";
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void ExitButton_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizationButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
