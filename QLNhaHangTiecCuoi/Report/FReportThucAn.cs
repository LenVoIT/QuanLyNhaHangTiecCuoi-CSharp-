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
    public partial class FReportThucAn : Form
    {
        public FReportThucAn()
        {
            InitializeComponent();
        }

        private void FReportThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangDataSet.TableThucAn' table. You can move, or remove it, as needed.
            this.qLNhaHangDataSet.EnforceConstraints = false;
            this.tableThucAnTableAdapter.Fill(this.qLNhaHangDataSet.TableThucAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
