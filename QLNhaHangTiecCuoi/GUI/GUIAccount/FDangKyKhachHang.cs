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
    public partial class FDangKyKhachHang : Form
    {
        BUS_KHACHHANG bUS_KHACHHANG;
        public FDangKyKhachHang()
        {
            InitializeComponent();
            cb_GioiTinh.Items.Add("Nam");
            cb_GioiTinh.Items.Add("Nữ");
            cb_GioiTinh.SelectedIndex = 0;
        }
        private void FDangKyKhachHang_Load(object sender, EventArgs e)
        {
            bUS_KHACHHANG = new BUS_KHACHHANG();
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "" || txt_XacNhanMatKhau.Text == "" || txt_TenKH.Text == "" || txt_TaiKhoan.Text == "")
            {
                lb_ThongBao.Text = "Vui Lòng nhập đầy đủ thông tin!";
            }
            else
            {
                lb_ThongBao.Text = "";
                if (txt_TaiKhoan.Text.Contains(" ") || txt_TaiKhoan.Text.Contains("@"))
                {
                    lb_ThongBao.Text = "tài khoản không được chứa khoảng trắng và kí tự!";
                }
                else
                {
                    if (txt_MatKhau.Text != txt_XacNhanMatKhau.Text)
                    {
                        lb_ThongBao.Text = "Xác nhận mật khẩu không đúng!";
                    }
                    else
                    {

                        if (txt_MatKhau.Text.Length < 6 || txt_MatKhau.Text.Contains(" "))
                        {
                            lb_ThongBao.Text = "vui lòng nhập mật khẩu có độ dài ít nhất 6 kì tự và không có khoảng trắng!";

                        }
                        else
                        {
                            KHACHHANG k = new KHACHHANG();
                            k.TenKH = txt_TenKH.Text;
                            k.GioiTinh = cb_GioiTinh.Text;
                            k.SDT = txt_SDT.Text;
                            k.CMND = txt_CMND.Text;
                            k.DiaChi = txt_DiaChi.Text;
                            k.UserName = txt_TaiKhoan.Text;
                            int kq = bUS_KHACHHANG.AddKhachHang(k, txt_MatKhau.Text);
                            if (kq == 1)
                            {
                                MessageBox.Show("Đăng ký thành công!");
                                txt_TenKH.Text = "";
                                txt_SDT.Text = "";
                                txt_CMND.Text = "";
                                txt_DiaChi.Text = "";
                                txt_TaiKhoan.Text = "";
                                txt_MatKhau.Text = "";
                                txt_XacNhanMatKhau.Text = "";

                            }
                            else if (kq == 0)
                            {
                                lb_ThongBao.Text = "Tài khoản này đã tồn tại!";
                            }
                            else
                            {
                                MessageBox.Show("Thêm khách hàng thất bại!");
                            }    
                        }
                    }

                }
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cb_GioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
