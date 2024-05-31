using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BanThang
    {
        //Properties
        DAL_BanThang banthang = new DAL_BanThang();

        //Methods

        //Lay Danh Sach Ban Thang
        public IQueryable LayDS()
        {
            return banthang.LayDS();
        }
        //Them Ban Thang
        public bool ThemBT(DTO_BanThang banThang)
        {
            return banthang.ThemBT(banThang);
        }
        //Sua Ban Thang
        public bool SuaBT(DTO_BanThang banThang)
        {
            return banthang.SuaBT(banThang);
        }
        //Xoa Ban Thang
        public bool XoaBT(string banThang)
        {
            return banthang.XoaBT(banThang);
        }
        public IQueryable LoadDSMaCT(string maTD)
        {
            return banthang.LoadDSMaCT(maTD);
        }
        public IQueryable LoadDMaDB(string maTD)
        {
            return banthang.LoadDMaDB(maTD);
        }
        public IQueryable LoadDMaCTT(string maDB)
        {
            return banthang.LoadDMaCTT(maDB);
        }
    }
}
