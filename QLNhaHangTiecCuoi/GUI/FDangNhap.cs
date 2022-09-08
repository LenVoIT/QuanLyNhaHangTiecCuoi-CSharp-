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
    public partial class FDangNhap : Form
    {
        internal static object show;

        public FDangNhap()
        {
            InitializeComponent();
            cb_QuyenTruyCap.Items.Add("Khách hàng");
            cb_QuyenTruyCap.Items.Add("Nhân viên");
            cb_QuyenTruyCap.SelectedIndex = 0;
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            lbPasswordAlert.Visible = false;
        }

        private bool CheckMatKhau(String password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            else
            {


            }
            return true;
            // check password co chu va so
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //bool resultChu = txtMatKhau.Text.ToString().All(Char.IsLetter);
            //bool resultSo = !txtMatKhau.Text.ToString().All(Char.IsLetterOrDigit);

            //lbPasswordAlert.Text = resultSo.ToString();
            //lbPasswordAlert.Visible = true;

            if (!CheckMatKhau(txtMatKhau.Text.ToString()))
            {
                lbPasswordAlert.Visible = true;
            }
            else
            {
                // tien hanh dang nhap vao he thong
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FDangKyNhanVien fDangKy = new FDangKyNhanVien();
            fDangKy.ShowDialog();
        }

        private void FDangNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
