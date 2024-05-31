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
    public partial class BanThang : Form
    {
        public BanThang()
        {
            InitializeComponent();
        }
        //Properties
        //Properties
        private static BUS_BanThang banthang = new BUS_BanThang();
        private static BUS_CauThu cauThu = new BUS_CauThu();
        private static BUS_LichThiDau lichthidau = new BUS_LichThiDau();
        public void LoadDSBanThang()
        {
            dtgvBanThang.DataSource = banthang.LayDS();
        }
        public void ResetField()
        {
            txtmaBT.Text = "";
            cbbMaCT.Text = "";
            cbbLoaiBT.Text = "";
            dtpThoiDiem.Text = "";
            cbbMaTD.Text = "";
            cbbMaDB.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_BanThang banThang = new DTO_BanThang(
                    txtmaBT.Text,
                    cbbMaCT.SelectedValue.ToString(),
                    cbbLoaiBT.SelectedItem.ToString(),
                    cbbMaTD.SelectedValue.ToString(),
                    cbbMaDB.SelectedValue.ToString(),
                    dtpThoiDiem.Value.TimeOfDay);

                banthang.ThemBT(banThang);

                MessageBox.Show("Thêm Thành Công " + txtmaBT.Text);
                LoadDSBanThang();
                ResetField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BanThang_Load(object sender, EventArgs e)
        {
            LoadDSBanThang();



            cbbMaTD.DataSource = lichthidau.LoadDSTD();
            cbbMaTD.DisplayMember = "MaTD";
            cbbMaTD.ValueMember = "MaTD";

            string maTD = cbbMaTD.SelectedValue.ToString();
            var dsMaDB = banthang.LoadDMaDB(maTD);

            cbbMaDB.DataSource = dsMaDB;
            cbbMaDB.DisplayMember = "TenDB"; // Hiển thị tên Đội bóng
            cbbMaDB.ValueMember = "MaDB"; // Giá trị thực sự được chọn là mã đội bóng
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa " + txtmaBT.Text + "?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    banthang.XoaBT(txtmaBT.Text);
                    LoadDSBanThang();
                    ResetField();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_BanThang banThang = new DTO_BanThang(
                    txtmaBT.Text,
                    cbbMaCT.SelectedValue.ToString(),
                    cbbLoaiBT.SelectedItem.ToString(),
                    cbbMaTD.SelectedValue.ToString(),
                    cbbMaDB.SelectedValue.ToString(),
                    dtpThoiDiem.Value.TimeOfDay);
                banthang.SuaBT(banThang);

                MessageBox.Show("Cập nhật thành công cho " + txtmaBT.Text);
                LoadDSBanThang();
                ResetField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void cbbMaTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaTD.SelectedValue != null)
            {
                try
                {
                    string maTD = cbbMaTD.SelectedValue.ToString();
                    var dsMaDB = banthang.LoadDMaDB(maTD);

                    cbbMaDB.DataSource = dsMaDB;
                    cbbMaDB.DisplayMember = "TenDB";
                    cbbMaDB.ValueMember = "MaDB";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cbbMaDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaDB.SelectedValue != null)
            {
                try
                {
                    string maDB = cbbMaDB.SelectedValue.ToString();
                    var dsMaCT = banthang.LoadDMaCTT(maDB);
                    cbbMaCT.DataSource = dsMaCT;
                    cbbMaCT.DisplayMember = "TenCT";
                    cbbMaCT.ValueMember = "MaCT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtmaBT.Enabled = true;
            txtmaBT.Text = "";
            cbbLoaiBT.SelectedIndex = -1;
            cbbMaCT.SelectedIndex = -1;
            cbbMaTD.SelectedIndex = -1;
            cbbMaDB.SelectedIndex = -1;
            dtpThoiDiem.Text = "";
        }

        private void dtgvBanThang_Click(object sender, EventArgs e)
        {
            int dong = dtgvBanThang.CurrentCell.RowIndex;
            txtmaBT.Text = dtgvBanThang.Rows[dong].Cells["MaBT"].Value.ToString();
            cbbLoaiBT.Text = dtgvBanThang.Rows[dong].Cells["LoaiBT"].Value.ToString();
            dtpThoiDiem.Text = dtgvBanThang.Rows[dong].Cells["ThoiDiem"].Value.ToString();
            string maCT = dtgvBanThang.Rows[dong].Cells["MaCT"].Value.ToString();
            cbbMaCT.SelectedValue = maCT;
            string maDB = dtgvBanThang.Rows[dong].Cells["MaDB"].Value.ToString();
            cbbMaDB.SelectedValue = maDB;
            cbbMaTD.Text = dtgvBanThang.Rows[dong].Cells["MaTD"].Value.ToString();
        }
    }
}
