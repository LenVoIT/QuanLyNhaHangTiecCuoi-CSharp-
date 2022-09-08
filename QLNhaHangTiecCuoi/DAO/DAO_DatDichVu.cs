using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_DatDichVu
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_DatDichVu()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }

        public dynamic ListDatDichVu(string maTiec)
        {
            return db.ListDichVuDat(maTiec).ToList();                
        }

        public void AddDichVu (DATDICHVU d)
        {
            db.pr_AddDatDV(d.MaTiec, d.MaDV);
        }
        public int SoLuongDichVu(string maTiec)
        {
            return db.DATDICHVUs.Where(s => s.MaTiec == maTiec).Count();
        }
        public void DeleteDichVu (DATDICHVU d)
        {
            db.pr_Xoa1DatDichVu(d.MaTiec, d.MaDV);
        }
        public DATDICHVU FindDatDichVu(string maTiec, string maDV)
        {
            return db.DATDICHVUs.FirstOrDefault(s => s.MaTiec == maTiec && s.MaDV == maDV);
        }

    }
}
