namespace QL_KhachSan
{
    partial class F_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Label();
            this.txt_error_2 = new System.Windows.Forms.Label();
            this.txt_error_1 = new System.Windows.Forms.Label();
            this.minimizationButton = new System.Windows.Forms.PictureBox();
            this.ExitButton_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassword.LinkColor = System.Drawing.Color.Black;
            this.forgotPassword.Location = new System.Drawing.Point(102, 460);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(91, 13);
            this.forgotPassword.TabIndex = 8;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Forgot password?";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassword_LinkClicked);
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(65, 205);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(202, 23);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            this.usernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameBox_KeyPress);
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(65, 292);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(202, 23);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordBox_KeyPress);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(104, 127);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(89, 45);
            this.bigLabel1.TabIndex = 9;
            this.bigLabel1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(31, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(31, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 13;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(31, 380);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(236, 44);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(219, 353);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(49, 16);
            this.reset.TabIndex = 17;
            this.reset.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // txt_error_2
            // 
            this.txt_error_2.AutoSize = true;
            this.txt_error_2.ForeColor = System.Drawing.Color.Black;
            this.txt_error_2.Location = new System.Drawing.Point(33, 333);
            this.txt_error_2.Name = "txt_error_2";
            this.txt_error_2.Size = new System.Drawing.Size(0, 13);
            this.txt_error_2.TabIndex = 7;
            // 
            // txt_error_1
            // 
            this.txt_error_1.AutoSize = true;
            this.txt_error_1.ForeColor = System.Drawing.Color.Black;
            this.txt_error_1.Location = new System.Drawing.Point(33, 245);
            this.txt_error_1.Name = "txt_error_1";
            this.txt_error_1.Size = new System.Drawing.Size(0, 13);
            this.txt_error_1.TabIndex = 18;
            // 
            // minimizationButton
            // 
            this.minimizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizationButton.Image = global::QL_KhachSan.Properties.Resources.minus;
            this.minimizationButton.Location = new System.Drawing.Point(222, 12);
            this.minimizationButton.Name = "minimizationButton";
            this.minimizationButton.Size = new System.Drawing.Size(24, 16);
            this.minimizationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizationButton.TabIndex = 20;
            this.minimizationButton.TabStop = false;
            this.minimizationButton.Click += new System.EventHandler(this.minimizationButton_Click);
            // 
            // ExitButton_2
            // 
            this.ExitButton_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton_2.Image = global::QL_KhachSan.Properties.Resources.close;
            this.ExitButton_2.Location = new System.Drawing.Point(264, 12);
            this.ExitButton_2.Name = "ExitButton_2";
            this.ExitButton_2.Size = new System.Drawing.Size(15, 15);
            this.ExitButton_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton_2.TabIndex = 19;
            this.ExitButton_2.TabStop = false;
            this.ExitButton_2.Click += new System.EventHandler(this.ExitButton_2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QL_KhachSan.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(31, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 534);
            this.Controls.Add(this.minimizationButton);
            this.Controls.Add(this.ExitButton_2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.txt_error_1);
            this.Controls.Add(this.txt_error_2);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Login";
            this.Text = "Đăng nhập";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.LinkLabel forgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label reset;
        private System.Windows.Forms.Label txt_error_2;
        private System.Windows.Forms.Label txt_error_1;
        private System.Windows.Forms.PictureBox ExitButton_2;
        private System.Windows.Forms.PictureBox minimizationButton;
    }
}

