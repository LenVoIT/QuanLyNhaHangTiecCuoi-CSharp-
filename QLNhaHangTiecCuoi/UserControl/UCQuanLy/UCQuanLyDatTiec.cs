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
    public partial class UCQuanLyDatTiec : UserControl
    {
        public NHANVIEN n;
        BUS_DATTIEC bUS_DATTIEC;
        BUS_HoaDon bUS_HoaDon;
        public UCQuanLyDatTiec()
        {
            InitializeComponent();
            
        }


        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(txt_MaTiec.Text != "")
            {    
                DATTIEC d = new DATTIEC();
                d.MaTiec = txt_MaTiec.Text;
                d.MaNV = n.MaNV;
                d.TinhTrang = "Đã xác nhận";
                bUS_DATTIEC.updateTinhTrangTiec(d);
                reset();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tiệc!");
            }
        }
        private void reset()
        {
            txt_MaTiec.Text = "";
            txt_MaKhachHang.Text = "";
            txt_NgayDatTiec.Text = "";
            txt_NgayToChuc.Text = "";
            txt_ThanhTien.Text = "";
            bUS_DATTIEC.getListDatTiecByTinhTrang("Chưa xác nhận", dgvDanhSachChuaXacNhan);
            bUS_DATTIEC.getListDatTiecByTinhTrang("Đã xác nhận", dgvDanhSachDaXacNhan);
            setUp_DanhSachChuaXacNhan();
            setUp_DanhSachDaXacNhan();
        }

        private void dgvDanhSachChuaXacNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaTiec.Text = dgvDanhSachChuaXacNhan.CurrentRow.Cells[0].Value.ToString();
                txt_MaKhachHang.Text = dgvDanhSachChuaXacNhan.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                txt_NgayDatTiec.Text = dgvDanhSachChuaXacNhan.Rows[e.RowIndex].Cells["NgayDat"].Value.ToString();
                txt_NgayToChuc.Text = dgvDanhSachChuaXacNhan.Rows[e.RowIndex].Cells["NgayToChuc"].Value.ToString();
                txt_ThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", bUS_HoaDon.getHoaDon(txt_MaTiec.Text).ThanhTien);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn ô tương ứng!");
            }
        }
        private void setUp_DanhSachChuaXacNhan()
        {
            dgvDanhSachChuaXacNhan.Columns[0].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.1);
            dgvDanhSachChuaXacNhan.Columns[1].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.20);
            dgvDanhSachChuaXacNhan.Columns[2].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.09);
            dgvDanhSachChuaXacNhan.Columns[3].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.09);
            dgvDanhSachChuaXacNhan.Columns[4].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.1);
            dgvDanhSachChuaXacNhan.Columns[5].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.13);
            dgvDanhSachChuaXacNhan.Columns[6].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.13);
            dgvDanhSachChuaXacNhan.Columns[7].Width = (int)(dgvDanhSachChuaXacNhan.Width * 0.15);
        }
        private void setUp_DanhSachDaXacNhan()
        {
            dgvDanhSachDaXacNhan.Columns[0].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.1);
            dgvDanhSachDaXacNhan.Columns[1].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.20);
            dgvDanhSachDaXacNhan.Columns[2].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.09);
            dgvDanhSachDaXacNhan.Columns[3].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.09);
            dgvDanhSachDaXacNhan.Columns[4].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.1);
            dgvDanhSachDaXacNhan.Columns[5].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.13);
            dgvDanhSachDaXacNhan.Columns[6].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.13);
            dgvDanhSachDaXacNhan.Columns[7].Width = (int)(dgvDanhSachDaXacNhan.Width * 0.15);
        }

        private void UCQuanLyDatTiec_Load(object sender, EventArgs e)
        {
            cb_TimKiemChuaXacNhan.Items.Add("Tìm kiếm theo mã tiệc");
            cb_TimKiemChuaXacNhan.Items.Add("Tìm kiếm theo mã KH");
            cb_TimKiemChuaXacNhan.SelectedIndex = 0;
            cb_TimKiemDaXacNhan.Items.Add("Tìm kiếm theo mã tiệc");
            cb_TimKiemDaXacNhan.Items.Add("Tìm kiếm theo mã KH");
            cb_TimKiemDaXacNhan.SelectedIndex = 0;
            bUS_DATTIEC = new BUS_DATTIEC();
            bUS_HoaDon = new BUS_HoaDon();
            reset();
        }

        private void dgvDanhSachDaXacNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaTiec.Text = dgvDanhSachDaXacNhan.CurrentRow.Cells[0].Value.ToString();
                txt_MaKhachHang.Text = dgvDanhSachDaXacNhan.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                txt_NgayDatTiec.Text = dgvDanhSachDaXacNhan.Rows[e.RowIndex].Cells["NgayDat"].Value.ToString();
                txt_NgayToChuc.Text = dgvDanhSachDaXacNhan.Rows[e.RowIndex].Cells["NgayToChuc"].Value.ToString();
                txt_ThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", bUS_HoaDon.getHoaDon(txt_MaTiec.Text).ThanhTien);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Vui lòng chọn ô tương ứng!");
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
                MessageBox.Show("Vui lòng chọn 1 tiệc!");
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaTiec.Text != "")
            {
                string maTiec = txt_MaTiec.Text;
                bUS_DATTIEC.xoaDatTiec(maTiec);
                MessageBox.Show("Xóa thành công!");
                reset();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 tiệc!");
        }

        private void txtTimKiemChuaXacNhan_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiemChuaXacNhan.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                bUS_DATTIEC.getListDatTiecByTinhTrang("Chưa xác nhận", dgvDanhSachChuaXacNhan);
                setUp_DanhSachChuaXacNhan();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaTiec");
                tmp.Columns.Add("TenTiec");
                tmp.Columns.Add("MaKH");
                tmp.Columns.Add("MaNV");
                tmp.Columns.Add("MaSanh");
                tmp.Columns.Add("NgayDat");
                tmp.Columns.Add("NgayToChuc");
                tmp.Columns.Add("TinhTrang");
                DataRow row;
                for (int i = 0; i <= dgvDanhSachChuaXacNhan.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemChuaXacNhan.SelectedIndex == 0)
                    {
                        temp = dgvDanhSachChuaXacNhan.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgvDanhSachChuaXacNhan.Rows[i].Cells[2].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgvDanhSachChuaXacNhan.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgvDanhSachChuaXacNhan.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgvDanhSachChuaXacNhan.Rows[i].Cells[2].Value.ToString();
                        row[4] = dgvDanhSachChuaXacNhan.Rows[i].Cells[4].Value.ToString();
                        row[5] = dgvDanhSachChuaXacNhan.Rows[i].Cells[5].Value.ToString();
                        row[6] = dgvDanhSachChuaXacNhan.Rows[i].Cells[6].Value.ToString();
                        row[7] = dgvDanhSachChuaXacNhan.Rows[i].Cells[7].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgvDanhSachChuaXacNhan.DataSource = tmp;
                setUp_DanhSachChuaXacNhan();
            }
            else
            {
                bUS_DATTIEC.getListDatTiecByTinhTrang("Chưa xác nhận", dgvDanhSachChuaXacNhan);
                setUp_DanhSachChuaXacNhan();
            }
        }

        private void txt_TimKiemDaXacNhan_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemDaXacNhan.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                bUS_DATTIEC.getListDatTiecByTinhTrang("Đã xác nhận", dgvDanhSachDaXacNhan);
                setUp_DanhSachDaXacNhan();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaTiec");
                tmp.Columns.Add("TenTiec");
                tmp.Columns.Add("MaKH");
                tmp.Columns.Add("MaNV");
                tmp.Columns.Add("MaSanh");
                tmp.Columns.Add("NgayDat");
                tmp.Columns.Add("NgayToChuc");
                tmp.Columns.Add("TinhTrang");
                DataRow row;
                for (int i = 0; i <= dgvDanhSachDaXacNhan.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemDaXacNhan.SelectedIndex == 0)
                    {
                        temp = dgvDanhSachDaXacNhan.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgvDanhSachDaXacNhan.Rows[i].Cells[2].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgvDanhSachDaXacNhan.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgvDanhSachDaXacNhan.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgvDanhSachDaXacNhan.Rows[i].Cells[2].Value.ToString();
                        row[3] = dgvDanhSachDaXacNhan.Rows[i].Cells[3].Value.ToString();
                        row[4] = dgvDanhSachDaXacNhan.Rows[i].Cells[4].Value.ToString();
                        row[5] = dgvDanhSachDaXacNhan.Rows[i].Cells[5].Value.ToString();
                        row[6] = dgvDanhSachDaXacNhan.Rows[i].Cells[6].Value.ToString();
                        row[7] = dgvDanhSachDaXacNhan.Rows[i].Cells[7].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgvDanhSachDaXacNhan.DataSource = tmp;
                setUp_DanhSachDaXacNhan();
            }
            else
            {
                bUS_DATTIEC.getListDatTiecByTinhTrang("Đã xác nhận", dgvDanhSachDaXacNhan);
                setUp_DanhSachDaXacNhan();
            }
        }

        private void cb_TimKiemChuaXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
