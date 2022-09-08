using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.BUS;
namespace QLNhaHangTiecCuoi
{
    public partial class UCDatSanh : UserControl
    {
        public string maTiec;
        BUS_DATTIEC bUS_DATTIEC;
        BUS_Sanh bUS_Sanh;
        public UCDatSanh()
        {
            InitializeComponent();
            bUS_DATTIEC = new BUS_DATTIEC();
            bUS_Sanh = new BUS_Sanh();
        }

        private void UCDatSanh_Load(object sender, EventArgs e)
        {
            cbTimKiemSanh.Items.Add("Tìm kiếm theo mã");
            cbTimKiemSanh.Items.Add("Tìm kiếm theo tên");
            cbTimKiemSanh.SelectedIndex = 0;
            cb_Buoi.Items.Add("Sáng");
            cb_Buoi.Items.Add("Tối");
            cb_Buoi.SelectedIndex = 0;
            txt_MaTiec.Text = maTiec;
            txt_MaKH.Text = bUS_DATTIEC.findDatTiec(maTiec).MaKH;
            dgv_DanhSachSanh.DataSource = bUS_Sanh.ListSanh();
            set_UpDgvSanhView();
            this.LoadSanh(maTiec);
        }
        private void LoadSanh(string maTiec)
        {
            DATTIEC d = new DATTIEC();
            d = bUS_DATTIEC.findDatTiec(maTiec);
            if(d.MaSanh != null)
            {    
                Sanh s = new Sanh();
                s = bUS_Sanh.ThongTinSanh(d.MaSanh);
                txt_TenSanh.Text = s.TenSanh;
                txt_Tang.Text = s.Tang;
                txt_SucChua.Text = String.Concat(s.SucChua);
                txt_MaSanh.Text = s.MaSanh;
                txt_GiaThue.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", s.DonGia);
                if (d.Buoi == "Sáng")
                    cb_Buoi.SelectedIndex = 0;
                else
                    cb_Buoi.SelectedIndex = 1;
                dtp_NgayToChuc.Value = (DateTime)d.NgayToChuc;
            }    
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            try
            {
                DATTIEC d = new DATTIEC();
                d.MaTiec = maTiec;
                d.MaSanh = txt_MaSanh.Text;
                d.NgayToChuc = dtp_NgayToChuc.Value;
                d.Buoi = cb_Buoi.Text;
                bUS_DATTIEC.datSanh(d);
                MessageBox.Show("Đặt sảnh thành công!");
            }
            catch (SqlException e1)
            {
                string loi = e1.ToString().Substring(49, 6);
                if (loi == "ERROR1")
                    MessageBox.Show("Bạn phải đặt tiệc trước ít nhất 7 ngày!");
                else if (loi == "ERROR2")
                    MessageBox.Show("Vào thời điểm này sảnh này đã có người đặt! Bạn vui lòng chọn thời điểm khác!");
                else
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void dgv_DanhSachSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaSanh.Text = dgv_DanhSachSanh.Rows[e.RowIndex].Cells["MaSanh"].Value.ToString();
                txt_TenSanh.Text = dgv_DanhSachSanh.Rows[e.RowIndex].Cells["TenSanh"].Value.ToString();
                txt_Tang.Text = dgv_DanhSachSanh.Rows[e.RowIndex].Cells["Tang"].Value.ToString();
                txt_SucChua.Text = dgv_DanhSachSanh.Rows[e.RowIndex].Cells["SucChua"].Value.ToString();
                txt_GiaThue.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachSanh.Rows[e.RowIndex].Cells["DonGia"].Value);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }
        private void set_UpDgvSanhView()
        {
            dgv_DanhSachSanh.Columns[0].Width = (int)(dgv_DanhSachSanh.Width * 0.15);
            dgv_DanhSachSanh.Columns[1].Width = (int)(dgv_DanhSachSanh.Width * 0.30);
            dgv_DanhSachSanh.Columns[2].Width = (int)(dgv_DanhSachSanh.Width * 0.15);
            dgv_DanhSachSanh.Columns[3].Width = (int)(dgv_DanhSachSanh.Width * 0.15);
            dgv_DanhSachSanh.Columns[3].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_DanhSachSanh.Columns[4].Width = (int)(dgv_DanhSachSanh.Width * 0.15);
        }
        private void txt_TimKiemSanh_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemSanh.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachSanh.DataSource = bUS_Sanh.ListSanh();
                set_UpDgvSanhView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaSanh");
                tmp.Columns.Add("TenSanh");
                tmp.Columns.Add("Tang");
                tmp.Columns.Add("DonGia");
                tmp.Columns.Add("SucChua");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachSanh.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cbTimKiemSanh.SelectedIndex == 0)
                    {
                        temp = dgv_DanhSachSanh.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_DanhSachSanh.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachSanh.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachSanh.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv_DanhSachSanh.Rows[i].Cells[2].Value.ToString();
                        row[3] = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VNĐ", dgv_DanhSachSanh.Rows[i].Cells[3].Value);
                        row[4] = dgv_DanhSachSanh.Rows[i].Cells[4].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachSanh.DataSource = tmp;
                set_UpDgvSanhView();
            }
            else
            {
                dgv_DanhSachSanh.DataSource = bUS_Sanh.ListSanh();
                set_UpDgvSanhView();
            }
        }

        private void cb_Buoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // comboBox1 is readonly
            e.Handled = true;
        }
    }
}
