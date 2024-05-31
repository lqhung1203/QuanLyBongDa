using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TrongTai
    {
        //Properties
        private static DataQLBongDaDataContext db = new DataQLBongDaDataContext();

        //Methods
        //Lay DS trong tai

        public IQueryable LayDS()
        {
            IQueryable ds = from tt in db.Tbl_TRONGTAIs
                            select new
                            {
                                maTT = tt.MaTT,
                                tenTT = tt.TenTT,
                                ngaySinh = tt.NgaySinh,
                                quocTich = tt.QuocTich,
                            };
            return ds;
        }

        //Them Trong Tai
        public bool ThemTT(DTO_TrongTai tT)
        {
            bool kq = false;
            try
            {
                Tbl_TRONGTAI tt = new Tbl_TRONGTAI()
                {
                    MaTT = tT.MaTT,
                    TenTT = tT.TenTT,
                    NgaySinh = tT.NgaySinh,
                    QuocTich = tT.QuocTich,
                };
                db.Tbl_TRONGTAIs.InsertOnSubmit(tt);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }

        //Sua Trong Tai
        public bool SuaTT(DTO_TrongTai tT)
        {
            bool kq = false;
            try
            {
                Tbl_TRONGTAI tt = db.Tbl_TRONGTAIs.Single(d => d.MaTT == tT.MaTT);
                tt.MaTT = tT.MaTT;
                tt.TenTT = tT.TenTT;
                tt.NgaySinh = tT.NgaySinh;
                tt.QuocTich = tT.QuocTich;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }

        //Xoa Trong Tai

        public bool XoaTT(string matT)
        {
            bool kq = false;
            try
            {
                Tbl_TRONGTAI tt = db.Tbl_TRONGTAIs.Single(d => d.MaTT == matT);
                db.Tbl_TRONGTAIs.DeleteOnSubmit(tt);

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return kq;
        }
    }
}
