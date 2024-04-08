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
            txtNameF.Text = dtgfmenu.CurrentRow.Cells[1].Value.ToString();
            txtCostF.Text = dtgfmenu.CurrentRow.Cells[3].Value.ToString();
            txtID.Text = dtgfmenu.CurrentRow.Cells[0].Value.ToString();
        }

        private void btneditF_Click(object sender, EventArgs e)
        {
            string name = txtNameF.Text;
            string catgory = cbCateF.Text;
            int cost = Convert.ToInt32(txtCostF.Text);
            int id = Convert.ToInt32(txtID.Text);
            if (Food_DAO.Instance.EditFood(name, catgory, cost,id))
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
            int id = Convert.ToInt32(txtID.Text);
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

        F_FoodQL fFoodql;

        private void btn_foodmng_Click(object sender, EventArgs e)
        {

        }

        private void btn_foodmng_Click_1(object sender, EventArgs e)
        {
            if (fFoodql == null)
            {
                fFoodql = new F_FoodQL();
                fFoodql.FormClosed += FFoodql_FormClosed;
                fFoodql.Show();
            }
            else
            {
                fFoodql.Activate();
            }
        }

        private void FFoodql_FormClosed(object sender, FormClosedEventArgs e)
        {
            fFoodql = null;
        }
    }
}
