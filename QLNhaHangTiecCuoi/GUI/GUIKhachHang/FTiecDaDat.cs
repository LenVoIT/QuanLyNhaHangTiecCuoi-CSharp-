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
    public partial class FTiecDaDat : Form
    {
        BUS_ACCOUNT bUS_ACCOUNT;
        BUS_DATTIEC bUS_DATTIEC;
        public KHACHHANG k;
        public FTiecDaDat()
        {
            InitializeComponent();
            bUS_ACCOUNT = new BUS_ACCOUNT();
            bUS_DATTIEC = new BUS_DATTIEC();
        }

        private void FTiecDaDat_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = k.UserName;
            txt_HoTen.Text = k.TenKH;
            bUS_DATTIEC.getListDatTiec(k.MaKH, dgv_TiecDaDat);
            setup_dgvDanhSachTiec();
        }

        private void setup_dgvDanhSachTiec()
        {
            dgv_TiecDaDat.Columns[0].Width = (int)(dgv_TiecDaDat.Width * 0.09);
            dgv_TiecDaDat.Columns[1].Width = (int)(dgv_TiecDaDat.Width * 0.25);
            dgv_TiecDaDat.Columns[2].Width = (int)(dgv_TiecDaDat.Width * 0.09);
            dgv_TiecDaDat.Columns[3].Width = (int)(dgv_TiecDaDat.Width * 0.09);
            dgv_TiecDaDat.Columns[4].Width = (int)(dgv_TiecDaDat.Width * 0.11);
            dgv_TiecDaDat.Columns[5].Width = (int)(dgv_TiecDaDat.Width * 0.11);
            dgv_TiecDaDat.Columns[6].Width = (int)(dgv_TiecDaDat.Width * 0.15);
        }

        private void btn_TroLai_Click(object sender, EventArgs e)
        {
            FGiaoDienKH f = new FGiaoDienKH();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dgv_TiecDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaTiec.Text = dgv_TiecDaDat.Rows[e.RowIndex].Cells["MaTiec"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Vui lòng chọn 1 tiệc tương ứng!");
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
            if(txt_MaTiec.Text != "")
            {
                bUS_DATTIEC.xoaDatTiec(txt_MaTiec.Text);
                MessageBox.Show("Xóa thành công!");
                txt_MaTiec.Text = "";
                bUS_DATTIEC.getListDatTiec(k.MaKH, dgv_TiecDaDat);
                setup_dgvDanhSachTiec();             
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn 1 tiệc!");
            }    
        }
    }
}
