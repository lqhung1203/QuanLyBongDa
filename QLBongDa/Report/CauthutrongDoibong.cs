using CrystalDecisions.Windows.Forms;
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
    public partial class CauthutrongDoibong : Form
    {
        public CauthutrongDoibong()
        {
            InitializeComponent();
        }

        public CauthutrongDoibong(string maDB)
        {
            InitializeComponent();
            QLBongDa.SP_LayCauthuDoibongDataTable b = new QLBongDa.SP_LayCauthuDoibongDataTable();
            QLBongDaTableAdapters.SP_LayCauthuDoibongTableAdapter a = new QLBongDaTableAdapters.SP_LayCauthuDoibongTableAdapter();
            b.Reset();
            a.Fill(b, maDB);

            InDSCauthuDoibong rpct = new InDSCauthuDoibong();

            rpct.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = rpct;
            crystalReportViewer1.RefreshReport();
        }

        private void CauthutrongDoibong_Load(object sender, EventArgs e)
        {

        }
    }
}
