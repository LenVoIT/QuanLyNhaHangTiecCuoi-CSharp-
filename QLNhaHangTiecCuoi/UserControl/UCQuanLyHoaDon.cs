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
    public partial class UCQuanLyHoaDon : UserControl
    {
        public UCQuanLyHoaDon()
        {
            InitializeComponent();
            cb_TimKiemHoaDon.Items.Add("Tìm kiếm theo mã HĐ");
            cb_TimKiemHoaDon.Items.Add("Tìm kiếm theo mã tiệc");
            cb_TimKiemHoaDon.SelectedIndex = 0;
        }
    }
}
