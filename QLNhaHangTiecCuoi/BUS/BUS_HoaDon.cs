using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHangTiecCuoi.DAO;
namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_HoaDon
    {
        DAO_HoaDon dAO_HoaDon;
        public BUS_HoaDon()
        {
            dAO_HoaDon = new DAO_HoaDon();
        }
        public HOADON getHoaDon(string maTiec)
        {
            return dAO_HoaDon.GetHoaDon(maTiec);
        }
        public List<HOADON> ListHoaDon()
        {
            return dAO_HoaDon.ListAllHoaDon();
        }
        public List<HOADON> ListHoaDonByTime(DateTime from, DateTime to)
        {
            return dAO_HoaDon.ListHoaDonByTime(from, to);
        }
        public void updateHD(HOADON h)
        {
            dAO_HoaDon.updateHD(h);
        }
    }
}
