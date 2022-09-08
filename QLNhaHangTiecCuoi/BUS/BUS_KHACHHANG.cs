using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNhaHangTiecCuoi.DAO;
using System.Threading.Tasks;

namespace QLNhaHangTiecCuoi.BUS
{
    
    class BUS_KHACHHANG
    {
        DAO_KhachHang dAO_KHACHHANG;
        DAO_ACCOUNT dAO_ACCOUNT;
        public BUS_KHACHHANG()
        {
            dAO_KHACHHANG = new DAO_KhachHang();
            dAO_ACCOUNT = new DAO_ACCOUNT();
        }
        public KHACHHANG getKHACHHANG(string maKH)
        {
            KHACHHANG k = dAO_KHACHHANG.GetKhachHang(maKH);
            return k;
        }
        public int AddKhachHang(KHACHHANG t, string pas)
        {
            int kq;
            if (dAO_ACCOUNT.checkAccountExists(t.UserName) != null)
                
            {
                kq = 0; // đã tồn tịa
            }    
            else
            {
                try
                {
                    dAO_KHACHHANG.AddKhachHang(t, pas);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;

                }
            }    
            return kq;
        }

        //SANG
        public List<KHACHHANG> ListKhachHang()
        {
            return dAO_KHACHHANG.ListKhachHang();
        }
        public int UpdateKhachHang(KHACHHANG d)
        {
            int kq = 0;
            if (dAO_KHACHHANG.FindKhachHang(d.MaKH) != null)
            {
                dAO_KHACHHANG.UpdateKhachHang(d);
                kq = 0;
            }
            else
            {
                try
                {

                    kq = 1;
                }
                catch (Exception eq)
                {
                    kq = -1;
                }
            }
            return kq;
        }
    }
}
