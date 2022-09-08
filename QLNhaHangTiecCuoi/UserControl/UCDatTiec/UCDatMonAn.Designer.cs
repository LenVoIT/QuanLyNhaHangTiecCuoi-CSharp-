
namespace QLNhaHangTiecCuoi
{
    partial class UCDatMonAn
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
            this.dgv_DanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.dgv_DanhSachMonAnChon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cb_TimKiemMonAn = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDanhSachMonAn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TimKiemDaChon = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDanhSachDaChon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MonAnChon = new System.Windows.Forms.TextBox();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.txt_TongSoLuong = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoLuongMonAn = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonAnChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachMonAn
            // 
            this.dgv_DanhSachMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachMonAn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMonAn.Location = new System.Drawing.Point(3, 278);
            this.dgv_DanhSachMonAn.Name = "dgv_DanhSachMonAn";
            this.dgv_DanhSachMonAn.RowHeadersWidth = 51;
            this.dgv_DanhSachMonAn.RowTemplate.Height = 24;
            this.dgv_DanhSachMonAn.Size = new System.Drawing.Size(918, 342);
            this.dgv_DanhSachMonAn.TabIndex = 0;
            this.dgv_DanhSachMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonAn_CellClick);
            // 
            // dgv_DanhSachMonAnChon
            // 
            this.dgv_DanhSachMonAnChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachMonAnChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMonAnChon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dgv_DanhSachMonAnChon.Location = new System.Drawing.Point(18, 30);
            this.dgv_DanhSachMonAnChon.Name = "dgv_DanhSachMonAnChon";
            this.dgv_DanhSachMonAnChon.RowHeadersWidth = 51;
            this.dgv_DanhSachMonAnChon.RowTemplate.Height = 24;
            this.dgv_DanhSachMonAnChon.Size = new System.Drawing.Size(541, 201);
            this.dgv_DanhSachMonAnChon.TabIndex = 1;
            this.dgv_DanhSachMonAnChon.UseWaitCursor = true;
            this.dgv_DanhSachMonAnChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonAnChon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.cb_TimKiemMonAn);
            this.groupBox1.Controls.Add(this.txt_TimKiemDanhSachMonAn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(788, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 29);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cb_TimKiemMonAn
            // 
            this.cb_TimKiemMonAn.FormattingEnabled = true;
            this.cb_TimKiemMonAn.Location = new System.Drawing.Point(398, 5);
            this.cb_TimKiemMonAn.Name = "cb_TimKiemMonAn";
            this.cb_TimKiemMonAn.Size = new System.Drawing.Size(164, 26);
            this.cb_TimKiemMonAn.TabIndex = 1;
            // 
            // txt_TimKiemDanhSachMonAn
            // 
            this.txt_TimKiemDanhSachMonAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemDanhSachMonAn.Location = new System.Drawing.Point(162, 5);
            this.txt_TimKiemDanhSachMonAn.Name = "txt_TimKiemDanhSachMonAn";
            this.txt_TimKiemDanhSachMonAn.Size = new System.Drawing.Size(230, 24);
            this.txt_TimKiemDanhSachMonAn.TabIndex = 0;
            this.txt_TimKiemDanhSachMonAn.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cb_TimKiemDaChon);
            this.groupBox2.Controls.Add(this.txt_TimKiemDanhSachDaChon);
            this.groupBox2.Controls.Add(this.dgv_DanhSachMonAnChon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(360, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã chọn:";
            this.groupBox2.UseWaitCursor = true;
            // 
            // cb_TimKiemDaChon
            // 
            this.cb_TimKiemDaChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TimKiemDaChon.FormattingEnabled = true;
            this.cb_TimKiemDaChon.Location = new System.Drawing.Point(372, 3);
            this.cb_TimKiemDaChon.Name = "cb_TimKiemDaChon";
            this.cb_TimKiemDaChon.Size = new System.Drawing.Size(164, 26);
            this.cb_TimKiemDaChon.TabIndex = 1;
            this.cb_TimKiemDaChon.UseWaitCursor = true;
            // 
            // txt_TimKiemDanhSachDaChon
            // 
            this.txt_TimKiemDanhSachDaChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiemDanhSachDaChon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemDanhSachDaChon.Location = new System.Drawing.Point(164, 3);
            this.txt_TimKiemDanhSachDaChon.Name = "txt_TimKiemDanhSachDaChon";
            this.txt_TimKiemDanhSachDaChon.Size = new System.Drawing.Size(202, 24);
            this.txt_TimKiemDanhSachDaChon.TabIndex = 0;
            this.txt_TimKiemDanhSachDaChon.UseWaitCursor = true;
            this.txt_TimKiemDanhSachDaChon.TextChanged += new System.EventHandler(this.txt_TimKiemDanhSachChon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã tiệc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số lượng món:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thành tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã món ăn đã chọn:";
            // 
            // txt_MonAnChon
            // 
            this.txt_MonAnChon.Location = new System.Drawing.Point(176, 140);
            this.txt_MonAnChon.Name = "txt_MonAnChon";
            this.txt_MonAnChon.ReadOnly = true;
            this.txt_MonAnChon.Size = new System.Drawing.Size(146, 22);
            this.txt_MonAnChon.TabIndex = 5;
            // 
            // txt_MaTiec
            // 
            this.txt_MaTiec.Enabled = false;
            this.txt_MaTiec.Location = new System.Drawing.Point(176, 12);
            this.txt_MaTiec.Name = "txt_MaTiec";
            this.txt_MaTiec.Size = new System.Drawing.Size(146, 22);
            this.txt_MaTiec.TabIndex = 5;
            // 
            // txt_TongSoLuong
            // 
            this.txt_TongSoLuong.Enabled = false;
            this.txt_TongSoLuong.Location = new System.Drawing.Point(176, 41);
            this.txt_TongSoLuong.Name = "txt_TongSoLuong";
            this.txt_TongSoLuong.ReadOnly = true;
            this.txt_TongSoLuong.Size = new System.Drawing.Size(146, 22);
            this.txt_TongSoLuong.TabIndex = 5;
            this.txt_TongSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TongSoLuong_KeyPress);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(176, 68);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(146, 22);
            this.txt_ThanhTien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // txt_SoLuongMonAn
            // 
            this.txt_SoLuongMonAn.Location = new System.Drawing.Point(176, 168);
            this.txt_SoLuongMonAn.Name = "txt_SoLuongMonAn";
            this.txt_SoLuongMonAn.Size = new System.Drawing.Size(146, 22);
            this.txt_SoLuongMonAn.TabIndex = 5;
            this.txt_SoLuongMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuongMonAn_KeyPress);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.Location = new System.Drawing.Point(36, 205);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 29);
            this.btn_Them.TabIndex = 6;
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
            this.btn_CapNhat.Location = new System.Drawing.Point(205, 205);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(117, 29);
            this.btn_CapNhat.TabIndex = 6;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // UCDatMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.txt_TongSoLuong);
            this.Controls.Add(this.txt_MaTiec);
            this.Controls.Add(this.txt_SoLuongMonAn);
            this.Controls.Add(this.txt_MonAnChon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachMonAn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCDatMonAn";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCDatMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonAnChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachMonAn;
        private System.Windows.Forms.DataGridView dgv_DanhSachMonAnChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiemDanhSachDaChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimKiemDanhSachMonAn;
        private System.Windows.Forms.ComboBox cb_TimKiemDaChon;
        private System.Windows.Forms.ComboBox cb_TimKiemMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_MonAnChon;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.TextBox txt_TongSoLuong;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoLuongMonAn;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
    }
}
