using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.DAO;
namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_DichVu
    {
        DAO_DichVu dAO_DichVu;
        public BUS_DichVu()
        {
            dAO_DichVu = new DAO_DichVu();
        }
        public List<DICHVU> ListDichVu()
        {
            return dAO_DichVu.ListDichVu();
        }

        public void ListDICHVUs(DataGridView dg)
        {
            dg.DataSource = dAO_DichVu.ListDichVu();
        }
        public int UpdateDichVu(DICHVU n)
        {
            int kq = 0;
            if (dAO_DichVu.FindDichVu(n.MaDV) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_DichVu.UpdateDichVu(n);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }
            return kq;
        }

        public int DeleteDichVu(DICHVU n)
        {
            int kq = 0;
            if (dAO_DichVu.FindDichVu(n.MaDV) == null)
            {
                kq = 0;
            }
            else if (dAO_DichVu.FindDichVu(n.MaDV) != null)
            {
                try
                {
                    dAO_DichVu.DeleteDichVu(n);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }
            return kq;
        }

        public int AddDichVu(DICHVU n)
        {
            int kq = 0;
            if (dAO_DichVu.DichVuByName(n.TenDV) == null)
            {
                dAO_DichVu.AddDichVu(n);
                kq = 1;

            }
            else if (dAO_DichVu.DichVuByName(n.TenDV).IsDeleted != null)
            {
                dAO_DichVu.AddDichVuisDeleted(n);
                kq = 1;
            }
            else
                kq = 0;
            return kq;
        }
    }
}
