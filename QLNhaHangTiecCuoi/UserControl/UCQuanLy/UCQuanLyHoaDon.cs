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
    public partial class UCQuanLyHoaDon : UserControl
    {
        BUS_HoaDon bUS_HoaDon;
        public UCQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void UCQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            bUS_HoaDon = new BUS_HoaDon();
            cb_DanhSachHoaDon.Items.Add("Toàn bộ hóa đơn");
            cb_DanhSachHoaDon.Items.Add("Danh sách hóa đơn theo thời gian");
            cb_DanhSachHoaDon.SelectedIndex = 0;
            dgv_DanhSachHD.DataSource = bUS_HoaDon.ListHoaDon();
            set_UpDgvHoaDonView();
            txt_DoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", doanhThu());

        }
        private int doanhThu()
        {
            int sum = 0;
            for(int i = 0; i < dgv_DanhSachHD.Rows.Count; i++)
            {
                sum += int.Parse(dgv_DanhSachHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            return sum;
        }

        private void dgv_DanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaHoaDon.Text = dgv_DanhSachHD.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                txt_NgayLap.Text = dgv_DanhSachHD.Rows[e.RowIndex].Cells["NgayLap"].Value.ToString();
                txt_ThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachHD.Rows[e.RowIndex].Cells["ThanhTien"].Value);
                txt_TinhTrang.Text = dgv_DanhSachHD.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                txt_MaTiec.Text = dgv_DanhSachHD.Rows[e.RowIndex].Cells["MaTiec"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }
        private void set_UpDgvHoaDonView()
        {
            dgv_DanhSachHD.Columns[0].Width = (int)(dgv_DanhSachHD.Width * 0.15);
            dgv_DanhSachHD.Columns[1].Width = (int)(dgv_DanhSachHD.Width * 0.15);
            dgv_DanhSachHD.Columns[2].Width = (int)(dgv_DanhSachHD.Width * 0.23);
            dgv_DanhSachHD.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_DanhSachHD.Columns[3].Width = (int)(dgv_DanhSachHD.Width * 0.22);
            dgv_DanhSachHD.Columns[4].Width = (int)(dgv_DanhSachHD.Width * 0.19);
            dgv_DanhSachHD.Columns[5].Visible = false;
        }
        private void cb_DanhSachHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_DanhSachHoaDon.SelectedIndex == 0)
            {
                dgv_DanhSachHD.DataSource = bUS_HoaDon.ListHoaDon();
                set_UpDgvHoaDonView();
                txt_DoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", doanhThu());
            }
            else
            {
                dgv_DanhSachHD.DataSource = bUS_HoaDon.ListHoaDonByTime(dtp_From.Value, dtp_To.Value);
                set_UpDgvHoaDonView();
                txt_DoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", doanhThu());
            }    
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            if(cb_DanhSachHoaDon.SelectedIndex == 1)
            {
                dgv_DanhSachHD.DataSource = bUS_HoaDon.ListHoaDonByTime(dtp_From.Value, dtp_To.Value);
                set_UpDgvHoaDonView();
                txt_DoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", doanhThu());
            }    
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            if (cb_DanhSachHoaDon.SelectedIndex == 1)
            {
                dgv_DanhSachHD.DataSource = bUS_HoaDon.ListHoaDonByTime(dtp_From.Value, dtp_To.Value);
                set_UpDgvHoaDonView();
                txt_DoanhThu.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", doanhThu());
            }
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            if (txt_MaTiec.Text != "")
            {
                FChiTietDatTiec f = new FChiTietDatTiec();
                f.maTiec = txt_MaTiec.Text;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 hóa đơn!");
        }

        private void cb_DanhSachHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
