using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaHangTiecCuoi.Report
{
    public partial class FReportSanh : Form
    {
        public FReportSanh()
        {
            InitializeComponent();
        }

        private void FReportSanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.qLNhaHangDataSet.EnforceConstraints = false;
            this.dataTable2TableAdapter.Fill(this.qLNhaHangDataSet.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
