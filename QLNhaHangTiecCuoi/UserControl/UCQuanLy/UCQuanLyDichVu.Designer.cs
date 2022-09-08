
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_TenDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cb_TimKiemDichVu = new System.Windows.Forms.ComboBox();
            this.txt_TimKiemDanhSachDichVu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.Location = new System.Drawing.Point(387, 188);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 30);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(184, 98);
            this.txt_GiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(145, 22);
            this.txt_GiaTien.TabIndex = 18;
            this.txt_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaTien_KeyPress);
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Location = new System.Drawing.Point(184, 58);
            this.txt_TenDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Size = new System.Drawing.Size(217, 22);
            this.txt_TenDichVu.TabIndex = 19;
            this.txt_TenDichVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenDichVu_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên dịch vụ:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(663, 188);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 30);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cb_TimKiemDichVu
            // 
            this.cb_TimKiemDichVu.FormattingEnabled = true;
            this.cb_TimKiemDichVu.Location = new System.Drawing.Point(397, 0);
            this.cb_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TimKiemDichVu.Name = "cb_TimKiemDichVu";
            this.cb_TimKiemDichVu.Size = new System.Drawing.Size(164, 26);
            this.cb_TimKiemDichVu.TabIndex = 1;
            this.cb_TimKiemDichVu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_TimKiemDichVu_KeyPress);
            // 
            // txt_TimKiemDanhSachDichVu
            // 
            this.txt_TimKiemDanhSachDichVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiemDanhSachDichVu.Location = new System.Drawing.Point(163, 0);
            this.txt_TimKiemDanhSachDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiemDanhSachDichVu.Name = "txt_TimKiemDanhSachDichVu";
            this.txt_TimKiemDanhSachDichVu.Size = new System.Drawing.Size(231, 24);
            this.txt_TimKiemDanhSachDichVu.TabIndex = 0;
            this.txt_TimKiemDanhSachDichVu.TextChanged += new System.EventHandler(this.txt_TimKiemDanhSachDichVu_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_DanhSachDichVu);
            this.groupBox1.Controls.Add(this.cb_TimKiemDichVu);
            this.groupBox1.Controls.Add(this.txt_TimKiemDanhSachDichVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(920, 376);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ:";
            // 
            // dgv_DanhSachDichVu
            // 
            this.dgv_DanhSachDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu.Location = new System.Drawing.Point(6, 29);
            this.dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            this.dgv_DanhSachDichVu.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu.RowTemplate.Height = 24;
            this.dgv_DanhSachDichVu.Size = new System.Drawing.Size(915, 345);
            this.dgv_DanhSachDichVu.TabIndex = 2;
            this.dgv_DanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDichVu_CellClick_1);
            // 
            // dgvDanhSachDichVu
            // 
            this.dgvDanhSachDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachDichVu.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDichVu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachDichVu.Location = new System.Drawing.Point(0, 271);
            this.dgvDanhSachDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachDichVu.Name = "dgvDanhSachDichVu";
            this.dgvDanhSachDichVu.RowHeadersWidth = 51;
            this.dgvDanhSachDichVu.RowTemplate.Height = 24;
            this.dgvDanhSachDichVu.Size = new System.Drawing.Size(919, 351);
            this.dgvDanhSachDichVu.TabIndex = 7;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Maroon;
            this.btn_CapNhat.Location = new System.Drawing.Point(525, 188);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(117, 30);
            this.btn_CapNhat.TabIndex = 20;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ThongKe.Location = new System.Drawing.Point(801, 188);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(117, 30);
            this.btn_ThongKe.TabIndex = 21;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // UCQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_GiaTien);
            this.Controls.Add(this.txt_TenDichVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDanhSachDichVu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLyDichVu";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCQuanLyDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.TextBox txt_TenDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cb_TimKiemDichVu;
        private System.Windows.Forms.TextBox txt_TimKiemDanhSachDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachDichVu;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}
