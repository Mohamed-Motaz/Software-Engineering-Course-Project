namespace Software_Engineering_Course_Project
{
    partial class Form1
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
            this.connectedBtn = new System.Windows.Forms.Button();
            this.disconnectedBtn = new System.Windows.Forms.Button();
            this.initializeDataBtn = new System.Windows.Forms.Button();
            this.groupReportBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.summReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectedBtn
            // 
            this.connectedBtn.Font = new System.Drawing.Font("Impact", 16.2F);
            this.connectedBtn.Location = new System.Drawing.Point(267, 273);
            this.connectedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectedBtn.Name = "connectedBtn";
            this.connectedBtn.Size = new System.Drawing.Size(314, 67);
            this.connectedBtn.TabIndex = 0;
            this.connectedBtn.Text = "Connected Mode";
            this.connectedBtn.UseVisualStyleBackColor = true;
            this.connectedBtn.Click += new System.EventHandler(this.connectedBtn_Click);
            // 
            // disconnectedBtn
            // 
            this.disconnectedBtn.Font = new System.Drawing.Font("Impact", 16.2F);
            this.disconnectedBtn.Location = new System.Drawing.Point(638, 273);
            this.disconnectedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnectedBtn.Name = "disconnectedBtn";
            this.disconnectedBtn.Size = new System.Drawing.Size(314, 67);
            this.disconnectedBtn.TabIndex = 1;
            this.disconnectedBtn.Text = "Disconnected Mode";
            this.disconnectedBtn.UseVisualStyleBackColor = true;
            this.disconnectedBtn.Click += new System.EventHandler(this.disconnectedBtn_Click);
            // 
            // initializeDataBtn
            // 
            this.initializeDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.initializeDataBtn.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializeDataBtn.Location = new System.Drawing.Point(717, 696);
            this.initializeDataBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initializeDataBtn.Name = "initializeDataBtn";
            this.initializeDataBtn.Size = new System.Drawing.Size(252, 59);
            this.initializeDataBtn.TabIndex = 2;
            this.initializeDataBtn.Text = "Initialize All Data";
            this.initializeDataBtn.UseVisualStyleBackColor = true;
            this.initializeDataBtn.Click += new System.EventHandler(this.initializeDataBtn_Click);
            // 
            // groupReportBtn
            // 
            this.groupReportBtn.Font = new System.Drawing.Font("Impact", 16.2F);
            this.groupReportBtn.Location = new System.Drawing.Point(267, 497);
            this.groupReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.groupReportBtn.Name = "groupReportBtn";
            this.groupReportBtn.Size = new System.Drawing.Size(314, 67);
            this.groupReportBtn.TabIndex = 3;
            this.groupReportBtn.Text = "Grouped Reports";
            this.groupReportBtn.UseVisualStyleBackColor = true;
            this.groupReportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(807, 93);
            this.label2.TabIndex = 5;
            this.label2.Text = "Health Insurance System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a Mode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 702);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(519, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "To Initialize All Tables For First Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generate Reports :";
            // 
            // summReportBtn
            // 
            this.summReportBtn.Font = new System.Drawing.Font("Impact", 16.2F);
            this.summReportBtn.Location = new System.Drawing.Point(638, 497);
            this.summReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.summReportBtn.Name = "summReportBtn";
            this.summReportBtn.Size = new System.Drawing.Size(314, 67);
            this.summReportBtn.TabIndex = 9;
            this.summReportBtn.Text = "Summarized Report";
            this.summReportBtn.UseVisualStyleBackColor = true;
            this.summReportBtn.Click += new System.EventHandler(this.summReportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 796);
            this.Controls.Add(this.summReportBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupReportBtn);
            this.Controls.Add(this.initializeDataBtn);
            this.Controls.Add(this.disconnectedBtn);
            this.Controls.Add(this.connectedBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectedBtn;
        private System.Windows.Forms.Button disconnectedBtn;
        private System.Windows.Forms.Button initializeDataBtn;
        private System.Windows.Forms.Button groupReportBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button summReportBtn;
    }
}

