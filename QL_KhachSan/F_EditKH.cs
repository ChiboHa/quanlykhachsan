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

namespace QL_KhachSan
{
    public partial class F_EditKH : Form
    {
        public F_EditKH()
        {
            InitializeComponent();
        }
        public void SetInfo(string sdt, string hoTen, string cccd)
        {
            sdtBox.Text = sdt;
            hoTenBox.Text = hoTen;
            cccdBox.Text = cccd;

            sdtBox.ReadOnly = true;
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            string id = sdtBox.Text;
            string name = hoTenBox.Text;
            string cccd = cccdBox.Text;

            if (KhachHang_DAO.Instance.EditKH(name, cccd, id))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi!");
            }
        }

    }
}
