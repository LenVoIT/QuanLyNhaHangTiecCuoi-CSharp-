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
    public partial class FGiaoDienNV : Form
    {
        BUS_ACCOUNT bUS_ACCOUNT;
        public string userName;
        public NHANVIEN n;
        
        public FGiaoDienNV()
        {
            InitializeComponent();
            
        }

        private void FGiaoDienNV_Load(object sender, EventArgs e)
        {

            bUS_ACCOUNT = new BUS_ACCOUNT();
        }

        private void pb_QLDonDatTiec_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 7;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLNhanVien_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 1;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLKhachHang_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 2;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLSanh_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 3;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLBoPhan_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 4;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLThucAn_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 5;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLDichVu_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 6;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void pb_QLHoaDon_Click(object sender, EventArgs e)
        {
            FQuanLy f = new FQuanLy();
            f.BienUc = 8;
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
