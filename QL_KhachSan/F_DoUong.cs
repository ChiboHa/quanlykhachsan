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
    public partial class F_DoUong : Form
    {
        public F_DoUong()
        {
            InitializeComponent();
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
