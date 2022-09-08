using QLNhaHangTiecCuoi.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.Report;

namespace QLNhaHangTiecCuoi
{
    public partial class UCQuanLySanh : UserControl
    {
        BUS_Sanh bUS_Sanh;
        Sanh d;



        public UCQuanLySanh()
        {
            InitializeComponent();

        }


        public void UCQuanLySanh_Load(object sender, EventArgs e)
        {

            bUS_Sanh = new BUS_Sanh();
            d = new Sanh();
            this.reset();
            cb_TimKiemTheoMuc.Items.Add("Tìm kiếm theo mã");

            cb_TimKiemTheoMuc.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemTheoMuc.SelectedIndex = 0;



        }
        public void reset()
        {
            bUS_Sanh = new BUS_Sanh();
            this.txt_TenSanh.Text = "";
            this.txt_Tang.Text = "";
            this.txt_SoLuongKhach.Text = "";
            this.txt_GiaTien.Text = "";
            this.dgv_DanhSachTimKiem.DataSource = bUS_Sanh.ListSanh();
            this.set_UpDgvSanhView();
        }


        
        private void set_UpDgvSanhView()
        {
            dgv_DanhSachTimKiem.Columns[0].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[1].Width = (int)(dgv_DanhSachTimKiem.Width * 0.30);
            dgv_DanhSachTimKiem.Columns[2].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[3].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[4].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[5].Visible = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                Sanh d1 = new Sanh();

                d1.TenSanh = txt_TenSanh.Text;
                d1.Tang = txt_Tang.Text;
                d1.SucChua = int.Parse(txt_SoLuongKhach.Text);
                d1.DonGia = int.Parse(txt_GiaTien.Text);
                int kq = bUS_Sanh.AddSanh(d1);

                if (kq == 0)
                    MessageBox.Show("Sảnh này tồn tại!");
                else if (kq == 1)
                    MessageBox.Show("Sảnh này đã được thêm thành công!");
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                reset();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            }


        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Sanh s = new Sanh();
                s.MaSanh = dgv_DanhSachTimKiem.CurrentRow.Cells[0].Value.ToString();
                s.TenSanh = txt_TenSanh.Text;
                s.Tang = txt_Tang.Text;
                s.SucChua = int.Parse(txt_SoLuongKhach.Text);
                s.DonGia = int.Parse(txt_GiaTien.Text);

                int kq = bUS_Sanh.UpdateSanh(s);
                if (kq == 0)
                    MessageBox.Show("Sảnh này đã được đặt!");
                else if (kq == 1)
                    MessageBox.Show("Sảnh này đã được sửa thành công!");
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                reset();
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
                Sanh d = new Sanh();
                d.MaSanh = dgv_DanhSachTimKiem.CurrentRow.Cells[0].Value.ToString();
                int kq = bUS_Sanh.DeleteSanh(d);
                if (kq == 0)
                    MessageBox.Show("Sảnh này không tồn tại!");
                else if (kq == 1)
                    MessageBox.Show("Sảnh này đã được xoá thành công!");
                else
                    MessageBox.Show("Xoá sảnh không thành công!");
                reset();
            }
            catch (Exception er)
            {
                MessageBox.Show("Vui lòng chọn sảnh cần xóa!");

            }

        }

        private void txt_TimKiemTheoMuc_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemTheoMuc.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachTimKiem.DataSource = bUS_Sanh.ListSanh();
                set_UpDgvSanhView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaSanh");
                tmp.Columns.Add("TenSanh");
                tmp.Columns.Add("Tang");
                tmp.Columns.Add("DonGia");
                tmp.Columns.Add("SucChua");
                tmp.Columns.Add("Isdeleted");
                DataRow row;
                for (int i = 0; i <= dgv_DanhSachTimKiem.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiemTheoMuc.SelectedIndex == 0)
                    {
                        temp = dgv_DanhSachTimKiem.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_DanhSachTimKiem.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_DanhSachTimKiem.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_DanhSachTimKiem.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv_DanhSachTimKiem.Rows[i].Cells[2].Value.ToString();
                        row[3] = dgv_DanhSachTimKiem.Rows[i].Cells[3].Value.ToString();
                        row[4] = dgv_DanhSachTimKiem.Rows[i].Cells[4].Value.ToString();
                        row[5] = dgv_DanhSachTimKiem.Rows[i].Cells[4].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachTimKiem.DataSource = tmp;
                set_UpDgvSanhView();
            }
            else
            {
                dgv_DanhSachTimKiem.DataSource = bUS_Sanh.ListSanh();
                set_UpDgvSanhView();
            }
        }

        private void dgv_DanhSachTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txt_TenSanh.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["TenSanh"].Value.ToString();
                txt_Tang.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["Tang"].Value.ToString();
                txt_SoLuongKhach.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["SucChua"].Value.ToString();
                txt_GiaTien.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();

            }
            catch (Exception eq)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FReportSanh f = new FReportSanh();
            f.ShowDialog();
        }

        private void txt_SoLuongKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TenSanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cb_TimKiemTheoMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
