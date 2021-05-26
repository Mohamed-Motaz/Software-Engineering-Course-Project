
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_plan = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.planCustReport = new System.Windows.Forms.RadioButton();
            this.custReport = new System.Windows.Forms.RadioButton();
            this.cb_cust_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(626, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // cb_plan
            // 
            this.cb_plan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_plan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_plan.FormattingEnabled = true;
            this.cb_plan.Location = new System.Drawing.Point(761, 54);
            this.cb_plan.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.cb_plan.Name = "cb_plan";
            this.cb_plan.Size = new System.Drawing.Size(72, 28);
            this.cb_plan.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(11, 160);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(994, 480);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelWidth = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.planCustReport);
            this.groupBox1.Controls.Add(this.custReport);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(249, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Report";
            // 
            // planCustReport
            // 
            this.planCustReport.AutoSize = true;
            this.planCustReport.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planCustReport.ForeColor = System.Drawing.Color.Transparent;
            this.planCustReport.Location = new System.Drawing.Point(16, 69);
            this.planCustReport.Margin = new System.Windows.Forms.Padding(2);
            this.planCustReport.Name = "planCustReport";
            this.planCustReport.Size = new System.Drawing.Size(220, 30);
            this.planCustReport.TabIndex = 1;
            this.planCustReport.Text = "Plan-Customer Report";
            this.planCustReport.UseVisualStyleBackColor = true;
            this.planCustReport.CheckedChanged += new System.EventHandler(this.planCustReport_CheckedChanged);
            // 
            // custReport
            // 
            this.custReport.AutoSize = true;
            this.custReport.Checked = true;
            this.custReport.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custReport.ForeColor = System.Drawing.Color.Transparent;
            this.custReport.Location = new System.Drawing.Point(16, 28);
            this.custReport.Margin = new System.Windows.Forms.Padding(2);
            this.custReport.Name = "custReport";
            this.custReport.Size = new System.Drawing.Size(186, 30);
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
            this.cb_cust_id.Location = new System.Drawing.Point(761, 9);
            this.cb_cust_id.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.cb_cust_id.Name = "cb_cust_id";
            this.cb_cust_id.Size = new System.Drawing.Size(72, 28);
            this.cb_cust_id.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(631, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chosen Plan :";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Image = ((System.Drawing.Image)(resources.GetObject("generateBtn.Image")));
            this.generateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateBtn.Location = new System.Drawing.Point(631, 101);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(205, 38);
            this.generateBtn.TabIndex = 18;
            this.generateBtn.Text = "Generate Report";
            this.generateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.Location = new System.Drawing.Point(918, 8);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(102, 33);
            this.BackBtn.TabIndex = 47;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 653);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.cb_cust_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cb_plan);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton planCustReport;
        private System.Windows.Forms.RadioButton custReport;
        private System.Windows.Forms.ComboBox cb_cust_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}