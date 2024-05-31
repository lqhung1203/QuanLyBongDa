using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DoiBong
    {
        DataQLBongDaDataContext db = new DataQLBongDaDataContext(Properties.Settings.Default.tspConnect);
        public IQueryable Load()
        {
            IQueryable dsdb = from ds in db.Tbl_DOIBONGs
                              select new
                              {
                                  MaDB = ds.MaDB,
                                  TenDB = ds.TenDB,
                                  DiaChi = ds.DiaChi,
                                  MaNTT = ds.MaNTT
                              };
            return dsdb;
        }
        public bool CapnhatDB(DTO_DoiBong dtodb)
        {
            bool kq = false;
            try
            {
                var Update = db.Tbl_DOIBONGs.Single(k => k.MaDB.Equals(dtodb.MaDB));
                Update.TenDB = dtodb.TenDB;
                Update.DiaChi = dtodb.DiaChi;
                Update.MaNTT = dtodb.MaNTT;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool XoaDB(DTO_DoiBong dtodb)
        {
            bool kq = false;
            
            try
            {
                //Xoa DB o bxh
                var xoaBXH = from x in db.Tbl_BXHs
                             where x.MaDB == dtodb.MaDB
                             select x;
                foreach (var item in xoaBXH)
                {
                    db.Tbl_BXHs.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }

                //Xoa DB 
                var xoa = from x in db.Tbl_DOIBONGs
                          where x.MaDB == dtodb.MaDB
                          select x;
                foreach (var item in xoa)
                {
                    db.Tbl_DOIBONGs.DeleteOnSubmit(item);
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
        public bool ThemDB(DTO_DoiBong dtdb)
        {
            bool kq = false;
            try
            {
                Tbl_DOIBONG doiBong = new Tbl_DOIBONG()
                {
                    MaDB = dtdb.MaDB,
                    TenDB = dtdb.TenDB,
                    DiaChi = dtdb.DiaChi,
                    MaNTT = dtdb.MaNTT,
                };
                db.Tbl_DOIBONGs.InsertOnSubmit(doiBong);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public IQueryable SearchDB(string timkiem)
        {
            IQueryable find = from tim in db.Tbl_DOIBONGs
                              where tim.MaDB.Contains(timkiem)
                              select tim;
            return find;
        }
    }
}
