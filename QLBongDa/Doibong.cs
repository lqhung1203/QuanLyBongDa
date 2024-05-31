using BUS;
using DTO;
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
    public partial class Doibong : Form
    {
        public Doibong()
        {
            InitializeComponent();
        }
        // Khởi tạo đối tượng BUS_DoiBong
        private static BUS_DoiBong BUSDB = new BUS_DoiBong();
        // Khởi tạo đối tượng BUS_NhaTaiTro
        private static BUS_NhaTaiTro BUSNTT = new BUS_NhaTaiTro();
        private static DTO_DoiBong DTODB;
        // Phương thức LoadDS dùng để tải danh sách đội bóng
        public void LoadDS()
        {
            dtgThongTinDB.DataSource = BUSDB.LoadDSDB();
            cboMaNTT.DataSource = BUSNTT.LoadDSNTT();
            cboMaNTT.DisplayMember = "TenNTT";
            cboMaNTT.ValueMember = "MaNTT";
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
                    DTODB = new DTO_DoiBong()
                    {
                        MaDB = txtMaDB.Text,
                        TenDB = txtTenDB.Text,
                        DiaChi = txtDiaChi.Text,
                        MaNTT = cboMaNTT.SelectedValue.ToString(),
                    };
                    if (BUSDB.AddDB(DTODB)) // Thực hiện thêm đội bóng vào cơ sở dữ liệu
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadDS(); //LoadDS dùng để tải danh sách đội bóng
                        Renew();// Làm mới các trường nhập liệu
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xử lý sự kiện Load của Form
        private void Doibong_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
        // Kiểm tra các trường thông tin có được nhập đầy đủ không
        public bool Checked()
        {
            if (txtMaDB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đội bóng!", "Thông báo");
                txtMaDB.Focus();
                return false;
            }
            if (txtTenDB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đội bóng!", "Thông báo");
                txtTenDB.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đội bóng!", "Thông báo");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        // Làm mới các trường nhập liệu
        public void Renew()
        {
            txtMaDB.Enabled = true;
            txtMaDB.Focus();
            txtMaDB.Text = "";
            txtTenDB.Text = "";
            txtDiaChi.Text = "";
            cboMaNTT.SelectedIndex = -1;
        }
        // Xử lý sự kiện click nút "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Renew();
        }
        // Xử lý sự kiện click nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMaDB.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã đội bóng!!", "Thông báo");
                    }
                    else
                    {
                        DTODB = new DTO_DoiBong()
                        {
                            MaDB = txtMaDB.Text,
                            TenDB = txtTenDB.Text,
                            DiaChi = txtDiaChi.Text,
                            MaNTT = cboMaNTT.Text,
                        };
                        if (BUSDB.DeleteDB(DTODB))// Thực hiện xóa đội bóng khỏi cơ sở dữ liệu
                        {
                            MessageBox.Show("Xóa Thành công!", "Thông Báo");
                            LoadDS();
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
        // Xử lý sự kiện click nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTODB = new DTO_DoiBong()
                {
                    MaDB = txtMaDB.Text,
                    TenDB = txtTenDB.Text,
                    DiaChi = txtDiaChi.Text,
                    MaNTT = cboMaNTT.SelectedValue.ToString(),
                };
                if (Checked()) // Kiểm tra các trường thông tin có được nhập đầy đủ không
                { 
                    if (BUSDB.UpdateDB(DTODB))// Thực hiện cập nhật thông tin đội bóng trong cơ sở dữ liệu
                    {
                        MessageBox.Show("Cập nhật Thành công!", "Thông Báo");
                        LoadDS();
                        Renew();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xử lý sự kiện click nút "Tìm kiếm"
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    LoadDS();
                    txtTimKiem.Focus();
                }
                else
                {
                   dtgThongTinDB.DataSource = BUSDB.SearchTenDB(txtTimKiem.Text);
                    MessageBox.Show($"Tìm thành công", "Thông báo");
                    Renew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgThongTinDB_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaDB.Enabled = false;
                int dong = dtgThongTinDB.CurrentCell.RowIndex;
                txtMaDB.Text = dtgThongTinDB.Rows[dong].Cells[0].Value.ToString();
                txtTenDB.Text = dtgThongTinDB.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dtgThongTinDB.Rows[dong].Cells[2].Value.ToString();

                string maNTT = dtgThongTinDB.Rows[dong].Cells[3].Value.ToString();

                // Thiết lập giá trị cho ComboBox dựa trên MaNTT
                cboMaNTT.SelectedValue = maNTT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void Sanvandong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SVD());
        }

        private void Nhataitro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaTaiTro());
        }

        private void Huanluyenvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanHuanLuyen());
        }

        private void Thephat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThePhat());
        }

        private void Banthang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanThang());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaDB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đội bóng để in cầu thủ!!!", "Thông báo");
            }
            else
            {
                CauthutrongDoibong f = new CauthutrongDoibong(Convert.ToString(txtMaDB.Text));
                f.ShowDialog();
            }    
        }

        private void tạoKếtQuảTrậnĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KetQuaThiDau());
        }

        private void trọngTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Trongtai()); 
        }

        private void top5CầuThủXuấtSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TopBanThang());
        }
    }
}
