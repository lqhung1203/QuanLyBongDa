using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BanHuanLuyen
    {
        DAL_BanHuanLuyen DALBHL = new DAL_BanHuanLuyen();
        public IQueryable LoadDSBHL()
        {
            return DALBHL.Load();
        }
        public bool AddBHL(DTO_BanHuanLuyen hl)
        {
            return DALBHL.ThemBHL(hl);
        }
        public bool DeleteBHL(DTO_BanHuanLuyen hl)
        {
            return DALBHL.XoaBHL(hl);
        }
        public bool UpdateBHL(DTO_BanHuanLuyen hl)
        {
            return DALBHL.CapnhatBHL(hl);
        }
    }
}
