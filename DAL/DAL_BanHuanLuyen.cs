using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BanHuanLuyen
    {
          DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        public IQueryable Load()
        {
            IQueryable hlv = from ds in db.Tbl_BANHUANLUYENs
                             select new
                             {
                                 MaBHL = ds.MaBHL,
                                 TenBHL = ds.TenBHL,
                                 ChucVu = ds.ChucVu,
                                 MaDB = ds.MaDB,
                             };
            return hlv;
        }
        public bool ThemBHL(DTO_BanHuanLuyen bhl)
        {
            bool kq = false;
            try
            {
                Tbl_BANHUANLUYEN DTBHL = new Tbl_BANHUANLUYEN()
                {
                    MaBHL = bhl.MaBHL,
                    TenBHL = bhl.TenBHL,
                    ChucVu = bhl.ChucVu,
                    MaDB = bhl.MaDB,
                };
                db.Tbl_BANHUANLUYENs.InsertOnSubmit(DTBHL);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool XoaBHL(DTO_BanHuanLuyen bhl)
        {
            bool kq = false;
            try
            {
                var xoa = from x in db.Tbl_BANHUANLUYENs
                          where x.MaBHL == bhl.MaBHL
                          select x;
                foreach (var item in xoa)
                {
                    db.Tbl_BANHUANLUYENs.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
                kq = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool CapnhatBHL(DTO_BanHuanLuyen bhl)
        {
            bool kq = false;
            try
            {
                var Update = db.Tbl_BANHUANLUYENs.Single(k => k.MaBHL.Equals(bhl.MaBHL));
                Update.TenBHL = bhl.TenBHL;
                Update.ChucVu = bhl.ChucVu;
                Update.MaDB = bhl.MaDB;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return kq;
        }
    }
}
