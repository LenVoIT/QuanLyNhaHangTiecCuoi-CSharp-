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
    public partial class FThongTinKH : Form
    {
        public KHACHHANG k;
        public FThongTinKH()
        {
            InitializeComponent();
        }

        private void FThongTinKH_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = k.UserName;
            txt_HoTen.Text = k.TenKH;
            txt_MaKH.Text = k.MaKH;
            txt_HoTen1.Text = k.TenKH;
            txt_GioiTinh.Text = k.GioiTinh;
            txt_SDT.Text = k.SDT;
            txt_CMND.Text = k.CMND;
            txt_DiaChi.Text = k.DiaChi;
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            FGiaoDienKH f = new FGiaoDienKH();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            FDoiMK f = new FDoiMK();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
