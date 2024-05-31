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
    public partial class KetQuaThiDau : Form
    {
        public KetQuaThiDau()
        {
            InitializeComponent();
        }
        private static BUS_KQThiDau BUSKQ = new BUS_KQThiDau();
        private static BUS_LichThiDau BUSLTD = new BUS_LichThiDau();
        private void KetQuaThiDau_Load(object sender, EventArgs e)
        {
            LoadDSKQ();
        }
        public void LoadDSKQ()
        {
            dtgKQTD.DataSource = BUSKQ.LoadDSKQTD();

            cboMaTD.DataSource = BUSLTD.LoadDSMaTD();
            cboMaTD.DisplayMember = "MaTD";
            cboMaTD.ValueMember = "MaTD";
        }

        private void btnTaoKQ_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {
                    DTO_KQThiDau kqTD = new DTO_KQThiDau()
                    {
                        MaKQ = txtMaKQ.Text,
                        MaTD = cboMaTD.SelectedValue.ToString(),
                        Doi1 = txtDoi1.Text,
                        Doi2 = txtDoi2.Text,
                        SoThePhatDoi1 = int.Parse(txtTPDoi1.Text),
                        SoThePhatDoi2 = int.Parse(txtTPDoi2.Text),
                        SoBTDoi1 = int.Parse(txtBanThangDoi1.Text),
                        SoBTDoi2 = int.Parse(txtBanThangDoi2.Text),
                    };
                    if (BUSKQ.AddKQ(kqTD))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDSKQ();
                        Renew();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public bool Checked()
        {
            if (txtMaKQ.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã kết quả");
                txtMaKQ.Focus();
                return false;
            }
            if (cboMaTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã trận đấu");
                cboMaTD.Focus();
                return false;
            }
            if (txtTPDoi1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thẻ phạt đội 1");
                txtTPDoi1.Focus();
                return false;
            }
            if (txtTPDoi2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thẻ phạt đội 2");
                txtTPDoi2.Focus();
                return false;
            }
            if (txtBanThangDoi1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số bàn thắng đội 1");
                txtBanThangDoi1.Focus();
                return false;
            }
            if (txtBanThangDoi2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số bàn thắng đội 2");
                txtBanThangDoi2.Focus();
                return false;
            }
            return true;
        }
        public void Renew()
        {
            txtMaKQ.Enabled = true;
            txtMaKQ.Text = "";
            txtTPDoi1.Text = "";
            txtTPDoi2.Text = "";
            txtBanThangDoi1.Text = "";
            txtBanThangDoi2.Text = "";
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMaKQ.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã kết quả trận đấu!!", "Thông báo");
                    }
                    else
                    {
                        DTO_KQThiDau kqTD = new DTO_KQThiDau()
                        {
                            MaKQ = txtMaKQ.Text,
                            MaTD = cboMaTD.SelectedValue.ToString(),
                            SoThePhatDoi1 = int.Parse(txtTPDoi1.Text),
                            SoThePhatDoi2 = int.Parse(txtTPDoi2.Text),
                            SoBTDoi1 = int.Parse(txtTPDoi1.Text),
                            SoBTDoi2 = int.Parse(txtTPDoi2.Text),
                        };
                        if (BUSKQ.DeleteKQ(kqTD))// Thực hiện xóa 
                        {
                            MessageBox.Show("Xóa Thành công!", "Thông Báo");
                            LoadDSKQ();
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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaKQ.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã kết quả trận đấu!!", "Thông báo");
                }
                else
                {
                    DTO_KQThiDau kqTD = new DTO_KQThiDau()
                    {
                        MaKQ = txtMaKQ.Text,
                        MaTD = cboMaTD.SelectedValue.ToString(),
                        SoThePhatDoi1 = int.Parse(txtTPDoi1.Text),
                        SoThePhatDoi2 = int.Parse(txtTPDoi2.Text),
                        SoBTDoi1 = int.Parse(txtBanThangDoi1.Text),
                        SoBTDoi2 = int.Parse(txtBanThangDoi2.Text),
                    };
                    if (BUSKQ.UpdateKQ(kqTD))
                    {
                        MessageBox.Show("Cập nhật Thành công!", "Thông Báo");
                        LoadDSKQ();
                        Renew();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgKQTD_Click(object sender, EventArgs e)
        {
            int dong = dtgKQTD.CurrentCell.RowIndex;
            txtMaKQ.Text = dtgKQTD.Rows[dong].Cells[0].Value.ToString();
            cboMaTD.SelectedValue = dtgKQTD.Rows[dong].Cells[1].Value.ToString();
            txtDoi1.Text = dtgKQTD.Rows[dong].Cells[2].Value.ToString();
            txtDoi2.Text = dtgKQTD.Rows[dong].Cells[3].Value.ToString();
            txtTPDoi1.Text = dtgKQTD.Rows[dong].Cells[4].Value.ToString();
            txtTPDoi2.Text = dtgKQTD.Rows[dong].Cells[5].Value.ToString();
            txtBanThangDoi1.Text = dtgKQTD.Rows[dong].Cells[6].Value.ToString();
            txtBanThangDoi2.Text = dtgKQTD.Rows[dong].Cells[7].Value.ToString();
        }

        private void cboMaTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string doibong = cboMaTD.SelectedValue.ToString();

                var doiBong = BUSLTD.GetDoiBongFromMaTD(doibong);
                if (doiBong != null)
                {
                    txtDoi1.Text = doiBong.Item1;
                    txtDoi2.Text = doiBong.Item2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
