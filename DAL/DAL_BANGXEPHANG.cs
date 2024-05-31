using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BANGXEPHANG
    {
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();


        public IQueryable LayDS()
        {
            IQueryable bxh = from ds in db.Tbl_BXHs
                             select new
                             {
                                 MaDB = ds.MaDB,
                                 SoTranThang = ds.SoTranThang,
                                 SoTranHoa = ds.SoTranHoa,
                                 SoTranThua = ds.SoTranThua,
                                 SoBanThang = ds.SoBanThang,
                                 SoBanThua = ds.SoBanThua,
                                 Diem = ds.Diem,
                             };
            return bxh;
        }
    }
}




