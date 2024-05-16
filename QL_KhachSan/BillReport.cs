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
    public partial class BillReport : Form
    {
        public BillReport()
        {
            InitializeComponent();

            DataSetBill.BillReportDataTable b = new DataSetBill.BillReportDataTable();
            DataSetBillTableAdapters.BillReportTableAdapter a = new DataSetBillTableAdapters.BillReportTableAdapter();
            b.Reset();
            a.Fill(b);


            CrystalReport1 rp = new CrystalReport1();
            rp.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
    }
}
