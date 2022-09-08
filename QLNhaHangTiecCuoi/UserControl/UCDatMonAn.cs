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
    public partial class UCDatMonAn : UserControl
    {
        public UCDatMonAn()
        {
            InitializeComponent();
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDaChon.SelectedIndex = 0;
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemMonAn.SelectedIndex = 0;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
