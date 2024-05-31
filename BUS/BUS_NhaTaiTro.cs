using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaTaiTro
    {
        DAL_NhaTaiTro DALNTT = new DAL_NhaTaiTro();
        // Phương thức LoadDSNTT dùng để tải danh sách các nhà tài trợ từ cơ sở dữ liệu.
        public IQueryable LoadDSNTT()
        {
            return DALNTT.LoadDS();
        }
        // Phương thức AddNTT dùng để thêm một nhà tài trợ mới vào cơ sở dữ liệu.
        public bool AddNTT(DTO_NhaTaiTro ntt)
        {
            return DALNTT.ThemNTT(ntt);
        }
        // Phương thức UpdateNTT dùng để cập nhật thông tin của một nhà tài trợ trong cơ sở dữ liệu.
        public bool UpdateNTT(DTO_NhaTaiTro ntt)
        {
            return DALNTT.CapnhatNTT(ntt);
        }
        // Phương thức DeleteNTT dùng để xóa một nhà tài trợ khỏi cơ sở dữ liệu.
        public bool DeleteNTT(DTO_NhaTaiTro ntt)
        {
            return DALNTT.XoaNTT(ntt);
        }
        // Phương thức SearchNTT dùng để tìm kiếm các nhà tài trợ theo mã
        public IQueryable SearchNTT(string timkiem)
        {
            return DALNTT.Search(timkiem);
        }
    }
}
