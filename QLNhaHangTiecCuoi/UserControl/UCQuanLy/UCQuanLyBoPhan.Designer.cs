
namespace QLNhaHangTiecCuoi
{
    partial class UCQuanLyBoPhan
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
            this.lbl_TenBP = new System.Windows.Forms.Label();
            this.txt_TenBoPhan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachBoPhan = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuongNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenBP
            // 
            this.lbl_TenBP.AutoSize = true;
            this.lbl_TenBP.Location = new System.Drawing.Point(14, 64);
            this.lbl_TenBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenBP.Name = "lbl_TenBP";
            this.lbl_TenBP.Size = new System.Drawing.Size(89, 17);
            this.lbl_TenBP.TabIndex = 4;
            this.lbl_TenBP.Text = "Tên bộ phận";
            // 
            // txt_TenBoPhan
            // 
            this.txt_TenBoPhan.Location = new System.Drawing.Point(160, 59);
            this.txt_TenBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenBoPhan.Name = "txt_TenBoPhan";
            this.txt_TenBoPhan.Size = new System.Drawing.Size(173, 22);
            this.txt_TenBoPhan.TabIndex = 5;
            this.txt_TenBoPhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenBoPhan_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgv_DanhSachNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(4, 324);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(917, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên thuộc bộ phận";
            // 
            // dgv_DanhSachNhanVien
            // 
            this.dgv_DanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNhanVien.Location = new System.Drawing.Point(0, 23);
            this.dgv_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachNhanVien.Name = "dgv_DanhSachNhanVien";
            this.dgv_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dgv_DanhSachNhanVien.Size = new System.Drawing.Size(917, 272);
            this.dgv_DanhSachNhanVien.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachBoPhan);
            this.groupBox2.Location = new System.Drawing.Point(345, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(576, 270);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bộ phận";
            // 
            // dgv_DanhSachBoPhan
            // 
            this.dgv_DanhSachBoPhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachBoPhan.Location = new System.Drawing.Point(0, 30);
            this.dgv_DanhSachBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachBoPhan.Name = "dgv_DanhSachBoPhan";
            this.dgv_DanhSachBoPhan.RowHeadersWidth = 51;
            this.dgv_DanhSachBoPhan.Size = new System.Drawing.Size(576, 232);
            this.dgv_DanhSachBoPhan.TabIndex = 0;
            this.dgv_DanhSachBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachBoPhan_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Them.Location = new System.Drawing.Point(17, 198);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 7;
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
            this.btn_CapNhat.Location = new System.Drawing.Point(130, 198);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(94, 37);
            this.btn_CapNhat.TabIndex = 7;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(252, 198);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng nhân viên:";
            // 
            // txt_SoLuongNhanVien
            // 
            this.txt_SoLuongNhanVien.Enabled = false;
            this.txt_SoLuongNhanVien.Location = new System.Drawing.Point(160, 90);
            this.txt_SoLuongNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuongNhanVien.Name = "txt_SoLuongNhanVien";
            this.txt_SoLuongNhanVien.ReadOnly = true;
            this.txt_SoLuongNhanVien.Size = new System.Drawing.Size(173, 22);
            this.txt_SoLuongNhanVien.TabIndex = 5;
            // 
            // UCQuanLyBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_SoLuongNhanVien);
            this.Controls.Add(this.txt_TenBoPhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenBP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLyBoPhan";
            this.Size = new System.Drawing.Size(925, 623);
            this.Load += new System.EventHandler(this.UCQuanLyBoPhan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBoPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TenBP;
        private System.Windows.Forms.TextBox txt_TenBoPhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSachNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachBoPhan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuongNhanVien;
    }
}
