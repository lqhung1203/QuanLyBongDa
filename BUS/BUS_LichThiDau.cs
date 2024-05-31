using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LichThiDau
    {
        private static DAL_LichThiDau DALLTD = new DAL_LichThiDau();
        public IQueryable LoadDSTD()
        {
            return DALLTD.LoadDS();
        }
        public bool AddLTD(DTO_LichThiDau ltd)
        {
            return DALLTD.ThemLichThiDau(ltd);
        }
        public bool DeleteLTD(DTO_LichThiDau ltd)
        {
            return DALLTD.XoaLichThiDau(ltd);
        }
        public bool UpdateLTD(DTO_LichThiDau ltd)
        {
            return DALLTD.CapnhatLichThiDau(ltd);
        }
        public IQueryable LoadDSMaTD()
        {
            return DALLTD.LoadMaTD();
        }
        public IQueryable<Tbl_LICHTHIDAU> LoadDSMaDB(string doibong)
        {
            return DALLTD.LoadDSMaDB(doibong);
        }
        public Tuple<string, string> GetDoiBongFromMaTD(string doibong)
        {
            var lichThiDau = LoadDSMaDB(doibong).FirstOrDefault();
            if (lichThiDau != null)
            {
                return new Tuple<string, string>(lichThiDau.Doi1, lichThiDau.Doi2);
            }
            return null;
        }
    }
}
