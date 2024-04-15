using Microsoft.SqlServer.Server;
using QL_KhachSan.DAO;
using QL_KhachSan.DTO;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_KhachSan
{
    public partial class F_DoUong : Form
    {
        public F_DoUong()
        {
            InitializeComponent();

            LoadFood();

            
        }

        

        void LoadFood()
        {
            dtgfmenu.DataSource = Food_DAO.Instance.GetListFood();
            dtgfmenu.Columns["ID"].Visible = false;
            dtgfmenu.Columns["Ten"].HeaderText = "Tên món";
            dtgfmenu.Columns["Muc"].HeaderText = "Mục";
            dtgfmenu.Columns["Gia"].HeaderText = "Giá";
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            string name = txtNameF.Text;
            string catgory = cbCateF.Text;
            int cost = Convert.ToInt32(txtCostF.Text);

            if (Food_DAO.Instance.AddFood(name, catgory, cost))
            {
                MessageBox.Show("Thêm thành công.");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }   
        }

        private void dtgfmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgfmenu.CurrentRow != null) // Check for valid row selection
            {
                txtNameF.Text = dtgfmenu.CurrentRow.Cells[1].Value.ToString();
                txtCostF.Text = dtgfmenu.CurrentRow.Cells[3].Value.ToString();
                string cate = dtgfmenu.CurrentRow.Cells[2].Value.ToString();
                switch (cate)
                {
                    case "Food":
                        cbCateF.Text ="Food";
                        break;
                    case "Drink":
                        cbCateF.Text = "Drink";
                        break;
                    default:
                        cbCateF.SelectedIndex = -1;
                        break;
                }
            }
        }
        private void btneditF_Click(object sender, EventArgs e)
        {
            string name = txtNameF.Text;
            string catgory = cbCateF.Text;
            int cost = Convert.ToInt32(txtCostF.Text);
            
            if (Food_DAO.Instance.EditFood(name, catgory, cost))
            {
                MessageBox.Show("Sửa thành công.");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btndelF_Click(object sender, EventArgs e)
        {
            string id = txtNameF.Text ;
            if (Food_DAO.Instance.DelFood(id))
            {
                MessageBox.Show("Xóa thành công.");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }


        private void btn_foodmng_Click(object sender, EventArgs e)
        {

        }

        private void F_DoUong_Load(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtNameF.Clear();
            txtCostF.Clear();
            cbCateF.SelectedIndex=-1;
        }
        void Search()
        {

            string tk = txtSearch.Text;
            if (string.IsNullOrEmpty(tk))
            {
                // Nếu ô tìm kiếm trống, hiển thị tất cả các dữ liệu
                LoadFood();
            }
            else
            {
                // Nếu có từ khóa tìm kiếm, thực hiện tìm kiếm bình thường
                dtgfmenu.DataSource = Food_DAO.Instance.SearchFood(tk);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtNameF.Clear();
            txtCostF.Clear();
            cbCateF.SelectedIndex = -1;
            Search();
        }
    }
}
