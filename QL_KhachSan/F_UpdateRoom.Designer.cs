namespace QL_KhachSan
{
    partial class F_UpdateRoom
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
            this.comboBox_booked = new ReaLTaiizor.Controls.PoisonComboBox();
            this.txt_booked = new ReaLTaiizor.Controls.FoxLabel();
            this.btt_update = new ReaLTaiizor.Controls.ForeverButton();
            this.comboBox_bedType = new ReaLTaiizor.Controls.PoisonComboBox();
            this.comboBox_roomType = new ReaLTaiizor.Controls.PoisonComboBox();
            this.txtBox_roomPrice = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtBox_roomNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txt_roomPrice = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_bed = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_type = new ReaLTaiizor.Controls.FoxLabel();
            this.txt_roomNumber = new ReaLTaiizor.Controls.FoxLabel();
            this.title_updateRoom = new ReaLTaiizor.Controls.SkyLabel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_booked
            // 
            this.comboBox_booked.FormattingEnabled = true;
            this.comboBox_booked.ItemHeight = 23;
            this.comboBox_booked.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox_booked.Location = new System.Drawing.Point(102, 283);
            this.comboBox_booked.Name = "comboBox_booked";
            this.comboBox_booked.Size = new System.Drawing.Size(323, 29);
            this.comboBox_booked.TabIndex = 37;
            this.comboBox_booked.UseSelectable = true;
            // 
            // txt_booked
            // 
            this.txt_booked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_booked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_booked.Location = new System.Drawing.Point(19, 293);
            this.txt_booked.Name = "txt_booked";
            this.txt_booked.Size = new System.Drawing.Size(82, 19);
            this.txt_booked.TabIndex = 36;
            this.txt_booked.Text = "Đã đặt:";
            // 
            // btt_update
            // 
            this.btt_update.BackColor = System.Drawing.Color.Transparent;
            this.btt_update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btt_update.Location = new System.Drawing.Point(165, 345);
            this.btt_update.Name = "btt_update";
            this.btt_update.Rounded = false;
            this.btt_update.Size = new System.Drawing.Size(120, 40);
            this.btt_update.TabIndex = 34;
            this.btt_update.Text = "Cập nhật";
            this.btt_update.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btt_update.Click += new System.EventHandler(this.btt_update_Click);
            // 
            // comboBox_bedType
            // 
            this.comboBox_bedType.FormattingEnabled = true;
            this.comboBox_bedType.ItemHeight = 23;
            this.comboBox_bedType.Items.AddRange(new object[] {
            "Giường đơn",
            "Giường đôi"});
            this.comboBox_bedType.Location = new System.Drawing.Point(102, 184);
            this.comboBox_bedType.Name = "comboBox_bedType";
            this.comboBox_bedType.Size = new System.Drawing.Size(323, 29);
            this.comboBox_bedType.TabIndex = 33;
            this.comboBox_bedType.UseSelectable = true;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.ItemHeight = 23;
            this.comboBox_roomType.Items.AddRange(new object[] {
            "Phòng thường",
            "Phòng VIP"});
            this.comboBox_roomType.Location = new System.Drawing.Point(102, 134);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(323, 29);
            this.comboBox_roomType.TabIndex = 32;
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
            this.txtBox_roomPrice.Location = new System.Drawing.Point(102, 234);
            this.txtBox_roomPrice.MaxLength = 32767;
            this.txtBox_roomPrice.Multiline = false;
            this.txtBox_roomPrice.Name = "txtBox_roomPrice";
            this.txtBox_roomPrice.ReadOnly = false;
            this.txtBox_roomPrice.Size = new System.Drawing.Size(323, 28);
            this.txtBox_roomPrice.TabIndex = 31;
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
            this.txtBox_roomNumber.Location = new System.Drawing.Point(102, 84);
            this.txtBox_roomNumber.MaxLength = 32767;
            this.txtBox_roomNumber.Multiline = false;
            this.txtBox_roomNumber.Name = "txtBox_roomNumber";
            this.txtBox_roomNumber.ReadOnly = false;
            this.txtBox_roomNumber.Size = new System.Drawing.Size(323, 28);
            this.txtBox_roomNumber.TabIndex = 30;
            this.txtBox_roomNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_roomNumber.UseSystemPasswordChar = false;
            // 
            // txt_roomPrice
            // 
            this.txt_roomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_roomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_roomPrice.Location = new System.Drawing.Point(14, 243);
            this.txt_roomPrice.Name = "txt_roomPrice";
            this.txt_roomPrice.Size = new System.Drawing.Size(82, 19);
            this.txt_roomPrice.TabIndex = 29;
            this.txt_roomPrice.Text = "Giá phòng:";
            // 
            // txt_bed
            // 
            this.txt_bed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_bed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_bed.Location = new System.Drawing.Point(14, 194);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.Size = new System.Drawing.Size(82, 19);
            this.txt_bed.TabIndex = 28;
            this.txt_bed.Text = "Kiểu giường:";
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_type.Location = new System.Drawing.Point(14, 144);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(82, 19);
            this.txt_type.TabIndex = 27;
            this.txt_type.Text = "Kiểu phòng:";
            // 
            // txt_roomNumber
            // 
            this.txt_roomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_roomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.txt_roomNumber.Location = new System.Drawing.Point(14, 93);
            this.txt_roomNumber.Name = "txt_roomNumber";
            this.txt_roomNumber.Size = new System.Drawing.Size(82, 19);
            this.txt_roomNumber.TabIndex = 26;
            this.txt_roomNumber.Text = "Số Phòng:";
            // 
            // title_updateRoom
            // 
            this.title_updateRoom.AutoSize = true;
            this.title_updateRoom.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.title_updateRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.title_updateRoom.Location = new System.Drawing.Point(12, 15);
            this.title_updateRoom.Name = "title_updateRoom";
            this.title_updateRoom.Size = new System.Drawing.Size(315, 38);
            this.title_updateRoom.TabIndex = 25;
            this.title_updateRoom.Text = "Sửa lại thông tin";
            // 
            // btn_close
            // 
            this.btn_close.Image = global::QL_KhachSan.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(435, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(15, 15);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 35;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // F_UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(455, 400);
            this.Controls.Add(this.comboBox_booked);
            this.Controls.Add(this.txt_booked);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.comboBox_bedType);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.txtBox_roomPrice);
            this.Controls.Add(this.txtBox_roomNumber);
            this.Controls.Add(this.txt_roomPrice);
            this.Controls.Add(this.txt_bed);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_roomNumber);
            this.Controls.Add(this.title_updateRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_UpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_UpdateRoom";
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonComboBox comboBox_booked;
        private ReaLTaiizor.Controls.FoxLabel txt_booked;
        private System.Windows.Forms.PictureBox btn_close;
        private ReaLTaiizor.Controls.ForeverButton btt_update;
        private ReaLTaiizor.Controls.PoisonComboBox comboBox_bedType;
        private ReaLTaiizor.Controls.PoisonComboBox comboBox_roomType;
        private ReaLTaiizor.Controls.DungeonTextBox txtBox_roomPrice;
        private ReaLTaiizor.Controls.DungeonTextBox txtBox_roomNumber;
        private ReaLTaiizor.Controls.FoxLabel txt_roomPrice;
        private ReaLTaiizor.Controls.FoxLabel txt_bed;
        private ReaLTaiizor.Controls.FoxLabel txt_type;
        private ReaLTaiizor.Controls.FoxLabel txt_roomNumber;
        private ReaLTaiizor.Controls.SkyLabel title_updateRoom;
    }
}