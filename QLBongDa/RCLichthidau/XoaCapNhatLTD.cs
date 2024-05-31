using BUS;
using BUSS;
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

namespace QLBongDa.RCLichthidau
{
    public partial class XoaCapNhatLTD : Form
    {
        public XoaCapNhatLTD()
        {
            InitializeComponent();
        }
        private static BUS_LichThiDau BUSLTD = new BUS_LichThiDau();
        private static BUS_DoiBong BUSDB = new BUS_DoiBong();
        private static BUS_SVD BUSSVD = new BUS_SVD();
        private static BUS_TongTai BUSTT = new BUS_TongTai();
        private void LoadDSDoiBong()
        {
            try
            {
                // Gán danh sách đội bóng vào combobox cho đội 1 và đội 2
                txtMaTD.Enabled = false;
                dtgTTLichThiDau.DataSource = BUSLTD.LoadDSTD();
                cboMaSVD.DataSource = BUSSVD.LayDS();
                cboMaSVD.DisplayMember = "TenSVD";
                cboMaSVD.ValueMember = "MaSVD";

                cboMaTT.DataSource = BUSTT.LayDS();
                cboMaTT.DisplayMember = "TenTT";
                cboMaTT.ValueMember = "MaTT";

                cboDoi1.DataSource = BUSDB.LoadDSDB();
                cboDoi1.DisplayMember = "TenDB";
                cboDoi1.ValueMember = "MaDB";

                cboDoi2.DataSource = BUSDB.LoadDSDB();
                cboDoi2.DisplayMember = "TenDB";
                cboDoi2.ValueMember = "MaDB";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách đội bóng: " + ex.Message);
            }
        }
        private void dtgTTLichThiDau_Click(object sender, EventArgs e)
        {
            txtMaTD.Enabled = false;
            int dong = dtgTTLichThiDau.CurrentCell.RowIndex;
            txtMaTD.Text = dtgTTLichThiDau.Rows[dong].Cells[0].Value.ToString();
            string MaSVD = dtgTTLichThiDau.Rows[dong].Cells[1].Value.ToString();
            cboMaSVD.SelectedValue = MaSVD;
            string MaTT = dtgTTLichThiDau.Rows[dong].Cells[2].Value.ToString();
            cboMaTT.SelectedValue = MaTT;
            string Doi1 = dtgTTLichThiDau.Rows[dong].Cells[3].Value.ToString();
            cboDoi1.SelectedValue = Doi1;
            string Doi2 = dtgTTLichThiDau.Rows[dong].Cells[4].Value.ToString();
            cboDoi2.SelectedValue = Doi2;
            dtfNgayTD.Text = dtgTTLichThiDau.Rows[dong].Cells[5].Value.ToString();
            dtfGioTD.Text = dtgTTLichThiDau.Rows[dong].Cells[6].Value.ToString();
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
        public void Renew()
        {
            txtMaTD.Text = "";
            txtMaTD.Focus();
        }
        private void XoaLTD_Load(object sender, EventArgs e)
        {
            LoadDSDoiBong();  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMaTD.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã trận đấu!!", "Thông báo");
                    }
                    else
                    {
                        DTO_LichThiDau LichThiDauDTO = new DTO_LichThiDau()
                        {
                            MaTD = txtMaTD.Text,
                            MaSVD = cboMaSVD.SelectedValue.ToString(),
                            MaTT = cboMaTT.SelectedValue.ToString(),
                            Doi1 = cboDoi1.SelectedValue.ToString(),
                            Doi2 = cboDoi2.SelectedValue.ToString(),
                            NgayThiDau = dtfNgayTD.Value.Date,
                            GioTD = dtfGioTD.Value.TimeOfDay,
                        };
                        if (BUSLTD.DeleteLTD(LichThiDauDTO))// Thực hiện xóa 
                        {
                            MessageBox.Show("Xóa Thành công!", "Thông Báo");
                            LoadDSDoiBong();
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
                if (txtMaTD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã trận đấu!!", "Thông báo");
                    txtMaTD.Focus();
                }
                else
                {
                    DTO_LichThiDau LichThiDauDTO = new DTO_LichThiDau()
                    {
                        MaTD = txtMaTD.Text,
                        MaSVD = cboMaSVD.SelectedValue.ToString(),
                        MaTT = cboMaTT.SelectedValue.ToString(),
                        Doi1 = cboDoi1.SelectedValue.ToString(),
                        Doi2 = cboDoi2.SelectedValue.ToString(),
                        NgayThiDau = dtfNgayTD.Value.Date,
                        GioTD = dtfGioTD.Value.TimeOfDay,
                    };
                    if (BUSLTD.UpdateLTD(LichThiDauDTO))
                    {
                        MessageBox.Show("Cập nhật Thành công!", "Thông Báo");
                        LoadDSDoiBong();
                        Renew();
                    }
                    
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
