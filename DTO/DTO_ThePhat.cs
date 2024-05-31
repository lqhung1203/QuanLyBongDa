using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThePhat
    {
        private string maTD;
        private TimeSpan thoiDiem;
        private string maTP;
        private string tenTP;
        private string maDB;
        private string maCT;

        public DTO_ThePhat() { }
        public DTO_ThePhat(string maTD, TimeSpan thoiDiem, string maTP, string tenTP, string maCT, string maDB)
        {
            this.maTD = maTD;
            this.thoiDiem = thoiDiem;
            this.maTP = maTP;
            this.tenTP = tenTP;
            this.maCT = maCT;
            this.maDB = maDB;
            this.maDB = maDB;
        }

        public string MaTP { get => maTP; set => maTP = value; }
        public string TenTP { get => tenTP; set => tenTP = value; }
        public string MaCT { get => maCT; set => maCT = value; }
        public string MaDB { get => maDB; set => maDB = value; }
        public string MaTD { get => maTD; set => maTD = value; }
        public TimeSpan ThoiDiem { get => thoiDiem; set => thoiDiem = value; }
    }
}
