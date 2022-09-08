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
    public partial class FDangKyNhanVien : Form
    {
        
        BUS_NHANVIEN bUS_NhanVien;
        BUS_BOPHAN bUS_BOPHAN;
        public FDangKyNhanVien()
        {
            InitializeComponent();
            bUS_NhanVien = new BUS_NHANVIEN();
            bUS_BOPHAN = new BUS_BOPHAN();
        }

        private void FDangKyNhanVien_Load(object sender, EventArgs e)
        {
            bUS_NhanVien.getListChucVu(cb_ChucVu);
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

            if (txt_MatKhau.Text == "" || txt_XacNhanMatKhau.Text == "" || txt_TenNV.Text == "" || txt_TaiKhoan.Text == "")
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
                            NHANVIEN n = new NHANVIEN();
                            n.TenNV = txt_TenNV.Text;
                            n.SDT = txt_SDT.Text;
                            n.CMND = txt_CMND.Text;
                            n.MaBP = bUS_BOPHAN.getMaBoPhan(cb_ChucVu.Text);
                            n.Luong = null;
                            n.ChucVu = cb_ChucVu.Text;
                            n.UserName = txt_TaiKhoan.Text;
                            int kq = bUS_NhanVien.AddNhanVien(n, txt_MatKhau.Text);
                            if (kq == 1)
                            {
                                MessageBox.Show("Đăng ký thành công!");
                                txt_TenNV.Text = "";
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
                                MessageBox.Show("Thêm nhân viên thất bại!");
                            }
                        }
                    }

                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
