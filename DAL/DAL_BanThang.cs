using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BanThang
    {
        //Methods
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        //Lay Danh Sach Ban Thang
        public IQueryable LayDS()
        {
            IQueryable ds = from bt in db.Tbl_BANTHANGs
                            select new
                            {
                                MaBT = bt.MaBT,
                                MaCT = bt.MaCT,
                                LoaiBT = bt.LoaiBT,
                                ThoiDiem = bt.ThoiDiem,
                                MaTD = bt.MaTD,
                                MaDB = bt.MaDB,
                            };
            return ds;
        }

        //Them Ban Thang 
        public bool ThemBT(DTO_BanThang banThang)
        {

            var kqThiDau = db.Tbl_KQTHIDAUs.FirstOrDefault(ketqua => ketqua.MaTD == banThang.MaTD);
            if (kqThiDau == null)
            {
                throw new Exception("Không tìm thấy kết quả trận đấu cho mã trận đấu đã cho.");
            }
            // Xác định số bàn thắng tối đa cho đội được thêm bàn thắng
            int maxGoals;
            if (banThang.MaDB == kqThiDau.Doi1)
            {
                maxGoals = kqThiDau.SoBTDoi1;
            }
            else if (banThang.MaDB == kqThiDau.Doi2)
            {
                maxGoals = kqThiDau.SoBTDoi2;
            }
            else
            {
                throw new Exception("Mã đội bóng không hợp lệ.");
            }

            // Đếm số lượng bàn thắng hiện tại của đội
            int soBTDoi = db.Tbl_BANTHANGs.Count(bt => bt.MaTD == banThang.MaTD && bt.MaDB == banThang.MaDB);

            if (soBTDoi < maxGoals)
            {
                bool kq = false;
                try
                {
                    Tbl_BANTHANG bt = new Tbl_BANTHANG()
                    {
                        MaBT = banThang.MaBT,
                        MaCT = banThang.MaCT,
                        LoaiBT = banThang.LoaiBT,
                        ThoiDiem = banThang.ThoiDiem,
                        MaTD = banThang.MaTD,
                        MaDB = banThang.MaDB,
                    };
                    db.Tbl_BANTHANGs.InsertOnSubmit(bt);
                    db.SubmitChanges();
                    kq = true;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                return kq;
            }
            else
            {
                throw new Exception("Vượt giới hạn bàn thắng!!!!");

            }

        }

        //Sua Ban Thang
        public bool SuaBT(DTO_BanThang banThang)
        {
            bool kq = false;
            try
            {
                Tbl_BANTHANG bt = db.Tbl_BANTHANGs.Single(d => d.MaBT == banThang.MaBT);
                bt.MaBT = banThang.MaBT;
                bt.MaCT = banThang.MaCT;
                bt.LoaiBT = banThang.LoaiBT;
                bt.ThoiDiem = banThang.ThoiDiem;
                bt.MaTD = banThang.MaTD;
                bt.MaDB = banThang.MaDB;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return kq;
        }

        //Xoa ban thang
        public bool XoaBT(string banThang)
        {
            bool kq = false;
            try
            {
                Tbl_BANTHANG bt = db.Tbl_BANTHANGs.Single(d => d.MaBT == banThang);

                db.Tbl_BANTHANGs.DeleteOnSubmit(bt);

                db.SubmitChanges();
                kq = true;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
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

    }
}
