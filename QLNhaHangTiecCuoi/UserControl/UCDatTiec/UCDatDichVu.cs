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
    public partial class UCDatDichVu : UserControl
    {
        public string maTiec;
        BUS_DichVu bUS_DichVu;
        BUS_DatDichVu bUS_DatDichVu;

        public UCDatDichVu()
        {
            InitializeComponent();
            bUS_DichVu = new BUS_DichVu();
            bUS_DatDichVu = new BUS_DatDichVu();
        }

        private void UCDatDichVu_Load(object sender, EventArgs e)
        {
            this.txt_MaTiec.Text = maTiec;
            this.reset();
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDaChon.SelectedIndex = 0;
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDichVu.SelectedIndex = 0;
        }
        private void set_UpDgvDichVuView()
        {
            dgv_DanhSachDichVu.Columns[0].Width = (int)(dgv_DanhSachDichVu.Width * 0.2);
            dgv_DanhSachDichVu.Columns[1].Width = (int)(dgv_DanhSachDichVu.Width * 0.45);
            dgv_DanhSachDichVu.Columns[2].Width = (int)(dgv_DanhSachDichVu.Width * 0.3);
            dgv_DanhSachDichVu.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
        }
        private void set_UpDgvDichVuChonView()
        {
            dgv_DanhSachDichVuChon.Columns[0].Width = (int)(dgv_DanhSachDichVuChon.Width * 0.2);
            dgv_DanhSachDichVuChon.Columns[1].Width = (int)(dgv_DanhSachDichVuChon.Width * 0.35);
            dgv_DanhSachDichVuChon.Columns[2].Width = (int)(dgv_DanhSachDichVuChon.Width * 0.3);
            dgv_DanhSachDichVuChon.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
        }

        private void dgv_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_DichVuChon.Text = dgv_DanhSachDichVu.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
                txt_GiaTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachDichVu.Rows[e.RowIndex].Cells["DonGia"].Value);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }
        public void reset()
        {
            txt_DichVuChon.Text = "";
            txt_GiaTien.Text = "";
            dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
            set_UpDgvDichVuView();
            dgv_DanhSachDichVuChon.DataSource = bUS_DatDichVu.ListDatDichVu(maTiec);
            set_UpDgvDichVuChonView();
            txt_TongSoLuong.Text = string.Concat(bUS_DatDichVu.SoLuongDichVu(maTiec));
            txt_ThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", TongTien());
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DATDICHVU d = new DATDICHVU();
            d.MaTiec = txt_MaTiec.Text;
            d.MaDV = txt_DichVuChon.Text;
            int kq = bUS_DatDichVu.AddDichVu(d);
            if (kq == 0)
                MessageBox.Show("Dịch vụ này đã được đặt!");
            else if (kq == 1)
                MessageBox.Show("Dịch vụ này đã được thêm thành công!");
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            reset();
        }
        public int TongTien()
        {
            int tongTien = 0;
            for(int i = 0; i < int.Parse(txt_TongSoLuong.Text); i++)
            {
                tongTien += int.Parse(dgv_DanhSachDichVuChon.Rows[i].Cells["DonGia"].Value.ToString());
            }
            return tongTien;
        }
        private void dgv_DanhSachDichVuChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_DichVuChon.Text = dgv_DanhSachDichVuChon.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
                txt_GiaTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachDichVuChon.Rows[e.RowIndex].Cells["DonGia"].Value);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DATDICHVU d = new DATDICHVU();
            d.MaTiec = txt_MaTiec.Text;
            d.MaDV = txt_DichVuChon.Text;
            int kq = bUS_DatDichVu.DeleteDichVu(d);
            if (kq == 0)
                MessageBox.Show("Dịch vụ này không tồn tại!");
            else if (kq == 1)
                MessageBox.Show("Dịch vụ này đã được xóa thành công!");
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            reset();
        }

        private void txt_TimKiemDanhSachDichVu_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemDanhSachDichVu.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
                set_UpDgvDichVuView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaDV");
                tmp.Columns.Add("TenDV");
                tmp.Columns.Add("DonGia");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachDichVu.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemDichVu.SelectedIndex == 0)
                    {
                        temp = dgv_DanhSachDichVu.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_DanhSachDichVu.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachDichVu.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachDichVu.Rows[i].Cells[1].Value.ToString();
                        row[2] = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachDichVu.Rows[i].Cells[2].Value);
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachDichVu.DataSource = tmp;
                set_UpDgvDichVuView();
            }
            else
            {
                dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
                set_UpDgvDichVuView();
            }
        }

        private void txt_TimKiemDanhSachDaChon_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemDanhSachDaChon.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachDichVuChon.DataSource = bUS_DatDichVu.ListDatDichVu(maTiec);
                set_UpDgvDichVuChonView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaDV");
                tmp.Columns.Add("TenDV");
                tmp.Columns.Add("DonGia");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachDichVuChon.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemDaChon.SelectedIndex == 0)
                    {
                        temp = dgv_DanhSachDichVuChon.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_DanhSachDichVuChon.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachDichVuChon.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachDichVuChon.Rows[i].Cells[1].Value.ToString();
                        row[2] = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachDichVuChon.Rows[i].Cells[2].Value);
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachDichVuChon.DataSource = tmp;
                set_UpDgvDichVuChonView();
            }
            else
            {
                dgv_DanhSachDichVuChon.DataSource = bUS_DatDichVu.ListDatDichVu(maTiec);
                set_UpDgvDichVuChonView();
            }
        }

        private void txt_TongSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
