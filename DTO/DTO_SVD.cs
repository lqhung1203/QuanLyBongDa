using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SVD
    {
        private string maSan, tenSan, diaChi;
        private int sucChua;

        public DTO_SVD(string maSan, string tenSan, string diaChi, int sucChua)
        {
            MaSan = maSan;
            TenSan = tenSan;
            DiaChi = diaChi;
            SucChua = sucChua;
        }
        public string MaSan
        {
            get => maSan;

            set => maSan = value;
        }
        public string TenSan
        {
            get => tenSan;

            set => tenSan = value;
        }
        public string DiaChi
        {
            get => diaChi;

            set => diaChi = value;
        }
        public int SucChua
        {
            get => sucChua;

            set => sucChua = value;
        }
    }
}
