using Microsoft.Reporting.WinForms;
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
        }

        private void BillReport_Load(object sender, EventArgs e)
        {
            BillContext context = new BillContext();
            List<View_All_Bill_Test> listBill = context.View_All_Bill_Test.ToList();

            reportViewer1.LocalReport.ReportPath = "rptBill.rdlc";
            var source = new ReportDataSource("BillDataSet", listBill);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
