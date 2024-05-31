using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThePhat
    {
        public DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        public IQueryable LoadDS()
        {
            IQueryable ds = from n in db.Tbl_THEPHATs
                            select new
                            {
                                MaTP = n.MaTP,
                                TenTP = n.TenTP,
                                ThoiDiem = n.ThoiDiem,
                                MaCT = n.MaCT,
                                MaTD = n.MaTD,
                                MaDB = n.MaDB,
                            };
            return ds;
        }
        public IQueryable LoadDSMaCT(string maTD)
        {
            IQueryable query = from cauThu in db.Tbl_CAUTHUs
                               where db.Tbl_LICHTHIDAUs.Any(lichThiDau => lichThiDau.MaTD == maTD && (lichThiDau.Doi1 == cauThu.MaDB || lichThiDau.Doi2 == cauThu.MaDB))
                               select new
                               {
                                   cauThu.MaCT,
                                   cauThu.TenCT
                               };
            return query;
        }

        public IQueryable LoadDMaDB(string maTD)
        {
            IQueryable query = from doibong in db.Tbl_DOIBONGs
                               where db.Tbl_LICHTHIDAUs.Any(lichthidau => lichthidau.MaTD == maTD && (lichthidau.Doi1 == doibong.MaDB || lichthidau.Doi2 == doibong.MaDB))
                               select new
                               {
                                   doibong.MaDB,
                                   doibong.TenDB
                               };
            return query;
        }
        public IQueryable LoadDMaCTT(string maDB)
        {
            IQueryable query = from cauThu in db.Tbl_CAUTHUs
                               where db.Tbl_CAUTHUs.Any(cauthu => cauthu.MaDB == maDB && (cauthu.MaDB == cauThu.MaDB))
                               select new
                               {
                                   cauThu.MaCT,
                                   cauThu.TenCT
                               };
            return query;
        }
        public bool ThemTP(DTO_ThePhat tp)
        {
            var kqThiDau = db.Tbl_KQTHIDAUs.FirstOrDefault(ketqua => ketqua.MaTD == tp.MaTD);
            if (kqThiDau == null)
            {
                throw new Exception("Không tìm thấy kết quả trận đấu cho mã trận đấu đã cho.");
            }
            // Xác định số thẻ phạt tối đa cho đội được thêm bàn thắng
            int gioiHanThe;
            if (tp.MaDB == kqThiDau.Doi1)
            {
                gioiHanThe = kqThiDau.SoThePhatDoi1;
            }
            else if (tp.MaDB == kqThiDau.Doi2)
            {
                gioiHanThe = kqThiDau.SoThePhatDoi2;
            }
            else
            {
                throw new Exception("Mã đội bóng không hợp lệ.");
            }

            // Đếm số lượng thẻ phạt hiện tại của đội
            int soTheDoi = db.Tbl_THEPHATs.Count(bt => bt.MaTD == tp.MaTD && bt.MaDB == tp.MaDB);

            if (soTheDoi < gioiHanThe)
            {
                bool kq = false;
                try
                {
                    Tbl_THEPHAT TP = new Tbl_THEPHAT()
                    {
                        MaTP = tp.MaTP,
                        TenTP = tp.TenTP,
                        ThoiDiem = tp.ThoiDiem,
                        MaCT = tp.MaCT,
                        MaTD = tp.MaTD,
                        MaDB = tp.MaDB,
                    };
                    db.Tbl_THEPHATs.InsertOnSubmit(TP);
                    db.SubmitChanges();
                    kq = true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return kq;
            }
            else
            {
                throw new Exception("Vượt quá giới hạn thẻ phạt của trận đấu");
            }

        }
        public bool CapNhatTP(DTO_ThePhat tp)
        {
            bool kq = false;
            try
            {
                var update = db.Tbl_THEPHATs.Single(k => k.MaTP.Equals(tp.MaTP));
                update.TenTP = tp.TenTP;
                update.ThoiDiem = tp.ThoiDiem;
                update.MaCT = tp.MaCT;
                update.MaTD = tp.MaTD;
                update.MaDB = tp.MaDB;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        public bool XoaTP(DTO_ThePhat tp)
        {
            bool kq = false;
            try
            {
                var xoa = from x in db.Tbl_THEPHATs
                          where x.MaTP == tp.MaTP
                          select x;
                foreach (var item in xoa)
                {
                    db.Tbl_THEPHATs.DeleteOnSubmit(item);
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
    }
}
