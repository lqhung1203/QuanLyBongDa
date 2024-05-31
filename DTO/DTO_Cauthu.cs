using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Cauthu
    {
        public string maCT, tenCT, viTri, maDB;
        public int soAo;

        public DTO_Cauthu() { }
        public DTO_Cauthu(string maCT, string tenCT, string viTri, string maDB, int soAo)
        {
            this.maCT = maCT;
            this.tenCT = tenCT;
            this.viTri = viTri;
            this.maDB = maDB;
            this.soAo = soAo;
        }

        public string MaCT { get => maCT; set => maCT = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public string MaDB { get => maDB; set => maDB = value; }
        public int SoAo { get => soAo; set => soAo = value; }
    }
}
