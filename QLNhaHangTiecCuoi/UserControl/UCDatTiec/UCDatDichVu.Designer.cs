
namespace QLNhaHangTiecCuoi
{
    partial class UCDatDichVu
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
            this.dgv_DanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.dgv_DanhSachDichVuChon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cb_TimKiemDichVu = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDanhSachDichVu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TimKiemDaChon = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDanhSachDaChon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DichVuChon = new System.Windows.Forms.TextBox();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.txt_TongSoLuong = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVuChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachDichVu
            // 
            this.dgv_DanhSachDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu.Location = new System.Drawing.Point(1, 271);
            this.dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            this.dgv_DanhSachDichVu.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu.RowTemplate.Height = 24;
            this.dgv_DanhSachDichVu.Size = new System.Drawing.Size(920, 349);
            this.dgv_DanhSachDichVu.TabIndex = 0;
            this.dgv_DanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDichVu_CellClick);
            // 
            // dgv_DanhSachDichVuChon
            // 
            this.dgv_DanhSachDichVuChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachDichVuChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachDichVuChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVuChon.Location = new System.Drawing.Point(6, 30);
            this.dgv_DanhSachDichVuChon.Name = "dgv_DanhSachDichVuChon";
            this.dgv_DanhSachDichVuChon.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVuChon.RowTemplate.Height = 24;
            this.dgv_DanhSachDichVuChon.Size = new System.Drawing.Size(553, 201);
            this.dgv_DanhSachDichVuChon.TabIndex = 1;
            this.dgv_DanhSachDichVuChon.UseWaitCursor = true;
            this.dgv_DanhSachDichVuChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDichVuChon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.cb_TimKiemDichVu);
            this.groupBox1.Controls.Add(this.txt_TimKiemDanhSachDichVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(797, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 29);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cb_TimKiemDichVu
            // 
            this.cb_TimKiemDichVu.FormattingEnabled = true;
            this.cb_TimKiemDichVu.Location = new System.Drawing.Point(398, 0);
            this.cb_TimKiemDichVu.Name = "cb_TimKiemDichVu";
            this.cb_TimKiemDichVu.Size = new System.Drawing.Size(164, 26);
            this.cb_TimKiemDichVu.TabIndex = 1;
            // 
            // txt_TimKiemDanhSachDichVu
            // 
            this.txt_TimKiemDanhSachDichVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemDanhSachDichVu.Location = new System.Drawing.Point(162, 0);
            this.txt_TimKiemDanhSachDichVu.Name = "txt_TimKiemDanhSachDichVu";
            this.txt_TimKiemDanhSachDichVu.Size = new System.Drawing.Size(230, 24);
            this.txt_TimKiemDanhSachDichVu.TabIndex = 0;
            this.txt_TimKiemDanhSachDichVu.TextChanged += new System.EventHandler(this.txt_TimKiemDanhSachDichVu_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cb_TimKiemDaChon);
            this.groupBox2.Controls.Add(this.txt_TimKiemDanhSachDaChon);
            this.groupBox2.Controls.Add(this.dgv_DanhSachDichVuChon);
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
            this.txt_TimKiemDanhSachDaChon.TextChanged += new System.EventHandler(this.txt_TimKiemDanhSachDaChon_TextChanged);
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
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số dịch vụ:";
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
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã dịch vụ đã chọn:";
            // 
            // txt_DichVuChon
            // 
            this.txt_DichVuChon.Enabled = false;
            this.txt_DichVuChon.Location = new System.Drawing.Point(176, 140);
            this.txt_DichVuChon.Name = "txt_DichVuChon";
            this.txt_DichVuChon.ReadOnly = true;
            this.txt_DichVuChon.Size = new System.Drawing.Size(146, 22);
            this.txt_DichVuChon.TabIndex = 5;
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
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Brown;
            this.btn_Them.Location = new System.Drawing.Point(127, 202);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 29);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá tiền:";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Enabled = false;
            this.txt_GiaTien.Location = new System.Drawing.Point(176, 168);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.ReadOnly = true;
            this.txt_GiaTien.Size = new System.Drawing.Size(146, 22);
            this.txt_GiaTien.TabIndex = 5;
            // 
            // UCDatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_ThanhTien);
            this.Controls.Add(this.txt_TongSoLuong);
            this.Controls.Add(this.txt_MaTiec);
            this.Controls.Add(this.txt_GiaTien);
            this.Controls.Add(this.txt_DichVuChon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachDichVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCDatDichVu";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCDatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVuChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVuChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiemDanhSachDaChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimKiemDanhSachDichVu;
        private System.Windows.Forms.ComboBox cb_TimKiemDaChon;
        private System.Windows.Forms.ComboBox cb_TimKiemDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_DichVuChon;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.TextBox txt_TongSoLuong;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaTien;
    }
}
