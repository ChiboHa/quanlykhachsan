using QL_KhachSan.DAO;
using System;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_ResetPassword : Form
    {
        public String email;
        public F_ResetPassword()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void show1_Click(object sender, EventArgs e)
        {
            if (newPasswordBox.PasswordChar.Equals('\0'))
            {
                newPasswordBox.PasswordChar = '*';
            }
            else
            {
                newPasswordBox.PasswordChar = '\0';
            }
        }

        private void show2_Click(object sender, EventArgs e)
        {
            if (confirmNewPasswordBox.PasswordChar.Equals('\0'))
            {
                confirmNewPasswordBox.PasswordChar = '*';
            }
            else
            {
                confirmNewPasswordBox.PasswordChar = '\0';
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (newPasswordBox.Text.Equals(confirmNewPasswordBox.Text))
            {
                Account_DAO.Instance.updatePassword(newPasswordBox.Text, email);
                this.Close();
            }
            else txt_error.Text = "Password must be duplicate!";
        }

        private void newPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
            }
        }

        private void confirmNewPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
            }
        }

        private void newPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }

        private void confirmNewPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                e.Handled = true;
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
    }
}
