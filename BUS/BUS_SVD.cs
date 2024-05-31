using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUSS
{
    public class BUS_SVD
    {
        //Properties
        private DAL_SVD svd = new DAL_SVD();

        //Methods

        //layDS SVD

        public IQueryable LayDS()
        {
            return svd.LayDS();
        }
        //Them SVD
        public bool ThemSVD(DTO_SVD sVD)
        {
            return svd.ThemSVD(sVD);
        }
        //Sua SVD
        public bool SuaSVD(DTO_SVD sVD)
        {
            return svd.SuaSVD(sVD);
        }
        //Xoa SVD
        public bool XoaSVD(string sVD)
        {
            return svd.XoaSVD(sVD);
        }
    }
}
