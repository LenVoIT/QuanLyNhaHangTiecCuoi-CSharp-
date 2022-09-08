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
    public partial class UCQuanLyDatTiec : UserControl
    {
        public UCQuanLyDatTiec()
        {
            InitializeComponent();
            cb_TimKiemChuaXacNhan.Items.Add("Tìm kiếm theo mã tiệc");
            cb_TimKiemChuaXacNhan.Items.Add("Tìm kiếm theo mã KH");
            cb_TimKiemChuaXacNhan.SelectedIndex = 0;
            cb_TimKiemDaXacNhan.Items.Add("Tìm kiếm theo mã tiệc");
            cb_TimKiemDaXacNhan.Items.Add("Tìm kiếm theo KH");
            cb_TimKiemDaXacNhan.SelectedIndex = 0;
        }

    }
}
