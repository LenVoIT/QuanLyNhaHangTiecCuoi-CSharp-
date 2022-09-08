using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.DAO;


namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_DATTIEC
    {
        DAO_DatTiec dAO_DATTIEC;
        public BUS_DATTIEC()
        {
            dAO_DATTIEC = new DAO_DatTiec();
        }
        
        public DATTIEC findDatTiec(string maTiec)
        {
            return dAO_DATTIEC.FindDatTiec(maTiec);
        }
        public int AddDatTiec(DATTIEC d)
        {
            int kq = 0;
            if (dAO_DATTIEC.FindDatTiec(d.MaTiec) != null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_DATTIEC.AddDatTiec(d);
                    kq = 1;
                }
                catch (Exception e)
                {

                    kq = -1;
                }
                
            }

            return kq;
            
        }
        public String Max_Tiec()
        {
            string maMax = dAO_DATTIEC.Max_Tiec();
            return maMax;
        }
        public int UpdateTiec(DATTIEC d)
        {
            int kq = 0;
            if (dAO_DATTIEC.FindDatTiec(d.MaTiec) == null)
            {
                kq = 0;
            }
            else if (dAO_DATTIEC.FindDatTiec(d.MaTiec) != null)
            {
                try
                {
                    dAO_DATTIEC.UpdateThongTinDatTiec(d);
                    kq = 1;
                }
                catch (Exception ez)
                {

                    kq = -1;
                }

            }
            return kq;
        }
        public string maSanhDaDat(DATTIEC d)
        {
            return dAO_DATTIEC.maSanh(d);
        }
        public void datSanh(DATTIEC d)
        {

            dAO_DATTIEC.AddSanh(d);
        }
        public void getListDatTiec(string maKH, DataGridView dg)
        {
            dg.DataSource = dAO_DATTIEC.getListDatTiec(maKH);
        }
        public void xoaDatTiec(string maTiec)
        {
            dAO_DATTIEC.DeleteDatTiec(maTiec);
        }
        public void getListDatTiecByTinhTrang(string tinhTrang, DataGridView dg)
        {
            dg.DataSource = dAO_DATTIEC.getListDatTiecByTinhTrang(tinhTrang);
        }
        public void updateTinhTrangTiec(DATTIEC d)
        {
            dAO_DATTIEC.updateTinhTrangTiec(d);
        }
    }
}
