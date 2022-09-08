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
    public partial class UCDatSanh : UserControl
    {
        public UCDatSanh()
        {
            InitializeComponent();
            cbTimKiemSanh.Items.Add("Tìm kiếm theo tên");
            cbTimKiemSanh.Items.Add("Tìm kiếm theo mã");
            cbTimKiemSanh.SelectedIndex = 0;
            cb_DanhSachSanh.Items.Add("Danh sách sảnh phù hợp");
            cb_DanhSachSanh.Items.Add("Tất cả các sảnh");
            cb_DanhSachSanh.SelectedIndex = 0;
        }

    }
}
