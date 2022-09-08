using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_ACCOUNT
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_ACCOUNT()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();

        }
        public ACCOUNT getACCOUNT(ACCOUNT a1, string type)
        {
            ACCOUNT a = db.ACCOUNTs.FirstOrDefault(s => s.UserName == a1.UserName && s.PassWord == a1.PassWord && s.TypeUser == type);
            return a;
        }
        public KHACHHANG GetKhachHangByuserName(string us)
        {
            KHACHHANG k = db.KHACHHANGs.FirstOrDefault(s => s.UserName == us);
            return k;
        }
        public NHANVIEN GetNhanVienByuserName(string us)
        {
            NHANVIEN n = db.NHANVIENs.FirstOrDefault(s => s.UserName == us);
            return n;
        }
        public ACCOUNT checkAccountExists ( string us)
        {
            return db.ACCOUNTs.FirstOrDefault(s => s.UserName == us);
        }

    }
}
