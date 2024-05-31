using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CauThu
    {

        //Properties
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();

        //Methods

        //Lay Danh Sach Cau Thu 
        public IQueryable LayDS()
        {
            IQueryable ds = from ct in db.Tbl_CAUTHUs
                            select new
                            {
                                maCT = ct.MaCT,
                                tenCT = ct.TenCT,
                                viTri = ct.ViTri,
                                soAo = ct.SoAo,
                                maDB = ct.MaDB,
                            };
            return ds;
        }

        //Them Cau Thu
        public bool ThemCT(DTO_Cauthu cauThu)
        {
            bool kq = false;
            try
            {
                Tbl_CAUTHU ct = new Tbl_CAUTHU()
                {
                    MaCT = cauThu.MaCT,
                    TenCT = cauThu.TenCT,
                    ViTri = cauThu.ViTri,
                    SoAo = cauThu.SoAo,
                    MaDB = cauThu.MaDB,
                };
                db.Tbl_CAUTHUs.InsertOnSubmit(ct);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return kq;
        }

        //Sua Cau Thu 
        public bool SuaCT(DTO_Cauthu cauThu)
        {
            bool kq = false;
            try
            {
                Tbl_CAUTHU ct = db.Tbl_CAUTHUs.Single(d => d.MaCT == cauThu.MaCT);

                ct.MaCT = cauThu.MaCT;
                ct.TenCT = cauThu.TenCT;
                ct.ViTri = cauThu.ViTri;
                ct.SoAo = cauThu.SoAo;
                ct.MaDB = cauThu.MaDB;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return kq;
        }

        //Xoa CT
        public bool XoaCT(string macauThu)
        {
            bool kq = false;
            try
            {
                Tbl_CAUTHU ct = db.Tbl_CAUTHUs.Single(d => d.MaCT == macauThu);

                db.Tbl_CAUTHUs.DeleteOnSubmit(ct);
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
