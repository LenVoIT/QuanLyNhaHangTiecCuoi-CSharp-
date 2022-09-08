using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.DAO;

namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_NHANVIEN
    {
        DAO_NhanVien dAO_NhanVien;
        DAO_BOPHAN dAO_BoPhan;
        DAO_ACCOUNT dAO_ACCOUNT;
        public BUS_NHANVIEN()
        {
            dAO_NhanVien = new DAO_NhanVien();
            dAO_BoPhan = new DAO_BOPHAN();
            dAO_ACCOUNT = new DAO_ACCOUNT();
        }
        public void getListChucVu(ComboBox c)
        {
            c.DataSource = dAO_BoPhan.getListChucVu();
            c.DisplayMember = "TenBP";

        }
        public int AddNhanVien(NHANVIEN n, string pass)
        {
            int kq;
            if(dAO_ACCOUNT.checkAccountExists(n.UserName) != null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_NhanVien.AddNhanVien(n, pass);
                    kq = 1;
                }
                catch (Exception e)
                {
                    kq = -1;
                }
            }    
            return kq;
        }
    
        public void GetListNhanVienByBP(DataGridView dg , string MAPB)
        {
            dg.DataSource = dAO_NhanVien.ListNhanVienByBP(MAPB);
        }

        //nguyen
        public void ListNHANVIENs(DataGridView dg)
        {
            dg.DataSource = dAO_NhanVien.NHANVIENList();
        }

        public int UpdateNhanVien(NHANVIEN n)
        {
            int kq = 0;
            if (dAO_NhanVien.FindNhanVien(n.MaNV) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_NhanVien.UpdateNhanVien(n);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }
            return kq;
        }

        public int DeleteNhanVien(NHANVIEN n)
        {
            int kq = 0;
            if (dAO_NhanVien.FindNhanVien(n.MaNV) == null)
            {
                kq = 0;
            }
            else if (dAO_NhanVien.FindNhanVien(n.MaNV) != null)
            {
                try
                {
                    dAO_NhanVien.DeleteNhanVien(n);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }
            return kq;
        }

        public dynamic ListNHANVIENs()
        {
            return dAO_NhanVien.NHANVIENList();
        }
    }
}
