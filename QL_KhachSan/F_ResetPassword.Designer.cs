namespace QL_KhachSan
{
    partial class F_ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ResetPassword));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.show1 = new System.Windows.Forms.PictureBox();
            this.show2 = new System.Windows.Forms.PictureBox();
            this.txt_error = new System.Windows.Forms.Label();
            this.minimizationButton = new System.Windows.Forms.PictureBox();
            this.ExitButton_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(115, 30);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(206, 40);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "RESET PASSWORD";
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordBox.Location = new System.Drawing.Point(36, 119);
            this.newPasswordBox.Multiline = true;
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(311, 23);
            this.newPasswordBox.TabIndex = 12;
            this.newPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPasswordBox_KeyDown);
            this.newPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPasswordBox_KeyPress);
            // 
            // confirmNewPasswordBox
            // 
            this.confirmNewPasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.confirmNewPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmNewPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordBox.Location = new System.Drawing.Point(36, 191);
            this.confirmNewPasswordBox.Multiline = true;
            this.confirmNewPasswordBox.Name = "confirmNewPasswordBox";
            this.confirmNewPasswordBox.PasswordChar = '*';
            this.confirmNewPasswordBox.Size = new System.Drawing.Size(311, 23);
            this.confirmNewPasswordBox.TabIndex = 15;
            this.confirmNewPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmNewPasswordBox_KeyDown);
            this.confirmNewPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmNewPasswordBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirm new password";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(125, 243);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(147, 40);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // show1
            // 
            this.show1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show1.Image = ((System.Drawing.Image)(resources.GetObject("show1.Image")));
            this.show1.Location = new System.Drawing.Point(347, 119);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(23, 23);
            this.show1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show1.TabIndex = 21;
            this.show1.TabStop = false;
            this.show1.Click += new System.EventHandler(this.show1_Click);
            // 
            // show2
            // 
            this.show2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show2.Image = ((System.Drawing.Image)(resources.GetObject("show2.Image")));
            this.show2.Location = new System.Drawing.Point(347, 191);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(23, 23);
            this.show2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show2.TabIndex = 22;
            this.show2.TabStop = false;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // txt_error
            // 
            this.txt_error.AutoSize = true;
            this.txt_error.ForeColor = System.Drawing.Color.Black;
            this.txt_error.Location = new System.Drawing.Point(32, 211);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(0, 19);
            this.txt_error.TabIndex = 24;
            // 
            // minimizationButton
            // 
            this.minimizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizationButton.Image = global::QL_KhachSan.Properties.Resources.minus;
            this.minimizationButton.Location = new System.Drawing.Point(342, 8);
            this.minimizationButton.Name = "minimizationButton";
            this.minimizationButton.Size = new System.Drawing.Size(24, 16);
            this.minimizationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizationButton.TabIndex = 26;
            this.minimizationButton.TabStop = false;
            this.minimizationButton.Click += new System.EventHandler(this.minimizationButton_Click);
            // 
            // ExitButton_2
            // 
            this.ExitButton_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton_2.Image = global::QL_KhachSan.Properties.Resources.close;
            this.ExitButton_2.Location = new System.Drawing.Point(384, 8);
            this.ExitButton_2.Name = "ExitButton_2";
            this.ExitButton_2.Size = new System.Drawing.Size(15, 15);
            this.ExitButton_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton_2.TabIndex = 25;
            this.ExitButton_2.TabStop = false;
            this.ExitButton_2.Click += new System.EventHandler(this.ExitButton_2_Click);
            // 
            // F_ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 302);
            this.Controls.Add(this.minimizationButton);
            this.Controls.Add(this.ExitButton_2);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.show2);
            this.Controls.Add(this.show1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmNewPasswordBox);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.bigLabel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_ResetPassword";
            this.Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)(this.show1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.TextBox confirmNewPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox show1;
        private System.Windows.Forms.PictureBox show2;
        private System.Windows.Forms.Label txt_error;
        private System.Windows.Forms.PictureBox minimizationButton;
        private System.Windows.Forms.PictureBox ExitButton_2;
    }
}