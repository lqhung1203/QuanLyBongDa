using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaTaiTro
    {
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        public IQueryable LoadDS()
        {
            IQueryable ds = from n in db.Tbl_NHATAITROs
                            select  n;
            return ds;
        }
        public bool ThemNTT(DTO_NhaTaiTro ntt)
        {
            bool kq=false;
            try
            {
                Tbl_NHATAITRO TT = new Tbl_NHATAITRO()
                {
                    MaNTT = ntt.MaNTT,
                    TenNTT = ntt.TenNTT,
                    SDT = ntt.SDT,
                };
                db.Tbl_NHATAITROs.InsertOnSubmit(TT);
                db.SubmitChanges();
                kq =true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool XoaNTT(DTO_NhaTaiTro ntt)
        {
            bool kq = false;
            try
            {      
                var dl = from x in db.Tbl_NHATAITROs
                         where x.MaNTT == ntt.MaNTT
                         select x;
                foreach (var item in dl)
                {
                    db.Tbl_NHATAITROs.DeleteOnSubmit(item);
                    db.SubmitChanges();
                    kq=true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool CapnhatNTT(DTO_NhaTaiTro ntt)
        {
            bool kq = false;
            try
            {
                var ud = db.Tbl_NHATAITROs.Single(k => k.MaNTT.Equals(ntt.MaNTT));
                ud.TenNTT = ntt.TenNTT;
                ud.SDT = ntt.SDT;

                db.SubmitChanges(); 
                kq=true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public IQueryable Search(string timkiem)
        {
            IQueryable seek = from tk in db.Tbl_NHATAITROs
                       where tk.MaNTT.Contains(timkiem) 
                       select tk;
            return seek;
        }
    }
}
