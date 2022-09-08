
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyDatTiec
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
            this.dgvDanhSachDaXacNhan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TimKiemDaXacNhan = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDaXacNhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayDatTiec = new System.Windows.Forms.TextBox();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NgayToChuc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TimKiemChuaXacNhan = new System.Windows.Forms.ComboBox();
            this.txtTimKiemChuaXacNhan = new System.Windows.Forms.TextBox();
            this.dgvDanhSachChuaXacNhan = new System.Windows.Forms.DataGridView();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDaXacNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuaXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachDaXacNhan
            // 
            this.dgvDanhSachDaXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachDaXacNhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachDaXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDaXacNhan.Location = new System.Drawing.Point(2, 394);
            this.dgvDanhSachDaXacNhan.Name = "dgvDanhSachDaXacNhan";
            this.dgvDanhSachDaXacNhan.RowHeadersWidth = 51;
            this.dgvDanhSachDaXacNhan.RowTemplate.Height = 24;
            this.dgvDanhSachDaXacNhan.Size = new System.Drawing.Size(918, 187);
            this.dgvDanhSachDaXacNhan.TabIndex = 0;
            this.dgvDanhSachDaXacNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDaXacNhan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_TimKiemDaXacNhan);
            this.groupBox1.Controls.Add(this.txt_TimKiemDaXacNhan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn đặt tiệc đã xác nhận:";
            // 
            // cb_TimKiemDaXacNhan
            // 
            this.cb_TimKiemDaXacNhan.FormattingEnabled = true;
            this.cb_TimKiemDaXacNhan.Location = new System.Drawing.Point(548, 0);
            this.cb_TimKiemDaXacNhan.Name = "cb_TimKiemDaXacNhan";
            this.cb_TimKiemDaXacNhan.Size = new System.Drawing.Size(164, 24);
            this.cb_TimKiemDaXacNhan.TabIndex = 1;
            this.cb_TimKiemDaXacNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TimKiemChuaXacNhan_KeyPress);
            // 
            // txt_TimKiemDaXacNhan
            // 
            this.txt_TimKiemDaXacNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemDaXacNhan.Location = new System.Drawing.Point(312, 0);
            this.txt_TimKiemDaXacNhan.Name = "txt_TimKiemDaXacNhan";
            this.txt_TimKiemDaXacNhan.Size = new System.Drawing.Size(230, 22);
            this.txt_TimKiemDaXacNhan.TabIndex = 0;
            this.txt_TimKiemDaXacNhan.TextChanged += new System.EventHandler(this.txt_TimKiemDaXacNhan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã tiệc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày đặt tiệc:";
            // 
            // txt_NgayDatTiec
            // 
            this.txt_NgayDatTiec.Enabled = false;
            this.txt_NgayDatTiec.Location = new System.Drawing.Point(608, 41);
            this.txt_NgayDatTiec.Name = "txt_NgayDatTiec";
            this.txt_NgayDatTiec.ReadOnly = true;
            this.txt_NgayDatTiec.Size = new System.Drawing.Size(146, 22);
            this.txt_NgayDatTiec.TabIndex = 5;
            // 
            // txt_MaTiec
            // 
            this.txt_MaTiec.Enabled = false;
            this.txt_MaTiec.Location = new System.Drawing.Point(176, 12);
            this.txt_MaTiec.Name = "txt_MaTiec";
            this.txt_MaTiec.ReadOnly = true;
            this.txt_MaTiec.Size = new System.Drawing.Size(146, 22);
            this.txt_MaTiec.TabIndex = 5;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Enabled = false;
            this.txt_MaKhachHang.Location = new System.Drawing.Point(176, 42);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.ReadOnly = true;
            this.txt_MaKhachHang.Size = new System.Drawing.Size(146, 22);
            this.txt_MaKhachHang.TabIndex = 5;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(176, 72);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(146, 22);
            this.txt_ThanhTien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày tổ chức:";
            // 
            // txt_NgayToChuc
            // 
            this.txt_NgayToChuc.Enabled = false;
            this.txt_NgayToChuc.Location = new System.Drawing.Point(609, 72);
            this.txt_NgayToChuc.Name = "txt_NgayToChuc";
            this.txt_NgayToChuc.ReadOnly = true;
            this.txt_NgayToChuc.Size = new System.Drawing.Size(146, 22);
            this.txt_NgayToChuc.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cb_TimKiemChuaXacNhan);
            this.groupBox2.Controls.Add(this.txtTimKiemChuaXacNhan);
            this.groupBox2.Controls.Add(this.dgvDanhSachChuaXacNhan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(2, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn đặt tiệc chưa xác nhận:";
            // 
            // cb_TimKiemChuaXacNhan
            // 
            this.cb_TimKiemChuaXacNhan.FormattingEnabled = true;
            this.cb_TimKiemChuaXacNhan.Location = new System.Drawing.Point(548, 0);
            this.cb_TimKiemChuaXacNhan.Name = "cb_TimKiemChuaXacNhan";
            this.cb_TimKiemChuaXacNhan.Size = new System.Drawing.Size(164, 24);
            this.cb_TimKiemChuaXacNhan.TabIndex = 1;
            this.cb_TimKiemChuaXacNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TimKiemChuaXacNhan_KeyPress);
            // 
            // txtTimKiemChuaXacNhan
            // 
            this.txtTimKiemChuaXacNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKiemChuaXacNhan.Location = new System.Drawing.Point(312, 0);
            this.txtTimKiemChuaXacNhan.Name = "txtTimKiemChuaXacNhan";
            this.txtTimKiemChuaXacNhan.Size = new System.Drawing.Size(230, 22);
            this.txtTimKiemChuaXacNhan.TabIndex = 0;
            this.txtTimKiemChuaXacNhan.TextChanged += new System.EventHandler(this.txtTimKiemChuaXacNhan_TextChanged);
            // 
            // dgvDanhSachChuaXacNhan
            // 
            this.dgvDanhSachChuaXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChuaXacNhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachChuaXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChuaXacNhan.Location = new System.Drawing.Point(1, 30);
            this.dgvDanhSachChuaXacNhan.Name = "dgvDanhSachChuaXacNhan";
            this.dgvDanhSachChuaXacNhan.RowHeadersWidth = 51;
            this.dgvDanhSachChuaXacNhan.RowTemplate.Height = 24;
            this.dgvDanhSachChuaXacNhan.Size = new System.Drawing.Size(917, 181);
            this.dgvDanhSachChuaXacNhan.TabIndex = 0;
            this.dgvDanhSachChuaXacNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChuaXacNhan_CellClick);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ChiTiet.Location = new System.Drawing.Point(659, 586);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(117, 29);
            this.btn_ChiTiet.TabIndex = 6;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XacNhan.Location = new System.Drawing.Point(799, 328);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(117, 29);
            this.btn_XacNhan.TabIndex = 6;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(801, 586);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 29);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // UCQuanLyDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.txt_MaTiec);
            this.Controls.Add(this.txt_NgayToChuc);
            this.Controls.Add(this.txt_NgayDatTiec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachDaXacNhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCQuanLyDatTiec";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCQuanLyDatTiec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDaXacNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuaXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachDaXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimKiemDaXacNhan;
        private System.Windows.Forms.ComboBox cb_TimKiemDaXacNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgayDatTiec;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NgayToChuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_TimKiemChuaXacNhan;
        private System.Windows.Forms.TextBox txtTimKiemChuaXacNhan;
        private System.Windows.Forms.DataGridView dgvDanhSachChuaXacNhan;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Xoa;
    }
}