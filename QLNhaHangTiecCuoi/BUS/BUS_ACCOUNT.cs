using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHangTiecCuoi.DAO;


namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_ACCOUNT
    {
        DAO_ACCOUNT dAO_ACCOUNT;
        public BUS_ACCOUNT()
        {
            dAO_ACCOUNT = new DAO_ACCOUNT();

        }
        public int checkACCOUNT(ACCOUNT a, string type)
        {
            int kq = 0;
            if (dAO_ACCOUNT.getACCOUNT(a, type) != null)
            {
                kq = 1;
            }
            else
            {
                kq = -1;
            }
            return kq;
        }
        
        public KHACHHANG getKhachHangByUserName(string us)
        {
            return dAO_ACCOUNT.GetKhachHangByuserName(us);
        }
        public NHANVIEN getNhanVienByUserName(string us)
        {
            return dAO_ACCOUNT.GetNhanVienByuserName(us);
        }
    }
}
