using QLNhaHangTiecCuoi.BUS;
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
using QLNhaHangTiecCuoi.Report;

namespace QLNhaHangTiecCuoi
{
    public partial class UCQuanLyDichVu : UserControl
    {
        BUS_DichVu bUS_DichVu;
        public string MaDV;
        public UCQuanLyDichVu()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txt_TenDichVu.Text = "";
            txt_GiaTien.Text = "";
            dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
            set_dgvDichVu();
        }
        public void set_dgvDichVu()
        {
            dgv_DanhSachDichVu.Columns[0].Width = (int)(dgv_DanhSachDichVu.Width * 0.15);
            dgv_DanhSachDichVu.Columns[1].Width = (int)(dgv_DanhSachDichVu.Width * 0.50);
            dgv_DanhSachDichVu.Columns[2].Width = (int)(dgv_DanhSachDichVu.Width * 0.25);
            dgv_DanhSachDichVu.Columns[2].DefaultCellStyle.Format = "0#,##0 VNĐ";
            dgv_DanhSachDichVu.Columns[3].Visible = false;

        }

        private void UCQuanLyDichVu_Load(object sender, EventArgs e)
        {
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDichVu.SelectedIndex = 0;
            bUS_DichVu = new BUS_DichVu();
            reset();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU d = new DICHVU();
                d.TenDV = txt_TenDichVu.Text;
                d.DonGia = int.Parse(txt_GiaTien.Text);
                int KQ = bUS_DichVu.AddDichVu(d);
                if (KQ == 0)
                {
                    MessageBox.Show("Dịch vụ đã tồn tại!");
                }
                else if (KQ == 1)
                {

                    MessageBox.Show("Thêm dịch vụ thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công!");
                }
                this.reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            try
            {
                DICHVU d = new DICHVU();
                d.MaDV = dgv_DanhSachDichVu.CurrentRow.Cells[0].Value.ToString();
                d.TenDV = txt_TenDichVu.Text;
                d.DonGia = int.Parse(txt_GiaTien.Text);
                int KQ = bUS_DichVu.UpdateDichVu(d);
                if (KQ == 0)
                {
                    MessageBox.Show("Dịch vụ này chưa tồn tại!");
                }
                else if (KQ == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    bUS_DichVu = new BUS_DichVu();
                    reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DICHVU d = new DICHVU();
            d.MaDV = dgv_DanhSachDichVu.CurrentRow.Cells[0].Value.ToString();
            int KQ = bUS_DichVu.DeleteDichVu(d);
            if (KQ == 0)
            {
                MessageBox.Show("dịch vụ này chưa tồn tại!");
            }
            else if (KQ == 1)
            {
                MessageBox.Show("Xoá thành công!");
                bUS_DichVu = new BUS_DichVu();
                reset();
            }
            else
            {
                MessageBox.Show("Xoá không thành công!");
            }
        }


        private void txt_TimKiemDanhSachDichVu_TextChanged_1(object sender, EventArgs e)
        {

            string value = txt_TimKiemDanhSachDichVu.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
                set_dgvDichVu();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaDV");
                tmp.Columns.Add("TenDV");
                tmp.Columns.Add("DonGia");
                tmp.Columns.Add("Isdeleted");
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
                        row[3] = dgv_DanhSachDichVu.Rows[i].Cells[1].Value.ToString();
                        tmp.Rows.Add(row);
                    }
                }
                dgv_DanhSachDichVu.DataSource = tmp;
                set_dgvDichVu();
            }
            else
            {
                dgv_DanhSachDichVu.DataSource = bUS_DichVu.ListDichVu();
                set_dgvDichVu();
            }
        }

        private void dgv_DanhSachDichVu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachDichVu.Rows.Count)
            {

                txt_TenDichVu.Text = dgv_DanhSachDichVu.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
                txt_GiaTien.Text = dgv_DanhSachDichVu.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FReportDichVu f = new FReportDichVu();
            f.ShowDialog();
        }

        private void txt_TenDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_TimKiemDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
