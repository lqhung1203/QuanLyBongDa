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
    public partial class RpNTTDB : Form
    {
        public RpNTTDB()
        {
            InitializeComponent();
            QLBongDa.sp_LayDSNTTDBDataTable b = new QLBongDa.sp_LayDSNTTDBDataTable();
            QLBongDaTableAdapters.sp_LayDSNTTDBTableAdapter a = new QLBongDaTableAdapters.sp_LayDSNTTDBTableAdapter();
            b.Reset();
            a.Fill(b);

            InDSNTTDB bxh = new InDSNTTDB();

            bxh.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = bxh;
            crystalReportViewer1.RefreshReport();
        }

        private void RpNTTDB_Load(object sender, EventArgs e)
        {

        }
    }
}
