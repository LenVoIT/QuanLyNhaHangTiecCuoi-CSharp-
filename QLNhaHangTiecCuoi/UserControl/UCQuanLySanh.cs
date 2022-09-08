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
    public partial class UCQuanLySanh : UserControl
    {
        public UCQuanLySanh()
        {
            InitializeComponent();
            cb_TimKiemTheoMuc.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemTheoMuc.Items.Add("Tìm kiếm theo tầng ");
            cb_TimKiemTheoMuc.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemTheoMuc.SelectedIndex = 0;
        }
    }
}
