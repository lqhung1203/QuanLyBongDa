using BUSS;
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
    public partial class Trongtai : Form
    {
        public Trongtai()
        {
            InitializeComponent();
        }
        public static BUS_TongTai trongtai = new BUS_TongTai();
        private void Trongtai_Load(object sender, EventArgs e)
        {
            LoadDSTT();
        }
        private void LoadDSTT()
        {
            dtgvTT.DataSource = trongtai.LayDS();
        }
        private void ResetFlield()
        {
            txtmaTT.Enabled = true;
            txtmaTT.Text = "";
            txtTenTT.Text = "";
            dtpNgaySinh.Text = "";
            txtQuocTich.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.DTO_TrongTai tt = new DTO.DTO_TrongTai(
                    txtmaTT.Text,
                    txtTenTT.Text,
                    dtpNgaySinh.Value,
                    txtQuocTich.Text);
                trongtai.ThemTT(tt);
                LoadDSTT();
                ResetFlield();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa " + txtmaTT.Text + "?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    trongtai.XoaTT(txtmaTT.Text);
                    LoadDSTT();
                    ResetFlield();
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
                DTO.DTO_TrongTai tt = new DTO.DTO_TrongTai(
                    txtmaTT.Text,
                    txtTenTT.Text,
                    dtpNgaySinh.Value,
                    txtQuocTich.Text);
                trongtai.SuaTT(tt);
                LoadDSTT();
                ResetFlield();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetFlield();
        }

        private void dtgvTT_Click(object sender, EventArgs e)
        {
            txtmaTT.Enabled = false;
            int dong = dtgvTT.CurrentCell.RowIndex;
            txtmaTT.Text = dtgvTT.Rows[dong].Cells["maTT"].Value.ToString();
            txtTenTT.Text = dtgvTT.Rows[dong].Cells["tenTT"].Value.ToString();
            dtpNgaySinh.Text = dtgvTT.Rows[dong].Cells["ngaySinh"].Value.ToString();
            txtQuocTich.Text = dtgvTT.Rows[dong].Cells["quocTich"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thông báo trước khi thoát nếu YES sẽ thoát khỏi form ngược thì không
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
