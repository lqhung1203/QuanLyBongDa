using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DoiBong
    {
        DAL_DoiBong DALDB = new DAL_DoiBong();
        // Phương thức LoadDSDB dùng để tải danh sách các đội bóng từ cơ sở dữ liệu.
        public IQueryable LoadDSDB()
        {
            return DALDB.Load();
        }
        // Phương thức AddDB dùng để thêm một đội bóng mới vào cơ sở dữ liệu.
        public bool AddDB(DTO_DoiBong db)
        {
            return DALDB.ThemDB(db);
        }
        // Phương thức UpdateDB dùng để cập nhật thông tin của một đội bóng trong cơ sở dữ liệu.
        public bool UpdateDB(DTO_DoiBong db)
        {
            return DALDB.CapnhatDB(db);
        }
        // Phương thức DeleteDB dùng để xóa một đội bóng khỏi cơ sở dữ liệu.
        public bool DeleteDB(DTO_DoiBong db)
        {
            return DALDB.XoaDB(db);
        }
        // Phương thức SearchTenDB dùng để tìm kiếm các đội bóng dựa trên tên gần giống với chuỗi tìm kiếm.
        public IQueryable SearchTenDB(string timkiem) 
        { 
            return DALDB.SearchDB(timkiem);
        }
    }
}
