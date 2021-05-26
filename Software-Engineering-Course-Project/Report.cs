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
    public partial class Report : Form
    {
        CrystalReport1 CR1;
        CrystalReport2 CR2;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1();
            CR2 = new CrystalReport2();

            foreach (ParameterDiscreteValue v in CR1.ParameterFields[0].DefaultValues)
            {
                cb_cust_id.Items.Add(v.Value);
            }

            foreach (ParameterDiscreteValue v in CR2.ParameterFields[0].DefaultValues)
            {
                cb_plan.Items.Add(v.Value);
            }

            if (custReport.Checked)
            {
                cb_plan.Enabled = false;
            }
            else if (planCustReport.Checked)
            {
                cb_plan.Enabled = true;
            }

        }
        void radioSelectChange()
        {
            if (custReport.Checked)
            {
                cb_plan.Enabled = false;
                CR1.SetParameterValue(0, cb_cust_id.Text);
                crystalReportViewer1.ReportSource = CR1;
            }
            else if (planCustReport.Checked)
            {
                cb_plan.Enabled = true;
                CR2.SetParameterValue(0, cb_plan.Text);
                crystalReportViewer1.ReportSource = CR2;
            }

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (custReport.Checked)
            {
                try
                {
                    CR1.SetParameterValue(0, cb_cust_id.Text);
                    crystalReportViewer1.ReportSource = CR1;
                }
                catch { MessageBox.Show("Select an ID"); }
              
            }
            else if (planCustReport.Checked)
            {
                if(cb_plan.Text == "") { cb_plan.Text = "A"; }
                CR2.SetParameterValue(0, cb_plan.Text);
                crystalReportViewer1.ReportSource = CR2;
            }
        }

        private void custReport_CheckedChanged(object sender, EventArgs e)
        {
            cb_plan.Enabled = false;
            cb_cust_id.Enabled = true;
        }

        private void planCustReport_CheckedChanged(object sender, EventArgs e)
        {
            cb_cust_id.Enabled = false;
            cb_plan.Enabled = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
