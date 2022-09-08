using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_DichVu
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_DichVu()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public List<DICHVU> ListDichVu()
        {
            return db.DICHVUs.Select(s => s).Where(s => s.IsDeleted == null).ToList();
        }
        public DICHVU FindDichVu(string MaDV)
        {
            DICHVU dichvu = db.DICHVUs.FirstOrDefault(s => s.MaDV == MaDV);
            return dichvu;
        }
        public void UpdateDichVu(DICHVU n)
        {
            db.pr_SuaDichVu(n.MaDV, n.TenDV, n.DonGia);
        }

        public void DeleteDichVu(DICHVU n)
        {
            db.pr_XoaDichVu(n.MaDV);
        }

        public void AddDichVu(DICHVU n)
        {
            db.pr_AddDichVu(n.TenDV, n.DonGia);
        }
        public void AddDichVuisDeleted(DICHVU n)
        {
            db.pr_AddDichVuisDeleted(n.TenDV, n.DonGia);
        }
        public DICHVU DichVuByName(string TenDV)
        {
            return db.DICHVUs.FirstOrDefault(s => s.TenDV == TenDV);
        }
    }
}
