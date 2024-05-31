using QLBongDa.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDa.Connection
{
    public partial class formConnect : Form
    {
        public formConnect()
        {
            InitializeComponent();  
        }

        private void formConnect_Load(object sender, EventArgs e)
        {
            rdoXacthucWins.Checked = true;
            txtTaikhoan.Enabled = false;
            txtMatkhau.Enabled = false;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string connString = "";
                if (rdoXacthucWins.Checked == true)
                {
                    connString = "server=" + txtTenServer.Text;
                    connString += ";database=" + txtTenDb.Text;
                    connString += ";integrated security=true";
                    conn.ConnectionString = connString;
                }
                else
                {
                    connString = "server=" + txtTenServer.Text;
                    connString += ";database=" + txtTenDb.Text;
                    connString += ";uid=" + txtTaikhoan.Text;
                    connString += ";pwd=" + txtMatkhau.Text;
                    conn.ConnectionString = connString;
                }
                conn.Open();
                MessageBox.Show("Kết nối thành công");
                this.Hide();
                formLogin lg = new formLogin();
                lg.ShowDialog();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Faild!!!" + ex.Message);
            }
        }

        private void rdoXacthucSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
        }

        private void rdoXacthucWins_CheckedChanged(object sender, EventArgs e)
        {
            txtTaikhoan.Enabled = false;
            txtMatkhau.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
