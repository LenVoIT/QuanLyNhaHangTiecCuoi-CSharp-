
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
            this.lbl_MaBP = new System.Windows.Forms.Label();
            this.lbl_TenBP = new System.Windows.Forms.Label();
            this.txt_MaBoPhan = new System.Windows.Forms.TextBox();
            this.txt_TenBoPhan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TimKiem = new System.Windows.Forms.ComboBox();
            this.dtg_DanhSachBoPhan = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaBP
            // 
            this.lbl_MaBP.AutoSize = true;
            this.lbl_MaBP.Location = new System.Drawing.Point(19, 59);
            this.lbl_MaBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaBP.Name = "lbl_MaBP";
            this.lbl_MaBP.Size = new System.Drawing.Size(83, 17);
            this.lbl_MaBP.TabIndex = 4;
            this.lbl_MaBP.Text = "Mã bộ phận";
            // 
            // lbl_TenBP
            // 
            this.lbl_TenBP.AutoSize = true;
            this.lbl_TenBP.Location = new System.Drawing.Point(19, 110);
            this.lbl_TenBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenBP.Name = "lbl_TenBP";
            this.lbl_TenBP.Size = new System.Drawing.Size(89, 17);
            this.lbl_TenBP.TabIndex = 4;
            this.lbl_TenBP.Text = "Tên bộ phận";
            // 
            // txt_MaBoPhan
            // 
            this.txt_MaBoPhan.Location = new System.Drawing.Point(137, 54);
            this.txt_MaBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaBoPhan.Name = "txt_MaBoPhan";
            this.txt_MaBoPhan.Size = new System.Drawing.Size(201, 22);
            this.txt_MaBoPhan.TabIndex = 5;
            // 
            // txt_TenBoPhan
            // 
            this.txt_TenBoPhan.Location = new System.Drawing.Point(137, 105);
            this.txt_TenBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenBoPhan.Name = "txt_TenBoPhan";
            this.txt_TenBoPhan.Size = new System.Drawing.Size(201, 22);
            this.txt_TenBoPhan.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dtg_DanhSachNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(346, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(575, 270);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên thuộc bộ phận";
            // 
            // dtg_DanhSachNhanVien
            // 
            this.dtg_DanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachNhanVien.Location = new System.Drawing.Point(8, 23);
            this.dtg_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_DanhSachNhanVien.Name = "dtg_DanhSachNhanVien";
            this.dtg_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dtg_DanhSachNhanVien.Size = new System.Drawing.Size(567, 230);
            this.dtg_DanhSachNhanVien.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_TimKiem);
            this.groupBox2.Controls.Add(this.dtg_DanhSachBoPhan);
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Location = new System.Drawing.Point(4, 319);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(921, 304);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bộ phận";
            // 
            // cb_TimKiem
            // 
            this.cb_TimKiem.FormattingEnabled = true;
            this.cb_TimKiem.Location = new System.Drawing.Point(388, 0);
            this.cb_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TimKiem.Name = "cb_TimKiem";
            this.cb_TimKiem.Size = new System.Drawing.Size(181, 24);
            this.cb_TimKiem.TabIndex = 8;
            // 
            // dtg_DanhSachBoPhan
            // 
            this.dtg_DanhSachBoPhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_DanhSachBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachBoPhan.Location = new System.Drawing.Point(0, 30);
            this.dtg_DanhSachBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_DanhSachBoPhan.Name = "dtg_DanhSachBoPhan";
            this.dtg_DanhSachBoPhan.RowHeadersWidth = 51;
            this.dtg_DanhSachBoPhan.Size = new System.Drawing.Size(917, 270);
            this.dtg_DanhSachBoPhan.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(165, 0);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(215, 22);
            this.txt_TimKiem.TabIndex = 5;
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
            // 
            // UCQuanLyBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_TenBoPhan);
            this.Controls.Add(this.txt_MaBoPhan);
            this.Controls.Add(this.lbl_TenBP);
            this.Controls.Add(this.lbl_MaBP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQuanLyBoPhan";
            this.Size = new System.Drawing.Size(925, 623);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachBoPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaBP;
        private System.Windows.Forms.Label lbl_TenBP;
        private System.Windows.Forms.TextBox txt_MaBoPhan;
        private System.Windows.Forms.TextBox txt_TenBoPhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_DanhSachNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_DanhSachBoPhan;
        private System.Windows.Forms.ComboBox cb_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
    }
}
