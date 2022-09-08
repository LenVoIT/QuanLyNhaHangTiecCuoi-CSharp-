
namespace QLNhaHangTiecCuoi
{
    partial class FTiecDaDat
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

        private void InitializeComponent()
        {
            this.dgv_TiecDaDat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TroLai = new System.Windows.Forms.Button();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaTiec = new System.Windows.Forms.TextBox();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiecDaDat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TiecDaDat
            // 
            this.dgv_TiecDaDat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TiecDaDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_TiecDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TiecDaDat.Location = new System.Drawing.Point(1, 208);
            this.dgv_TiecDaDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TiecDaDat.Name = "dgv_TiecDaDat";
            this.dgv_TiecDaDat.RowHeadersWidth = 51;
            this.dgv_TiecDaDat.RowTemplate.Height = 24;
            this.dgv_TiecDaDat.Size = new System.Drawing.Size(939, 242);
            this.dgv_TiecDaDat.TabIndex = 1;
            this.dgv_TiecDaDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TiecDaDat_CellClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(939, 64);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh Sách Tiệc Đã Đặt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TroLai
            // 
            this.btn_TroLai.BackColor = System.Drawing.Color.Transparent;
            this.btn_TroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroLai.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TroLai.Location = new System.Drawing.Point(8, 456);
            this.btn_TroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TroLai.Name = "btn_TroLai";
            this.btn_TroLai.Size = new System.Drawing.Size(132, 41);
            this.btn_TroLai.TabIndex = 9;
            this.btn_TroLai.Text = "Quay lại";
            this.btn_TroLai.UseVisualStyleBackColor = false;
            this.btn_TroLai.Click += new System.EventHandler(this.btn_TroLai_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(159, 165);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.Size = new System.Drawing.Size(241, 32);
            this.txt_HoTen.TabIndex = 13;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Enabled = false;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(159, 112);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.ReadOnly = true;
            this.txt_TaiKhoan.Size = new System.Drawing.Size(241, 32);
            this.txt_TaiKhoan.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ Tên :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tài Khoản :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông tin tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã tiệc:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MaTiec
            // 
            this.txt_MaTiec.Enabled = false;
            this.txt_MaTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTiec.Location = new System.Drawing.Point(621, 110);
            this.txt_MaTiec.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaTiec.Multiline = true;
            this.txt_MaTiec.Name = "txt_MaTiec";
            this.txt_MaTiec.ReadOnly = true;
            this.txt_MaTiec.Size = new System.Drawing.Size(241, 32);
            this.txt_MaTiec.TabIndex = 13;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ChiTiet.Location = new System.Drawing.Point(795, 456);
            this.btn_ChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(132, 41);
            this.btn_ChiTiet.TabIndex = 9;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xoa.Location = new System.Drawing.Point(642, 456);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(132, 41);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Hủy";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FTiecDaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 503);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_MaTiec);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.btn_TroLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_TiecDaDat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTiecDaDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiệc đã đặt";
            this.Load += new System.EventHandler(this.FTiecDaDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiecDaDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.DataGridView dgv_TiecDaDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TroLai;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaTiec;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_Xoa;
    }
}