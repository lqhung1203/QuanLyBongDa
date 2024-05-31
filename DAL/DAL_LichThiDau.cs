using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LichThiDau
    {
        DataQLBongDaDataContext db = new DataQLBongDaDataContext();
        public IQueryable LoadDS()
        {
            IQueryable ds = from n in db.Tbl_LICHTHIDAUs
                            select new
                            {
                                MaTD = n.MaTD,
                                SVD = n.MaSVD,
                                TT = n.MaTT,
                                Doi1 = n.Doi1,
                                Doi2 = n.Doi2,
                                NgayTD = n.NgayThiDau,
                                GioTD = n.GioTD,
                            };
            return ds;
        }
        public IQueryable LoadMaTD()
        {
            IQueryable ds = from n in db.Tbl_LICHTHIDAUs
                            select n;
            return ds;
        }
        public IQueryable<Tbl_LICHTHIDAU> LoadDSMaDB(string doibong)
        {
           return db.Tbl_LICHTHIDAUs.Where(lich => lich.MaTD == doibong);
        }
        // Phương thức để thêm lịch thi đấu
        public bool ThemLichThiDau(DTO_LichThiDau lichThiDauDTO)
        {
            bool kq = false;
            try
            {
                Tbl_LICHTHIDAU lichThiDau = new Tbl_LICHTHIDAU
                {
                    MaTD = lichThiDauDTO.MaTD,
                    MaDB = lichThiDauDTO.MaDB,
                    MaSVD = lichThiDauDTO.MaSVD,
                    MaTT = lichThiDauDTO.MaTT,
                    Doi1 = lichThiDauDTO.doi1,
                    Doi2 = lichThiDauDTO.doi2,
                    NgayThiDau = lichThiDauDTO.NgayThiDau,
                    GioTD = lichThiDauDTO.GioTD,
                };

                db.Tbl_LICHTHIDAUs.InsertOnSubmit(lichThiDau);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);          
            }
            return kq;
        }
        // Phương thức để sửa lịch thi đấu
        public bool CapnhatLichThiDau(DTO_LichThiDau lichThiDauDTO)
        {
            bool kq = false;
            try
            {
                var capnhat = db.Tbl_LICHTHIDAUs.Single(k => k.MaTD.Equals(lichThiDauDTO.maTD));
                capnhat.MaSVD = lichThiDauDTO.maSVD;
                capnhat.MaTT = lichThiDauDTO.maTT;
                capnhat.Doi1 = lichThiDauDTO.doi1;
                capnhat.Doi2 = lichThiDauDTO.doi2;
                capnhat.NgayThiDau = lichThiDauDTO.ngayThiDau;
                capnhat.GioTD = lichThiDauDTO.gioTD;

                db.SubmitChanges();
                kq = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return kq;
        }
        // Phương thức để xóa lịch thi đấu
        public bool XoaLichThiDau(DTO_LichThiDau lichThiDauDTO)
        {
            bool kq = false;
            try
            {
                var xoa = from x in db.Tbl_LICHTHIDAUs
                          where x.MaTD == lichThiDauDTO.MaTD
                          select x;
                foreach (var item in xoa)
                {
                    db.Tbl_LICHTHIDAUs.DeleteOnSubmit(item);
                    db.SubmitChanges();

                };
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
