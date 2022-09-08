using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.BUS;
namespace QLNhaHangTiecCuoi
{
    public partial class UCThanhToan : UserControl
    {
        public string maTiec;
        BUS_DATTIEC bUS_DatTiec;
        BUS_DatDichVu bUS_DatDichVu;
        BUS_DatMonAn bUS_DatMonAn;
        BUS_KHACHHANG bUS_KhachHang;
        BUS_Sanh bUS_Sanh;
        BUS_HoaDon bUS_HoaDon;
        KHACHHANG k;
        HOADON h;
        public bool flag;
        public UCThanhToan()
        {
            InitializeComponent();
            bUS_DatTiec = new BUS_DATTIEC();
            bUS_DatDichVu = new BUS_DatDichVu();
            bUS_DatMonAn = new BUS_DatMonAn();
            bUS_KhachHang = new BUS_KHACHHANG();
            bUS_Sanh = new BUS_Sanh();
            bUS_HoaDon = new BUS_HoaDon();
            flag = false;
        }

        private void UCThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                DATTIEC d = new DATTIEC();
                h = new HOADON();
                d = bUS_DatTiec.findDatTiec(maTiec);
                k = new KHACHHANG();
                k = bUS_KhachHang.getKHACHHANG(d.MaKH);
                h = bUS_HoaDon.getHoaDon(maTiec);
                Sanh s = new Sanh();
                s = bUS_Sanh.ThongTinSanh(d.MaSanh);
                dgv_DichVu.DataSource = bUS_DatDichVu.ListDatDichVu(d.MaTiec);
                dgv_DichVu.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
                dgv_MonAn.DataSource = bUS_DatMonAn.ListDatMon(d.MaTiec);
                dgv_MonAn.Columns[3].DefaultCellStyle.Format = "0#,##0 VNĐ";
                txt_HoTen.Text = k.TenKH;
                txt_MaKH.Text = k.MaKH;
                txt_CMND.Text = k.CMND;
                txt_SDT.Text = k.SDT;
                txt_MaSanh.Text = d.MaSanh;
                txt_NgayDatTiec.Text = d.NgayDat.ToString();
                txt_NgayToChuc.Text = d.NgayToChuc.ToString();
                txt_Buoi.Text = d.Buoi;
                if(s != null)
                    txt_TenSanh.Text = s.TenSanh;
                txt_SoLuongBan.Text = string.Concat(d.SoLuongBan);
                txt_TongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", h.ThanhTien);
            }
            catch (Exception e1)
            {
                
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin trước");
            }
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_MaSanh.Text != "")
            {
                flag = true;
                bUS_HoaDon.updateHD(h);
                MessageBox.Show("Thanh toán thành công!");
            }
            else
                MessageBox.Show("Bạn vui lòng chọn sảnh cưới!");
        }
    }
}
