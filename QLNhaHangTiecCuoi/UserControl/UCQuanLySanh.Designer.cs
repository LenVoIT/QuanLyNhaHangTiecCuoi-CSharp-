
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLySanh
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_SoLuongKhach = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grb_ThongTinSanh = new System.Windows.Forms.GroupBox();
            this.txt_TenSanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaSanh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMaSanh = new System.Windows.Forms.Label();
            this.cb_TimKiemTheoMuc = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemTheoMuc = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_DanhSachTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Tang = new System.Windows.Forms.TextBox();
            this.grb_ThongTinSanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.Location = new System.Drawing.Point(545, 129);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 32);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(636, 89);
            this.txt_GiaTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(192, 24);
            this.txt_GiaTien.TabIndex = 3;
            // 
            // txt_SoLuongKhach
            // 
            this.txt_SoLuongKhach.Location = new System.Drawing.Point(636, 55);
            this.txt_SoLuongKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SoLuongKhach.Name = "txt_SoLuongKhach";
            this.txt_SoLuongKhach.Size = new System.Drawing.Size(195, 24);
            this.txt_SoLuongKhach.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(484, 94);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Giá Tiền";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(484, 63);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Số Lượng Khách";
            // 
            // grb_ThongTinSanh
            // 
            this.grb_ThongTinSanh.Controls.Add(this.txt_GiaTien);
            this.grb_ThongTinSanh.Controls.Add(this.txt_Tang);
            this.grb_ThongTinSanh.Controls.Add(this.txt_TenSanh);
            this.grb_ThongTinSanh.Controls.Add(this.label20);
            this.grb_ThongTinSanh.Controls.Add(this.txt_SoLuongKhach);
            this.grb_ThongTinSanh.Controls.Add(this.label1);
            this.grb_ThongTinSanh.Controls.Add(this.txt_MaSanh);
            this.grb_ThongTinSanh.Controls.Add(this.label22);
            this.grb_ThongTinSanh.Controls.Add(this.label14);
            this.grb_ThongTinSanh.Controls.Add(this.lblMaSanh);
            this.grb_ThongTinSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTinSanh.Location = new System.Drawing.Point(20, 4);
            this.grb_ThongTinSanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_ThongTinSanh.Name = "grb_ThongTinSanh";
            this.grb_ThongTinSanh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_ThongTinSanh.Size = new System.Drawing.Size(901, 155);
            this.grb_ThongTinSanh.TabIndex = 10;
            this.grb_ThongTinSanh.TabStop = false;
            this.grb_ThongTinSanh.Text = "Thông Tinh Sảnh";
            // 
            // txt_TenSanh
            // 
            this.txt_TenSanh.Location = new System.Drawing.Point(148, 57);
            this.txt_TenSanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenSanh.Name = "txt_TenSanh";
            this.txt_TenSanh.Size = new System.Drawing.Size(265, 24);
            this.txt_TenSanh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tầng:";
            // 
            // txt_MaSanh
            // 
            this.txt_MaSanh.Location = new System.Drawing.Point(148, 25);
            this.txt_MaSanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaSanh.Name = "txt_MaSanh";
            this.txt_MaSanh.Size = new System.Drawing.Size(265, 24);
            this.txt_MaSanh.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên Sảnh";
            // 
            // lblMaSanh
            // 
            this.lblMaSanh.AutoSize = true;
            this.lblMaSanh.Location = new System.Drawing.Point(8, 32);
            this.lblMaSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSanh.Name = "lblMaSanh";
            this.lblMaSanh.Size = new System.Drawing.Size(67, 18);
            this.lblMaSanh.TabIndex = 0;
            this.lblMaSanh.Text = "Mã Sảnh";
            // 
            // cb_TimKiemTheoMuc
            // 
            this.cb_TimKiemTheoMuc.FormattingEnabled = true;
            this.cb_TimKiemTheoMuc.Location = new System.Drawing.Point(379, 0);
            this.cb_TimKiemTheoMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_TimKiemTheoMuc.Name = "cb_TimKiemTheoMuc";
            this.cb_TimKiemTheoMuc.Size = new System.Drawing.Size(168, 24);
            this.cb_TimKiemTheoMuc.TabIndex = 2;
            // 
            // txt_TimKiemTheoMuc
            // 
            this.txt_TimKiemTheoMuc.Location = new System.Drawing.Point(171, 1);
            this.txt_TimKiemTheoMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiemTheoMuc.Name = "txt_TimKiemTheoMuc";
            this.txt_TimKiemTheoMuc.Size = new System.Drawing.Size(199, 22);
            this.txt_TimKiemTheoMuc.TabIndex = 3;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_CapNhat.Location = new System.Drawing.Point(649, 129);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(99, 32);
            this.btn_CapNhat.TabIndex = 11;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(753, 129);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 32);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachTimKiem
            // 
            this.dgv_DanhSachTimKiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTimKiem.Location = new System.Drawing.Point(0, 234);
            this.dgv_DanhSachTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DanhSachTimKiem.Name = "dgv_DanhSachTimKiem";
            this.dgv_DanhSachTimKiem.RowHeadersWidth = 51;
            this.dgv_DanhSachTimKiem.Size = new System.Drawing.Size(925, 389);
            this.dgv_DanhSachTimKiem.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimKiemTheoMuc);
            this.groupBox1.Controls.Add(this.cb_TimKiemTheoMuc);
            this.groupBox1.Location = new System.Drawing.Point(0, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(924, 420);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các sảnh:";
            // 
            // txt_Tang
            // 
            this.txt_Tang.Location = new System.Drawing.Point(148, 88);
            this.txt_Tang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tang.Name = "txt_Tang";
            this.txt_Tang.Size = new System.Drawing.Size(83, 24);
            this.txt_Tang.TabIndex = 3;
            // 
            // UCQuanLySanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgv_DanhSachTimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ThongTinSanh);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCQuanLySanh";
            this.Size = new System.Drawing.Size(925, 623);
            this.grb_ThongTinSanh.ResumeLayout(false);
            this.grb_ThongTinSanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.TextBox txt_SoLuongKhach;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grb_ThongTinSanh;
        private System.Windows.Forms.TextBox txt_TenSanh;
        private System.Windows.Forms.TextBox txt_MaSanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMaSanh;
        private System.Windows.Forms.ComboBox cb_TimKiemTheoMuc;
        private System.Windows.Forms.TextBox txt_TimKiemTheoMuc;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DanhSachTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Tang;
    }
}
