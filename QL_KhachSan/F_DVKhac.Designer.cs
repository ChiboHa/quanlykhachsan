namespace QL_KhachSan
{
    partial class F_DVKhac
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_extend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_bookedRoom = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookedRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_pay);
            this.panel4.Controls.Add(this.btn_extend);
            this.panel4.Location = new System.Drawing.Point(533, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 63);
            this.panel4.TabIndex = 3;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(145, 10);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(100, 40);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_extend
            // 
            this.btn_extend.Location = new System.Drawing.Point(25, 10);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(100, 40);
            this.btn_extend.TabIndex = 0;
            this.btn_extend.Text = "Gia hạn";
            this.btn_extend.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_bookedRoom);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 564);
            this.panel2.TabIndex = 1;
            // 
            // dgv_bookedRoom
            // 
            this.dgv_bookedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookedRoom.Location = new System.Drawing.Point(3, 3);
            this.dgv_bookedRoom.Name = "dgv_bookedRoom";
            this.dgv_bookedRoom.Size = new System.Drawing.Size(515, 558);
            this.dgv_bookedRoom.TabIndex = 0;
            // 
            // F_DVKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_DVKhac";
            this.Text = "F_DVKhac";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookedRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_extend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_bookedRoom;
    }
}