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
    public partial class UCQuanLyThucAn : UserControl
    {
        public UCQuanLyThucAn()
        {
            InitializeComponent();

            cb_LoaiThucPham.Items.Add("Thức ăn");
            cb_LoaiThucPham.Items.Add("Thức uống");
            cb_LoaiThucPham.SelectedIndex = 0;

            cb_DonViTinh.Items.Add("Tô");
            cb_DonViTinh.Items.Add("Dĩa");
            cb_DonViTinh.Items.Add("Chai");
            cb_DonViTinh.Items.Add("Lon");
            cb_DonViTinh.SelectedIndex = 0;

            cb_TimKiem.Items.Add("Tìm kiếm theo tên");
            cb_TimKiem.Items.Add("Tìm kiếm theo mã");
            cb_TimKiem.SelectedIndex = 0;
        }
    }
}
