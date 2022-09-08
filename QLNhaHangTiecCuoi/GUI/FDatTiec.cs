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
    public partial class FDatTiec : Form
    {
        public FDatTiec()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_ThongTinDatTiec_Click(object sender, EventArgs e)
        {
            UCThongTinDatTiec uc = new UCThongTinDatTiec();
            addUserControl(uc);
        }

        private void btn_DatSanh_Click(object sender, EventArgs e)
        {
            UCDatSanh uc = new UCDatSanh();
            addUserControl(uc);
        }

        private void btn_DatThucAn_Click(object sender, EventArgs e)
        {
            UCDatMonAn uc = new UCDatMonAn();
            addUserControl(uc);
        }

        private void btn_DatDichVu_Click(object sender, EventArgs e)
        {
            UCDatDichVu uc = new UCDatDichVu();
            addUserControl(uc);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            UCThanhToan uc = new UCThanhToan();
            addUserControl(uc);
        }
    }
}
