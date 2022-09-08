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
    public partial class UCDatDichVu : UserControl
    {
        public UCDatDichVu()
        {
            InitializeComponent();
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDaChon.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDaChon.SelectedIndex = 0;
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo tên");
            cb_TimKiemDichVu.Items.Add("Tìm kiếm theo mã");
            cb_TimKiemDichVu.SelectedIndex = 0;
        }
    }
}
