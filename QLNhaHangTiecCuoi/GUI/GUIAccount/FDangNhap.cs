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
    public partial class FDangNhap : Form
    {
        public string userName;
        public KHACHHANG k;
        public NHANVIEN n;
        internal static object show;
        BUS_ACCOUNT bUS_ACCOUNT;
        public FDangNhap()
        {
            InitializeComponent();
            cb_QuyenTruyCap.Items.Add("Khách hàng");
            cb_QuyenTruyCap.Items.Add("Nhân viên");
            cb_QuyenTruyCap.SelectedIndex = 0;
            bUS_ACCOUNT = new BUS_ACCOUNT();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            lbPasswordAlert.Visible = false;
            txtMatKhau.PasswordChar = '*';
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            ACCOUNT a = new ACCOUNT();
            if(txtUsername.Text == "" || txtMatKhau.Text == "")
            {
                lbPasswordAlert.Text = "bạn chưa nhập đầy đủ! vui lòng nhập thông tin";
            } 
            else
            {
                if (cb_QuyenTruyCap.Text == "Khách hàng")
                {
                    a.UserName = txtUsername.Text;
                    a.PassWord = txtMatKhau.Text;
                    if (bUS_ACCOUNT.checkACCOUNT(a, "KH") == 1)
                    {

                        FGiaoDienKH f = new FGiaoDienKH();
                        f.k = bUS_ACCOUNT.getKhachHangByUserName(txtUsername.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {

                        lbPasswordAlert.Text = "Nhập mật khẩu không đúng! vui lòng nhập lại";
                    }
                }
                else// đăng nhập bên nhân viên
                {
                    a.UserName = txtUsername.Text;
                    a.PassWord = txtMatKhau.Text;
                    if (bUS_ACCOUNT.checkACCOUNT(a, "NV") == 1)
                    {

                        FGiaoDienNV f = new FGiaoDienNV();
                        f.n = bUS_ACCOUNT.getNhanVienByUserName(txtUsername.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {

                        lbPasswordAlert.Text = "Nhập mật khẩu không đúng! vui lòng nhập lại";
                    }
                }
            }

            

        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FDangKyKhachHang fDangKy = new FDangKyKhachHang();
            this.Hide();
            fDangKy.ShowDialog();
            this.Close();
        }
        private void FDangNhap_Load_1(object sender, EventArgs e)
        {

        }

        private void FDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
