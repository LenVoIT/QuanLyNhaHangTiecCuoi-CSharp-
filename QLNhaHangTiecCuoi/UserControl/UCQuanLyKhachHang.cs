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
    public partial class UCQuanLyKhachHang : UserControl
    {
        public UCQuanLyKhachHang()
        {
            InitializeComponent();
            cb_GioiTinh.Items.Add("Nam");
            cb_GioiTinh.Items.Add("Nữ");
            cb_GioiTinh.Items.Add("Khác");
            cb_GioiTinh.SelectedIndex = 0;
            cb_TimKiem.Items.Add("Tìm kiếm theo tên");
            cb_TimKiem.Items.Add("Tìm kiếm theo mã");
            cb_TimKiem.SelectedIndex = 0;
        }
    }
}
