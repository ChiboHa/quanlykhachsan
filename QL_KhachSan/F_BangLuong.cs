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
    public partial class F_BangLuong : Form
    {
        public F_BangLuong()
        {
            InitializeComponent();
            dgvEmployeeSalaries.CellContentClick += dgvEmployeeSalaries_CellContentClick; // Gắn sự kiện CellContentClick
        }

        private void F_BangLuong_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            // Load dữ liệu lương của nhân viên
            LoadEmployeeSalaries();

            // Load dữ liệu tổng lương theo tháng của khách sạn
            LoadHotelTotalSalaries();
        }

        #region Tính lương nhân viên
        private void LoadEmployeeSalaries()
        {
            // Lấy tháng và năm từ các điều khiển trên form
            int month = dtpSalaryMonth.Value.Month;
            int year = dtpSalaryMonth.Value.Year;

            // Lấy dữ liệu lương của nhân viên dựa trên tháng và năm đã chọn
            var employeeSalaries = Luong_DAO.Instance.GetLuongByMonthAndYear(month, year);

            // Xóa các cột hiện tại trong DataGridView
            dgvEmployeeSalaries.Columns.Clear();

            // Thêm các cột mới vào DataGridView
            dgvEmployeeSalaries.Columns.Add("STT", "STT");
            dgvEmployeeSalaries.Columns.Add("ID", "ID");
            dgvEmployeeSalaries.Columns.Add("ID_nv", "ID_nv");
            dgvEmployeeSalaries.Columns.Add("Ho", "Họ");
            dgvEmployeeSalaries.Columns.Add("Ten", "Tên");
            dgvEmployeeSalaries.Columns.Add("GioiTinh", "Giới tính");
            dgvEmployeeSalaries.Columns.Add("Role", "Chức vụ");
            dgvEmployeeSalaries.Columns.Add("Luong", "Lương");
            dgvEmployeeSalaries.Columns.Add("Delete", "Xóa");

            // Lặp qua từng dòng dữ liệu và hiển thị trên DataGridView
            int stt = 1; // Biến số thứ tự bắt đầu từ 1
            foreach (DataRow row in employeeSalaries.Rows)
            {
                // Tạo một Button cho mỗi hàng
                DataGridViewButtonCell btnDelete = new DataGridViewButtonCell();
                btnDelete.Value = "Xóa";
                dgvEmployeeSalaries.Rows.Add(new object[]
                {
            stt++,
            row["ID"],
            row["ID_nv"],
            row["Ho"],
            row["Ten"],
            row["GioiTinh"],
            row["Role"],
            row["TongLuong"],
            btnDelete
                });
            }

            // Ẩn cột ID
            dgvEmployeeSalaries.Columns["ID"].Visible = false;
            dgvEmployeeSalaries.Columns["ID_nv"].Visible = false;
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            // Mở form F_LuongCRUD để thêm lương cho nhân viên
            F_LuongCRUD addSalaryForm = new F_LuongCRUD();
            addSalaryForm.ShowDialog();

            // Sau khi thêm lương, reload dữ liệu để cập nhật
            LoadDefaultData();
        }


        private void dtpSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            // Khi thay đổi tháng và năm, reload dữ liệu để cập nhật
            LoadDefaultData();
        }

        // Xử lý sự kiện khi click vào ô trong DataGridView
        private void dgvEmployeeSalaries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào nút Xóa
            if (e.ColumnIndex == dgvEmployeeSalaries.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị của cell "ID" và "ID_nv"
                object cellValueID = dgvEmployeeSalaries.Rows[e.RowIndex].Cells["ID"].Value;
                object cellValueID_nv = dgvEmployeeSalaries.Rows[e.RowIndex].Cells["ID_nv"].Value;

                // Kiểm tra giá trị của cell không null và không rỗng
                if (cellValueID != null && !string.IsNullOrEmpty(cellValueID.ToString()) &&
                    cellValueID_nv != null && !string.IsNullOrEmpty(cellValueID_nv.ToString()))
                {
                    // Thử chuyển đổi giá trị của cell thành số nguyên
                    if (int.TryParse(cellValueID.ToString(), out int luongID))
                    {
                        // Gọi phương thức xóa lương của nhân viên
                        bool deleteSuccess = Luong_DAO.Instance.DeleteLuong(luongID);

                        // Kiểm tra xem xóa thành công hay không
                        if (deleteSuccess)
                        {
                            MessageBox.Show("Đã xóa lương của nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Sau khi xóa, cần load lại dữ liệu lương
                            LoadEmployeeSalaries();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa lương của nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Nếu không thể chuyển đổi thành số nguyên, hiển thị thông báo lỗi
                        MessageBox.Show("Giá trị của ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Nếu giá trị của cell là null hoặc rỗng, hiển thị thông báo lỗi
                    MessageBox.Show("Giá trị của ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        #endregion

        #region Tính tổng lương
        private void LoadHotelTotalSalaries()
        {
            // Xóa dữ liệu hiện tại trên DataGridView
            dgvHotelTotalSalaries.Rows.Clear();

            // Lấy dữ liệu tổng lương của khách sạn từ cơ sở dữ liệu
            DataTable totalSalaries = TongLuong_DAO.Instance.GetHotelTotalSalaries();

            // Hiển thị dữ liệu trên DataGridView
            int stt = 1;
            foreach (DataRow row in totalSalaries.Rows)
            {
                dgvHotelTotalSalaries.Rows.Add(new object[]
                {
            stt++,
            row["Thang"],
            row["Nam"],
            row["TongLuong"]
                });
            }
        }
        
        private void btnGenerateHotelTotalSalary_Click(object sender, EventArgs e)
        {
            int month = dtpSalary.Value.Month;
            int year = dtpSalary.Value.Year;

            // Kiểm tra xem đã có bản ghi nào có tháng và năm tương tự trong database chưa
            bool isExistingRecord = TongLuong_DAO.Instance.CheckExistingRecord(month, year);

            if (isExistingRecord)
            {
                // Nếu đã có bản ghi tương tự, thực hiện xóa bản ghi đó trước khi thêm bản ghi mới
                bool deleteSuccess = TongLuong_DAO.Instance.DeleteExistingRecord(month, year);
                if (!deleteSuccess)
                {
                    MessageBox.Show($"Không thể xóa bản ghi tổng lương cho tháng {month} năm {year}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Tính tổng lương của khách sạn từ các bản ghi lương của nhân viên theo tháng và năm
            bool success = TongLuong_DAO.Instance.CalculateAndInsertHotelTotalSalary(month, year);

            if (success)
            {
                // Hiển thị thông báo
                MessageBox.Show($"Tính tổng lương tháng {month} năm {year} thành công và lưu vào CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHotelTotalSalaries();
            }
            else
            {
                MessageBox.Show($"Tính tổng lương tháng {month} năm {year} không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dgvEmployeeSalaries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang định dạng cell trong cột Lương
            if (dgvEmployeeSalaries.Columns[e.ColumnIndex].Name == "Luong")
            {
                // Kiểm tra kiểu dữ liệu của cell
                if (e.Value != null && e.Value.GetType() == typeof(decimal))
                {
                    // Định dạng giá trị để chỉ hiển thị số trước dấu phẩy
                    e.Value = ((decimal)e.Value).ToString("#,0") + " đ";
                    e.FormattingApplied = true; // Đánh dấu đã xử lý định dạng
                }
            }
        }
    }
}