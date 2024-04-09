namespace QL_KhachSan
{
    partial class F_AddRoom
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
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btt_add = new ReaLTaiizor.Controls.ForeverButton();
            this.comboBox_bedType = new ReaLTaiizor.Controls.PoisonComboBox();
            this.comboBox_roomType = new ReaLTaiizor.Controls.PoisonComboBox();
            this.txtBox_roomPrice = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtBox_roomNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txt_roomPrice = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_bedType = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_roomType = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_roomNumber = new ReaLTaiizor.Controls.FoxLabel();
            this.title_addRoom = new ReaLTaiizor.Controls.SkyLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Image = global::QL_KhachSan.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(435, 16);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(15, 15);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 23;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btt_add
            // 
            this.btt_add.BackColor = System.Drawing.Color.Transparent;
            this.btt_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btt_add.Location = new System.Drawing.Point(172, 345);
            this.btt_add.Name = "btt_add";
            this.btt_add.Rounded = false;
            this.btt_add.Size = new System.Drawing.Size(120, 40);
            this.btt_add.TabIndex = 22;
            this.btt_add.Text = "Thêm phòng";
            this.btt_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // comboBox_bedType
            // 
            this.comboBox_bedType.FormattingEnabled = true;
            this.comboBox_bedType.ItemHeight = 23;
            this.comboBox_bedType.Items.AddRange(new object[] {
            "Giường đơn",
            "Giường đôi"});
            this.comboBox_bedType.Location = new System.Drawing.Point(109, 206);
            this.comboBox_bedType.Name = "comboBox_bedType";
            this.comboBox_bedType.Size = new System.Drawing.Size(323, 29);
            this.comboBox_bedType.TabIndex = 21;
            this.comboBox_bedType.UseSelectable = true;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.ItemHeight = 23;
            this.comboBox_roomType.Items.AddRange(new object[] {
            "Phòng thường",
            "Phòng VIP"});
            this.comboBox_roomType.Location = new System.Drawing.Point(109, 143);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(323, 29);
            this.comboBox_roomType.TabIndex = 20;
            this.comboBox_roomType.UseSelectable = true;
            // 
            // txtBox_roomPrice
            // 
            this.txtBox_roomPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_roomPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBox_roomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_roomPrice.EdgeColor = System.Drawing.Color.White;
            this.txtBox_roomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_roomPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_roomPrice.Location = new System.Drawing.Point(109, 275);
            this.txtBox_roomPrice.MaxLength = 32767;
            this.txtBox_roomPrice.Multiline = false;
            this.txtBox_roomPrice.Name = "txtBox_roomPrice";
            this.txtBox_roomPrice.ReadOnly = false;
            this.txtBox_roomPrice.Size = new System.Drawing.Size(323, 28);
            this.txtBox_roomPrice.TabIndex = 19;
            this.txtBox_roomPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_roomPrice.UseSystemPasswordChar = false;
            // 
            // txtBox_roomNumber
            // 
            this.txtBox_roomNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_roomNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtBox_roomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_roomNumber.EdgeColor = System.Drawing.Color.White;
            this.txtBox_roomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_roomNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBox_roomNumber.Location = new System.Drawing.Point(109, 84);
            this.txtBox_roomNumber.MaxLength = 32767;
            this.txtBox_roomNumber.Multiline = false;
            this.txtBox_roomNumber.Name = "txtBox_roomNumber";
            this.txtBox_roomNumber.ReadOnly = false;
            this.txtBox_roomNumber.Size = new System.Drawing.Size(323, 28);
            this.txtBox_roomNumber.TabIndex = 18;
            this.txtBox_roomNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_roomNumber.UseSystemPasswordChar = false;
            // 
            // txt_roomPrice
            // 
            this.txt_roomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_roomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_roomPrice.Location = new System.Drawing.Point(21, 284);
            this.txt_roomPrice.Name = "txt_roomPrice";
            this.txt_roomPrice.Size = new System.Drawing.Size(82, 19);
            this.txt_roomPrice.TabIndex = 17;
            this.txt_roomPrice.Text = "Giá phòng:";
            // 
            // txt_bedType
            // 
            this.txt_bedType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_bedType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_bedType.Location = new System.Drawing.Point(21, 216);
            this.txt_bedType.Name = "txt_bedType";
            this.txt_bedType.Size = new System.Drawing.Size(82, 19);
            this.txt_bedType.TabIndex = 16;
            this.txt_bedType.Text = "Kiểu giường:";
            // 
            // txt_roomType
            // 
            this.txt_roomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_roomType.Location = new System.Drawing.Point(21, 153);
            this.txt_roomType.Name = "txt_roomType";
            this.txt_roomType.Size = new System.Drawing.Size(82, 19);
            this.txt_roomType.TabIndex = 15;
            this.txt_roomType.Text = "Kiểu phòng:";
            // 
            // txt_roomNumber
            // 
            this.txt_roomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_roomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_roomNumber.Location = new System.Drawing.Point(21, 93);
            this.txt_roomNumber.Name = "txt_roomNumber";
            this.txt_roomNumber.Size = new System.Drawing.Size(82, 19);
            this.txt_roomNumber.TabIndex = 14;
            this.txt_roomNumber.Text = "Số Phòng:";
            // 
            // title_addRoom
            // 
            this.title_addRoom.AutoSize = true;
            this.title_addRoom.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.title_addRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.title_addRoom.Location = new System.Drawing.Point(14, 16);
            this.title_addRoom.Name = "title_addRoom";
            this.title_addRoom.Size = new System.Drawing.Size(318, 38);
            this.title_addRoom.TabIndex = 13;
            this.title_addRoom.Text = "Thêm phòng mới";
            // 
            // F_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(467, 409);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.comboBox_bedType);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.txtBox_roomPrice);
            this.Controls.Add(this.txtBox_roomNumber);
            this.Controls.Add(this.txt_roomPrice);
            this.Controls.Add(this.txt_bedType);
            this.Controls.Add(this.txt_roomType);
            this.Controls.Add(this.txt_roomNumber);
            this.Controls.Add(this.title_addRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AddRoom";
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_close;
        private ReaLTaiizor.Controls.ForeverButton btt_add;
        private ReaLTaiizor.Controls.PoisonComboBox comboBox_bedType;
        private ReaLTaiizor.Controls.PoisonComboBox comboBox_roomType;
        private ReaLTaiizor.Controls.DungeonTextBox txtBox_roomPrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtBox_roomNumber;
        private ReaLTaiizor.Controls.FoxLabel txt_roomPrice;
        private ReaLTaiizor.Controls.FoxLabel txt_bedType;
        private ReaLTaiizor.Controls.FoxLabel txt_roomType;
        private ReaLTaiizor.Controls.FoxLabel txt_roomNumber;
        private ReaLTaiizor.Controls.SkyLabel title_addRoom;
    }
}