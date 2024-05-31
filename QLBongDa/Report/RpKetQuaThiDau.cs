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
    public partial class RpKetQuaThiDau : Form
    {
        public RpKetQuaThiDau()
        {
            InitializeComponent();
            QLBongDa.sp_KetQuaThiDauDataTable b = new QLBongDa.sp_KetQuaThiDauDataTable();
            QLBongDaTableAdapters.sp_KetQuaThiDauTableAdapter a = new QLBongDaTableAdapters.sp_KetQuaThiDauTableAdapter();
            b.Reset();
            a.Fill(b);

            InKetQuaThiDau kqThiDau = new InKetQuaThiDau();

            kqThiDau.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = kqThiDau;
            crystalReportViewer1.RefreshReport();
        }

        private void RpKetQuaThiDau_Load(object sender, EventArgs e)
        {

        }
    }
}
