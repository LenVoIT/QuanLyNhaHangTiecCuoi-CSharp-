using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.BUS;


namespace QLNhaHangTiecCuoi
{
    public partial class FGiaoDienKH : Form
    {

        BUS_ACCOUNT bUS_ACCOUNT = new BUS_ACCOUNT();
       
        public KHACHHANG k;

       
        public FGiaoDienKH()
        {
            InitializeComponent();
        }


        private void pb_DatTiecCuoi_Click(object sender, EventArgs e)
        {
            
            FDatTiec f = new FDatTiec();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void FGiaoDienKH_Load(object sender, EventArgs e)
        {
            
        }
        private void pb_TiecDaDat_Click(object sender, EventArgs e)
        {
            FTiecDaDat f = new FTiecDaDat();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_ThongTin_Click(object sender, EventArgs e)
        {
            FThongTinKH f = new FThongTinKH();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
