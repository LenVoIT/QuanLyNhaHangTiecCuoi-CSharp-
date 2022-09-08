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
    public partial class UCDatMonAn : UserControl
    {
        BUS_DatMonAn bUS_DatMonAn;
        BUS_MonAn bUS_MonAn;
        public string maTiec;
        public UCDatMonAn()
        {
            InitializeComponent();
            
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemDanhSachMonAn.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachMonAn.DataSource = bUS_MonAn.ListMonAn();
                set_UpDgvMonAnView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaMA");
                tmp.Columns.Add("TenMA");
                tmp.Columns.Add("DonGia");
                tmp.Columns.Add("Loai");
                tmp.Columns.Add("DonViTinh");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachMonAn.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemMonAn.SelectedIndex == 0)
                    {
                        temp = dgv_DanhSachMonAn.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_DanhSachMonAn.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachMonAn.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachMonAn.Rows[i].Cells[1].Value.ToString();
                        row[2] = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachMonAn.Rows[i].Cells[2].Value);
                        row[3] = dgv_DanhSachMonAn.Rows[i].Cells[3].Value.ToString();
                        row[4] = dgv_DanhSachMonAn.Rows[i].Cells[4].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachMonAn.DataSource = tmp;
                set_UpDgvMonAnView();
            }
            else
            {
                dgv_DanhSachMonAn.DataSource = bUS_MonAn.ListMonAn();
                set_UpDgvMonAnView();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (int.Parse(txt_SoLuongMonAn.Text) != 0)
                    {
                        DATMONAN d = new DATMONAN();
                        d.MaTiec = txt_MaTiec.Text;
                        d.MaMA = txt_MonAnChon.Text;
                        d.SoLuong = int.Parse(txt_SoLuongMonAn.Text);
                        int kq = bUS_DatMonAn.addDatMon(d);
                        if (kq == 0)
                            MessageBox.Show("Món này đã được thêm vào thực đơn!");
                        else if (kq == 1)
                            MessageBox.Show("Thêm món ăn thành công!");
                        else
                            MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!");
                        this.Reset();
                    }
                    else
                    {
                        MessageBox.Show("vui lòng nhập khác 0!");
                    }
            }
                catch (Exception e1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                    
            
        }
        private void set_UpDgvMonAnChonView()
        {
            dgv_DanhSachMonAnChon.Columns[0].Width = (int)(dgv_DanhSachMonAnChon.Width * 0.2);
            dgv_DanhSachMonAnChon.Columns[1].Width = (int)(dgv_DanhSachMonAnChon.Width * 0.23);
            dgv_DanhSachMonAnChon.Columns[2].Width = (int)(dgv_DanhSachMonAnChon.Width * 0.23);
            dgv_DanhSachMonAnChon.Columns[3].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_DanhSachMonAnChon.Columns[3].Width = (int)(dgv_DanhSachMonAnChon.Width * 0.23);
        }
        private void set_UpDgvMonAnView()
        {
            dgv_DanhSachMonAn.Columns[0].Width = (int)(dgv_DanhSachMonAn.Width * 0.12);
            dgv_DanhSachMonAn.Columns[1].Width = (int)(dgv_DanhSachMonAn.Width * 0.30);
            dgv_DanhSachMonAn.Columns[2].Width = (int)(dgv_DanhSachMonAn.Width * 0.18);
            dgv_DanhSachMonAn.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_DanhSachMonAn.Columns[3].Width = (int)(dgv_DanhSachMonAn.Width * 0.18);
            dgv_DanhSachMonAn.Columns[4].Width = (int)(dgv_DanhSachMonAn.Width * 0.18);
        }
        private void Reset()
        {
            this.txt_MonAnChon.Text = "";
            this.txt_SoLuongMonAn.Text = "";
            this.txt_TongSoLuong.Text = string.Concat(bUS_DatMonAn.TongSoLuongMon(maTiec));
            this.txt_ThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", bUS_DatMonAn.TongThanhTien(maTiec));
            this.dgv_DanhSachMonAnChon.DataSource = bUS_DatMonAn.ListDatMon(maTiec);
            this.set_UpDgvMonAnChonView();
            this.dgv_DanhSachMonAn.DataSource = bUS_MonAn.ListMonAn();
            this.set_UpDgvMonAnView();
        }
        private void UCDatMonAn_Load(object sender, EventArgs e)
        {
            txt_MaTiec.Text = maTiec;
            bUS_DatMonAn = new BUS_DatMonAn();
            bUS_MonAn = new BUS_MonAn();
            this.Reset();
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDaChon.SelectedIndex = 0;
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemMonAn.SelectedIndex = 0;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (int.Parse(txt_SoLuongMonAn.Text) != 0)
                    {
                        DATMONAN d = new DATMONAN();
                        d.MaTiec = txt_MaTiec.Text;
                        d.MaMA = txt_MonAnChon.Text;
                        d.SoLuong = int.Parse(txt_SoLuongMonAn.Text);
                        int kq = bUS_DatMonAn.updateDatMon(d);
                        if (kq == 0)
                            MessageBox.Show("Không có món này trong danh sách!");
                        else if (kq == 1)
                            MessageBox.Show("Cập nhật món thành công!");
                        else
                            MessageBox.Show("Cập nhật món không thành công!");
                        this.Reset();
                    }
                    else
                    {
                        MessageBox.Show("vui lòng nhập khác 0!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
               
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DATMONAN d = new DATMONAN();
                d.MaTiec = txt_MaTiec.Text;
                d.MaMA = txt_MonAnChon.Text;
                int kq = bUS_DatMonAn.deleteDatMon(d);
                if (kq == 0)
                    MessageBox.Show("Không có món này trong danh sách!");
                else if (kq == 1)
                    MessageBox.Show("Xóa món ăn thành công!");
                else
                    MessageBox.Show("Xóa món ăn không thành công!");
                this.Reset();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
            }
        }

        private void dgv_DanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MonAnChon.Text = dgv_DanhSachMonAn.Rows[e.RowIndex].Cells["MaMA"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn ô tương ứng!");
            }
        }

        private void dgv_DanhSachMonAnChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MonAnChon.Text = dgv_DanhSachMonAnChon.Rows[e.RowIndex].Cells["MaMA"].Value.ToString();
                txt_SoLuongMonAn.Text = dgv_DanhSachMonAnChon.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn ô tương ứng!");
            }
        }

        private void txt_TimKiemDanhSachChon_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemDanhSachDaChon.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachMonAnChon.DataSource = bUS_DatMonAn.ListDatMon(maTiec);
                set_UpDgvMonAnChonView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaTiec");
                tmp.Columns.Add("MaMA");
                tmp.Columns.Add("SoLuong");
                tmp.Columns.Add("ThanhTien");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachMonAnChon.Rows.Count - 1; i++)
                {
                    string temp;
                    temp = dgv_DanhSachMonAnChon.Rows[i].Cells[1].Value.ToString().ToLower();
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachMonAnChon.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachMonAnChon.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv_DanhSachMonAnChon.Rows[i].Cells[2].Value.ToString();
                        row[3] = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachMonAnChon.Rows[i].Cells[3].Value);
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachMonAnChon.DataSource = tmp;
                set_UpDgvMonAnChonView();
            }
            else
            {
                dgv_DanhSachMonAnChon.DataSource = bUS_DatMonAn.ListDatMon(maTiec);
                set_UpDgvMonAnChonView();
            }
        }

        private void txt_SoLuongMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TongSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
