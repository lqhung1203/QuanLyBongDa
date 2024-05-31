using QLBongDa.Login;
using QLBongDa.RCLichthidau;
using QLBongDa.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDa
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }
        private Form curentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1_body.Controls.Add(childForm);
            panel1_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDoibong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doibong());

        }

        private void btnTrandau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemLichThiDau());
        }

        private void btnXephang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BangXepHang());
        }

        private void btnCauthu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CauThu());
        }
        private void LogoMain_Click(object sender, EventArgs e)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
        }

        private void btnLichthidau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RpLichThiDau());
        }

        private void btnKetQuaThiDau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RpKetQuaThiDau());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                formLogin lg = new formLogin();
                this.Hide();
                lg.Show();
            }
        }
    }
}
