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
using QLNhaHangTiecCuoi.GUI.GUIKhachHang;
namespace QLNhaHangTiecCuoi
{
    public partial class FDatTiec : Form
    {
        UCThongTinDatTiec uc1;
        UCThanhToan uc;
        public KHACHHANG k;
        public FDatTiec()
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
        private void btn_ThongTinDatTiec_Click(object sender, EventArgs e)
        {
            addUserControl(uc1);
        }

        private void btn_DatSanh_Click(object sender, EventArgs e)
        {
            if (uc1.maTiec != null)
            {
                UCDatSanh uc = new UCDatSanh();
                uc.maTiec = uc1.maTiec;
                addUserControl(uc);
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin đặt tiệc trước");
        }

        private void btn_DatThucAn_Click(object sender, EventArgs e)
        {
            if (uc1.maTiec != null)
            {
                UCDatMonAn uc = new UCDatMonAn();
                uc.maTiec = uc1.maTiec;
                addUserControl(uc);
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin đặt tiệc trước");
        }

        private void btn_DatDichVu_Click(object sender, EventArgs e)
        {
            if (uc1.maTiec != null)
            {
                UCDatDichVu uc = new UCDatDichVu();
                uc.maTiec = uc1.maTiec;
                addUserControl(uc);
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin đặt tiệc trước");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (uc1.maTiec != null)
            {
                uc = new UCThanhToan();
                uc.maTiec = uc1.maTiec;
                addUserControl(uc);
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin đặt tiệc trước");
        }

        private void FDatTiec_Load(object sender, EventArgs e)
        {
            uc1 = new UCThongTinDatTiec();
            uc = new UCThanhToan();
            uc1.k = this.k;
            addUserControl(uc1);
            
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            BUS_DATTIEC bUS_DATTIEC = new BUS_DATTIEC();
            if (uc1.maTiec != null)
            {
                if (uc.flag == false)
                {
                    FXacNhan f0 = new FXacNhan();
                    f0.ShowDialog();
                    if (f0.flag == true)
                    {
                            bUS_DATTIEC.xoaDatTiec(uc1.maTiec);
                            MessageBox.Show("Tiệc đang đặt đã bị xóa!");
                            trangChu();
                    }
                }
                else
                {
                    trangChu();
                }
            }
            else
            {
                trangChu();
            }
        }
        public void trangChu()
        {
            FGiaoDienKH f = new FGiaoDienKH();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        public void dangXuat()
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            BUS_DATTIEC bUS_DATTIEC = new BUS_DATTIEC();
            if (uc1.maTiec != null)
            {
                if (uc.flag == false)
                {
                    FXacNhan f0 = new FXacNhan();
                    f0.ShowDialog();
                    if (f0.flag == true)
                    {
                        bUS_DATTIEC.xoaDatTiec(uc1.maTiec);
                        MessageBox.Show("Tiệc đang đặt đã bị xóa!");
                        dangXuat();
                    }
                }
                else
                {
                    dangXuat();
                }
            }
            else
            {
                dangXuat();
            }
        }
    }
}
