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
    public partial class BangXepHang : Form
    {
        public BangXepHang()
        {
            InitializeComponent();
            QLBongDa.sp_SapXepBXH_GiamDanDiemDataTable b = new QLBongDa.sp_SapXepBXH_GiamDanDiemDataTable();
            QLBongDaTableAdapters.sp_SapXepBXH_GiamDanDiemTableAdapter a = new QLBongDaTableAdapters.sp_SapXepBXH_GiamDanDiemTableAdapter();
            b.Reset();
            a.Fill(b);

            InBXH bxh = new InBXH();

            bxh.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = bxh;
            crystalReportViewer1.RefreshReport();
        }

        private void BangXepHang_Load(object sender, EventArgs e)
        {

        }
    }
}
