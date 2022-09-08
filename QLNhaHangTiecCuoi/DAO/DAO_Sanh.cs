using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_Sanh
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_Sanh()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public List<Sanh> ListSanh()
        {
            return db.Sanhs.Select(s => s).Where(s => s.IsDeleted == null).ToList();
        }
        public Sanh ThongTinSanh(string maSanh)
        {
            return db.Sanhs.FirstOrDefault(s => s.MaSanh == maSanh);
        }
        // sang
        public void UpdateSanh(Sanh d)
        {
            db.pr_SuaSanh(d.MaSanh, d.TenSanh, d.Tang, d.DonGia, d.SucChua);
        }
        public void DeleteSanh(Sanh d)
        {
            db.pr_XoaSanh(d.MaSanh);
        }

        public Sanh ThongTinByName(string TenSanh)
        {
            return db.Sanhs.FirstOrDefault(s => s.TenSanh == TenSanh);
        }
        public void ThemSanh (Sanh s)
        {
            db.pr_AddSanh(s.TenSanh, s.Tang, s.DonGia, s.SucChua);
        }
        public void ThemSanhisDeleted(Sanh d)
        {
            db.pr_AddSanhisDeleted(d.TenSanh, d.Tang, d.DonGia, d.SucChua);
        }
    }
}
