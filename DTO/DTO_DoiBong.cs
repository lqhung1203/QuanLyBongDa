using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoiBong
    {
        private string maNTT;
        private string maDB;
        private string tenDB;
        private string diaChi;

        public DTO_DoiBong() { }

        public DTO_DoiBong(string maNTT, string maDB, string tenDB, string diaChi)
        {
            this.maNTT = maNTT;
            this.maDB = maDB;
            this.tenDB = tenDB;
            this.diaChi = diaChi;
        }

        public string MaDB { get => maDB; set => maDB = value; }
        public string TenDB { get => tenDB; set => tenDB = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaNTT { get => maNTT; set => maNTT = value; }
    }
}
