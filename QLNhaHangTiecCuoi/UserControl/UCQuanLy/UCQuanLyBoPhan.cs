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

namespace QLNhaHangTiecCuoi
{
    public partial class UCQuanLyBoPhan : UserControl
    {
        BUS_BOPHAN bUS_BoPhan;
        BUS_NHANVIEN bUS_NHANVIEN;
        public UCQuanLyBoPhan()
        {
            InitializeComponent();
            bUS_BoPhan = new BUS_BOPHAN();
            bUS_NHANVIEN = new BUS_NHANVIEN();
        }

        private void UCQuanLyBoPhan_Load(object sender, EventArgs e)
        {          
            
            this.Reset();
        }
        public void Reset()
        {
            bUS_BoPhan = new BUS_BOPHAN();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            this.dgv_DanhSachBoPhan.DataSource = bUS_BoPhan.listBoPhan();
            this.dgv_DanhSachNhanVien.DataSource = null;
            txt_TenBoPhan.Text = "";
            txt_SoLuongNhanVien.Text = "";
            set_UpDgvBoPhanView();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(txt_TenBoPhan.Text != "")
            {
                BOPHAN d = new BOPHAN();
               
                d.TenBP = txt_TenBoPhan.Text;
                int kq = bUS_BoPhan.AddBoPhan(d.TenBP);
                if (kq == 0)
                    MessageBox.Show("Bộ phận này đã tồn tại");
                else if (kq == 1)
                {
                    MessageBox.Show("Thêm bộ phận thành công!");           
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            Reset();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(txt_TenBoPhan.Text != "")
            {
                BOPHAN d = new BOPHAN();
                d.MaBP = dgv_DanhSachBoPhan.CurrentRow.Cells[0].Value.ToString();
                d.TenBP = txt_TenBoPhan.Text;
                int kq = bUS_BoPhan.UpdateBoPhan(d);
                if (kq == 0)
                    MessageBox.Show("Không có bộ phận này trong danh sách");
                else if (kq == 1)
                {
                    MessageBox.Show("Cập nhật bộ phận thành công!");
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            Reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(txt_TenBoPhan.Text != "")
            {
                BOPHAN d = new BOPHAN();
                d.MaBP = dgv_DanhSachBoPhan.CurrentRow.Cells[0].Value.ToString();
                d.TenBP = txt_TenBoPhan.Text;
                int kq = bUS_BoPhan.DeleteBoPhan(d);
                if (kq == 0)
                    MessageBox.Show("Không có bộ phận này trong danh sách!");
                else if (kq == 1)
                {
                    MessageBox.Show("Xóa bộ phận thành công!");
                    
                }
                else
                    MessageBox.Show("Xóa bộ phận không thành công!");
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            Reset();
        }
        private void set_UpDgvBoPhanView()
        {
            dgv_DanhSachBoPhan.Columns[0].Width = (int)(dgv_DanhSachBoPhan.Width * 0.2);
            dgv_DanhSachBoPhan.Columns[1].Width = (int)(dgv_DanhSachBoPhan.Width * 0.4);
            dgv_DanhSachBoPhan.Columns[2].Width = (int)(dgv_DanhSachBoPhan.Width * 0.3);
        }
        private void set_UpDgvNhanVienView()
        {
            dgv_DanhSachNhanVien.Columns[9].Visible = false;
            dgv_DanhSachNhanVien.Columns[8].Visible = false ;
        }
        private void dgv_DanhSachBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_TenBoPhan.Text = dgv_DanhSachBoPhan.Rows[e.RowIndex].Cells["TenBP"].Value.ToString();
                txt_SoLuongNhanVien.Text = dgv_DanhSachBoPhan.Rows[e.RowIndex].Cells["SoLuongNV"].Value.ToString();
                
                bUS_NHANVIEN.GetListNhanVienByBP(dgv_DanhSachNhanVien, dgv_DanhSachBoPhan.CurrentRow.Cells[0].Value.ToString());
                set_UpDgvNhanVienView();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn đúng ô tương ứng!");
            }
        }

        private void txt_TenBoPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
