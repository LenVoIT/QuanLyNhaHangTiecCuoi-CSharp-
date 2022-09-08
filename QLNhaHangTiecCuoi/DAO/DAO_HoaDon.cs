using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_HoaDon
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_HoaDon()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public HOADON GetHoaDon(string maTiec)
        {
            return db.HOADONs.FirstOrDefault(s => s.MaTiec == maTiec);
        }
        public List<HOADON> ListAllHoaDon()
        {
            return db.HOADONs.Select(s => s).ToList();
        }
        public List<HOADON> ListHoaDonByTime(DateTime from, DateTime to)
        {
            return db.HOADONs.Where(s => s.NgayLap >= from && s.NgayLap <= to).ToList();
        }
        public void updateHD(HOADON h)
        {
            string tinhTrang = "Đã thanh toán";
            h.TinhTrang = tinhTrang;
            db.SubmitChanges();
        }
    }
}
