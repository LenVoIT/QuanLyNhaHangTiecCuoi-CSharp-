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
    public partial class FDoiMK : Form
    {
        public KHACHHANG k;
        public NHANVIEN n;
        BUS_ACCOUNT bUS_ACCOUNT;
        public FDoiMK()
        {
            InitializeComponent();
            bUS_ACCOUNT = new BUS_ACCOUNT();
           
        }

        private void FDoiMK_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = k.UserName;
            txt_MatKhauMoi.PasswordChar = '*';
            txt_NhapLai.PasswordChar = '*';
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            FThongTinKH f = new FThongTinKH();
            f.k = this.k;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(txt_MatKhauMoi.Text != txt_NhapLai.Text)
            {
                lb_ThongBao.Text = "Nhập lại mật khẩu không đúng !";
            }  
            else
            {

            }    
            
        }
    }
}
