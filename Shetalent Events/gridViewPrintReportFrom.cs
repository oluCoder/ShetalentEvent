using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shetalent_Events
{
    public partial class gridViewPrintReportFrom : Form
    {
        List<DGVClass> _list;


        public gridViewPrintReportFrom()
        {
        }

        public gridViewPrintReportFrom(List<DGVClass> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void gridViewPrintReportFrom_Load(object sender, EventArgs e)
        {
            gridViewReport1.SetDataSource(_list);

            crystalReportViewer1.ReportSource = gridViewReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
