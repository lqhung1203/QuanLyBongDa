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
    public partial class RpLichThiDau : Form
    {
        public RpLichThiDau()
        {
            InitializeComponent();
            QLBongDa.sp_LichThiDauDataTable b = new QLBongDa.sp_LichThiDauDataTable();
            QLBongDaTableAdapters.sp_LichThiDauTableAdapter a = new QLBongDaTableAdapters.sp_LichThiDauTableAdapter();
            b.Reset();
            a.Fill(b);

            InLichThiDau lichThiDau = new InLichThiDau();

            lichThiDau.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = lichThiDau;
            crystalReportViewer1.RefreshReport();
        }

        private void RpLichThiDau_Load(object sender, EventArgs e)
        {

        }
    }
}
