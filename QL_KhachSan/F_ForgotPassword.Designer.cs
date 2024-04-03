namespace QL_KhachSan
{
    partial class F_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ForgotPassword));
            this.emailBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codePicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_error = new System.Windows.Forms.Label();
            this.emailPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizationButton = new System.Windows.Forms.PictureBox();
            this.ExitButton_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Location = new System.Drawing.Point(100, 245);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(416, 25);
            this.emailBox.TabIndex = 4;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            this.emailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailBox_KeyDown);
            this.emailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailBox_KeyPress);
            // 
            // codeBox
            // 
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBox.Location = new System.Drawing.Point(100, 246);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(416, 25);
            this.codeBox.TabIndex = 5;
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeBox_KeyDown);
            this.codeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeBox_KeyPress);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Black;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.Location = new System.Drawing.Point(52, 310);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(465, 49);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Reset Password";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24.75F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(140, 121);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(266, 51);
            this.bigLabel1.TabIndex = 10;
            this.bigLabel1.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter your email to reset Password";
            // 
            // codePicture
            // 
            this.codePicture.Image = ((System.Drawing.Image)(resources.GetObject("codePicture.Image")));
            this.codePicture.Location = new System.Drawing.Point(51, 241);
            this.codePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codePicture.Name = "codePicture";
            this.codePicture.Size = new System.Drawing.Size(41, 25);
            this.codePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codePicture.TabIndex = 13;
            this.codePicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(51, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 1);
            this.panel2.TabIndex = 14;
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.Location = new System.Drawing.Point(68, 286);
            this.txt_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(0, 16);
            this.txt_error.TabIndex = 15;
            // 
            // emailPicture
            // 
            this.emailPicture.Image = ((System.Drawing.Image)(resources.GetObject("emailPicture.Image")));
            this.emailPicture.Location = new System.Drawing.Point(51, 241);
            this.emailPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailPicture.Name = "emailPicture";
            this.emailPicture.Size = new System.Drawing.Size(41, 25);
            this.emailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPicture.TabIndex = 16;
            this.emailPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "The confirmation code has been sent to your email";
            // 
            // minimizationButton
            // 
            this.minimizationButton.Image = global::QL_KhachSan.Properties.Resources.minus;
            this.minimizationButton.Location = new System.Drawing.Point(476, 12);
            this.minimizationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizationButton.Name = "minimizationButton";
            this.minimizationButton.Size = new System.Drawing.Size(32, 20);
            this.minimizationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizationButton.TabIndex = 22;
            this.minimizationButton.TabStop = false;
            this.minimizationButton.Click += new System.EventHandler(this.minimizationButton_Click);
            // 
            // ExitButton_2
            // 
            this.ExitButton_2.Image = global::QL_KhachSan.Properties.Resources.close;
            this.ExitButton_2.Location = new System.Drawing.Point(532, 12);
            this.ExitButton_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton_2.Name = "ExitButton_2";
            this.ExitButton_2.Size = new System.Drawing.Size(20, 18);
            this.ExitButton_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton_2.TabIndex = 21;
            this.ExitButton_2.TabStop = false;
            this.ExitButton_2.Click += new System.EventHandler(this.ExitButton_2_Click);
            // 
            // F_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 388);
            this.Controls.Add(this.minimizationButton);
            this.Controls.Add(this.ExitButton_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailPicture);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.codePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_ForgotPassword";
            this.Text = "Forgot Password";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_ForgotPassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_ForgotPassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_ForgotPassword_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox codeBox;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox codePicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_error;
        private System.Windows.Forms.PictureBox emailPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox minimizationButton;
        private System.Windows.Forms.PictureBox ExitButton_2;
    }
}