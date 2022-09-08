using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHangTiecCuoi.DAO;
namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_Sanh
    {
        DAO_Sanh dAO_Sanh;
        public BUS_Sanh()
        {
            dAO_Sanh = new DAO_Sanh();
        }
        public List<Sanh> ListSanh()
        {
            return dAO_Sanh.ListSanh();
        }
        public Sanh ThongTinSanh(string maSanh)
        {
            return dAO_Sanh.ThongTinSanh(maSanh);
        }
        //sang
        public int AddSanh(Sanh d)
        {

            int kq = 0;
            if (dAO_Sanh.ThongTinByName(d.TenSanh) == null)
            {

                dAO_Sanh.ThemSanh(d);
                kq = 1;

            }
            else if (dAO_Sanh.ThongTinByName(d.TenSanh).IsDeleted != null)
            {
                dAO_Sanh.ThemSanhisDeleted(d);
                kq = 1;
            }
            else
                kq = 0;
            return kq;
        }
        public int UpdateSanh(Sanh d)
        {
            int kq = 0;
            if (dAO_Sanh.ThongTinSanh(d.MaSanh) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_Sanh.UpdateSanh(d);
                    kq = 1;
                }
                catch (Exception ee)
                {
                    kq = -1;
                }
            }
            return kq;
        }
        public int DeleteSanh(Sanh d)
        {
            int kq = 0;
            if (dAO_Sanh.ThongTinSanh(d.MaSanh) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_Sanh.DeleteSanh(d);
                    kq = 1;
                }
                catch (Exception ez)
                {
                    kq = -1;
                }
            }
            return kq;
        }
    }
}
