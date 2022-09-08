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
    public partial class UCQuanLyDichVu : UserControl
    {
        public UCQuanLyDichVu()
        {
            InitializeComponent();
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.SelectedIndex = 0;
        }
    }
}
