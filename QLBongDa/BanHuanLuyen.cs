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
    public partial class BanHuanLuyen : Form
    {
        private static BUS_BanHuanLuyen BUSBHL = new BUS_BanHuanLuyen();
        private static BUS_DoiBong BUSDB  = new BUS_DoiBong();
        private static DTO_BanHuanLuyen DTOBHL;
        public BanHuanLuyen()
        {
            InitializeComponent();
        }

        private void BanHuanLuyen_Load(object sender, EventArgs e)
        {
            LoadDSBHL();
            cboMaDB.DataSource = BUSDB.LoadDSDB();
            cboMaDB.DisplayMember = "TenDB";
            cboMaDB.ValueMember = "MaDB";
        }
        public void LoadDSBHL()
        {
            dtgThongTinHLV.DataSource = BUSBHL.LoadDSBHL();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())// Kiểm tra các trường thông tin có được nhập đầy đủ không
                {
                    DTOBHL = new DTO_BanHuanLuyen()
                    {
                        MaBHL = txtMaHLV.Text,
                        TenBHL = txtTenHLV.Text,
                        ChucVu = txtChucVu.Text,
                        MaDB = cboMaDB.SelectedValue.ToString(),
                    };
                    if (BUSBHL.AddBHL(DTOBHL)) // Thực hiện thêm vào cơ sở dữ liệu
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDSBHL(); //LoadDS dùng để tải danh sách 
                        Renew();// Làm mới các trường nhập liệu
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Checked()
        {
            if (txtMaHLV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã HVL!", "Thông báo");
                txtMaHLV.Focus();
                return false;
            }
            if (txtTenHLV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên HLV!", "Thông báo");
                txtTenHLV.Focus();
                return false;
            }
            if (txtChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chức vụ HVL!", "Thông báo");
                txtChucVu.Focus();
                return false;
            }
            return true;
        }
        public void Renew()
        {
            txtMaHLV.Enabled = true;
            txtMaHLV.Focus();
            txtMaHLV.Text = "";
            txtTenHLV.Text = "";
            txtChucVu.Text = "";
            cboMaDB.SelectedIndex = -1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DTOBHL = new DTO_BanHuanLuyen()
                    {

                        MaBHL = txtMaHLV.Text,
                        TenBHL = txtTenHLV.Text,
                        ChucVu = txtChucVu.Text,
                        MaDB = cboMaDB.SelectedValue.ToString()
                    };
                    if (BUSBHL.DeleteBHL(DTOBHL))// Thực hiện xóa  khỏi cơ sở dữ liệu
                    {
                        MessageBox.Show("Xóa Thành công!", "Thông Báo");
                        LoadDSBHL();
                        Renew();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTOBHL = new DTO_BanHuanLuyen()
                {
                    MaBHL = txtMaHLV.Text,
                    TenBHL = txtTenHLV.Text,
                    ChucVu = txtChucVu.Text,
                    MaDB = cboMaDB.SelectedValue.ToString()
                };
                if (Checked()) // Kiểm tra các trường thông tin có được nhập đầy đủ không
                {
                    if (BUSBHL.UpdateBHL(DTOBHL))// Thực hiện cập nhật thông tin
                    {
                        MessageBox.Show("Cập nhật Thành công!", "Thông Báo");
                        LoadDSBHL();
                        Renew();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgThongTinHLV_Click(object sender, EventArgs e)
        {
            txtMaHLV.Enabled = false;
            int dong = dtgThongTinHLV.CurrentCell.RowIndex;
            txtMaHLV.Text = dtgThongTinHLV.Rows[dong].Cells[0].Value.ToString();
            txtTenHLV.Text = dtgThongTinHLV.Rows[dong].Cells[1].Value.ToString();
            txtChucVu.Text = dtgThongTinHLV.Rows[dong].Cells[2].Value.ToString();
            string MaDB = dtgThongTinHLV.Rows[dong].Cells[3].Value.ToString();

            // Thiết lập giá trị cho ComboBox dựa trên MaDB
            cboMaDB.SelectedValue = MaDB;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
