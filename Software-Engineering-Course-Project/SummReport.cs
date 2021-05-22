using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Software_Engineering_Course_Project
{
    public partial class SummReport : Form
    {
        public SummReport()
        {
            InitializeComponent();
        }

        private void SummReport_Load(object sender, EventArgs e)
        {
            CrystalReport3 CR3 = new CrystalReport3();
            crystalReportViewer1.ReportSource = CR3;

        }
    }
}
