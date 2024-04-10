using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_KhachSan.DAO;
using QL_KhachSan.DTO;

namespace QL_KhachSan
{
    public partial class F_MonAn : Form
    {
        


        public F_MonAn()
        {
            InitializeComponent();
            LoadFoods();
        }
        public class CustomButton : Button
        {
            public CustomButton()
            {
                // Set default properties
                Width = 90;
                Height = 90;
                BackColor = Color.Black;
                ForeColor = Color.White;
                Font = new Font("Arial", 14);
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.MouseOverBackColor = Color.Silver;
                FlatAppearance.MouseDownBackColor = Color.DimGray;
                FlatAppearance.BorderColor = Color.Black;
                FlatAppearance.BorderSize = 2;
            }
        }

        public class CustomLabel : Label 
        {
            public CustomLabel()
            {
                ForeColor = Color.Black;
                BackColor = Color.White;
                Font = new Font("Arial", 12);
                AutoSize = true;

                Dock = DockStyle.Bottom;
                TextAlign = ContentAlignment.MiddleCenter;
                BorderStyle = BorderStyle.FixedSingle;
                  
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        void LoadFoods()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Food> list = Food_DAO.Instance.GetListFood();

            foreach (Food item in list)
            {
                if (item.Muc.Equals("Food"))
                {
                    CustomButton btn = new CustomButton();
                    btn.Click += (sender, e) =>
                    {
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Black;
                    };
                    CustomLabel lbl = new CustomLabel();
                    lbl.Text = item.Gia.ToString();
                    btn.Controls.Add(lbl);
                    btn.Text = item.Ten;
                    btn.Tag = item.ID;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }
        void LoadDrinks()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Food> list = Food_DAO.Instance.GetListFood();

            foreach (Food item in list)
            {
                if (item.Muc.Equals("Drink"))
                {
                    CustomButton btn = new CustomButton();
                    btn.Click += (sender, e) =>
                    {
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Black;
                    };
                    CustomLabel lbl = new CustomLabel();
                    lbl.Text = item.Gia.ToString();
                    btn.Controls.Add(lbl);
                    btn.Text = item.Ten;
                    btn.Tag = item.ID;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            LoadFoods();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int foodcode = Convert.ToInt32(((Button)sender).Tag); // Trích xuất giá trị food code từ Tag
                                                                      // Tiếp tục xử lý dữ liệu

                Food food = Food_DAO.Instance.GetFoodByID(foodcode);
                if (food != null)
                {
                    bool exist = false;
                    int numrow = 0;
                    int numtext = 0;
                    foreach (DataGridViewRow itm in dataGridView1.Rows)
                    {
                        if (itm.Cells[1].Value != null)
                        {
                            if (itm.Cells[1].Value.ToString() == food.ID.ToString())
                            {
                                exist = true;
                                numrow = itm.Index;
                                numtext = Convert.ToInt32(itm.Cells[4].Value);
                                break;
                            }
                        }
                    }
                    if (exist == false)
                    {
                        int cost = Convert.ToInt32(food.Gia);
                        int subtotalprice = Convert.ToInt32(cost) * 1;
                        dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, food.ID, food.Ten, food.Gia, 1, subtotalprice);
                    }
                    else
                    {
                        dataGridView1.Rows[numrow].Cells[4].Value = Convert.ToInt32("1") + numtext;
                        dataGridView1.Rows[numrow].Cells[5].Value = Convert.ToInt32(dataGridView1.Rows[numrow].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[numrow].Cells[4].Value);
                    }
                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi khi không thể chuyển đổi
                MessageBox.Show("Invalid food code: " + ex.Message);
            }
        }

        private void Get_grandTotal()
        {

            int grandtotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                grandtotal = grandtotal + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lbl_GrandTotal.Text = grandtotal.ToString();

        }


        private void Get_pricedata()
        {
            try
            {
                double noofProducts = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    noofProducts = noofProducts + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                lbl_noOfProducts.Text = noofProducts.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Get_grandTotal();
            Get_pricedata();

            lbl_date.Text = DateTime.Now.ToString("ddd, dd-MM-yyyy");
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void new_order()
        {
            LoadFoods();
            dataGridView1.Rows.Clear();
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd");


        }



        private void F_MonAn_Load(object sender, EventArgs e)
        {


        }

        


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Get_grandTotal();

        }

        private void F_MonAn_Load_1(object sender, EventArgs e)
        {
           
            Timer timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây (1000ms)
            timer.Tick += Timer1_Tick;
            timer.Start();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            new_order_1();
            
        }
        private void new_order_1()
        {
            // Tải lại danh sách món ăn
            dataGridView1.Rows.Clear(); // Xóa hết dữ liệu trong DataGridView
            flowLayoutPanel1.Controls.Clear();

            // Cập nhật lại các số liệu
            Get_grandTotal();
            Get_pricedata();
            
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            LoadDrinks();
        }
        private void ThanhToan()
        {
            int grandtotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                grandtotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }

            string idkh = txt_kh.Text;
            DateTime currentDate = DateTime.Now;

            // Thêm hóa đơn mới và lấy ID của hóa đơn vừa được tạo ra
            BillFoodDAO.Instance.AddBill(idkh,currentDate,currentDate.Month.ToString(),grandtotal,"NO");
            int billID = BillFoodDAO.Instance.GetUncheckBillID();
            // Kiểm tra xem có lỗi xảy ra khi thêm hóa đơn hay không
            if (billID != -1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int idfood = Convert.ToInt32(row.Cells[1].Value);
                    string itemName = row.Cells[2].Value.ToString();
                    int itemPrice = Convert.ToInt32(row.Cells[3].Value);
                    int itemQuantity = Convert.ToInt32(row.Cells[4].Value);
                    int itemTotal = Convert.ToInt32(row.Cells[5].Value);

                    // Thêm thông tin về món ăn vào bảng Pos, sử dụng billID lấy được ở bước trước
                    PosDAO.Instance.AddPos(billID,idfood,itemName,itemPrice,itemQuantity,itemTotal);
                }

                // Hiển thị thông báo cho người dùng về việc thanh toán thành công

                // Xóa dữ liệu trong DataGridView và cập nhật lại giao diện người dùng sau khi thanh toán
                dataGridView1.Rows.Clear();
                Get_grandTotal();
                Get_pricedata();
            }
            else
            {
                // Hiển thị thông báo cho người dùng về việc có lỗi xảy ra khi thêm hóa đơn
            }
        }


        private void btnAddBill_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void txt_kh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
