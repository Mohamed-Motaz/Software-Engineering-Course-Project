namespace Software_Engineering_Course_Project
{
    partial class NewListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewListItem));
            this.label1 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plan_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.name_label.Location = new System.Drawing.Point(335, 26);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID :";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.id_label.Location = new System.Drawing.Point(319, 67);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 17);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Email :";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email_label.Location = new System.Drawing.Point(673, 26);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(42, 17);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer Plan :";
            // 
            // plan_label
            // 
            this.plan_label.AutoSize = true;
            this.plan_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.plan_label.Location = new System.Drawing.Point(673, 67);
            this.plan_label.Name = "plan_label";
            this.plan_label.Size = new System.Drawing.Size(36, 17);
            this.plan_label.TabIndex = 7;
            this.plan_label.Text = "Plan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(981, 10);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // NewListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.plan_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label1);
            this.Name = "NewListItem";
            this.Size = new System.Drawing.Size(1001, 133);
            this.Load += new System.EventHandler(this.NewListItem_Load);
            this.MouseLeave += new System.EventHandler(this.NewListItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NewListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label plan_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
