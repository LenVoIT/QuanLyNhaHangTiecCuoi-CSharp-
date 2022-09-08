
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyHoaDon
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
            this.dgv_DanhSachHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.cb_DanhSachHoaDon = new System.Windows.Forms.ComboBox();
            this.txt_DoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.txt_NgayLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachHD
            // 
            this.dgv_DanhSachHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHD.Location = new System.Drawing.Point(3, 269);
            this.dgv_DanhSachHD.Name = "dgv_DanhSachHD";
            this.dgv_DanhSachHD.RowHeadersWidth = 51;
            this.dgv_DanhSachHD.RowTemplate.Height = 24;
            this.dgv_DanhSachHD.Size = new System.Drawing.Size(918, 292);
            this.dgv_DanhSachHD.TabIndex = 0;
            this.dgv_DanhSachHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHD_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.cb_DanhSachHoaDon);
            this.groupBox1.Controls.Add(this.txt_DoanhThu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn:";
            // 
            // dtp_To
            // 
            this.dtp_To.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Location = new System.Drawing.Point(464, 3);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(199, 22);
            this.dtp_To.TabIndex = 7;
            this.dtp_To.ValueChanged += new System.EventHandler(this.dtp_To_ValueChanged);
            // 
            // cb_DanhSachHoaDon
            // 
            this.cb_DanhSachHoaDon.FormattingEnabled = true;
            this.cb_DanhSachHoaDon.Location = new System.Drawing.Point(681, 1);
            this.cb_DanhSachHoaDon.Name = "cb_DanhSachHoaDon";
            this.cb_DanhSachHoaDon.Size = new System.Drawing.Size(239, 26);
            this.cb_DanhSachHoaDon.TabIndex = 1;
            this.cb_DanhSachHoaDon.SelectedIndexChanged += new System.EventHandler(this.cb_DanhSachHoaDon_SelectedIndexChanged);
            this.cb_DanhSachHoaDon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_DanhSachHoaDon_KeyPress);
            // 
            // txt_DoanhThu
            // 
            this.txt_DoanhThu.Enabled = false;
            this.txt_DoanhThu.Location = new System.Drawing.Point(729, 343);
            this.txt_DoanhThu.Name = "txt_DoanhThu";
            this.txt_DoanhThu.Size = new System.Drawing.Size(191, 24);
            this.txt_DoanhThu.TabIndex = 5;
            this.txt_DoanhThu.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            this.label2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(602, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doanh thu:";
            this.label7.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_TinhTrang);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_MaHoaDon);
            this.groupBox2.Controls.Add(this.txt_MaTiec);
            this.groupBox2.Controls.Add(this.txt_NgayLap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn đã chọn:";
            this.groupBox2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hóa đơn:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã tiệc:";
            this.label5.UseWaitCursor = true;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Enabled = false;
            this.txt_TinhTrang.Location = new System.Drawing.Point(651, 116);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.ReadOnly = true;
            this.txt_TinhTrang.Size = new System.Drawing.Size(191, 24);
            this.txt_TinhTrang.TabIndex = 5;
            this.txt_TinhTrang.UseWaitCursor = true;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(651, 72);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(191, 24);
            this.txt_ThanhTien.TabIndex = 5;
            this.txt_ThanhTien.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày lập:";
            this.label6.UseWaitCursor = true;
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.Enabled = false;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(181, 30);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.ReadOnly = true;
            this.txt_MaHoaDon.Size = new System.Drawing.Size(191, 24);
            this.txt_MaHoaDon.TabIndex = 5;
            this.txt_MaHoaDon.UseWaitCursor = true;
            // 
            // txt_MaTiec
            // 
            this.txt_MaTiec.Enabled = false;
            this.txt_MaTiec.Location = new System.Drawing.Point(181, 75);
            this.txt_MaTiec.Name = "txt_MaTiec";
            this.txt_MaTiec.ReadOnly = true;
            this.txt_MaTiec.Size = new System.Drawing.Size(191, 24);
            this.txt_MaTiec.TabIndex = 5;
            this.txt_MaTiec.UseWaitCursor = true;
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.Enabled = false;
            this.txt_NgayLap.Location = new System.Drawing.Point(181, 120);
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.ReadOnly = true;
            this.txt_NgayLap.Size = new System.Drawing.Size(191, 24);
            this.txt_NgayLap.TabIndex = 5;
            this.txt_NgayLap.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tình trạng:";
            this.label3.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thành tiền:";
            this.label8.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            this.label1.UseWaitCursor = true;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ChiTiet.Location = new System.Drawing.Point(268, 204);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(117, 29);
            this.btn_ChiTiet.TabIndex = 6;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // dtp_From
            // 
            this.dtp_From.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From.Location = new System.Drawing.Point(465, 211);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(199, 22);
            this.dtp_From.TabIndex = 7;
            this.dtp_From.ValueChanged += new System.EventHandler(this.dtp_From_ValueChanged);
            // 
            // UCQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.dgv_DanhSachHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCQuanLyHoaDon";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_DanhSachHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.TextBox txt_NgayLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.TextBox txt_DoanhThu;
        private System.Windows.Forms.Label label7;
    }
}
