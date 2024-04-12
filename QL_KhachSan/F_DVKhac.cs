using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using ReaLTaiizor.Controls;
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
    public partial class F_DVKhac : Form
    {

        public F_DVKhac()
        {
            InitializeComponent();
            dgv_bookedRoom.Columns.Add("ID", "ID");
            dgv_bookedRoom.Columns.Add("SoPhong", "Số phòng");
            dgv_bookedRoom.Columns.Add("IDKhach", "ID khách");
            dgv_bookedRoom.Columns.Add("NgayNhan", "Ngày nhận");
            dgv_bookedRoom.Columns.Add("NgayTra", "Ngày trả");
            dgv_bookedRoom.Columns["NgayNhan"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_bookedRoom.Columns["NgayTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            // Gán sự kiện RowPrePaint cho DataGridVie
            dgv_bookedRoom.RowPrePaint += List_RowPrePaint;
            // Tắt dòng "New Row"
            dgv_bookedRoom.AllowUserToAddRows = false;
            // Load dữ liệu từ database và gán vào DataGridView
            LoadBillRooms();
        }
        private void LoadBillRooms()
        {
            List<BillRoom> billRooms = Bill_Room_DAO.Instance.GetBillRoomsByStatus0();

            // Duyệt qua danh sách các BillRoom và thêm vào DataGridView
            foreach (BillRoom billRoom in billRooms)
            {
                dgv_bookedRoom.Columns["ID"].Width = 30;
                dgv_bookedRoom.Columns["SoPhong"].Width = 80;
                dgv_bookedRoom.Columns["IDKhach"].Width = 80;
                dgv_bookedRoom.Columns["NgayNhan"].Width = 140;
                dgv_bookedRoom.Columns["NgayTra"].Width = 140;
                dgv_bookedRoom.Rows.Add(billRoom.ID, billRoom.Room_No, billRoom.Customer_id, billRoom.Date_check_in, billRoom.Date_check_out);
                
            }
        }
        private void List_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Kiểm tra nếu hàng hiện tại không phải là hàng header
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị date_check_out từ cột thứ 4 (index 3) của hàng hiện tại
                DateTime date_check_out = Convert.ToDateTime(dgv_bookedRoom.Rows[e.RowIndex].Cells[4].Value);

                // Kiểm tra nếu date_check_out nhỏ hơn ngày hiện tại
                if (date_check_out.Date < DateTime.Now.Date)
                {
                    // Đặt màu cho hàng là màu đỏ
                    dgv_bookedRoom.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dgv_bookedRoom.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    // Đặt màu mặc định cho hàng
                    dgv_bookedRoom.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgv_bookedRoom.DefaultCellStyle.BackColor;
                    dgv_bookedRoom.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgv_bookedRoom.DefaultCellStyle.ForeColor;
                }
            }
        }
        private void ReloadData()
        {
            // Xóa dữ liệu hiện tại của DataGridView
            dgv_bookedRoom.Rows.Clear();

            // Load lại dữ liệu từ cơ sở dữ liệu và gán vào DataGridView
            LoadBillRooms();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dgv_bookedRoom.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có muốn thanh toán cho căn phòng này?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả từ hộp thoại xác nhận
                if (result == DialogResult.Yes)
                {
                    // Lấy index của hàng đang được chọn
                    int rowIndex = dgv_bookedRoom.CurrentRow.Index;

                    // Lấy giá trị ID của bản ghi tương ứng
                    int ID = Convert.ToInt32(dgv_bookedRoom.Rows[rowIndex].Cells["ID"].Value);

                    // Thực hiện cập nhật trạng thái trong cơ sở dữ liệu
                    bool success = Bill_Room_DAO.Instance.UpdateStatus(ID);
                    ReloadData();
                }
                else
                {
                    // Không làm gì nếu người dùng chọn "Không"
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một căn phòng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
