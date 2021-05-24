namespace Software_Engineering_Course_Project
{
    partial class DisconnectedMode
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioCust = new System.Windows.Forms.RadioButton();
            this.searchIdBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(507, 696);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 39);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 253);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1014, 420);
            this.dataGridView.TabIndex = 6;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(441, 155);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(199, 40);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load Information";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUser);
            this.groupBox1.Controls.Add(this.radioCust);
            this.groupBox1.Location = new System.Drawing.Point(395, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(67, 73);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(140, 21);
            this.radioUser.TabIndex = 1;
            this.radioUser.Text = "Users Information";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioCust
            // 
            this.radioCust.AutoSize = true;
            this.radioCust.Checked = true;
            this.radioCust.Location = new System.Drawing.Point(67, 33);
            this.radioCust.Name = "radioCust";
            this.radioCust.Size = new System.Drawing.Size(170, 21);
            this.radioCust.TabIndex = 0;
            this.radioCust.TabStop = true;
            this.radioCust.Text = "Customers Information";
            this.radioCust.UseVisualStyleBackColor = true;
            // 
            // searchIdBtn
            // 
            this.searchIdBtn.Location = new System.Drawing.Point(905, 215);
            this.searchIdBtn.Name = "searchIdBtn";
            this.searchIdBtn.Size = new System.Drawing.Size(119, 32);
            this.searchIdBtn.TabIndex = 8;
            this.searchIdBtn.Text = "Search";
            this.searchIdBtn.UseVisualStyleBackColor = true;
            this.searchIdBtn.Click += new System.EventHandler(this.searchIdBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(159, 220);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 22);
            this.searchBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search By ID:";
            // 
            // DisconnectedMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchIdBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisconnectedMode";
            this.Text = "DisconnectedMode";
            this.Load += new System.EventHandler(this.DisconnectedMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioCust;
        private System.Windows.Forms.Button searchIdBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
    }
}