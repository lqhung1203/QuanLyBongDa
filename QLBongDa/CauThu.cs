using BUS;
using DTO;
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
    public partial class CauThu : Form
    {
        public CauThu()
        {
            InitializeComponent();
        }
        //Properties
        public static BUS_CauThu cauthu = new BUS_CauThu();
        public static BUS_DoiBong BUSDB = new BUS_DoiBong();
        private void CauThu_Load(object sender, EventArgs e)
        {
            LoadDSCauThu();
            cbbMaDB.DataSource = BUSDB.LoadDSDB();
            cbbMaDB.DisplayMember = "TenDB";
            cbbMaDB.ValueMember = "MaDB";
        }

        public void LoadDSCauThu()
        {
            dtgvCauThu.DataSource = cauthu.LayDS();
        }
        public void ResetFlied()
        {

            txtmaCauThu.Text = "";
            txtTenCauThu.Text = "";
            cbbViTri.Text = "";
            txtSoAo.Text = "";
            cbbMaDB.Text = "";
        }

        private void dtgvCauThu_Click(object sender, EventArgs e)
        {
            int dong = dtgvCauThu.CurrentCell.RowIndex;
            txtmaCauThu.Text = dtgvCauThu.Rows[dong].Cells["MaCT"].Value.ToString();
            txtTenCauThu.Text = dtgvCauThu.Rows[dong].Cells["TenCT"].Value.ToString();
            cbbViTri.SelectedItem = dtgvCauThu.Rows[dong].Cells["ViTri"].Value.ToString();
            txtSoAo.Text = dtgvCauThu.Rows[dong].Cells["SoAo"].Value.ToString();
            string doibong = dtgvCauThu.Rows[dong].Cells["MaDB"].Value.ToString();
            cbbMaDB.SelectedValue = doibong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Cauthu ct = new DTO_Cauthu(
                    txtmaCauThu.Text,
                    txtTenCauThu.Text,
                    cbbViTri.SelectedItem.ToString(),
                    cbbMaDB.SelectedValue.ToString(),
                    int.Parse(txtSoAo.Text
                ));
                cauthu.ThemCauThu(ct);

                LoadDSCauThu();
                ResetFlied();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa" + txtmaCauThu.Text + "?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    cauthu.XoaCauThu(txtmaCauThu.Text);
                    LoadDSCauThu();
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
                DTO_Cauthu ct = new DTO_Cauthu(
                    txtmaCauThu.Text,
                    txtTenCauThu.Text,
                    cbbViTri.SelectedItem.ToString(),
                    cbbMaDB.SelectedValue.ToString(),
                    int.Parse(txtSoAo.Text)
                    );
                cauthu.SuaCauThu(ct);

                LoadDSCauThu();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị một hộp thoại thông báo để xác nhận việc thoát
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form hiện tại
                this.Close();
            }
        }
    }
}
