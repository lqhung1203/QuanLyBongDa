using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThePhat
    {
        DAL_ThePhat DALTP = new DAL_ThePhat();
        public IQueryable LoadDSTP()
        {
            return DALTP.LoadDS();
        }
        public bool AddTP(DTO_ThePhat tp)
        {
            return DALTP.ThemTP(tp);
        }
        public bool UpdateTP(DTO_ThePhat tp)
        {
            return DALTP.CapNhatTP(tp);
        }
        public bool DeleteTP(DTO_ThePhat tp)
        {
            return DALTP.XoaTP(tp);
        }
        public IQueryable LoadDSMaCT(string maTD)
        {
            return DALTP.LoadDSMaCT(maTD);
        }
        public IQueryable LoadDMaDB(string maTD)
        {
            return DALTP.LoadDMaDB(maTD);
        }
        public IQueryable LoadDMaCTT(string maDB)
        {
            return DALTP.LoadDMaCTT(maDB);
        }
    }
}
