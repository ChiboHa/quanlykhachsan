using QL_KhachSan.DAO;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_ForgotPassword : Form
    {
        //private String profileName = "NguyenLong"; // Email config
        private String profileName = "F4";
        private long randomNumber;
        private int status = 3;

        public F_ForgotPassword()
        {
            InitializeComponent();
            this.CenterToScreen();
            codeBox.Visible = false;
            label2.Visible = false;

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            forgotPassword();
        }

        private void forgotPassword()
        {
            Random rd = new Random();

            if (!codeBox.Visible)
            {
                randomNumber = rd.Next(10000, 99999);

                if (emailBox.Text.Trim().Equals(""))
                {
                    txt_error.Text = "Please enter your email!";
                    emailBox.Focus();
                }
                else if (!IsValidEmail(emailBox.Text))
                {
                    txt_error.Text = "Invalid email, Please re-enter your email!";
                    emailBox.Focus();
                }
                else
                {
                    if (Account_DAO.Instance.checkEmail(emailBox.Text))
                    {
                        Account_DAO.Instance.sendEmail(profileName, emailBox.Text, randomNumber);
                        acceptButton.Text = "Confirm";
                        emailBox.Visible = false;
                        codeBox.Visible = true;
                        emailPicture.Visible = false;
                        label1.Visible = false;
                        label2.Visible = true;
                    }
                    else
                    {
                        txt_error.Text = "Your account was not found, please re-enter!";
                        emailBox.Focus();
                    }
                }
            }
            else
            {
                if (codeBox.Text.Trim().Equals(randomNumber.ToString()))
                {
                    this.Hide();
                    F_ResetPassword rs_password = new F_ResetPassword();
                    rs_password.email = emailBox.Text;
                    rs_password.ShowDialog();
                    this.Close();
                }
                else if (status > 0)
                {
                    txt_error.Text = "Invalid verification code! You have " + status + " times left";
                    emailBox.Focus();
                    status--;
                }
                else
                {
                    txt_error.Text = "Verification code has expired!";
                    acceptButton.Enabled = false;
                }
            }
        }

        // Trả về true nếu chuỗi là email hợp lệ
        private bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            txt_error.Text = "";
        }

        private void emailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }
        private void codeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void emailBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceptButton.PerformClick();
            }
        }

        private void codeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceptButton.PerformClick();
            }
        }

        private void ExitButton_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizationButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void F_ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void F_ForgotPassword_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void F_ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }
    }
}
