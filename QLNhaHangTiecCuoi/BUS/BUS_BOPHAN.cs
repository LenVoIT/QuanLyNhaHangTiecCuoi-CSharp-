using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.DAO;

namespace QLNhaHangTiecCuoi.BUS
{
    class BUS_BOPHAN
    {
        DAO_BOPHAN dAO_BOPHAN;
       
        public BUS_BOPHAN()
        {
            dAO_BOPHAN = new DAO_BOPHAN();
            
            
        }
        public string getMaBoPhan(string ten)
        {
            return dAO_BOPHAN.getMaBoPhan(ten).MaBP;
        }
        public int AddBoPhan(string tenBP)
        {
            int kq = 0;
            if (dAO_BOPHAN.TimBoPhan(tenBP) != null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_BOPHAN.AddBoPhan(tenBP);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }
            return kq;
        }
        public int UpdateBoPhan(BOPHAN d)
        {
            int kq = 0;
            if (dAO_BOPHAN.TimBoPhanByMa(d.MaBP) == null)
            {
                kq = 0;
            }
            else
            {
                try
                {
                    dAO_BOPHAN.UpdateBoPhan(d);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                };
            }

            return kq;
        }
        public int DeleteBoPhan(BOPHAN d)
        {
            int kq = 0;
            if (dAO_BOPHAN.TimBoPhan(d.TenBP) == null)
            {
                kq = 0;
            }
            else
            {

                try
                {
                    dAO_BOPHAN.DeleteBoPhan(d);
                    kq = 1;
                }
                catch (Exception)
                {
                    kq = -1;
                }
            }

            return kq;
        }
        public List<BOPHAN> listBoPhan()
        {
            return dAO_BOPHAN.ListBoPhan();
        }
        
    }
}
