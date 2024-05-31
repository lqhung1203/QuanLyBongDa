using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KQThiDau
    {
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        public IQueryable LoadDSKQ()
        {
            IQueryable KQ = from dskq in db.Tbl_KQTHIDAUs
                            select new
                            {
                                MaKQ = dskq.MaKQ,
                                MaTD = dskq.MaTD,
                                Doi1 = dskq.Doi1,
                                Doi2 = dskq.Doi2,
                                soTPDoi1 = dskq.SoThePhatDoi1,
                                soTPDoi2 = dskq.SoThePhatDoi2,
                                soBTDoi1 = dskq.SoBTDoi1,
                                soBTDoi2 = dskq.SoBTDoi2,
                            };
            return KQ;
        }
        public bool ThemKQ(DTO_KQThiDau kqTD)
        {
            bool kq = false;
            try
            {
                Tbl_KQTHIDAU KQTD = new Tbl_KQTHIDAU()
                {
                    MaKQ = kqTD.MaKQ,
                    MaTD = kqTD.MaTD,
                    Doi1 = kqTD.Doi1,
                    Doi2 = kqTD.Doi2,
                    SoThePhatDoi1 = kqTD.SoThePhatDoi1,
                    SoThePhatDoi2 = kqTD.SoThePhatDoi2,
                    SoBTDoi1 = kqTD.SoBTDoi1,
                    SoBTDoi2 = kqTD.SoBTDoi2,         
                };
                db.Tbl_KQTHIDAUs.InsertOnSubmit(KQTD);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool XoaKQ(DTO_KQThiDau kqTD)
        {
            bool kq = false;
            try
            {
                var xoa = from x in db.Tbl_KQTHIDAUs
                          where x.MaKQ == kqTD.MaKQ
                          select x;
                foreach (var x in xoa)
                {
                    db.Tbl_KQTHIDAUs.DeleteOnSubmit(x);
                    db.SubmitChanges();
                    kq = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool CapnhatKQ(DTO_KQThiDau kqTD)
        {
            bool kq = false;
            try
            {
                var capnhat = db.Tbl_KQTHIDAUs.Single(k => k.MaKQ.Equals(kqTD.MaKQ));
                capnhat.MaTD = kqTD.MaTD;
                capnhat.SoThePhatDoi1 = kqTD.SoThePhatDoi1;
                capnhat.SoThePhatDoi2 = kqTD.SoThePhatDoi2;
                capnhat.SoBTDoi1 = kqTD.SoBTDoi1;
                capnhat.SoBTDoi2 = kqTD.SoBTDoi2;

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
