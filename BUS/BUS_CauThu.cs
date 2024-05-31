using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CauThu
    {

        //Properties
        DAL_CauThu ct = new DAL_CauThu();

        //Methods

        //Lay Danh Sach Cau Thu
        public IQueryable LayDS()
        {
            return ct.LayDS();
        }

        //Them Cau Thu
        public bool ThemCauThu(DTO_Cauthu cauThu)
        {
            return ct.ThemCT(cauThu);
        }

        //Sua cau Thu
        public bool SuaCauThu(DTO_Cauthu cauThu)
        {
            return ct.SuaCT(cauThu);
        }

        //Xoa cau Thu
        public bool XoaCauThu(string cauThu)
        {
            return ct.XoaCT(cauThu);
        }
    }
}
