using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDa.Report
{
    public partial class TopBanThang : Form
    {
        public TopBanThang()
        {
            InitializeComponent();
            QLBongDa.Top5CauThuGhiBanDataTable b = new QLBongDa.Top5CauThuGhiBanDataTable();
            QLBongDaTableAdapters.Top5CauThuGhiBanTableAdapter a = new QLBongDaTableAdapters.Top5CauThuGhiBanTableAdapter();
            b.Reset();
            a.Fill(b);

            InTopbanthang rpct = new InTopbanthang();

            rpct.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = rpct;
            crystalReportViewer1.RefreshReport();
        }
        private void TopBanThang_Load(object sender, EventArgs e)
        {

        }
    }
}
