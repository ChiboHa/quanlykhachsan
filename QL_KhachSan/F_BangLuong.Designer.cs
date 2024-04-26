using System.Windows.Forms;

namespace QL_KhachSan
{
    partial class F_BangLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BangLuong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHotelTotalSalaries = new System.Windows.Forms.DataGridView();
            this.STTTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmployeeSalaries = new System.Windows.Forms.DataGridView();
            this.dtpSalary = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddSalary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGenerateHotelTotalSalary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelTotalSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSalaryMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(766, 27);
            this.dtpSalaryMonth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(114, 26);
            this.dtpSalaryMonth.TabIndex = 1;
            this.dtpSalaryMonth.ValueChanged += new System.EventHandler(this.dtpSalaryMonth_ValueChanged);
            this.dtpSalaryMonth.Format = DateTimePickerFormat.Custom;
            this.dtpSalaryMonth.CustomFormat = "MM/yyyy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28025F));
            this.tableLayoutPanel1.Controls.Add(this.dgvHotelTotalSalaries, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEmployeeSalaries, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 157);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 622);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvHotelTotalSalaries
            // 
            this.dgvHotelTotalSalaries.AllowUserToAddRows = false;
            this.dgvHotelTotalSalaries.AllowUserToDeleteRows = false;
            this.dgvHotelTotalSalaries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.dgvHotelTotalSalaries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHotelTotalSalaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHotelTotalSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHotelTotalSalaries.BackgroundColor = System.Drawing.Color.White;
            this.dgvHotelTotalSalaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHotelTotalSalaries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHotelTotalSalaries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotelTotalSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHotelTotalSalaries.ColumnHeadersHeight = 55;
            this.dgvHotelTotalSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHotelTotalSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTTL,
            this.Thang,
            this.Nam,
            this.TongLuong});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHotelTotalSalaries.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHotelTotalSalaries.EnableHeadersVisualStyles = false;
            this.dgvHotelTotalSalaries.Location = new System.Drawing.Point(2, 2);
            this.dgvHotelTotalSalaries.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHotelTotalSalaries.Name = "dgvHotelTotalSalaries";
            this.dgvHotelTotalSalaries.ReadOnly = true;
            this.dgvHotelTotalSalaries.RowHeadersVisible = false;
            this.dgvHotelTotalSalaries.RowHeadersWidth = 30;
            this.dgvHotelTotalSalaries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHotelTotalSalaries.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.dgvHotelTotalSalaries.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
            this.dgvHotelTotalSalaries.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.dgvHotelTotalSalaries.RowTemplate.Height = 40;
            this.dgvHotelTotalSalaries.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvHotelTotalSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHotelTotalSalaries.Size = new System.Drawing.Size(368, 618);
            this.dgvHotelTotalSalaries.TabIndex = 8;
            // 
            // STTTL
            // 
            this.STTTL.FillWeight = 20F;
            this.STTTL.HeaderText = "STT";
            this.STTTL.MinimumWidth = 6;
            this.STTTL.Name = "STTTL";
            this.STTTL.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.FillWeight = 50F;
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.FillWeight = 50F;
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // TongLuong
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = "0";
            this.TongLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongLuong.HeaderText = "Tổng lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            // 
            // dgvEmployeeSalaries
            // 
            this.dgvEmployeeSalaries.AllowUserToAddRows = false;
            this.dgvEmployeeSalaries.AllowUserToDeleteRows = false;
            this.dgvEmployeeSalaries.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.dgvEmployeeSalaries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployeeSalaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeSalaries.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeSalaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeSalaries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeSalaries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployeeSalaries.ColumnHeadersHeight = 55;
            this.dgvEmployeeSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ho,
            this.Ten,
            this.GioiTinh,
            this.Role,
            this.Luong,
            this.Delete,
            this.Edit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeSalaries.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployeeSalaries.EnableHeadersVisualStyles = false;
            this.dgvEmployeeSalaries.Location = new System.Drawing.Point(374, 2);
            this.dgvEmployeeSalaries.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployeeSalaries.Name = "dgvEmployeeSalaries";
            this.dgvEmployeeSalaries.ReadOnly = true;
            this.dgvEmployeeSalaries.RowHeadersVisible = false;
            this.dgvEmployeeSalaries.RowHeadersWidth = 30;
            this.dgvEmployeeSalaries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeeSalaries.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.dgvEmployeeSalaries.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(235)))), ((int)(((byte)(219)))));
            this.dgvEmployeeSalaries.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.dgvEmployeeSalaries.RowTemplate.Height = 40;
            this.dgvEmployeeSalaries.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEmployeeSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeSalaries.Size = new System.Drawing.Size(585, 618);
            this.dgvEmployeeSalaries.TabIndex = 7;
            this.dgvEmployeeSalaries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmployeeSalaries_CellFormatting);
            // 
            // dtpSalary
            // 
            this.dtpSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSalary.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalary.Location = new System.Drawing.Point(176, 27);
            this.dtpSalary.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSalary.Name = "dtpSalary";
            this.dtpSalary.Size = new System.Drawing.Size(114, 26);
            this.dtpSalary.TabIndex = 4;
            this.dtpSalary.Format = DateTimePickerFormat.Custom;
            this.dtpSalary.CustomFormat = "MM/yyyy";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Sửa";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.AllowAnimations = true;
            this.btnAddSalary.AllowMouseEffects = true;
            this.btnAddSalary.AllowToggling = false;
            this.btnAddSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSalary.AnimationSpeed = 200;
            this.btnAddSalary.AutoGenerateColors = false;
            this.btnAddSalary.AutoRoundBorders = false;
            this.btnAddSalary.AutoSizeLeftIcon = true;
            this.btnAddSalary.AutoSizeRightIcon = true;
            this.btnAddSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSalary.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSalary.BackgroundImage")));
            this.btnAddSalary.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSalary.ButtonText = "Thêm lương";
            this.btnAddSalary.ButtonTextMarginLeft = 0;
            this.btnAddSalary.ColorContrastOnClick = 45;
            this.btnAddSalary.ColorContrastOnHover = 45;
            this.btnAddSalary.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddSalary.CustomizableEdges = borderEdges1;
            this.btnAddSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSalary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSalary.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddSalary.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddSalary.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSalary.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.IconLeft = null;
            this.btnAddSalary.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSalary.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSalary.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddSalary.IconMarginLeft = 11;
            this.btnAddSalary.IconPadding = 10;
            this.btnAddSalary.IconRight = null;
            this.btnAddSalary.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSalary.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSalary.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddSalary.IconSize = 25;
            this.btnAddSalary.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddSalary.IdleBorderRadius = 0;
            this.btnAddSalary.IdleBorderThickness = 0;
            this.btnAddSalary.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddSalary.IdleIconLeftImage = null;
            this.btnAddSalary.IdleIconRightImage = null;
            this.btnAddSalary.IndicateFocus = false;
            this.btnAddSalary.Location = new System.Drawing.Point(883, 27);
            this.btnAddSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSalary.OnDisabledState.BorderRadius = 1;
            this.btnAddSalary.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSalary.OnDisabledState.BorderThickness = 1;
            this.btnAddSalary.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddSalary.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddSalary.OnDisabledState.IconLeftImage = null;
            this.btnAddSalary.OnDisabledState.IconRightImage = null;
            this.btnAddSalary.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddSalary.onHoverState.BorderRadius = 1;
            this.btnAddSalary.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSalary.onHoverState.BorderThickness = 1;
            this.btnAddSalary.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddSalary.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.onHoverState.IconLeftImage = null;
            this.btnAddSalary.onHoverState.IconRightImage = null;
            this.btnAddSalary.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSalary.OnIdleState.BorderRadius = 1;
            this.btnAddSalary.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSalary.OnIdleState.BorderThickness = 1;
            this.btnAddSalary.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSalary.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.OnIdleState.IconLeftImage = null;
            this.btnAddSalary.OnIdleState.IconRightImage = null;
            this.btnAddSalary.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddSalary.OnPressedState.BorderRadius = 1;
            this.btnAddSalary.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSalary.OnPressedState.BorderThickness = 1;
            this.btnAddSalary.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddSalary.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.OnPressedState.IconLeftImage = null;
            this.btnAddSalary.OnPressedState.IconRightImage = null;
            this.btnAddSalary.Size = new System.Drawing.Size(112, 32);
            this.btnAddSalary.TabIndex = 1;
            this.btnAddSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSalary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSalary.TextMarginLeft = 0;
            this.btnAddSalary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddSalary.UseDefaultRadiusAndThickness = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // btnGenerateHotelTotalSalary
            // 
            this.btnGenerateHotelTotalSalary.AllowAnimations = true;
            this.btnGenerateHotelTotalSalary.AllowMouseEffects = true;
            this.btnGenerateHotelTotalSalary.AllowToggling = false;
            this.btnGenerateHotelTotalSalary.AnimationSpeed = 200;
            this.btnGenerateHotelTotalSalary.AutoGenerateColors = false;
            this.btnGenerateHotelTotalSalary.AutoRoundBorders = false;
            this.btnGenerateHotelTotalSalary.AutoSizeLeftIcon = true;
            this.btnGenerateHotelTotalSalary.AutoSizeRightIcon = true;
            this.btnGenerateHotelTotalSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateHotelTotalSalary.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGenerateHotelTotalSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateHotelTotalSalary.BackgroundImage")));
            this.btnGenerateHotelTotalSalary.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerateHotelTotalSalary.ButtonText = "Tính tổng";
            this.btnGenerateHotelTotalSalary.ButtonTextMarginLeft = 0;
            this.btnGenerateHotelTotalSalary.ColorContrastOnClick = 45;
            this.btnGenerateHotelTotalSalary.ColorContrastOnHover = 45;
            this.btnGenerateHotelTotalSalary.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnGenerateHotelTotalSalary.CustomizableEdges = borderEdges2;
            this.btnGenerateHotelTotalSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateHotelTotalSalary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerateHotelTotalSalary.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGenerateHotelTotalSalary.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGenerateHotelTotalSalary.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGenerateHotelTotalSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateHotelTotalSalary.ForeColor = System.Drawing.Color.White;
            this.btnGenerateHotelTotalSalary.IconLeft = null;
            this.btnGenerateHotelTotalSalary.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateHotelTotalSalary.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateHotelTotalSalary.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGenerateHotelTotalSalary.IconMarginLeft = 11;
            this.btnGenerateHotelTotalSalary.IconPadding = 10;
            this.btnGenerateHotelTotalSalary.IconRight = null;
            this.btnGenerateHotelTotalSalary.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateHotelTotalSalary.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateHotelTotalSalary.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGenerateHotelTotalSalary.IconSize = 25;
            this.btnGenerateHotelTotalSalary.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGenerateHotelTotalSalary.IdleBorderRadius = 0;
            this.btnGenerateHotelTotalSalary.IdleBorderThickness = 0;
            this.btnGenerateHotelTotalSalary.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGenerateHotelTotalSalary.IdleIconLeftImage = null;
            this.btnGenerateHotelTotalSalary.IdleIconRightImage = null;
            this.btnGenerateHotelTotalSalary.IndicateFocus = false;
            this.btnGenerateHotelTotalSalary.Location = new System.Drawing.Point(294, 27);
            this.btnGenerateHotelTotalSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateHotelTotalSalary.Name = "btnGenerateHotelTotalSalary";
            this.btnGenerateHotelTotalSalary.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerateHotelTotalSalary.OnDisabledState.BorderRadius = 1;
            this.btnGenerateHotelTotalSalary.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerateHotelTotalSalary.OnDisabledState.BorderThickness = 1;
            this.btnGenerateHotelTotalSalary.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerateHotelTotalSalary.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerateHotelTotalSalary.OnDisabledState.IconLeftImage = null;
            this.btnGenerateHotelTotalSalary.OnDisabledState.IconRightImage = null;
            this.btnGenerateHotelTotalSalary.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnGenerateHotelTotalSalary.onHoverState.BorderRadius = 1;
            this.btnGenerateHotelTotalSalary.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerateHotelTotalSalary.onHoverState.BorderThickness = 1;
            this.btnGenerateHotelTotalSalary.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnGenerateHotelTotalSalary.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGenerateHotelTotalSalary.onHoverState.IconLeftImage = null;
            this.btnGenerateHotelTotalSalary.onHoverState.IconRightImage = null;
            this.btnGenerateHotelTotalSalary.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateHotelTotalSalary.OnIdleState.BorderRadius = 1;
            this.btnGenerateHotelTotalSalary.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerateHotelTotalSalary.OnIdleState.BorderThickness = 1;
            this.btnGenerateHotelTotalSalary.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateHotelTotalSalary.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGenerateHotelTotalSalary.OnIdleState.IconLeftImage = null;
            this.btnGenerateHotelTotalSalary.OnIdleState.IconRightImage = null;
            this.btnGenerateHotelTotalSalary.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerateHotelTotalSalary.OnPressedState.BorderRadius = 1;
            this.btnGenerateHotelTotalSalary.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerateHotelTotalSalary.OnPressedState.BorderThickness = 1;
            this.btnGenerateHotelTotalSalary.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerateHotelTotalSalary.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGenerateHotelTotalSalary.OnPressedState.IconLeftImage = null;
            this.btnGenerateHotelTotalSalary.OnPressedState.IconRightImage = null;
            this.btnGenerateHotelTotalSalary.Size = new System.Drawing.Size(112, 32);
            this.btnGenerateHotelTotalSalary.TabIndex = 2;
            this.btnGenerateHotelTotalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerateHotelTotalSalary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerateHotelTotalSalary.TextMarginLeft = 0;
            this.btnGenerateHotelTotalSalary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGenerateHotelTotalSalary.UseDefaultRadiusAndThickness = true;
            this.btnGenerateHotelTotalSalary.Click += new System.EventHandler(this.btnGenerateHotelTotalSalary_Click);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Image = global::QL_KhachSan.Properties.Resources.icons8_edit_24;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 56;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.Image = global::QL_KhachSan.Properties.Resources.icons8_delete_24;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 56;
            // 
            // Luong
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = "0";
            this.Luong.DefaultCellStyle = dataGridViewCellStyle7;
            this.Luong.HeaderText = "Tổng lương";
            this.Luong.MinimumWidth = 15;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Chức vụ";
            this.Role.MinimumWidth = 10;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.FillWeight = 80F;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 15;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.HeaderText = "Họ";
            this.Ho.MinimumWidth = 10;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.FillWeight = 1F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 2;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // F_BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 807);
            this.ControlBox = false;
            this.Controls.Add(this.dtpSalary);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.btnGenerateHotelTotalSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_BangLuong";
            this.Text = "F_BangLuong";
            this.Load += new System.EventHandler(this.F_BangLuong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelTotalSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeSalaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGenerateHotelTotalSalary;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSalary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHotelTotalSalaries;
        private System.Windows.Forms.DataGridView dgvEmployeeSalaries;
        private System.Windows.Forms.DateTimePicker dtpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Ho;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Luong;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
    }
}