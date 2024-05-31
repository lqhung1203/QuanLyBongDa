using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TrongTai
    {
        private string maTT, tenTT, quocTich;
        private DateTime ngaySinh;

        public DTO_TrongTai(string maTT, string tenTT, DateTime ngaySinh, string quocTich)
        {
            MaTT = maTT;
            TenTT = tenTT;
            NgaySinh = ngaySinh;
            QuocTich = quocTich;
        }
        public string MaTT
        {
            get => maTT;

            set => maTT = value;
        }
        public string TenTT
        {
            get => tenTT;

            set => tenTT = value;
        }
        public DateTime NgaySinh
        {
            get => ngaySinh;

            set => ngaySinh = value;
        }
        public string QuocTich
        {
            get => quocTich;

            set => quocTich = value;
        }
    }
}
