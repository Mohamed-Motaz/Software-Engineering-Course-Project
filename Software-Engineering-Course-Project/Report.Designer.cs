
namespace Software_Engineering_Course_Project
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_plan = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.planCustReport = new System.Windows.Forms.RadioButton();
            this.custReport = new System.Windows.Forms.RadioButton();
            this.cb_cust_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // cb_plan
            // 
            this.cb_plan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_plan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_plan.FormattingEnabled = true;
            this.cb_plan.Location = new System.Drawing.Point(814, 103);
            this.cb_plan.Margin = new System.Windows.Forms.Padding(20);
            this.cb_plan.Name = "cb_plan";
            this.cb_plan.Size = new System.Drawing.Size(95, 33);
            this.cb_plan.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 258);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1310, 639);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(526, 190);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(237, 47);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate Report";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.planCustReport);
            this.groupBox1.Controls.Add(this.custReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Report";
            // 
            // planCustReport
            // 
            this.planCustReport.AutoSize = true;
            this.planCustReport.Location = new System.Drawing.Point(58, 90);
            this.planCustReport.Name = "planCustReport";
            this.planCustReport.Size = new System.Drawing.Size(198, 22);
            this.planCustReport.TabIndex = 1;
            this.planCustReport.Text = "Plan-Customer Report";
            this.planCustReport.UseVisualStyleBackColor = true;
            this.planCustReport.CheckedChanged += new System.EventHandler(this.planCustReport_CheckedChanged);
            // 
            // custReport
            // 
            this.custReport.AutoSize = true;
            this.custReport.Checked = true;
            this.custReport.Location = new System.Drawing.Point(58, 41);
            this.custReport.Name = "custReport";
            this.custReport.Size = new System.Drawing.Size(168, 22);
            this.custReport.TabIndex = 0;
            this.custReport.TabStop = true;
            this.custReport.Text = "Customers Report";
            this.custReport.UseVisualStyleBackColor = true;
            this.custReport.CheckedChanged += new System.EventHandler(this.custReport_CheckedChanged);
            // 
            // cb_cust_id
            // 
            this.cb_cust_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cust_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_cust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cust_id.FormattingEnabled = true;
            this.cb_cust_id.Location = new System.Drawing.Point(814, 47);
            this.cb_cust_id.Margin = new System.Windows.Forms.Padding(20);
            this.cb_cust_id.Name = "cb_cust_id";
            this.cb_cust_id.Size = new System.Drawing.Size(95, 33);
            this.cb_cust_id.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chosen Plan :";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 909);
            this.Controls.Add(this.cb_cust_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cb_plan);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_plan;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton planCustReport;
        private System.Windows.Forms.RadioButton custReport;
        private System.Windows.Forms.ComboBox cb_cust_id;
        private System.Windows.Forms.Label label2;
    }
}