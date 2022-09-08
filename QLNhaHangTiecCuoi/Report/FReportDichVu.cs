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
    public partial class FReportDichVu : Form
    {
        public FReportDichVu()
        {
            InitializeComponent();
        }

        private void FReportDichVu_Load(object sender, EventArgs e)
        {
            this.qLNhaHangDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.qLNhaHangDataSet.DataTable1);
            this.reportViewer1.RefreshReport();
        }
    }
}
