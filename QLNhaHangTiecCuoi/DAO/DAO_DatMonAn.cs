using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_DatMonAn
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_DatMonAn()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }

        public void ADDFood(DATMONAN d)
        {
            db.pr_AddDatMon(d.MaTiec, d.MaMA, d.SoLuong);
        }

        public void UpdateFood(DATMONAN d)
        {
            db.pr_SuaDatMon(d.MaTiec, d.MaMA, d.SoLuong);
        }

        public void DeleteFood(DATMONAN d)
        {
            db.pr_Xoa1DatMonAn(d.MaTiec, d.MaMA);
        }

        public DATMONAN FindFood(string maTiec, string maFood)
        {
            DATMONAN d = db.DATMONANs.FirstOrDefault(s => s.MaTiec == maTiec && s.MaMA == maFood);
            return d;
        }
        public dynamic ListDatMon(string maTiec)
        {
            dynamic d = db.DATMONANs.Select(s => new
            {
                s.MaTiec,
                s.MaMA,
                s.SoLuong,
                s.ThanhTien
            }).Where(s => s.MaTiec == maTiec).ToList();
            return d;
        }
        public int TongSoLuongMon(string maTiec)
        {
            int d = db.DATMONANs.Where(s => s.MaTiec == maTiec).Count();
            return d;
        }
        public string TongThanhTien(string maTiec)
        {
           return db.TongThanhTien(maTiec);
        }
    }
}
