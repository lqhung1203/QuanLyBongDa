using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LichThiDau
    {
        public string doi2;
        public TimeSpan gioTD;
        public string maTD;
        public string maTT;
        public string maDB;
        public string doi1;
        public DateTime ngayThiDau;
        public string maSVD;

        public DTO_LichThiDau() { }
        public DTO_LichThiDau(string doi2, TimeSpan gioTD, string maTD, string maTT, string maDB, string doi1, DateTime ngayThiDau, string maSVD)
        {
            this.doi2 = doi2;
            this.gioTD = gioTD;
            this.maTD = maTD;
            this.maTT = maTT;
            this.maDB = maDB;
            this.doi1 = doi1;
            this.ngayThiDau = ngayThiDau;
            this.maSVD = maSVD;
        }

        public string Doi2 { get => doi2; set => doi2 = value; }
        public TimeSpan GioTD { get => gioTD; set => gioTD = value; }
        public string MaTD { get => maTD; set => maTD = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public string MaDB { get => maDB; set => maDB = value; }
        public string Doi1 { get => doi1; set => doi1 = value; }
        public DateTime NgayThiDau { get => ngayThiDau; set => ngayThiDau = value; }
        public string MaSVD { get => maSVD; set => maSVD = value; }
    }
}
