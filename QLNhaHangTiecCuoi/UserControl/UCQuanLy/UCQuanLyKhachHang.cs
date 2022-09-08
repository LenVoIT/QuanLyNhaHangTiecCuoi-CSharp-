using QLNhaHangTiecCuoi.BUS;
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

    public partial class UCQuanLyKhachHang : UserControl
    {
        BUS_KHACHHANG bUS_KHACHHANG;
        public string maKH;
        public UCQuanLyKhachHang()
        {
            InitializeComponent();
            bUS_KHACHHANG = new BUS_KHACHHANG();
        }

        private void UCQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            cb_GioiTinh.Items.Add("Nam");
            cb_GioiTinh.Items.Add("Nữ");
            cb_GioiTinh.SelectedIndex = 0;
            cb_TimKiem.Items.Add("Tìm kiếm theo mã");
            cb_TimKiem.Items.Add("Tìm kiếm theo tên");           
            cb_TimKiem.SelectedIndex = 0;
            this.reset();
        }
        private void reset()
        {
            bUS_KHACHHANG = new BUS_KHACHHANG();
            this.txt_CMND.Text = "";
            this.txt_DiaChi.Text = "";
            
            this.txt_SDT.Text = "";
            this.txt_TenKhachHang.Text = "";
            this.cb_GioiTinh.SelectedIndex = 0;
            this.dgv_KhachHang.DataSource = bUS_KHACHHANG.ListKhachHang();
            set_UpDgvKhachHangView();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FDangKyKhachHang f = new FDangKyKhachHang();
            f.ShowDialog();
            reset();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            try
            {
                KHACHHANG d = new KHACHHANG();
                d.MaKH = dgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
                d.TenKH = txt_TenKhachHang.Text;
                d.CMND = txt_CMND.Text;
                d.GioiTinh = cb_GioiTinh.Text;
                d.SDT = txt_SDT.Text;
                d.DiaChi = txt_DiaChi.Text;
                int kq = bUS_KHACHHANG.UpdateKhachHang(d);
                if (kq == 0)
                    MessageBox.Show("Khách hàng cập nhật thành công!");
                else if (kq == 1)
                    MessageBox.Show("Khách hàng cập nhật không thành công!");
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
            }
        }
        private void set_UpDgvKhachHangView()
        {
            dgv_KhachHang.Columns[0].Width = (int)(dgv_KhachHang.Width * 0.12);
            dgv_KhachHang.Columns[1].Width = (int)(dgv_KhachHang.Width * 0.2);
            dgv_KhachHang.Columns[2].Width = (int)(dgv_KhachHang.Width * 0.12);
            dgv_KhachHang.Columns[3].Width = (int)(dgv_KhachHang.Width * 0.12);
            dgv_KhachHang.Columns[4].Width = (int)(dgv_KhachHang.Width * 0.12);
            dgv_KhachHang.Columns[5].Width = (int)(dgv_KhachHang.Width * 0.12);
            dgv_KhachHang.Columns[6].Width = (int)(dgv_KhachHang.Width * 0.10);
            dgv_KhachHang.Columns[7].Visible = false;
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_TenKhachHang.Text = dgv_KhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                if (dgv_KhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString() == "Nam")
                    cb_GioiTinh.SelectedIndex = 0;
                else
                    cb_GioiTinh.SelectedIndex = 1;
                txt_CMND.Text = dgv_KhachHang.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                txt_SDT.Text = dgv_KhachHang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txt_DiaChi.Text = dgv_KhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiem.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_KhachHang.DataSource = bUS_KHACHHANG.ListKhachHang();
                set_UpDgvKhachHangView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaKH");
                tmp.Columns.Add("TenKH");             
                tmp.Columns.Add("GioiTinh"); 
                tmp.Columns.Add("CMND");
                tmp.Columns.Add("SDT");
                tmp.Columns.Add("DiaChi");
                tmp.Columns.Add("UserName");
                tmp.Columns.Add("Null");
                DataRow row;
                for (int i = 0; i <= dgv_KhachHang.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiem.SelectedIndex == 0)
                    {
                        temp = dgv_KhachHang.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_KhachHang.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_KhachHang.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_KhachHang.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv_KhachHang.Rows[i].Cells[2].Value.ToString();
                        row[3] = dgv_KhachHang.Rows[i].Cells[3].Value.ToString();
                        row[4] = dgv_KhachHang.Rows[i].Cells[4].Value.ToString();
                        row[5] = dgv_KhachHang.Rows[i].Cells[5].Value.ToString();
                        row[6] = dgv_KhachHang.Rows[i].Cells[6].Value.ToString();
                        row[7] = dgv_KhachHang.Rows[i].Cells[7].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_KhachHang.DataSource = tmp;
                set_UpDgvKhachHangView();
            }
            else
            {
                dgv_KhachHang.DataSource = bUS_KHACHHANG.ListKhachHang();
                set_UpDgvKhachHangView();
            }

        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_GioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cb_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
