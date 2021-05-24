namespace Software_Engineering_Course_Project
{
    partial class AddOrEditUser
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
            this.noRadioBtn = new System.Windows.Forms.RadioButton();
            this.yesRadioBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.salaryTxtBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userEmailTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.textVersionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // noRadioBtn
            // 
            this.noRadioBtn.AutoSize = true;
            this.noRadioBtn.Location = new System.Drawing.Point(217, 203);
            this.noRadioBtn.Name = "noRadioBtn";
            this.noRadioBtn.Size = new System.Drawing.Size(39, 17);
            this.noRadioBtn.TabIndex = 28;
            this.noRadioBtn.TabStop = true;
            this.noRadioBtn.Text = "No";
            this.noRadioBtn.UseVisualStyleBackColor = true;
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.Location = new System.Drawing.Point(145, 203);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(43, 17);
            this.yesRadioBtn.TabIndex = 27;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes";
            this.yesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Salary";
            // 
            // salaryTxtBox
            // 
            this.salaryTxtBox.Location = new System.Drawing.Point(145, 240);
            this.salaryTxtBox.Name = "salaryTxtBox";
            this.salaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTxtBox.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Is Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "User Email";
            // 
            // userEmailTxtBox
            // 
            this.userEmailTxtBox.Location = new System.Drawing.Point(145, 150);
            this.userEmailTxtBox.Name = "userEmailTxtBox";
            this.userEmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userEmailTxtBox.TabIndex = 19;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(145, 103);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTxtBox.TabIndex = 18;
            // 
            // textVersionComboBox
            // 
            this.textVersionComboBox.FormattingEnabled = true;
            this.textVersionComboBox.Location = new System.Drawing.Point(145, 42);
            this.textVersionComboBox.Name = "textVersionComboBox";
            this.textVersionComboBox.Size = new System.Drawing.Size(121, 21);
            this.textVersionComboBox.TabIndex = 17;
            this.textVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.textVersionComboBox_SelectedIndexChanged);
            // 
            // AddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 394);
            this.Controls.Add(this.noRadioBtn);
            this.Controls.Add(this.yesRadioBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salaryTxtBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userEmailTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.textVersionComboBox);
            this.Name = "AddOrEditUser";
            this.Text = "AddOrEditUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddOrEditUser_FormClosing);
            this.Load += new System.EventHandler(this.AddOrEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton noRadioBtn;
        private System.Windows.Forms.RadioButton yesRadioBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userEmailTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.ComboBox textVersionComboBox;
    }
}