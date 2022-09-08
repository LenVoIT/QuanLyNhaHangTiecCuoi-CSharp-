
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyThucAn
    { /// <summary> 
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lbl_TenThucPham = new System.Windows.Forms.Label();
            this.lbl_LoaiThucPham = new System.Windows.Forms.Label();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.txt_TenThucPham = new System.Windows.Forms.TextBox();
            this.cb_LoaiThucPham = new System.Windows.Forms.ComboBox();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.cb_DonViTinh = new System.Windows.Forms.ComboBox();
            this.dgv_ThucAn = new System.Windows.Forms.DataGridView();
            this.cb_TimKiem = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Them.Location = new System.Drawing.Point(339, 108);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(127, 37);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(636, 108);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(127, 37);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(488, 108);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(127, 37);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // lbl_TenThucPham
            // 
            this.lbl_TenThucPham.AutoSize = true;
            this.lbl_TenThucPham.Location = new System.Drawing.Point(25, 23);
            this.lbl_TenThucPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenThucPham.Name = "lbl_TenThucPham";
            this.lbl_TenThucPham.Size = new System.Drawing.Size(103, 17);
            this.lbl_TenThucPham.TabIndex = 3;
            this.lbl_TenThucPham.Text = "Tên thực phẩm";
            // 
            // lbl_LoaiThucPham
            // 
            this.lbl_LoaiThucPham.AutoSize = true;
            this.lbl_LoaiThucPham.Location = new System.Drawing.Point(25, 70);
            this.lbl_LoaiThucPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiThucPham.Name = "lbl_LoaiThucPham";
            this.lbl_LoaiThucPham.Size = new System.Drawing.Size(105, 17);
            this.lbl_LoaiThucPham.TabIndex = 3;
            this.lbl_LoaiThucPham.Text = "Loại thực phẩm";
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(412, 16);
            this.lbl_DonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(75, 17);
            this.lbl_DonViTinh.TabIndex = 3;
            this.lbl_DonViTinh.Text = "Đơn vị tính";
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Location = new System.Drawing.Point(412, 64);
            this.lbl_GiaTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(57, 17);
            this.lbl_GiaTien.TabIndex = 3;
            this.lbl_GiaTien.Text = "Giá tiền";
            // 
            // txt_TenThucPham
            // 
            this.txt_TenThucPham.Location = new System.Drawing.Point(172, 16);
            this.txt_TenThucPham.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenThucPham.Name = "txt_TenThucPham";
            this.txt_TenThucPham.Size = new System.Drawing.Size(169, 22);
            this.txt_TenThucPham.TabIndex = 4;
            this.txt_TenThucPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenThucPham_KeyPress);
            // 
            // cb_LoaiThucPham
            // 
            this.cb_LoaiThucPham.FormattingEnabled = true;
            this.cb_LoaiThucPham.Location = new System.Drawing.Point(172, 62);
            this.cb_LoaiThucPham.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LoaiThucPham.Name = "cb_LoaiThucPham";
            this.cb_LoaiThucPham.Size = new System.Drawing.Size(169, 24);
            this.cb_LoaiThucPham.TabIndex = 5;
            this.cb_LoaiThucPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_DonViTinh_KeyPress);
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(565, 64);
            this.txt_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(169, 22);
            this.txt_GiaTien.TabIndex = 4;
            this.txt_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaTien_KeyPress);
            // 
            // cb_DonViTinh
            // 
            this.cb_DonViTinh.FormattingEnabled = true;
            this.cb_DonViTinh.Location = new System.Drawing.Point(565, 16);
            this.cb_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_DonViTinh.Name = "cb_DonViTinh";
            this.cb_DonViTinh.Size = new System.Drawing.Size(169, 24);
            this.cb_DonViTinh.TabIndex = 5;
            this.cb_DonViTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_DonViTinh_KeyPress);
            // 
            // dgv_ThucAn
            // 
            this.dgv_ThucAn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucAn.Location = new System.Drawing.Point(-8, 33);
            this.dgv_ThucAn.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ThucAn.Name = "dgv_ThucAn";
            this.dgv_ThucAn.RowHeadersWidth = 51;
            this.dgv_ThucAn.Size = new System.Drawing.Size(923, 374);
            this.dgv_ThucAn.TabIndex = 6;
            this.dgv_ThucAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThucAn_CellClick);
            // 
            // cb_TimKiem
            // 
            this.cb_TimKiem.FormattingEnabled = true;
            this.cb_TimKiem.Location = new System.Drawing.Point(358, 1);
            this.cb_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TimKiem.Name = "cb_TimKiem";
            this.cb_TimKiem.Size = new System.Drawing.Size(169, 24);
            this.cb_TimKiem.TabIndex = 7;
            this.cb_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TimKiem_KeyPress);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(160, 1);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(169, 22);
            this.txt_TimKiem.TabIndex = 4;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cb_TimKiem);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.dgv_ThucAn);
            this.groupBox1.Location = new System.Drawing.Point(8, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(915, 407);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(783, 108);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(127, 37);
            this.btn_ThongKe.TabIndex = 2;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // UCQuanLyThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cb_DonViTinh);
            this.Controls.Add(this.cb_LoaiThucPham);
            this.Controls.Add(this.txt_GiaTien);
            this.Controls.Add(this.txt_TenThucPham);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.lbl_DonViTinh);
            this.Controls.Add(this.lbl_LoaiThucPham);
            this.Controls.Add(this.lbl_TenThucPham);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLyThucAn";
            this.Size = new System.Drawing.Size(927, 632);
            this.Load += new System.EventHandler(this.UCQuanLyThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Label lbl_TenThucPham;
        private System.Windows.Forms.Label lbl_LoaiThucPham;
        private System.Windows.Forms.Label lbl_DonViTinh;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.TextBox txt_TenThucPham;
        private System.Windows.Forms.ComboBox cb_LoaiThucPham;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.ComboBox cb_DonViTinh;
        private System.Windows.Forms.DataGridView dgv_ThucAn;
        private System.Windows.Forms.ComboBox cb_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}
