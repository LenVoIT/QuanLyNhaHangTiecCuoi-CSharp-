using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi
{
    class DAO_NhanVien
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_NhanVien()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public NHANVIEN GetNhanVien(string maNV)
        {
            return db.NHANVIENs.FirstOrDefault(s => s.MaNV == maNV);
        }
        public NHANVIEN GetNhanVienByUserName(string userName)
        {
            return db.NHANVIENs.FirstOrDefault(s => s.UserName == userName);
        }
        public void AddNhanVien(NHANVIEN n, string password)
        {
            db.pr_AddNhanVien(n.TenNV, n.SDT, n.CMND, n.MaBP, n.ChucVu, n.Luong, n.UserName, password);
        }
        public List<NHANVIEN> ListNhanVienByBP(string MABP)
        {
            List<NHANVIEN> d = db.NHANVIENs.Select(s => s).Where(s => s.MaBP == MABP).ToList();
            return d;
        }
        //nguyen
        public dynamic NHANVIENList()
        {

            var ds = db.NHANVIENs.Select(s => new {
                s.MaNV,
                s.TenNV,
                s.SDT,
                s.CMND,
                s.MaBP,
                s.ChucVu,
                s.Luong,
                s.UserName

            }).ToList();
            return ds;

        }

        public NHANVIEN FindNhanVien(string maNV)
        {
            NHANVIEN nhanvien = db.NHANVIENs.FirstOrDefault(s => s.MaNV == maNV);
            return nhanvien;
        }

        public void UpdateNhanVien(NHANVIEN n)
        {
            db.pr_SuaNhanVien(n.MaNV, n.TenNV, n.SDT, n.CMND, n.MaBP, n.ChucVu, n.Luong);
        }

        public void DeleteNhanVien(NHANVIEN n)
        {
            db.pr_XoaNhanVien(n.MaNV);
        }
    }
}
