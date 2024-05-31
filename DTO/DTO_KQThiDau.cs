using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KQThiDau
    {
        public string MaKQ, MaTD, Doi1, Doi2;
        private int soBTDoi2;
        private int soThePhatDoi1;
        private int soThePhatDoi2;
        private int soBTDoi1;

        public DTO_KQThiDau() { }
        public DTO_KQThiDau(string maKQ, string maTD, string doi1, string doi2, int soBTDoi2, int soThePhatDoi1, int soThePhatDoi2, int soBTDoi1)
        {
            MaKQ = maKQ;
            MaTD = maTD;
            Doi1 = doi1;
            Doi2 = doi2;
            this.soBTDoi2 = soBTDoi2;
            this.soThePhatDoi1 = soThePhatDoi1;
            this.soThePhatDoi2 = soThePhatDoi2;
            this.soBTDoi1 = soBTDoi1;
        }

        public int SoThePhatDoi1 { get => soThePhatDoi1; set => soThePhatDoi1 = value; }
        public int SoThePhatDoi2 { get => soThePhatDoi2; set => soThePhatDoi2 = value; }
        public int SoBTDoi1 { get => soBTDoi1; set => soBTDoi1 = value; }
        public int SoBTDoi2 { get => soBTDoi2; set => soBTDoi2 = value; }
    }
}
