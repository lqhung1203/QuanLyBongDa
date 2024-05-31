using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KQThiDau
    {
        DAL_KQThiDau DALKQTD = new DAL_KQThiDau();
        public IQueryable LoadDSKQTD() 
        {
            return DALKQTD.LoadDSKQ();
        }
        public bool AddKQ(DTO_KQThiDau KQTD)
        {
            return DALKQTD.ThemKQ(KQTD);
        }
        public bool UpdateKQ(DTO_KQThiDau KQTD)
        {
            return DALKQTD.CapnhatKQ(KQTD);
        }
        public bool DeleteKQ(DTO_KQThiDau KQTD)
        {
            return DALKQTD.XoaKQ(KQTD);
        }
    }
}
