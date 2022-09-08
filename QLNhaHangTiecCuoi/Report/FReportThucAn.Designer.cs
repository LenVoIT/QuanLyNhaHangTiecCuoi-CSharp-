
namespace QLNhaHangTiecCuoi.Report
{
    partial class FReportThucAn
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
            this.tableThucAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaHangDataSet = new QLNhaHangTiecCuoi.QLNhaHangDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableThucAnTableAdapter = new QLNhaHangTiecCuoi.QLNhaHangDataSetTableAdapters.TableThucAnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableThucAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableThucAnBindingSource
            // 
            this.tableThucAnBindingSource.DataMember = "TableThucAn";
            this.tableThucAnBindingSource.DataSource = this.qLNhaHangDataSetBindingSource;
            // 
            // qLNhaHangDataSetBindingSource
            // 
            this.qLNhaHangDataSetBindingSource.DataSource = this.qLNhaHangDataSet;
            this.qLNhaHangDataSetBindingSource.Position = 0;
            // 
            // qLNhaHangDataSet
            // 
            this.qLNhaHangDataSet.DataSetName = "QLNhaHangDataSet";
            this.qLNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tableThucAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNhaHangTiecCuoi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(964, 617);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableThucAnTableAdapter
            // 
            this.tableThucAnTableAdapter.ClearBeforeFill = true;
            // 
            // FReportThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 617);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReportThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FReportThucAn";
            this.Load += new System.EventHandler(this.FReportThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableThucAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLNhaHangDataSetBindingSource;
        private QLNhaHangDataSet qLNhaHangDataSet;
        private System.Windows.Forms.BindingSource tableThucAnBindingSource;
        private QLNhaHangDataSetTableAdapters.TableThucAnTableAdapter tableThucAnTableAdapter;
    }
}