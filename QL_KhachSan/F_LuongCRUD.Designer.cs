namespace QL_KhachSan
{
    partial class F_LuongCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LuongCRUD));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.lbl_Employees = new System.Windows.Forms.Label();
            this.dtpSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.numWorkingHours = new System.Windows.Forms.NumericUpDown();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Hour = new System.Windows.Forms.Label();
            this.btnAddSalary = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployees.ForeColor = System.Drawing.Color.Black;
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(216, 78);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(268, 31);
            this.cboEmployees.TabIndex = 0;
            // 
            // lbl_Employees
            // 
            this.lbl_Employees.AutoSize = true;
            this.lbl_Employees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employees.Location = new System.Drawing.Point(79, 81);
            this.lbl_Employees.Name = "lbl_Employees";
            this.lbl_Employees.Size = new System.Drawing.Size(88, 23);
            this.lbl_Employees.TabIndex = 1;
            this.lbl_Employees.Text = "Nhân viên";
            // 
            // dtpSalaryMonth
            // 
            this.dtpSalaryMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtpSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalaryMonth.Location = new System.Drawing.Point(216, 148);
            this.dtpSalaryMonth.Name = "dtpSalaryMonth";
            this.dtpSalaryMonth.Size = new System.Drawing.Size(268, 30);
            this.dtpSalaryMonth.TabIndex = 2;
            // 
            // numWorkingHours
            // 
            this.numWorkingHours.Location = new System.Drawing.Point(216, 222);
            this.numWorkingHours.Name = "numWorkingHours";
            this.numWorkingHours.Size = new System.Drawing.Size(65, 22);
            this.numWorkingHours.TabIndex = 3;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(79, 148);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(81, 23);
            this.lbl_Time.TabIndex = 4;
            this.lbl_Time.Text = "Thời gian";
            // 
            // lbl_Hour
            // 
            this.lbl_Hour.AutoSize = true;
            this.lbl_Hour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hour.Location = new System.Drawing.Point(79, 219);
            this.lbl_Hour.Name = "lbl_Hour";
            this.lbl_Hour.Size = new System.Drawing.Size(91, 23);
            this.lbl_Hour.TabIndex = 5;
            this.lbl_Hour.Text = "Số giờ làm";
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.AllowAnimations = true;
            this.btnAddSalary.AllowMouseEffects = true;
            this.btnAddSalary.AllowToggling = false;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddSalary.CustomizableEdges = borderEdges2;
            this.btnAddSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSalary.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSalary.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddSalary.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddSalary.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F);
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
            this.btnAddSalary.Location = new System.Drawing.Point(216, 304);
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
            this.btnAddSalary.Size = new System.Drawing.Size(150, 39);
            this.btnAddSalary.TabIndex = 6;
            this.btnAddSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSalary.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSalary.TextMarginLeft = 0;
            this.btnAddSalary.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddSalary.UseDefaultRadiusAndThickness = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // F_LuongCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 392);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.lbl_Hour);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.numWorkingHours);
            this.Controls.Add(this.dtpSalaryMonth);
            this.Controls.Add(this.lbl_Employees);
            this.Controls.Add(this.cboEmployees);
            this.Name = "F_LuongCRUD";
            this.Text = "F_LuongCRUD";
            this.Load += new System.EventHandler(this.F_LuongCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Label lbl_Employees;
        private System.Windows.Forms.DateTimePicker dtpSalaryMonth;
        private System.Windows.Forms.NumericUpDown numWorkingHours;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Hour;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSalary;
    }
}