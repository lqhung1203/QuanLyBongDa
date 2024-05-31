using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SVD
    {
        //Properties
        private static DataQLBongDaDataContext db = new DataQLBongDaDataContext();

        //Method
        //Lay Danh sach san van dong

        public IQueryable LayDS()
        {
            IQueryable ds = from svd in db.Tbl_SVDs
                            select new
                            {
                                MaSVD = svd.MaSVD,
                                TenSVD = svd.TenSVD,
                                DiaChi = svd.DiaChi,
                                SucChua = svd.SucChua,
                            };
            return ds;
        }

        //Them SVD
        public bool ThemSVD(DTO_SVD sVD)
        {
            bool kq = false;
            try
            {
                Tbl_SVD svd = new Tbl_SVD()
                {
                    MaSVD = sVD.MaSan,
                    TenSVD = sVD.TenSan,
                    DiaChi = sVD.DiaChi,
                    SucChua = sVD.SucChua,
                };
                db.Tbl_SVDs.InsertOnSubmit(svd);
                db.SubmitChanges();
                kq = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }

        //Sua SVD
        public bool SuaSVD(DTO_SVD sVD)
        {
            bool kq = false;
            try
            {
                Tbl_SVD svd = db.Tbl_SVDs.Single(d => d.MaSVD == sVD.MaSan);
                svd.MaSVD = sVD.MaSan;
                svd.TenSVD = sVD.TenSan;
                svd.DiaChi = sVD.DiaChi;
                svd.SucChua = sVD.SucChua;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return kq;
        }

        //Xoa SVD
        public bool XoaSVD(string maSan)
        {
            bool kq = false;
            try
            {
                Tbl_SVD sVD = db.Tbl_SVDs.Single(d => d.MaSVD == maSan);
                db.Tbl_SVDs.DeleteOnSubmit(sVD);

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
