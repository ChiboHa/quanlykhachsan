using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class F_MonAn : Form
    {
        public F_MonAn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        F_FoodQL fFoodql;

        private void bunifuButton1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
