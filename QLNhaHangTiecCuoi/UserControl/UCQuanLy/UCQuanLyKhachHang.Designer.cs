
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyKhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grb_DanhSachKhachHang = new System.Windows.Forms.GroupBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.cb_TimKiem = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.grb_DanhSachKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(22, 48);
            this.lbl_TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(111, 17);
            this.lbl_TenKhachHang.TabIndex = 0;
            this.lbl_TenKhachHang.Text = "Tên khách hàng";
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.Location = new System.Drawing.Point(22, 92);
            this.lbl_CMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(48, 17);
            this.lbl_CMND.TabIndex = 0;
            this.lbl_CMND.Text = "CMND";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(22, 137);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(60, 17);
            this.lbl_GioiTinh.TabIndex = 0;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(452, 47);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(91, 17);
            this.lbl_SoDienThoai.TabIndex = 0;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(452, 91);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(51, 17);
            this.lbl_DiaChi.TabIndex = 0;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Enabled = false;
            this.txt_TenKhachHang.Location = new System.Drawing.Point(184, 48);
            this.txt_TenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.ReadOnly = true;
            this.txt_TenKhachHang.Size = new System.Drawing.Size(231, 22);
            this.txt_TenKhachHang.TabIndex = 1;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(184, 92);
            this.txt_CMND.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(231, 22);
            this.txt_CMND.TabIndex = 1;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(590, 43);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(231, 22);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(590, 87);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(231, 22);
            this.txt_DiaChi.TabIndex = 1;
            this.txt_DiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiaChi_KeyPress);
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Location = new System.Drawing.Point(184, 137);
            this.cb_GioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(231, 24);
            this.cb_GioiTinh.TabIndex = 2;
            this.cb_GioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_GioiTinh_KeyPress);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Them.Location = new System.Drawing.Point(522, 135);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 37);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(698, 135);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(108, 37);
            this.btn_CapNhat.TabIndex = 8;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1021, 130);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 37);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // grb_DanhSachKhachHang
            // 
            this.grb_DanhSachKhachHang.Controls.Add(this.dgv_KhachHang);
            this.grb_DanhSachKhachHang.Controls.Add(this.cb_TimKiem);
            this.grb_DanhSachKhachHang.Controls.Add(this.txt_TimKiem);
            this.grb_DanhSachKhachHang.Location = new System.Drawing.Point(0, 267);
            this.grb_DanhSachKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachKhachHang.Name = "grb_DanhSachKhachHang";
            this.grb_DanhSachKhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.grb_DanhSachKhachHang.Size = new System.Drawing.Size(925, 496);
            this.grb_DanhSachKhachHang.TabIndex = 9;
            this.grb_DanhSachKhachHang.TabStop = false;
            this.grb_DanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(4, 30);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.Size = new System.Drawing.Size(917, 322);
            this.dgv_KhachHang.TabIndex = 0;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // cb_TimKiem
            // 
            this.cb_TimKiem.FormattingEnabled = true;
            this.cb_TimKiem.Location = new System.Drawing.Point(455, 0);
            this.cb_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TimKiem.Name = "cb_TimKiem";
            this.cb_TimKiem.Size = new System.Drawing.Size(231, 24);
            this.cb_TimKiem.TabIndex = 2;
            this.cb_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TimKiem_KeyPress);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(215, 0);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(231, 22);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // UCQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grb_DanhSachKhachHang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_CMND);
            this.Controls.Add(this.lbl_TenKhachHang);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLyKhachHang";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCQuanLyKhachHang_Load);
            this.grb_DanhSachKhachHang.ResumeLayout(false);
            this.grb_DanhSachKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grb_DanhSachKhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.ComboBox cb_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}
