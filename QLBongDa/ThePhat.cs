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
    public partial class ThePhat : Form
    {
        public ThePhat()
        {
            InitializeComponent();
        }
        private static BUS_ThePhat BUSTP = new BUS_ThePhat();
        private static BUS_LichThiDau BUSTD = new BUS_LichThiDau();
        private static DTO_ThePhat DTOTP;
        private void ThePhat_Load(object sender, EventArgs e)
        {
            LoadDSTP();
        }
        public void LoadDSTP()
        {
            dtgTTTP.DataSource = BUSTP.LoadDSTP();


            cboMaTD.DataSource = BUSTD.LoadDSTD();
            cboMaTD.DisplayMember = "MaTD";
            cboMaTD.ValueMember = "MaTD";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {
                    DTOTP = new DTO_ThePhat()
                    {
                        MaTP = txtMaTP.Text,
                        TenTP = txtTenTP.Text,
                        ThoiDiem = dtfThoiDiem.Value.TimeOfDay,
                        MaCT = cboMaCT.SelectedValue.ToString(),
                        MaTD = cboMaTD.SelectedValue.ToString(),
                        MaDB = cbbDoiBong.SelectedValue.ToString(),
                    };
                    if (BUSTP.AddTP(DTOTP))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDSTP();
                        Renew();// Làm mới các trường nhập liệu
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Renew()
        {
            txtMaTP.Text = "";
            txtTenTP.Text = "";
            dtfThoiDiem.Text = "";
        }
        public bool Checked()
        {
            if (txtMaTP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã TP!!", "Thông báo");
                txtMaTP.Focus();
                return false;
            }

            if (txtTenTP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên TP!!", "Thông báo");
                txtTenTP.Focus();
                return false;
            }
            if (dtfThoiDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời điểm", "Thông báo");
                dtfThoiDiem.Focus();
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Checked())
                    {
                        DTOTP = new DTO_ThePhat()
                        {
                            MaTP = txtMaTP.Text,
                            TenTP = txtTenTP.Text,
                            ThoiDiem = dtfThoiDiem.Value.TimeOfDay,
                            MaCT = cboMaCT.SelectedValue.ToString(),
                            MaTD = cboMaTD.SelectedValue.ToString(),
                        };
                        if (BUSTP.DeleteTP(DTOTP))
                        {
                            MessageBox.Show("Xóa Thành công!", "Thông Báo");
                            LoadDSTP();
                            Renew();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {
                    DTOTP = new DTO_ThePhat()
                    {
                        MaTP = txtMaTP.Text,
                        TenTP = txtTenTP.Text,
                        ThoiDiem = dtfThoiDiem.Value.TimeOfDay,
                        MaCT = cboMaCT.SelectedValue.ToString(),
                        MaTD = cboMaTD.SelectedValue.ToString(),
                        MaDB = cbbDoiBong.SelectedValue.ToString(),
                    };
                    if (BUSTP.UpdateTP(DTOTP))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông Báo");
                        LoadDSTP();
                        Renew();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void dtgTTTP_Click(object sender, EventArgs e)
        {
            int dong = dtgTTTP.CurrentCell.RowIndex;
            txtMaTP.Text = dtgTTTP.Rows[dong].Cells["MaTP"].Value.ToString();
            txtTenTP.Text = dtgTTTP.Rows[dong].Cells["TenTP"].Value.ToString();
            dtfThoiDiem.Text = dtgTTTP.Rows[dong].Cells["ThoiDiem"].Value.ToString();
            string maCT = dtgTTTP.Rows[dong].Cells["MaCT"].Value.ToString();
            cboMaCT.SelectedValue = maCT;
            string maDB = dtgTTTP.Rows[dong].Cells["MaDB"].Value.ToString();
            cbbDoiBong.SelectedValue = maDB;
            cboMaTD.Text = dtgTTTP.Rows[dong].Cells["MaTD"].Value.ToString();
        }

        private void cboMaTD_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string maTD = cboMaTD.SelectedValue.ToString();
                var dsMaDB = BUSTP.LoadDMaDB(maTD);

                cbbDoiBong.DataSource = dsMaDB;
                cbbDoiBong.DisplayMember = "TenDB";
                cbbDoiBong.ValueMember = "MaDB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Thông báo trước khi thoát nếu YES sẽ thoát khỏi form ngược thì không
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbbDoiBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDoiBong.SelectedValue != null)
            {
                try
                {
                    string maDB = cbbDoiBong.SelectedValue.ToString();
                    var dsMaCT = BUSTP.LoadDMaCTT(maDB);

                    cboMaCT.DataSource = dsMaCT;
                    cboMaCT.DisplayMember = "TenCT"; // Hiển thị tên cầu thủ
                    cboMaCT.ValueMember = "MaCT"; // Giá trị thực sự được chọn là mã cầu thủ
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
