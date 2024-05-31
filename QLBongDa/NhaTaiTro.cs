using BUS;
using DTO;
using QLBongDa.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDa
{
    public partial class NhaTaiTro : Form
    {
        public NhaTaiTro()
        {
            InitializeComponent();
        }
        private static BUS_NhaTaiTro BUSNTT = new BUS_NhaTaiTro();
        private static DTO_NhaTaiTro DTONTT;
        //Load dữ liệu nhà tài trợ lên Form data
        private void NhaTaiTro_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
        public void LoadDS()
        {
            dtgThongTinNTT.DataSource = BUSNTT.LoadDSNTT();
        }
        //Thêm nhà tài trợ
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {       
                if (Checked())
                {
                    DTONTT = new DTO_NhaTaiTro
                    {
                        MaNTT = txtMaNTT.Text,
                        TenNTT = txtTenNTT.Text,
                        SDT = int.Parse(txtSDT.Text)
                    };
                    if (BUSNTT.AddNTT(DTONTT))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
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
        //Kiểm tra xem các trường đã nhập chưa
        public bool Checked()
        {
            if (txtMaNTT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Nhà tài trợ!!", "Thông báo");
                txtMaNTT.Focus();
                return false;
            }
            if (txtTenNTT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài trợ!!", "Thông báo");
                txtTenNTT.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SDT!!", "Thông báo");
                txtSDT.Focus();
                return false;
            }
            // Kiểm tra xem SDT có chứa ký tự không phải số hay không
            foreach (char c in txtSDT.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại phải là số nguyên!", "Thông báo");
                    txtSDT.Focus();
                    return false;
                }
            }
            return true;
        }    
        //Làm mới các trường 
        public void Renew()
        {
            //Mở textbox lại
            txtMaNTT.Enabled = true; 
            //Khi mà bấm renew các textbox sẽ rỗng và chỉ vào textbox MaNTT
            txtMaNTT.Focus();
            txtMaNTT.Text = "";
            txtTenNTT.Text = "";
            txtSDT.Text = "";
;       }
        //Button làm mới lại các trường
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Renew();
        }
        //Button Xóa các NTT
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Hỏi trước khi xóa, Nếu Yes Mã NTT đó sẽ được xóa, Ngược lại thì sẽ không xóa
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Kiểm tra nếu mã NTt rỗng thì thông báo nhập mã NTT
                    if (txtMaNTT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã Nhà tài trợ!!", "Thông báo");
                    }
                    else
                    {
                        DTONTT = new DTO_NhaTaiTro
                        {
                            MaNTT = txtMaNTT.Text,
                            TenNTT = txtTenNTT.Text,
                            SDT = int.Parse(txtSDT.Text)
                        };
                        if (BUSNTT.DeleteNTT(DTONTT))
                        {
                            MessageBox.Show("Xóa Thành công!", "Thông Báo");
                            LoadDS();
                            Renew();
                        }
                    }
                }
            }
            //Bắt lỗi và thông báo ra ngoài
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Button Cập nhật
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checked())
                {
                    DTONTT = new DTO_NhaTaiTro
                    {
                        MaNTT = txtMaNTT.Text,
                        TenNTT = txtTenNTT.Text,
                        SDT = int.Parse(txtSDT.Text)
                    };
                    if (BUSNTT.UpdateNTT(DTONTT))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Thông báo trước khi thoát nếu YES sẽ thoát khỏi form ngược thì không
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Đưa dữ liệu dưới dtg lên các trường
        private void dtgThongTinNTT_Click(object sender, EventArgs e)
        {
            txtMaNTT.Enabled = false;
            int dong = dtgThongTinNTT.CurrentCell.RowIndex;
            txtMaNTT.Text = dtgThongTinNTT.Rows[dong].Cells[0].Value.ToString();
            txtTenNTT.Text = dtgThongTinNTT.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = dtgThongTinNTT.Rows[dong].Cells[2].Value.ToString();
        }
        //Tìm kiếm Nhà tài trợ theo mã NTT
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu txtTimKiem rỗng thì Load dữ liệu trong database lên
                if (txtTimKiem.Text == "")
                {
                    LoadDS();
                    txtTimKiem.Focus();
                }
                else
                {
                    dtgThongTinNTT.DataSource = BUSNTT.SearchNTT(txtTimKiem.Text);
                    MessageBox.Show($"Tìm thành công", "Thông báo");
                    Renew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatDSNTT_Click(object sender, EventArgs e)
        {
            RpNTTDB rp = new RpNTTDB();
            rp.ShowDialog();
        }
    }
}
