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
    public partial class ThemLichThiDau : Form
    {
        public ThemLichThiDau()
        {
            InitializeComponent();
        }
        private static BUS_LichThiDau BUSLTD = new BUS_LichThiDau();
        private static BUS_DoiBong BUSDB = new BUS_DoiBong();
        private static BUS_SVD BUSSVD = new BUS_SVD();
        private static BUS_TongTai BUSTT = new BUS_TongTai();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị một hộp thoại thông báo để xác nhận việc thoát
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form hiện tại
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {

                    // Tạo đối tượng DTO từ các giá trị nhập từ form
                    DTO_LichThiDau lichThiDauDTO = new DTO_LichThiDau
                    {
                        MaTD = txtMaTD.Text,
                        MaSVD = cboMaSVD.SelectedValue.ToString(),
                        MaTT = cboMaTT.SelectedValue.ToString(),
                        Doi1 = cboDoi1.SelectedValue.ToString(),
                        Doi2 = cboDoi2.SelectedValue.ToString(),
                        NgayThiDau = dtfNgayTD.Value.Date,
                        GioTD = dtfGioTD.Value.TimeOfDay,
                    };

                    // Gọi phương thức ThêmLichThiDau từ BUS để thêm lịch thi đấu
                    if (BUSLTD.AddLTD(lichThiDauDTO))
                    {
                        MessageBox.Show("Thêm lịch thi đấu thành công.");
                        LoadDSDoiBong();
                        Renew();
                    }
                    else
                    {
                        MessageBox.Show("Thêm lịch thi đấu thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ThemLichThiDau_Load(object sender, EventArgs e)
        {
            LoadDSDoiBong();    
        }
        public bool Checked()
        {
            if (txtMaTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã trận đấu");
                txtMaTD.Focus();
                return false;
            }
            return true;
        }
        public void Renew()
        {
            txtMaTD.Text = "";
            txtMaTD.Focus();
            txtMaTD.Enabled = true;
        }
        private void LoadDSDoiBong()
        {
            try
            {
                dtgTTLichThiDau.DataSource = BUSLTD.LoadDSTD();
                // Gán danh sách đội bóng vào combobox cho đội 1 và đội 2
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void btnXoaCapNhat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XoaCapNhatLTD());
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
    }
}
