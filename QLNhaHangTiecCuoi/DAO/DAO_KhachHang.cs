using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_KhachHang
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_KhachHang()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public KHACHHANG GetKhachHang (string maKh)
        {
            return db.KHACHHANGs.FirstOrDefault(s => s.MaKH == maKh);
        }
        public KHACHHANG GetKhachHangByUserName(string userName)
        {
            return db.KHACHHANGs.FirstOrDefault(s => s.UserName == userName);
        }
        public void AddKhachHang(KHACHHANG k, string password)
        {
            db.pr_AddKhachHang(k.TenKH, k.GioiTinh, k.CMND, k.SDT, k.DiaChi, k.UserName, password);

        }

        // SANG
        public KHACHHANG FindKhachHang(string maKH)
        {
            return db.KHACHHANGs.FirstOrDefault(s => s.MaKH == maKH);
        }


        

        public void UpdateKhachHang(KHACHHANG d)
        {
            db.pr_SuaKhachhang(d.MaKH, d.TenKH, d.GioiTinh, d.CMND, d.SDT, d.DiaChi);
        }

        internal List<KHACHHANG> ListKhachHang()
        {
            return db.KHACHHANGs.Select(s => s).ToList();
        }
    }
}
