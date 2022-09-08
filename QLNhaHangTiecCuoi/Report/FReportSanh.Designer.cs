
namespace QLNhaHangTiecCuoi.Report
{
    partial class FReportSanh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLNhaHangDataSet = new QLNhaHangTiecCuoi.QLNhaHangDataSet();
            this.qLNhaHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new QLNhaHangTiecCuoi.QLNhaHangDataSetTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNhaHangTiecCuoi.ReportSanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLNhaHangDataSet
            // 
            this.qLNhaHangDataSet.DataSetName = "QLNhaHangDataSet";
            this.qLNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNhaHangDataSetBindingSource
            // 
            this.qLNhaHangDataSetBindingSource.DataSource = this.qLNhaHangDataSet;
            this.qLNhaHangDataSetBindingSource.Position = 0;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.qLNhaHangDataSetBindingSource;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FReportSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReportSanh";
            this.Text = "FReportSanh";
            this.Load += new System.EventHandler(this.FReportSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLNhaHangDataSetBindingSource;
        private QLNhaHangDataSet qLNhaHangDataSet;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private QLNhaHangDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
    }
}