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
    public partial class UCThanhToan : UserControl
    {
        public UCThanhToan()
        {
            InitializeComponent();
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.SelectedIndex = 0;
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemMonAn.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemMonAn.SelectedIndex = 0;
        }

        private void UCThanhToan_Load(object sender, EventArgs e)
        {

        }

    }
}
