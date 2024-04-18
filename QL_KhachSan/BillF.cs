using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.DAO;
using QL_KhachSan.DTO;

namespace QL_KhachSan
{
    public partial class BillF : Form
    {
        public BillF()
        {
            InitializeComponent();
            LoadBillF(); 
        }
        void LoadBillF()
        {
            billFview.DataSource = BillFoodDAO.Instance.GetDsBill();
            billFview.Columns["ID"].Visible = false;
            billFview.Columns["idkhachhang"].HeaderText = "Số điện thoại";
            billFview.Columns["transdate"].HeaderText = "Ngày";
            billFview.Columns["transmonth"].Visible = false;
            billFview.Columns["grandtotal"].HeaderText = "Tổng tiền";
            billFview.Columns["trangthai"].HeaderText = "Thanh toán";

        }

        private void billFview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = billFview.Rows[e.RowIndex];
                int billID = Convert.ToInt32(row.Cells["ID"].Value);
                int grandtotal = Convert.ToInt32(row.Cells["grandtotal"].Value);
                string idkh = row.Cells["idkhachhang"].Value.ToString();
                DateTime transDate = Convert.ToDateTime(row.Cells["transdate"].Value); // Lấy giá trị ngày tháng từ cột transdate
                lbl_GrandTotal.Text = grandtotal.ToString();
               
                // Giả sử bạn có một phương thức để lấy thông tin Pos theo BillID
                dataGridView1.DataSource = PosDAO.Instance.GetListBillF(billID);
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["billID"].Visible = false;
                dataGridView1.Columns["foodcode"].Visible = false;
                dataGridView1.Columns["foodname"].HeaderText = "Tên món";
                dataGridView1.Columns["cost"].HeaderText = "Đơn giá";
                dataGridView1.Columns["quantity"].HeaderText = "Số lượng";
                dataGridView1.Columns["totalprice"].HeaderText = "Giá";

                // Hiển thị tên khách hàng
                KhachHang kh = KhachHang_DAO.Instance.GetCustomerById(idkh);
                if (kh != null)
                {
                    lbl_Name.Text = kh.Name;
                    lbl_Name.Show();
                }
                else
                {
                    lbl_Name.Hide();
                }
                // Hiển thị ngày tháng
                lbl_date.Text = transDate.ToString("dd/MM/yyyy"); // Format ngày tháng theo dd/MM/yyyy
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
