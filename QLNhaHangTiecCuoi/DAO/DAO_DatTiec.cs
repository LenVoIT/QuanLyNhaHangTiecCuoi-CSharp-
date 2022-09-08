using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_DatTiec
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_DatTiec()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public void AddDatTiec(DATTIEC d)
        {
            db.pr_addDatTiec(d.MaKH, d.TenTiec, d.SoLuongBan, d.SoLuongKhach);
        }
        public DATTIEC FindDatTiec(string maTiec)
        {
            DATTIEC d = db.DATTIECs.FirstOrDefault(s => s.MaTiec == maTiec);
            return d;
        }
        public void DeleteDatTiec(string maTiec)
        {
            db.pr_XoaDatTiec(maTiec);
        }
        public void UpdateThongTinDatTiec(DATTIEC d)
        {
            DATTIEC d1 = FindDatTiec(d.MaTiec);
            d1.TenTiec = d.TenTiec;
            d1.SoLuongBan = d.SoLuongBan;
            d1.SoLuongKhach = d.SoLuongKhach;
            db.SubmitChanges();
            
        }
        public void AddSanh(DATTIEC d)
        {
            db.pr_AddDatSanh(d.MaTiec, d.MaSanh, d.NgayToChuc, d.Buoi);
        }
        public String Max_Tiec ()
        {
            string maMax = db.Max_DatTiec();
            return maMax;
        }
       public string maSanh(DATTIEC d)
        {
            return d.MaSanh;
        }
        public dynamic getListDatTiec(string maKH)

        {
            var d = db.DATTIECs.Select(s => new
            {
                s.MaTiec,
                s.TenTiec,
                s.MaKH,
                s.MaSanh,
                s.SoLuongBan,
                s.SoLuongKhach,
                s.TinhTrang
            }).Where(s => s.MaKH == maKH).ToList();
            return d;
        }
        public dynamic getListDatTiecByTinhTrang(string tinhTrang)
        {

            var a = db.DATTIECs.Select(s => new
            {
                s.MaTiec,
                s.TenTiec,
                s.MaKH,
                s.MaNV,
                s.MaSanh,
                s.NgayDat,
                s.NgayToChuc,
                s.TinhTrang
            }).Where(s => s.TinhTrang == tinhTrang).ToList();
            return a;
        }
        public void updateTinhTrangTiec(DATTIEC t)
        {
            DATTIEC d = FindDatTiec(t.MaTiec);
            d.TinhTrang = t.TinhTrang;
            d.MaNV = t.MaNV;
            db.SubmitChanges();
        }
    }
}
