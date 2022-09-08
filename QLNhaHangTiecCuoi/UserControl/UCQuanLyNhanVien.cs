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
    public partial class UCQuanLyNhanVien : UserControl
    {
        public UCQuanLyNhanVien()
        {
            InitializeComponent();
            cb_TimKiemTheoMuc.Items.Add("Tìm Kiếm Theo Mã");
            cb_TimKiemTheoMuc.Items.Add("Tìm Kiếm Theo Tên");
            cb_TimKiemTheoMuc.SelectedIndex = 0;
        }
    }
}
