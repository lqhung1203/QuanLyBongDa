using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUSS
{
    public class BUS_TongTai
    {
        //Properties
        private DAL_TrongTai trongtai = new DAL_TrongTai();

        //Methods

        //LayDS Trong Tai
        public IQueryable LayDS()
        {
            return trongtai.LayDS();
        }

        //Them TT
        public bool ThemTT(DTO_TrongTai tT)
        {
            return trongtai.ThemTT(tT);
        }

        //Sua TT
        public bool SuaTT(DTO_TrongTai tT)
        {
            return trongtai.SuaTT(tT);
        }

        //Xoa TT
        public bool XoaTT(string tT)
        {
            return trongtai.XoaTT(tT);
        }
    }
}
