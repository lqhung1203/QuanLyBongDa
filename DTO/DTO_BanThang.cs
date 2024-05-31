using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BanThang
    {
        public string maBT, maCT, loaiBT, maTD, maDB;
        public TimeSpan thoiDiem;

        public DTO_BanThang() { }
        public DTO_BanThang(string maBT, string maCT, string loaiBT, string maTD, string maDB, TimeSpan thoiDiem)
        {
            this.maBT = maBT;
            this.maCT = maCT;
            this.loaiBT = loaiBT;
            this.maTD = maTD;
            this.thoiDiem = thoiDiem;
            this.maDB = maDB;
        }

        public string MaBT { get => maBT; set => maBT = value; }
        public string MaDB { get => maDB; set => maDB = value; }
        public string MaCT { get => maCT; set => maCT = value; }
        public string LoaiBT { get => loaiBT; set => loaiBT = value; }
        public string MaTD { get => maTD; set => maTD = value; }
        public TimeSpan ThoiDiem { get => thoiDiem; set => thoiDiem = value; }
    }
}
