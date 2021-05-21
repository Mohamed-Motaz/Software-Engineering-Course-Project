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
            this.SuspendLayout();
            // 
            // connectedBtn
            // 
            this.connectedBtn.Location = new System.Drawing.Point(232, 281);
            this.connectedBtn.Name = "connectedBtn";
            this.connectedBtn.Size = new System.Drawing.Size(91, 58);
            this.connectedBtn.TabIndex = 0;
            this.connectedBtn.Text = "Connected Mode";
            this.connectedBtn.UseVisualStyleBackColor = true;
            this.connectedBtn.Click += new System.EventHandler(this.connectedBtn_Click);
            // 
            // disconnectedBtn
            // 
            this.disconnectedBtn.Location = new System.Drawing.Point(403, 281);
            this.disconnectedBtn.Name = "disconnectedBtn";
            this.disconnectedBtn.Size = new System.Drawing.Size(91, 58);
            this.disconnectedBtn.TabIndex = 1;
            this.disconnectedBtn.Text = "Disconnected Mode";
            this.disconnectedBtn.UseVisualStyleBackColor = true;
            this.disconnectedBtn.Click += new System.EventHandler(this.disconnectedBtn_Click);
            // 
            // initializeDataBtn
            // 
            this.initializeDataBtn.Location = new System.Drawing.Point(261, 47);
            this.initializeDataBtn.Name = "initializeDataBtn";
            this.initializeDataBtn.Size = new System.Drawing.Size(167, 67);
            this.initializeDataBtn.TabIndex = 2;
            this.initializeDataBtn.Text = "Initialize All Data";
            this.initializeDataBtn.UseVisualStyleBackColor = true;
            this.initializeDataBtn.Click += new System.EventHandler(this.initializeDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.initializeDataBtn);
            this.Controls.Add(this.disconnectedBtn);
            this.Controls.Add(this.connectedBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectedBtn;
        private System.Windows.Forms.Button disconnectedBtn;
        private System.Windows.Forms.Button initializeDataBtn;
    }
}

