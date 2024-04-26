using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_KhachSan
{
    public partial class F_DatPhong : Form
    {
        F_EditKH editKH;
        String id_KH, id_HDP;

        public F_DatPhong()
        {
            InitializeComponent();
            hoTenBox.ReadOnly = true;
            cccdBox.ReadOnly = true;
            b_Add.Hide();
            LoadKhach();
        }
        public void LoadKhach()
        {
            listKhachHang.DataSource = KhachHang_DAO.Instance.GetListKH();

            // Thiết lập vị trí hiển thị cho cột "edit" và "delete" thành chỉ số của cột cuối cùng
            int lastIndex = listKhachHang.Columns.Count - 1;
            listKhachHang.Columns["Edit"].DisplayIndex = lastIndex;
            listKhachHang.Columns["Delete"].DisplayIndex = lastIndex;

            // Thiết lập tiêu đề cho các cột
            listKhachHang.Columns["Id"].HeaderText = "Số điện thoại";
            listKhachHang.Columns["Name"].HeaderText = "Họ và tên";
            listKhachHang.Columns["Cccd"].HeaderText = "Căn cước công dân";
        }
        private void listKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột được nhấp là cột "Edit" và không phải hàng header
            if (e.ColumnIndex == listKhachHang.Columns["Edit"].Index && e.RowIndex != -1)
            {
                // Lấy thông tin khách hàng từ hàng được chọn
                DataGridViewRow selectedRow = listKhachHang.Rows[e.RowIndex];
                string sdt = selectedRow.Cells["Id"].Value.ToString();
                string hoTen = selectedRow.Cells["Name"].Value.ToString();
                string cccd = selectedRow.Cells["Cccd"].Value.ToString();

                // Mở hoặc kích hoạt form F_EditKH và truyền thông tin vào các TextBox tương ứng
                if (editKH == null || editKH.IsDisposed)
                {
                    editKH = new F_EditKH();
                    editKH.FormClosed += EditKH_FormClosed;
                    editKH.SetInfo(sdt, hoTen, cccd); // Truyền thông tin vào form F_EditKH
                    editKH.Show();
                }
                else
                {
                    editKH.Activate();
                    editKH.SetInfo(sdt, hoTen, cccd); // Truyền thông tin vào form F_EditKH
                }
            }
            if(e.ColumnIndex == listKhachHang.Columns["Delete"].Index && e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = listKhachHang.Rows[e.RowIndex];
                string sdt = selectedRow.Cells["Id"].Value.ToString();
                if (KhachHang_DAO.Instance.DelKH(sdt))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadKhach();
                }
                else
                {
                    MessageBox.Show("Có lỗi");
                }
            }
        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            LoadKhach();
        }

        private void EditKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            editKH = null;
        }

        private void F_DatPhong_Load(object sender, EventArgs e)
        {
            
            try
            {
                // Thiết lập giao diện cho tabControl1
                tabControl1.Appearance = TabAppearance.FlatButtons;
                tabControl1.ItemSize = new System.Drawing.Size(0, 1);
                tabControl1.SizeMode = TabSizeMode.Fixed;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            
        }

        private void b_DatPhongTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
            tabControl1.SelectedIndex = 0;
        }

        private void b_ThanhToanTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
            //listBillRoom();
        }


        private void b_Next_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(sdtBox.Text) || string.IsNullOrWhiteSpace(hoTenBox.Text) || string.IsNullOrWhiteSpace(cccdBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }


        private void b_Previous_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void checkSDT()
        {
            string customerId = sdtBox.Text;
            KhachHang customer = KhachHang_DAO.Instance.GetCustomerById(customerId);

            if (customer != null)
            {
                // Nếu có khách hàng có ID tương tự, điền thông tin vào các TextBox khác
                hoTenBox.Text = customer.Name;
                cccdBox.Text = customer.Cccd;
                b_Next.Show();
                b_Add.Hide();
            }
            else
            {
                // Nếu không tìm thấy khách hàng,
                hoTenBox.ReadOnly = false;
                cccdBox.ReadOnly = false;
                hoTenBox.Focus();
                hoTenBox.Text = "";
                cccdBox.Text = "";
                b_Add.Show();
                b_Next.Hide();
            }
        }

        private void b_Check_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin từ số điện thoại
            checkSDT();
        }


        private void b_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các thông tin cần thiết đã được nhập vào hay chưa
            if (string.IsNullOrWhiteSpace(sdtBox.Text) || string.IsNullOrWhiteSpace(hoTenBox.Text) || string.IsNullOrWhiteSpace(cccdBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Tạo một đối tượng KhachHang mới từ thông tin đã nhập
            KhachHang newCustomer = new KhachHang(sdtBox.Text, hoTenBox.Text, cccdBox.Text);

            try
            {
                if (KhachHang_DAO.Instance.InsertKhachHang(newCustomer))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    hoTenBox.ReadOnly = true;
                    cccdBox.ReadOnly = true;
                    b_Add.Hide();
                    b_Next.Show();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void b_DatPhong_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (string.IsNullOrWhiteSpace(sdtBox.Text) || string.IsNullOrWhiteSpace(soPhongBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn số phòng!");
                    return;
                }

                string id_KhachHang = sdtBox.Text;

                if (soPhongBox.SelectedItem != null)
                {
                    Item selectedItem = soPhongBox.SelectedItem as Item;
                    DateTime checkInDate = dtp_CheckIn.Value.Date;
                    DateTime checkOutDate = dtp_CheckOut.Value.Date;

                    try
                    {
                        Bill_Room_DAO.Instance.InsertBillRoom(selectedItem.Value.ToString(), id_KhachHang, checkInDate, checkOutDate);

                        Rooms_DAO.Instance.setBooked("YES", selectedItem.Value.ToString());

                        MessageBox.Show("Đặt phòng thành công!");
                        reset();
                        tabControl1.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đặt phòng: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn số phòng!");
                }
            }
        }

        private void hoTenBox_TextChanged(object sender, EventArgs e)
        {
            txt_error1.Text = "";
        }

        private void sdtBox_TextChanged(object sender, EventArgs e)
        {
            txt_error2.Text = "";
        }

        private void cccdBox_TextChanged(object sender, EventArgs e)
        {
            txt_error3.Text = "";
        }

        private bool validate()
        {
            bool status = true;
            if (hoTenBox.Text.Trim().Equals(""))
            {
                txt_error1.Text = "Vui lòng nhập họ tên!";
                status = false;
            }
            if (sdtBox.Text.Trim().Equals(""))
            {
                txt_error2.Text = "Vui lòng nhập số điện thoại!";
                status = false;
            }
            if (cccdBox.Text.Trim().Equals(""))
            {
                txt_error3.Text = "Vui lòng nhập CCCD!";
                status = false;
            }
            if (loaiPhongBox.Text == null || loaiPhongBox.Text.Trim().Equals(""))
            {
                txt_error4.Text = "Vui lòng lựa chọn loại phòng!";
                status = false;
            }
            if (loaiGiuongBox.Text == null || loaiPhongBox.Text.Trim().Equals(""))
            {
                txt_error5.Text = "Vui lòng lựa chọn loại giường!";
                status = false;
            }
            if (soPhongBox.Text == null || soPhongBox.Text.Trim().Equals(""))
            {
                txt_error6.Text = "Vui lòng lựa chọn số phòng!";
                status = false;
            }
            return status;
        }
        private void reset()
        {
            hoTenBox.Text = "";
            sdtBox.Text = "";
            cccdBox.Text = "";
            loaiPhongBox.Text = "";
            loaiGiuongBox.Text = "";
            soPhongBox.Text = "";
            txt_error1.Text = "";
            txt_error2.Text = "";
            txt_error3.Text = "";
            txt_error4.Text = "";
            txt_error5.Text = "";
            txt_error6.Text = "";
            soPhongBox.Items.Clear();
        }


        private void loaiPhongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem cả hai combobox đã được chọn hay chưa
            if (loaiPhongBox.SelectedItem != null && loaiGiuongBox.SelectedItem != null)
            {
                // Gọi hàm để lấy danh sách số phòng dựa trên loại phòng và loại giường được chọn
                getRoomNo();
            }
        }

        private void loaiGiuongBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem cả hai combobox đã được chọn hay chưa
            if (loaiPhongBox.SelectedItem != null && loaiGiuongBox.SelectedItem != null)
            {
                // Gọi hàm để lấy danh sách số phòng dựa trên loại phòng và loại giường được chọn
                getRoomNo();
            }
        }

        void Search()
        {
            string tk = txtsearch.Text;
            if (string.IsNullOrEmpty(tk))
            {
                LoadKhach();
            }
            else
            {
                listKhachHang.DataSource = KhachHang_DAO.Instance.SearchKH(tk);
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Search();
        }

        // Theo dõi lựa chọn loại phòng, giường lấy ra số phòng
        private void getRoomNo()
        {
            txt_error4.Text = "";
            List<Rooms> roomNo = Rooms_DAO.Instance.getRooms(loaiPhongBox.Text, loaiGiuongBox.Text);
            soPhongBox.Items.Clear();
            foreach (var item in roomNo)
            {
                soPhongBox.Items.Add(new Item() { Text = item.RoomNo, Value = item.ID });
            }
        }

    }

    public class Item
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
