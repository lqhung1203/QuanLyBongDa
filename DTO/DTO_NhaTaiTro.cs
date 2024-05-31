using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaTaiTro
    {
        private string tenNTT;
        private int sDT;
        private string maNTT;
        public DTO_NhaTaiTro() { }
        public DTO_NhaTaiTro(string tenNTT, int sDT, string maNTT)
        {
            this.tenNTT = tenNTT;
            this.sDT = sDT;
            this.maNTT = maNTT;
        }
        public string MaNTT { get => maNTT; set => maNTT = value; }
        public string TenNTT { get => tenNTT; set => tenNTT = value; }
        public int SDT { get => sDT; set => sDT = value; }
    }
}
