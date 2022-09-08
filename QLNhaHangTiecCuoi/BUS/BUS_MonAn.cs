using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.DAO;

namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_MonAn
    {
        DAO_MonAn dAO_MONAN;
        public BUS_MonAn()
        {
            dAO_MONAN = new DAO_MonAn();
        }
        public List<MONAN> ListMonAn()
        {
            List<MONAN> d = dAO_MONAN.ListMonAn();
            return d;
        }
        public int AddMonAn(MONAN d)
        {
            int kq = 0;
            if (dAO_MONAN.MonAnByName(d.TenMa) == null)
            {
                dAO_MONAN.AddThucAn(d);
                kq = 1;
            }
            else if (dAO_MONAN.MonAnByName(d.TenMa).IsDeleted != null)
            {
                dAO_MONAN.AddThucAnisDeleted(d);
                kq = 1;
            }
            else
                kq = 0;
            return kq;
        }

        public int UpdateMonAn(MONAN d)
        {
            int kq = 0;
            if (dAO_MONAN.TimThucAn(d.MaMA) == null)
            {
                kq = 0;
            }
            else if (dAO_MONAN.TimThucAn(d.MaMA) != null)
            {
                try
                {
                    dAO_MONAN.UpdateThucAn(d);
                    kq = 1;
                }
                catch (Exception ex)
                {
                    kq = -1;
                }

            }
            return kq;
        }
        public int DeleteMonAn(MONAN d)
        {
            int kq = 0;
            if (dAO_MONAN.TimThucAn(d.MaMA) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_MONAN.XoaThucAn(d);
                    kq = 1;
                }
                catch (Exception ex)
                {
                    kq = -1;
                }

            }
            return kq;
        }
        public void getListMonAn(DataGridView dg)
        {
            dg.DataSource = dAO_MONAN.ListMonAn();
        }
    }
}
