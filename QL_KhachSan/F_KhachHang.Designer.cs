namespace QL_KhachSan
{
    partial class F_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dropDown_Search = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.listInfo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.listInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(54, 33);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(255, 46);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "THÔNG TIN ĐẶT PHÒNG";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dropDown_Search
            // 
            this.dropDown_Search.BackColor = System.Drawing.Color.Transparent;
            this.dropDown_Search.BackgroundColor = System.Drawing.Color.White;
            this.dropDown_Search.BorderColor = System.Drawing.Color.Transparent;
            this.dropDown_Search.BorderRadius = 5;
            this.dropDown_Search.Color = System.Drawing.Color.Transparent;
            this.dropDown_Search.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropDown_Search.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDown_Search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropDown_Search.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDown_Search.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropDown_Search.DisabledIndicatorColor = System.Drawing.Color.Gray;
            this.dropDown_Search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDown_Search.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropDown_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_Search.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDown_Search.FillDropDown = true;
            this.dropDown_Search.FillIndicator = false;
            this.dropDown_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDown_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropDown_Search.ForeColor = System.Drawing.Color.Black;
            this.dropDown_Search.FormattingEnabled = true;
            this.dropDown_Search.Icon = null;
            this.dropDown_Search.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDown_Search.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dropDown_Search.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDown_Search.IndicatorThickness = 2;
            this.dropDown_Search.IsDropdownOpened = false;
            this.dropDown_Search.ItemBackColor = System.Drawing.Color.WhiteSmoke;
            this.dropDown_Search.ItemBorderColor = System.Drawing.Color.White;
            this.dropDown_Search.ItemForeColor = System.Drawing.Color.Black;
            this.dropDown_Search.ItemHeight = 26;
            this.dropDown_Search.ItemHighLightColor = System.Drawing.Color.Silver;
            this.dropDown_Search.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropDown_Search.Items.AddRange(new object[] {
            "Thông tin chi tiết tất cả khách hàng",
            "Khách hàng trong khách sạn",
            "Khách hàng đã thanh toán"});
            this.dropDown_Search.ItemTopMargin = 3;
            this.dropDown_Search.Location = new System.Drawing.Point(407, 146);
            this.dropDown_Search.Name = "dropDown_Search";
            this.dropDown_Search.Size = new System.Drawing.Size(260, 32);
            this.dropDown_Search.TabIndex = 1;
            this.dropDown_Search.Text = null;
            this.dropDown_Search.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDown_Search.TextLeftMargin = 5;
            this.dropDown_Search.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.bunifuLabel2.Location = new System.Drawing.Point(384, 105);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(90, 30);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Search By";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // listInfo
            // 
            this.listInfo.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.listInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listInfo.ColumnHeadersHeight = 40;
            this.listInfo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.listInfo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listInfo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listInfo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listInfo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listInfo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.listInfo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listInfo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.listInfo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.listInfo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listInfo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.listInfo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.listInfo.CurrentTheme.Name = null;
            this.listInfo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listInfo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.listInfo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listInfo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.listInfo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.listInfo.EnableHeadersVisualStyles = false;
            this.listInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.listInfo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.listInfo.HeaderBgColor = System.Drawing.Color.Empty;
            this.listInfo.HeaderForeColor = System.Drawing.Color.White;
            this.listInfo.Location = new System.Drawing.Point(12, 229);
            this.listInfo.Name = "listInfo";
            this.listInfo.RowHeadersVisible = false;
            this.listInfo.RowTemplate.Height = 40;
            this.listInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listInfo.Size = new System.Drawing.Size(1000, 334);
            this.listInfo.TabIndex = 3;
            this.listInfo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // F_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 845);
            this.ControlBox = false;
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.dropDown_Search);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_KhachHang";
            this.Text = "F_Customers";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.F_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown dropDown_Search;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDataGridView listInfo;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
    }
}