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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectedBtn = new System.Windows.Forms.Button();
            this.disconnectedBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.summReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.initializeDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Health Insurance System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Mode :";
            // 
            // connectedBtn
            // 
            this.connectedBtn.BackColor = System.Drawing.Color.Transparent;
            this.connectedBtn.FlatAppearance.BorderSize = 0;
            this.connectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectedBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedBtn.ForeColor = System.Drawing.Color.White;
            this.connectedBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectedBtn.Image")));
            this.connectedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.connectedBtn.Location = new System.Drawing.Point(12, 134);
            this.connectedBtn.Name = "connectedBtn";
            this.connectedBtn.Size = new System.Drawing.Size(203, 36);
            this.connectedBtn.TabIndex = 11;
            this.connectedBtn.Text = "Connected Mode";
            this.connectedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectedBtn.UseVisualStyleBackColor = false;
            this.connectedBtn.Click += new System.EventHandler(this.connectedBtn_Click);
            // 
            // disconnectedBtn
            // 
            this.disconnectedBtn.BackColor = System.Drawing.Color.Transparent;
            this.disconnectedBtn.FlatAppearance.BorderSize = 0;
            this.disconnectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectedBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectedBtn.ForeColor = System.Drawing.Color.White;
            this.disconnectedBtn.Image = ((System.Drawing.Image)(resources.GetObject("disconnectedBtn.Image")));
            this.disconnectedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.disconnectedBtn.Location = new System.Drawing.Point(12, 176);
            this.disconnectedBtn.Name = "disconnectedBtn";
            this.disconnectedBtn.Size = new System.Drawing.Size(238, 36);
            this.disconnectedBtn.TabIndex = 12;
            this.disconnectedBtn.Text = "Disconnected Mode";
            this.disconnectedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectedBtn.UseVisualStyleBackColor = false;
            this.disconnectedBtn.Click += new System.EventHandler(this.disconnectedBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Generate Reports:";
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportBtn.Image")));
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.Location = new System.Drawing.Point(17, 315);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 36);
            this.reportBtn.TabIndex = 14;
            this.reportBtn.Text = "Grouped Reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // summReportBtn
            // 
            this.summReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.summReportBtn.FlatAppearance.BorderSize = 0;
            this.summReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summReportBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summReportBtn.ForeColor = System.Drawing.Color.White;
            this.summReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("summReportBtn.Image")));
            this.summReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.summReportBtn.Location = new System.Drawing.Point(17, 357);
            this.summReportBtn.Name = "summReportBtn";
            this.summReportBtn.Size = new System.Drawing.Size(233, 36);
            this.summReportBtn.TabIndex = 15;
            this.summReportBtn.Text = "Summarized Report";
            this.summReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.summReportBtn.UseVisualStyleBackColor = false;
            this.summReportBtn.Click += new System.EventHandler(this.summReportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "To Initialize All Tables For First Time :";
            // 
            // initializeDataBtn
            // 
            this.initializeDataBtn.BackColor = System.Drawing.Color.Transparent;
            this.initializeDataBtn.FlatAppearance.BorderSize = 0;
            this.initializeDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initializeDataBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializeDataBtn.ForeColor = System.Drawing.Color.White;
            this.initializeDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("initializeDataBtn.Image")));
            this.initializeDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.initializeDataBtn.Location = new System.Drawing.Point(17, 476);
            this.initializeDataBtn.Name = "initializeDataBtn";
            this.initializeDataBtn.Size = new System.Drawing.Size(245, 36);
            this.initializeDataBtn.TabIndex = 17;
            this.initializeDataBtn.Text = "Initialize All Data";
            this.initializeDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.initializeDataBtn.UseVisualStyleBackColor = false;
            this.initializeDataBtn.Click += new System.EventHandler(this.initializeDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 614);
            this.Controls.Add(this.initializeDataBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summReportBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.disconnectedBtn);
            this.Controls.Add(this.connectedBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectedBtn;
        private System.Windows.Forms.Button disconnectedBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button summReportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button initializeDataBtn;
    }
}

