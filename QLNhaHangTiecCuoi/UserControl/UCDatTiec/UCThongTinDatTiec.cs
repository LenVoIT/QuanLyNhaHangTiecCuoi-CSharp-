using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHangTiecCuoi.BUS;

namespace QLNhaHangTiecCuoi
{
    public partial class UCThongTinDatTiec : UserControl
    {
        BUS_DATTIEC bUS_DATTIEC;
        BUS_KHACHHANG bUS_KHACHHANG;
        
        public string maTiec;
        public KHACHHANG k;
        public UCThongTinDatTiec()
        {
            InitializeComponent();
            bUS_DATTIEC = new BUS_DATTIEC();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            
        }
        private void UCThongTinDatTiec_Load(object sender, EventArgs e)
        {
            txt_TenKhachHang.Text = bUS_KHACHHANG.getKHACHHANG(k.MaKH).TenKH;
            txt_SDT.Text = bUS_KHACHHANG.getKHACHHANG(k.MaKH).SDT;
            txt_NgayDat.Text = DateTime.Now.ToString();
            txt_MaTiec.Text = bUS_DATTIEC.Max_Tiec();
        }
        public void btn_Them_Click(object sender, EventArgs e)
        {
                try
                {
                    if (int.Parse(txt_SoKhach.Text) != 0 && int.Parse(txt_Ban.Text) != 0)
                    {
                        DATTIEC d = new DATTIEC();
                        this.maTiec = txt_MaTiec.Text;
                        d.MaTiec = txt_MaTiec.Text;
                        d.TenTiec = txt_TenTiec.Text;
                        d.SoLuongBan = int.Parse(txt_Ban.Text);
                        d.SoLuongKhach = int.Parse(txt_SoKhach.Text);
                        d.MaKH = k.MaKH;
                        int KQ = bUS_DATTIEC.AddDatTiec(d);
                        if (KQ == 0)// da ton tai
                        {
                            MessageBox.Show("Tiệc này đã tồn tại!");
                        }
                        else if (KQ == 1)//chua ton tai ma them duoc
                        {
                            MessageBox.Show("Đã thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("vui lòng nhập khác 0 !");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
               
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (int.Parse(txt_Ban.Text) != 0 && int.Parse(txt_SoKhach.Text) != 0)
                    {
                        DATTIEC d = new DATTIEC();
                        d.MaTiec = txt_MaTiec.Text;
                        d.TenTiec = txt_TenTiec.Text;
                        d.SoLuongBan = int.Parse(txt_Ban.Text);
                        d.SoLuongKhach = int.Parse(txt_SoKhach.Text);
                        int KQ = bUS_DATTIEC.UpdateTiec(d);
                        if (KQ == 0)// tiệc chưa tồn tại
                        {
                            MessageBox.Show("Tiệc này chưa tồn tại!");
                        }
                        else if (KQ == 1)//update thành công
                        {
                            MessageBox.Show("Update thành công!");
                        }

                        else//update thất bại
                        {
                            MessageBox.Show("Update không thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("vui lòng nhập khác 0!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
               

        }

        private void txt_Ban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ban_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_SoKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_TenTiec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
