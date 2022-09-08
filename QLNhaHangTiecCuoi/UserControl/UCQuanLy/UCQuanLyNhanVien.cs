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
    public partial class UCQuanLyNhanVien : UserControl
    {
        
        BUS_NHANVIEN bUS_NHANVIEN;
        public string maNV;

        public UCQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void UCQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            reset();
            BUS_BOPHAN bUS_BOPHAN = new BUS_BOPHAN();
            cb_TimKiemTheoMuc.Items.Add("Tìm Kiếm Theo Mã");
            cb_TimKiemTheoMuc.Items.Add("Tìm Kiếm Theo Tên");
            cb_TimKiemTheoMuc.SelectedIndex = 0;
            comboBox1.DataSource = bUS_BOPHAN.listBoPhan();
            comboBox1.DisplayMember = "TenBP";
            comboBox1.ValueMember = "MaBP";
        }

        public void set_dgvNhanVien()
        {
            dgv_DanhSachTimKiem.Columns[0].Width = (int)(dgv_DanhSachTimKiem.Width * 0.10);
            dgv_DanhSachTimKiem.Columns[1].Width = (int)(dgv_DanhSachTimKiem.Width * 0.10);
            dgv_DanhSachTimKiem.Columns[2].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[3].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[4].Width = (int)(dgv_DanhSachTimKiem.Width * 0.10);
            dgv_DanhSachTimKiem.Columns[5].Width = (int)(dgv_DanhSachTimKiem.Width * 0.10);
            dgv_DanhSachTimKiem.Columns[6].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
            dgv_DanhSachTimKiem.Columns[7].Width = (int)(dgv_DanhSachTimKiem.Width * 0.15);
        }

        public void reset()
        {
            bUS_NHANVIEN = new BUS_NHANVIEN();

            this.txt_TenNhanVien.Text = "";
            this.txt_SoDienThoai.Text = "";
            this.txt_CMND.Text = "";
            this.txt_ChucVu.Text = "";
            this.txt_Luong.Text = "";
            this.txt_UserName.Text = "";
            this.dgv_DanhSachTimKiem.DataSource = bUS_NHANVIEN.ListNHANVIENs();
            this.set_dgvNhanVien();
        }

        private void dgv_DanhSachTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachTimKiem.Rows.Count)
            {

                try
                {
                    txt_TenNhanVien.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                    txt_SoDienThoai.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                    txt_CMND.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
                    
                    txt_ChucVu.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
                    if (string.IsNullOrEmpty(dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["MaBP"].Value as string))
                    {
                        comboBox1.Text = "";
                    }
                    else
                    {
                        comboBox1.SelectedValue = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["MaBP"].Value.ToString();
                    }
                    if (string.IsNullOrEmpty(dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["Luong"].Value.ToString()))
                    {
                        txt_Luong.Text = "";
                    }
                    else
                    {
                        txt_Luong.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["Luong"].Value.ToString();
                    }
                   
                    txt_UserName.Text = dgv_DanhSachTimKiem.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("chưa đủ thông tin!");
                }
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                NHANVIEN n = new NHANVIEN();
                n.MaNV = dgv_DanhSachTimKiem.CurrentRow.Cells[0].Value.ToString();
                n.TenNV = txt_TenNhanVien.Text;
                n.SDT = txt_SoDienThoai.Text;
                n.CMND = txt_CMND.Text;
                n.MaBP = comboBox1.SelectedValue.ToString();
                n.ChucVu = txt_ChucVu.Text;
                n.Luong = int.Parse(txt_Luong.Text);
                n.UserName = txt_UserName.Text;
                int KQ = bUS_NHANVIEN.UpdateNhanVien(n);
                if (KQ == 0)
                {
                    MessageBox.Show("Nhân viên này chưa tồn tại!");
                }
                else if (KQ == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }catch(Exception e1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!"); 
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NHANVIEN n = new NHANVIEN();
            n.MaNV = dgv_DanhSachTimKiem.CurrentRow.Cells[0].Value.ToString();
            int KQ = bUS_NHANVIEN.DeleteNhanVien(n);
            if (KQ == 0)
            {
                MessageBox.Show("Nhân viên này chưa tồn tại!");
            }
            else if (KQ == 1)
            {
                MessageBox.Show("Xoá thành công!");
                reset();
            }
            else
            {
                MessageBox.Show("Xoá không thành công!");
            }

        }

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FDangKyNhanVien f = new FDangKyNhanVien();
            f.ShowDialog();
            reset();
        }

        private void txt_TimKiemTheoMuc_TextChanged(object sender, EventArgs e)
        {
            string value = txt_TimKiemTheoMuc.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dgv_DanhSachTimKiem.DataSource = bUS_NHANVIEN.ListNHANVIENs();
                set_dgvNhanVien();
                DataTable tmp = new DataTable();
                tmp.Columns.Add("MaNV");
                tmp.Columns.Add("TenNV");
                tmp.Columns.Add("SDT");
                tmp.Columns.Add("CMND");
                tmp.Columns.Add("MaBP");
                tmp.Columns.Add("ChucVu");
                tmp.Columns.Add("Luong");
                tmp.Columns.Add("UserName");

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
                        try
                        {
                            row = tmp.NewRow();
                            row[0] = dgv_DanhSachTimKiem.Rows[i].Cells[0].Value.ToString();
                            row[1] = dgv_DanhSachTimKiem.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgv_DanhSachTimKiem.Rows[i].Cells[2].Value.ToString();
                            row[3] = dgv_DanhSachTimKiem.Rows[i].Cells[3].Value.ToString();
                            row[4] = dgv_DanhSachTimKiem.Rows[i].Cells[4].Value.ToString();
                            row[5] = dgv_DanhSachTimKiem.Rows[i].Cells[5].Value.ToString();
                            row[6] = dgv_DanhSachTimKiem.Rows[i].Cells[6].Value.ToString();
                            row[7] = dgv_DanhSachTimKiem.Rows[i].Cells[7].Value.ToString();
                            tmp.Rows.Add(row);
                        }
                        catch(Exception e1)
                        {

                        }
                    }
                }
                dgv_DanhSachTimKiem.DataSource = tmp;
                set_dgvNhanVien();
            }
            else
            {
                dgv_DanhSachTimKiem.DataSource = bUS_NHANVIEN.ListNHANVIENs();
                set_dgvNhanVien();
            }

        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}

