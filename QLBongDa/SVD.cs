using BUSS;
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
    public partial class SVD : Form
    {
        private static BUS_SVD sanvandong = new BUS_SVD();
        public SVD()
        {
            InitializeComponent();
        }

        private void SVD_Load(object sender, EventArgs e)
        {
            LoadDanhSachSVD();
        }
        private void LoadDanhSachSVD()
        {
            dtgvSVD.DataSource = sanvandong.LayDS();
        }
        private void ResetFlied()
        {
            txtMaSan.Enabled = true;
            txtMaSan.Text = "";
            txtTenSan.Text = "";
            txtSucChua.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.DTO_SVD svd = new DTO.DTO_SVD(
                    txtMaSan.Text,
                    txtTenSan.Text,
                    txtDiaChi.Text,
                    int.Parse(txtSucChua.Text));
                sanvandong.ThemSVD(svd);
                LoadDanhSachSVD();
                ResetFlied();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa " + txtMaSan.Text + "?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    sanvandong.XoaSVD(txtMaSan.Text);
                    LoadDanhSachSVD();
                    ResetFlied();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.DTO_SVD svd = new DTO.DTO_SVD(
                    txtMaSan.Text,
                    txtTenSan.Text,
                    txtDiaChi.Text,
                    int.Parse(txtSucChua.Text));
                sanvandong.SuaSVD(svd);
                LoadDanhSachSVD();
                ResetFlied();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetFlied();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hiển thị một hộp thoại thông báo để xác nhận việc thoát
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form hiện tại
                this.Close();
            }
        }

        private void dtgvSVD_Click(object sender, EventArgs e)
        {
            txtMaSan.Enabled = false;
            int dong = dtgvSVD.CurrentCell.RowIndex;
            txtMaSan.Text = dtgvSVD.Rows[dong].Cells[0].Value.ToString();
            txtTenSan.Text = dtgvSVD.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvSVD.Rows[dong].Cells[2].Value.ToString();
            txtSucChua.Text = dtgvSVD.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnXuaDS_Click(object sender, EventArgs e)
        {
            RpSanVanDong sp = new RpSanVanDong();
            sp.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Thông báo trước khi thoát nếu YES sẽ thoát khỏi form ngược thì không
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
