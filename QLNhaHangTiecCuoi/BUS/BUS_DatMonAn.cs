using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHangTiecCuoi.DAO;

namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_DatMonAn
    {
        DAO_DatMonAn dAO_DatMonAn;
        public BUS_DatMonAn()
        {
            dAO_DatMonAn = new DAO_DatMonAn();
        }

        public int addDatMon (DATMONAN d)
        {
            int kq = 0;
            if (dAO_DatMonAn.FindFood(d.MaTiec, d.MaMA) != null)
                kq = 0;
            else
            {
                try
                {
                    dAO_DatMonAn.ADDFood(d);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }
            }
            return kq;
        }
        public dynamic ListDatMon(string maTiec)
        {
            dynamic d = dAO_DatMonAn.ListDatMon(maTiec);
            return d;
        }
        public int updateDatMon(DATMONAN d)
        {
            int kq = 0;
            if (dAO_DatMonAn.FindFood(d.MaTiec, d.MaMA) == null)
                kq = 0;
            else
            {
                try
                {
                    dAO_DatMonAn.UpdateFood(d);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }
            }
            return kq;
        }
        public int deleteDatMon(DATMONAN d)
        {
            int kq = 0;
            if (dAO_DatMonAn.FindFood(d.MaTiec, d.MaMA) == null)
                kq = 0;
            else
            {
                try
                {
                    dAO_DatMonAn.DeleteFood(d);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }
            }
            return kq;
        }
        public int TongSoLuongMon(string maTiec)
        {
            int d = dAO_DatMonAn.TongSoLuongMon(maTiec);
            return d;
        }
        public string TongThanhTien(string maTiec)
        {
            return dAO_DatMonAn.TongThanhTien(maTiec);
        }
    }
}
