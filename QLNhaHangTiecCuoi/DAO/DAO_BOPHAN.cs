using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.DAO
{
    class DAO_BOPHAN
    {
        DbQLNhaHangTiecCuoiDataContext db;
        public DAO_BOPHAN()
        {
            db = new DbQLNhaHangTiecCuoiDataContext();
        }
        public dynamic getListChucVu()
        {
            var a = db.BOPHANs.Select(s => new
            {
                s.MaBP,
                s.TenBP,
            }).ToList();
            return a;
        }
        //LEN
        public BOPHAN getMaBoPhan(string ten)
        {
            return db.BOPHANs.FirstOrDefault(s => s.TenBP == ten);
        }
        public void AddBoPhan(string tenBP)
        {
            db.pr_AddBoPhan(tenBP);
            BOPHAN d = TimBoPhan(tenBP);
            d.SoLuongNV = 0;
            db.SubmitChanges();
        }
        public void UpdateBoPhan(BOPHAN d)
        {
            db.pr_SuaBoPhan(d.MaBP, d.TenBP);
        }
        public void DeleteBoPhan(BOPHAN d)
        {
            db.pr_XoaBP(d.MaBP);
        }
        public BOPHAN TimBoPhan(string tenBP)
        {
            BOPHAN d = db.BOPHANs.FirstOrDefault(s => s.TenBP == tenBP);
            return d;
        }
        public List<BOPHAN> ListBoPhan()
        {
            List<BOPHAN> d = db.BOPHANs.Select(s => s).ToList();
            return d;
        }
        public BOPHAN TimBoPhanByMa(string MaBP)
        {
            BOPHAN d = db.BOPHANs.FirstOrDefault(s => s.MaBP == MaBP);
            return d;
        }
    }
}
