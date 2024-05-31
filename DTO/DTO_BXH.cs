using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BXH
    {
        private string maDB, maKQ;
        private int soTranThang, soTranThua, soTranHoa, soBanThang, soBanThua, Diem;

        public DTO_BXH()
        {

        }
        public DTO_BXH(string maDB, string maKQ, int soTranThang, int soTranThua, int soTranHoa, int soBanThang, int soBanThua, int diem)
        {
            MaDB = maDB;
            MaKQ = maKQ;
            SoTranThang = soTranThang;
            SoTranThua = soTranThua;
            SoTranHoa = soTranHoa;
            SoBanThang = soBanThang;
            SoBanThua = soBanThua;
            Diem = diem;
        }
        public string MaDB
        {
            get => maDB;

            set => maDB = value;
        }
        public string MaKQ
        {
            get => maKQ;

            set => maKQ = value;
        }
        public int SoTranThang
        {
            get => soTranThang;

            set => soTranThang = value;
        }
        public int SoTranThua
        {
            get => soTranThua;

            set => soTranThua = value;
        }
        public int SoTranHoa
        {
            get => soTranHoa;

            set => soTranHoa = value;
        }
        public int SoBanThang
        {
            get => soBanThang;

            set => soBanThang = value;
        }
        public int SoBanThua
        {
            get => soBanThua;

            set => soBanThua = value;
        }
        public int Diem1
        {
            get => Diem;

            set => Diem = value;
        }
    }
}
