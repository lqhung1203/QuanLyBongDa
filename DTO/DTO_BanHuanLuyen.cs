using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BanHuanLuyen
    {
        private string maDB;
        private string maBHL;
        private string tenBHL;
        private string chucVu;
        public DTO_BanHuanLuyen() { }
        public DTO_BanHuanLuyen(string maDB, string maBHL, string tenBHL, string chucVu)
        {
            this.maDB = maDB;
            this.maBHL = maBHL;
            this.tenBHL = tenBHL;
            this.chucVu = chucVu;
        }

        public string MaBHL { get => maBHL; set => maBHL = value; }
        public string TenBHL { get => tenBHL; set => tenBHL = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string MaDB { get => maDB; set => maDB = value; }
    }
}
