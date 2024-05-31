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
    public partial class RpSanVanDong : Form
    {
        public RpSanVanDong()
        {
            InitializeComponent();
            QLBongDa.sp_LayDSSVDDataTable b = new QLBongDa.sp_LayDSSVDDataTable();
            QLBongDaTableAdapters.sp_LayDSSVDTableAdapter a = new QLBongDaTableAdapters.sp_LayDSSVDTableAdapter();
            b.Reset();
            a.Fill(b);

            InDSSVD spsvd = new InDSSVD();

            spsvd.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = spsvd;
            crystalReportViewer1.RefreshReport();
        }
        private void RpSanVanDong_Load(object sender, EventArgs e)
        {

        }
    }
}
