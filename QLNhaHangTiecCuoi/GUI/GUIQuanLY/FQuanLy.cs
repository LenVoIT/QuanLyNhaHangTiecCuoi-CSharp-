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
        public NHANVIEN n;
        public int BienUc;
        UCQuanLyNhanVien uc1 = new UCQuanLyNhanVien();
        UCQuanLyKhachHang uc2 = new UCQuanLyKhachHang();
        UCQuanLySanh uc3 = new UCQuanLySanh();
        UCQuanLyBoPhan uc4 = new UCQuanLyBoPhan();
        UCQuanLyThucAn uc5 = new UCQuanLyThucAn();
        UCQuanLyDichVu uc6 = new UCQuanLyDichVu();
        UCQuanLyDatTiec uc7 = new UCQuanLyDatTiec();
        UCQuanLyHoaDon uc8 = new UCQuanLyHoaDon();
        public FQuanLy()
        {
            InitializeComponent();
        }
        private void FQuanLy_Load(object sender, EventArgs e)
        {
            UCQuanLyNhanVien uc = new UCQuanLyNhanVien();
            switch (BienUc)
            {
                case 1:
                    addUserControl(uc1);
                    break;
                case 2:
                    addUserControl(uc2);
                    break;

                case 3:
                    addUserControl(uc3);
                    break;
                case 4:
                    addUserControl(uc4);
                    break;
                case 5:
                    addUserControl(uc5);
                    break;
                case 6:
                    addUserControl(uc6);
                    break;
                case 7:
                    uc7.n = this.n;
                    addUserControl(uc7);
                    break;
                case 8:
                    addUserControl(uc8);
                    break;

            }

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
            
            addUserControl(uc1);
        }

        private void btn_QuanLyThucAn_Click(object sender, EventArgs e)
        {
            
            addUserControl(uc5);
        }

        private void btn_QuanLySanh_Click(object sender, EventArgs e)
        {
            
            addUserControl(uc3);
        }

        private void btn_QuanLyBoPhan_Click(object sender, EventArgs e)
        {
            uc4 = new UCQuanLyBoPhan();
            addUserControl(uc4);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap dn = new FDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Close();
        }

        private void btn_QuanLyDichVu_Click(object sender, EventArgs e)
        {
            
            addUserControl(uc6);
        }

        private void btn_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
           
            addUserControl(uc2);
        }

        private void btn_QuanLyDonDatTiec_Click(object sender, EventArgs e)
        {
            
            uc7.n = this.n;
            addUserControl(uc7);
        }

        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            
            addUserControl(uc8);
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            FGiaoDienNV f = new FGiaoDienNV();
            f.n = this.n;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
