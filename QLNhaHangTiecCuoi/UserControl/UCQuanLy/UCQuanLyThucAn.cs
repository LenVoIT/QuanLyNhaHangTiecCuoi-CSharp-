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
using QLNhaHangTiecCuoi.Report;

namespace QLNhaHangTiecCuoi
{
    public partial class UCQuanLyThucAn : UserControl
    {
        BUS_MonAn bUS_MonAn;
        public string maMonAn;
        public UCQuanLyThucAn()
        {

            InitializeComponent();
            bUS_MonAn = new BUS_MonAn();


        }

        private void UCQuanLyThucAn_Load(object sender, EventArgs e)
        {
            cb_LoaiThucPham.Items.Add("Thức ăn");
            cb_LoaiThucPham.Items.Add("Thức uống");
            cb_LoaiThucPham.SelectedIndex = 0;

            cb_DonViTinh.Items.Add("Tô");
            cb_DonViTinh.Items.Add("Dĩa");
            cb_DonViTinh.Items.Add("Chai");
            cb_DonViTinh.Items.Add("Lon");
            cb_DonViTinh.Items.Add("Thùng");
            cb_DonViTinh.SelectedIndex = 0;

            
            cb_TimKiem.Items.Add("Tìm kiếm theo mã");
            cb_TimKiem.Items.Add("Tìm kiếm theo tên");
            cb_TimKiem.SelectedIndex = 0;
            bUS_MonAn = new BUS_MonAn();
            bUS_MonAn.getListMonAn(dgv_ThucAn);
            this.set_UpDgvThucAnView();
            reset();
        }
        public void reset()
        {
            bUS_MonAn = new BUS_MonAn();

            txt_TenThucPham.Text = "";
            txt_GiaTien.Text = "";
            bUS_MonAn.getListMonAn(dgv_ThucAn);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MONAN d = new MONAN();
            if(txt_TenThucPham.Text != "" || txt_GiaTien.Text != "")
            {
                d.TenMa = txt_TenThucPham.Text;
                d.DonGia = int.Parse(txt_GiaTien.Text);
                d.DonViTinh = cb_DonViTinh.Text;
                d.Loai = cb_LoaiThucPham.Text;
                int kq = bUS_MonAn.AddMonAn(d);
                if (kq == 0)
                    MessageBox.Show("Món này đã có sẵn trong thực đơn không thể thêm được!");
                else if (kq == 1)
                    MessageBox.Show("Thêm món ăn thành công!");
                else
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }          
            reset();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            MONAN d = new MONAN();
            if (txt_TenThucPham.Text != "" || txt_GiaTien.Text != "")
            {
                d.MaMA = dgv_ThucAn.CurrentRow.Cells[0].Value.ToString();
                d.TenMa = txt_TenThucPham.Text;
                d.DonViTinh = cb_DonViTinh.Text;
                d.Loai = cb_LoaiThucPham.Text;
                d.DonGia = decimal.Parse(txt_GiaTien.Text);
                int kq = bUS_MonAn.UpdateMonAn(d);
                if (kq == 0)
                    MessageBox.Show("Không có món này trong danh sách!");
                else if (kq == 1)
                {

                    MessageBox.Show("Cập nhật món ăn thành công!");
                }

                else
                    MessageBox.Show("Cập nhật món không thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_TenThucPham.Text != "")
            {
                MONAN d = new MONAN();
                d.MaMA = dgv_ThucAn.CurrentRow.Cells[0].Value.ToString();
                int kq = bUS_MonAn.DeleteMonAn(d);
                if (kq == 0)
                    MessageBox.Show("Chưa có món này trong danh sách!");
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa món ăn thành công!");

                }
                else
                    MessageBox.Show("Xóa món ăn không thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 món để xóa!");
            }
            reset();
        }

        
        private void set_UpDgvThucAnView()
        {
            dgv_ThucAn.Columns[0].Width = (int)(dgv_ThucAn.Width * 0.15);
            dgv_ThucAn.Columns[1].Width = (int)(dgv_ThucAn.Width * 0.30);
            dgv_ThucAn.Columns[2].Width = (int)(dgv_ThucAn.Width * 0.18);
            dgv_ThucAn.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_ThucAn.Columns[3].Width = (int)(dgv_ThucAn.Width * 0.15);
            dgv_ThucAn.Columns[4].Width = (int)(dgv_ThucAn.Width * 0.15);
            dgv_ThucAn.Columns[5].Visible = false;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiem.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                bUS_MonAn.getListMonAn(dgv_ThucAn);
                set_UpDgvThucAnView();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaMA");
                tmp.Columns.Add("TenMA");
                tmp.Columns.Add("DonGia");
                tmp.Columns.Add("Loai");
                tmp.Columns.Add("DonViTinh");
                tmp.Columns.Add("Isdeleted");
                DataRow row;
                for (int i = 0; i <= dgv_ThucAn.Rows.Count - 1; i++)
                {
                    string temp;
                    if (cb_TimKiem.SelectedIndex == 0)
                    {
                        temp = dgv_ThucAn.Rows[i].Cells[0].Value.ToString().ToLower();
                    }
                    else
                    {
                        temp = dgv_ThucAn.Rows[i].Cells[1].Value.ToString().ToLower();
                    }
                    if (temp.Contains(value.ToLower()))
                    {
                        row = tmp.NewRow();
                        row[0] = dgv_ThucAn.Rows[i].Cells[0].Value.ToString();
                        row[1] = dgv_ThucAn.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv_ThucAn.Rows[i].Cells[2].Value.ToString();
                        row[3] = dgv_ThucAn.Rows[i].Cells[3].Value.ToString();
                        row[4] = dgv_ThucAn.Rows[i].Cells[4].Value.ToString();
                        row[5] = dgv_ThucAn.Rows[i].Cells[4].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_ThucAn.DataSource = tmp;
                set_UpDgvThucAnView();
            }
            else
            {
                bUS_MonAn.getListMonAn(dgv_ThucAn);
                set_UpDgvThucAnView();
            }
        }

        private void dgv_ThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //txt_MaThucPham.Text = dgv_ThucAn.CurrentRow.Cells[0].Value.ToString();
                txt_TenThucPham.Text = dgv_ThucAn.Rows[e.RowIndex].Cells["TenMA"].Value.ToString();
                txt_GiaTien.Text = dgv_ThucAn.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FReportThucAn f = new FReportThucAn();
            f.ShowDialog();
        }

        private void cb_DonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TenThucPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cb_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
