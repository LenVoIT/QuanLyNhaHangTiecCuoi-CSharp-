using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHangTiecCuoi.DAO;
namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_DatDichVu
    {
        DAO_DatDichVu dAO_DatDichVu;
        public BUS_DatDichVu()
        {
            dAO_DatDichVu = new DAO_DatDichVu();
        }
        public dynamic ListDatDichVu(string maTiec)
        {
            return dAO_DatDichVu.ListDatDichVu(maTiec);
        }
        public int AddDichVu(DATDICHVU d)
        {
            int kq;
            if (dAO_DatDichVu.FindDatDichVu(d.MaTiec, d.MaDV) != null)
                kq = 0;
            else
            {
                try
                {
                    dAO_DatDichVu.AddDichVu(d);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }

            }
            return kq;
        }
        public int SoLuongDichVu(string maTiec)
        {
            return dAO_DatDichVu.SoLuongDichVu(maTiec);
        }
        public int DeleteDichVu(DATDICHVU d)
        {
            int kq;
            if (dAO_DatDichVu.FindDatDichVu(d.MaTiec, d.MaDV) == null)
                kq = 0;
            else
            {
                try
                {
                    dAO_DatDichVu.DeleteDichVu(d);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }
            }
            return kq;
        }
    }
}
