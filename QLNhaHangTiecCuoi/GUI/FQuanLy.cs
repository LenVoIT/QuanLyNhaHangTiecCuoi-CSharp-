using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangTiecCuoi
{
    public partial class FQuanLy : Form
    {
        public FQuanLy()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_QuanLyNV_Click(object sender, EventArgs e)
        {
            UCQuanLyNhanVien uc = new UCQuanLyNhanVien();
            addUserControl(uc);
        }

        private void btn_QuanLyThucAn_Click(object sender, EventArgs e)
        {
            UCQuanLyThucAn uc = new UCQuanLyThucAn();
            addUserControl(uc);
        }

        private void btn_QuanLySanh_Click(object sender, EventArgs e)
        {
            UCQuanLySanh uc = new UCQuanLySanh();
            addUserControl(uc);
        }

        private void btn_QuanLyBoPhan_Click(object sender, EventArgs e)
        {
            UCQuanLyBoPhan uc = new UCQuanLyBoPhan();
            addUserControl(uc);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            dn.Show();
        }

        private void btn_QuanLyDichVu_Click(object sender, EventArgs e)
        {
            UCQuanLyDichVu uc = new UCQuanLyDichVu();
            addUserControl(uc);
        }

        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            UCQuanLyKhachHang uc = new UCQuanLyKhachHang();
            addUserControl(uc);
        }

        private void btn_QuanLyDonDatTiec_Click(object sender, EventArgs e)
        {
            UCQuanLyDatTiec uc = new UCQuanLyDatTiec();
            addUserControl(uc);
        }

        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            UCQuanLyHoaDon uc = new UCQuanLyHoaDon();
            addUserControl(uc);
        }
    }
}
