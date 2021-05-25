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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditUser));
            this.noRadioBtn = new System.Windows.Forms.RadioButton();
            this.yesRadioBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.salaryTxtBox = new System.Windows.Forms.TextBox();
            this.userEmailTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.textVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noRadioBtn
            // 
            this.noRadioBtn.AutoSize = true;
            this.noRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.noRadioBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.noRadioBtn.ForeColor = System.Drawing.Color.Transparent;
            this.noRadioBtn.Location = new System.Drawing.Point(141, 250);
            this.noRadioBtn.Name = "noRadioBtn";
            this.noRadioBtn.Size = new System.Drawing.Size(59, 33);
            this.noRadioBtn.TabIndex = 28;
            this.noRadioBtn.TabStop = true;
            this.noRadioBtn.Text = "No";
            this.noRadioBtn.UseVisualStyleBackColor = false;
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.yesRadioBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.yesRadioBtn.ForeColor = System.Drawing.Color.Transparent;
            this.yesRadioBtn.Location = new System.Drawing.Point(43, 250);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(65, 33);
            this.yesRadioBtn.TabIndex = 27;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes";
            this.yesRadioBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 26;
            // 
            // salaryTxtBox
            // 
            this.salaryTxtBox.Location = new System.Drawing.Point(141, 182);
            this.salaryTxtBox.Name = "salaryTxtBox";
            this.salaryTxtBox.Size = new System.Drawing.Size(165, 20);
            this.salaryTxtBox.TabIndex = 25;
            // 
            // userEmailTxtBox
            // 
            this.userEmailTxtBox.Location = new System.Drawing.Point(181, 141);
            this.userEmailTxtBox.Name = "userEmailTxtBox";
            this.userEmailTxtBox.Size = new System.Drawing.Size(125, 20);
            this.userEmailTxtBox.TabIndex = 19;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(175, 103);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(131, 20);
            this.userNameTxtBox.TabIndex = 18;
            // 
            // textVersionComboBox
            // 
            this.textVersionComboBox.FormattingEnabled = true;
            this.textVersionComboBox.Location = new System.Drawing.Point(152, 58);
            this.textVersionComboBox.Name = "textVersionComboBox";
            this.textVersionComboBox.Size = new System.Drawing.Size(154, 21);
            this.textVersionComboBox.TabIndex = 17;
            this.textVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.textVersionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "User Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Is Admin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(49, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Salary:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(161, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 38);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 409);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noRadioBtn);
            this.Controls.Add(this.yesRadioBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salaryTxtBox);
            this.Controls.Add(this.userEmailTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.textVersionComboBox);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.TextBox userEmailTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.ComboBox textVersionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}