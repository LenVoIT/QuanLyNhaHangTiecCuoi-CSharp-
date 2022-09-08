
namespace QLNhaHangTiecCuoi
{
    partial class UCDatSanh
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
            this.dgv_DanhSachSanh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimKiemSanh = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemSanh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaThue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaSanh = new System.Windows.Forms.TextBox();
            this.txt_TenSanh = new System.Windows.Forms.TextBox();
            this.txt_Tang = new System.Windows.Forms.TextBox();
            this.txt_SucChua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dat = new System.Windows.Forms.Button();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_NgayToChuc = new System.Windows.Forms.DateTimePicker();
            this.cb_Buoi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachSanh
            // 
            this.dgv_DanhSachSanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachSanh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanh.Location = new System.Drawing.Point(3, 269);
            this.dgv_DanhSachSanh.Name = "dgv_DanhSachSanh";
            this.dgv_DanhSachSanh.RowHeadersWidth = 51;
            this.dgv_DanhSachSanh.RowTemplate.Height = 24;
            this.dgv_DanhSachSanh.Size = new System.Drawing.Size(918, 351);
            this.dgv_DanhSachSanh.TabIndex = 0;
            this.dgv_DanhSachSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanh_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTimKiemSanh);
            this.groupBox1.Controls.Add(this.txt_TimKiemSanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sảnh cưới:";
            // 
            // cbTimKiemSanh
            // 
            this.cbTimKiemSanh.FormattingEnabled = true;
            this.cbTimKiemSanh.Location = new System.Drawing.Point(398, 0);
            this.cbTimKiemSanh.Name = "cbTimKiemSanh";
            this.cbTimKiemSanh.Size = new System.Drawing.Size(164, 26);
            this.cbTimKiemSanh.TabIndex = 1;
            // 
            // txt_TimKiemSanh
            // 
            this.txt_TimKiemSanh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemSanh.Location = new System.Drawing.Point(195, 0);
            this.txt_TimKiemSanh.Name = "txt_TimKiemSanh";
            this.txt_TimKiemSanh.Size = new System.Drawing.Size(191, 24);
            this.txt_TimKiemSanh.TabIndex = 0;
            this.txt_TimKiemSanh.TextChanged += new System.EventHandler(this.txt_TimKiemSanh_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_GiaThue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_MaSanh);
            this.groupBox2.Controls.Add(this.txt_TenSanh);
            this.groupBox2.Controls.Add(this.txt_Tang);
            this.groupBox2.Controls.Add(this.txt_SucChua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(459, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 187);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sảnh đã chọn:";
            this.groupBox2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã sảnh cưới:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sảnh cưới:";
            this.label5.UseWaitCursor = true;
            // 
            // txt_GiaThue
            // 
            this.txt_GiaThue.Enabled = false;
            this.txt_GiaThue.Location = new System.Drawing.Point(181, 138);
            this.txt_GiaThue.Name = "txt_GiaThue";
            this.txt_GiaThue.Size = new System.Drawing.Size(191, 24);
            this.txt_GiaThue.TabIndex = 5;
            this.txt_GiaThue.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tầng:";
            this.label6.UseWaitCursor = true;
            // 
            // txt_MaSanh
            // 
            this.txt_MaSanh.Enabled = false;
            this.txt_MaSanh.Location = new System.Drawing.Point(181, 30);
            this.txt_MaSanh.Name = "txt_MaSanh";
            this.txt_MaSanh.Size = new System.Drawing.Size(191, 24);
            this.txt_MaSanh.TabIndex = 5;
            this.txt_MaSanh.UseWaitCursor = true;
            // 
            // txt_TenSanh
            // 
            this.txt_TenSanh.Enabled = false;
            this.txt_TenSanh.Location = new System.Drawing.Point(181, 57);
            this.txt_TenSanh.Name = "txt_TenSanh";
            this.txt_TenSanh.Size = new System.Drawing.Size(191, 24);
            this.txt_TenSanh.TabIndex = 5;
            this.txt_TenSanh.UseWaitCursor = true;
            // 
            // txt_Tang
            // 
            this.txt_Tang.Enabled = false;
            this.txt_Tang.Location = new System.Drawing.Point(181, 84);
            this.txt_Tang.Name = "txt_Tang";
            this.txt_Tang.Size = new System.Drawing.Size(191, 24);
            this.txt_Tang.TabIndex = 5;
            this.txt_Tang.UseWaitCursor = true;
            // 
            // txt_SucChua
            // 
            this.txt_SucChua.Enabled = false;
            this.txt_SucChua.Location = new System.Drawing.Point(181, 111);
            this.txt_SucChua.Name = "txt_SucChua";
            this.txt_SucChua.Size = new System.Drawing.Size(191, 24);
            this.txt_SucChua.TabIndex = 5;
            this.txt_SucChua.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sức chứa:";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giá thuê:";
            this.label8.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã tiệc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày tổ chức:";
            // 
            // btn_Dat
            // 
            this.btn_Dat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Dat.Location = new System.Drawing.Point(270, 195);
            this.btn_Dat.Name = "btn_Dat";
            this.btn_Dat.Size = new System.Drawing.Size(117, 29);
            this.btn_Dat.TabIndex = 6;
            this.btn_Dat.Text = "Đặt sảnh";
            this.btn_Dat.UseVisualStyleBackColor = false;
            this.btn_Dat.Click += new System.EventHandler(this.btn_Dat_Click);
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Location = new System.Drawing.Point(196, 79);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(191, 22);
            this.txt_MaKH.TabIndex = 5;
            // 
            // txt_MaTiec
            // 
            this.txt_MaTiec.Enabled = false;
            this.txt_MaTiec.Location = new System.Drawing.Point(196, 42);
            this.txt_MaTiec.Name = "txt_MaTiec";
            this.txt_MaTiec.Size = new System.Drawing.Size(191, 22);
            this.txt_MaTiec.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Buổi:";
            // 
            // dtp_NgayToChuc
            // 
            this.dtp_NgayToChuc.Location = new System.Drawing.Point(196, 116);
            this.dtp_NgayToChuc.Name = "dtp_NgayToChuc";
            this.dtp_NgayToChuc.Size = new System.Drawing.Size(191, 22);
            this.dtp_NgayToChuc.TabIndex = 7;
            // 
            // cb_Buoi
            // 
            this.cb_Buoi.FormattingEnabled = true;
            this.cb_Buoi.Location = new System.Drawing.Point(196, 153);
            this.cb_Buoi.Name = "cb_Buoi";
            this.cb_Buoi.Size = new System.Drawing.Size(191, 24);
            this.cb_Buoi.TabIndex = 8;
            this.cb_Buoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Buoi_KeyPress);
            // 
            // UCDatSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cb_Buoi);
            this.Controls.Add(this.dtp_NgayToChuc);
            this.Controls.Add(this.btn_Dat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaTiec);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DanhSachSanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCDatSanh";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCDatSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachSanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimKiemSanh;
        private System.Windows.Forms.ComboBox cbTimKiemSanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Dat;
        private System.Windows.Forms.TextBox txt_GiaThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaSanh;
        private System.Windows.Forms.TextBox txt_TenSanh;
        private System.Windows.Forms.TextBox txt_Tang;
        private System.Windows.Forms.TextBox txt_SucChua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_NgayToChuc;
        private System.Windows.Forms.ComboBox cb_Buoi;
    }
}
