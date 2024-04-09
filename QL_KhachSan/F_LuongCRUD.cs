﻿using QL_KhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_LuongCRUD : Form
    {
        private bool isAddingMode; // Xác định xem form đang được sử dụng để thêm mới hay chỉnh sửa
        private int luongID; // ID của bản ghi lương
        private string employeeID; // ID của nhân viên
        private DateTime salaryMonth; // Tháng của bản ghi lương
        private decimal tongLuong; // Tổng lương của bản ghi lương

        public F_LuongCRUD()
        {
            InitializeComponent();
            isAddingMode = true; // Mặc định form ở chế độ thêm mới
        }

        public F_LuongCRUD(int luongID, string employeeID, DateTime salaryMonth, decimal tongLuong)
        {
            InitializeComponent();
            isAddingMode = false; // Form ở chế độ chỉnh sửa
            // Lưu thông tin của bản ghi lương
            this.luongID = luongID;
            this.employeeID = employeeID;
            this.salaryMonth = salaryMonth;
            this.tongLuong = tongLuong;
            // Hiển thị thông tin lên các điều khiển
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            // Hiển thị thông tin về nhân viên và tháng lên các điều khiển
            cboEmployees.SelectedValue = employeeID;
            dtpSalaryMonth.Value = salaryMonth;
            //txtTotalSalary.Text = tongLuong.ToString();
            // Đặt trạng thái chỉ đọc cho các điều khiển
            cboEmployees.Enabled = false;
            dtpSalaryMonth.Enabled = false;
            //txtTotalSalary.ReadOnly = true;
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string employeeID = cboEmployees.SelectedValue.ToString();
            DateTime salaryMonth = dtpSalaryMonth.Value;
            decimal workingHours = numWorkingHours.Value;

            if (isAddingMode)
            {
                // Kiểm tra xem nhân viên đã có lương trong tháng và năm này chưa
                bool salaryExists = Luong_DAO.Instance.CheckSalaryExists(employeeID, salaryMonth);

                // Nếu nhân viên đã có lương trong tháng và năm này, hiển thị thông báo và không thêm mới
                if (salaryExists)
                {
                    MessageBox.Show("Nhân viên đã có lương trong tháng và năm này!");
                    return;
                }

                // Thêm lương cho nhân viên vào cơ sở dữ liệu
                bool success = Luong_DAO.Instance.InsertLuong(employeeID, salaryMonth, workingHours);

                // Kiểm tra kết quả và hiển thị thông báo tương ứng
                if (success)
                {
                    MessageBox.Show("Thêm lương thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm lương thất bại. Vui lòng thử lại!");
                }
            }
            else
            {
                // Cập nhật số giờ làm cho bản ghi lương trong cơ sở dữ liệu
                bool success = Luong_DAO.Instance.UpdateLuong(luongID, workingHours, tongLuong);

                // Kiểm tra kết quả và hiển thị thông báo tương ứng
                if (success)
                {
                    MessageBox.Show("Cập nhật số giờ làm thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật số giờ làm thất bại. Vui lòng thử lại!");
                }
            }
        }

        private void F_LuongCRUD_Load(object sender, EventArgs e)
        {
            // Load danh sách nhân viên vào ComboBox
            LoadEmployees();
            // Thiết lập giá trị mặc định cho tháng và năm
            dtpSalaryMonth.Value = DateTime.Now;
        }

        private void LoadEmployees()
        {
            // Lấy danh sách nhân viên từ cơ sở dữ liệu
            var employees = NhanVien_DAO.Instance.GetNhanViens();

            // Hiển thị danh sách nhân viên trong ComboBox
            cboEmployees.DataSource = employees;
            cboEmployees.DisplayMember = "Ten"; // Hiển thị tên nhân viên
            cboEmployees.ValueMember = "ID"; // Giá trị là ID của nhân viên
        }
    }
}
