using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_MonAn
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_MonAn()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public List<MONAN> ListMonAn ()
        {
            List<MONAN> d = db.MONANs.Select(s => s).Where(s => s.IsDeleted == null).ToList();
            return d;
        }
        public void AddThucAn(MONAN d)
        {
            db.pr_AddMonAn(d.TenMa, d.DonGia, d.Loai, d.DonViTinh);
        }
        public void UpdateThucAn(MONAN d)
        {
            db.pr_SuaMonAn(d.MaMA, d.TenMa, d.DonGia, d.Loai, d.DonViTinh);
        }
        public void XoaThucAn(MONAN d)
        {
            db.pr_XoaThucAn(d.MaMA);
        }
        public MONAN TimThucAn(string maMA)
        {
            MONAN d = db.MONANs.FirstOrDefault(s => s.MaMA == maMA);
            return d;
        }
        public void AddThucAnisDeleted(MONAN d)
        {
            db.pr_AddMonAnisDeleted(d.TenMa, d.DonGia, d.Loai, d.DonViTinh);
        }

        public MONAN MonAnByName(string TenMA)
        {
            return db.MONANs.FirstOrDefault(s => s.TenMa == TenMA);
        }
    }
}
