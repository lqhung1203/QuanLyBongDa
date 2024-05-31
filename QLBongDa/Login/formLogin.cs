using BUS;
using DevExpress.Xpo.Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDa.Login
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            string Thongbao = "";
            HienThiThongBao(Thongbao);
            AnMatKhau();
        }
        private static BUS_Login BUSLG= new BUS_Login();
        private void formLogin_Load(object sender, EventArgs e)
        {

        }
        private void HienThiThongBao(string thongBao)
        {
            if (string.IsNullOrWhiteSpace(thongBao))
            {
                // Nếu rỗng, ẩn Label
                lbError.Visible = false;
            }
            else
            {
                lbError.Text = thongBao;
                lbError.Visible = true;

            }
        }
        private void cboAnHien_CheckedChanged(object sender, EventArgs e)
        {
            bool hienMatKhau = cboAnHien.Checked;

            // Hiển thị hoặc ẩn mật khẩu tùy thuộc vào trạng thái của CheckBox
            if (hienMatKhau)
            {
                HienMatKhau();
            }
            else
            {
                AnMatKhau();
            }
        }
        private void AnMatKhau()
        {

            txtMatkhau.PasswordChar = '*';
        }

        private void HienMatKhau()
        {
            txtMatkhau.PasswordChar = '\0';
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTakhoan.Text;
            string password = txtMatkhau.Text;

            if (BUSLG.ValidLogin(username, password))
            {
                this.Hide();
                formMain trangchu = new formMain();
                trangchu.Show();
            }
            else
            {
                // Sai tên đăng nhập hoặc mật khẩu
                HienThiThongBao("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
