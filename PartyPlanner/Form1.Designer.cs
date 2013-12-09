namespace PartyPlanner
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
            this.m_PeopleNumberBox = new System.Windows.Forms.NumericUpDown();
            this.m_FancyCheckBox = new System.Windows.Forms.CheckBox();
            this.m_HealthyPartyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_TotalCostLabel = new System.Windows.Forms.Label();
            this.m_NumberOfPeopleLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_NumberOfPeopleBDay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.m_FancyDecorationsBDay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_CakeWritingBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_BirthdayPartyCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PeopleNumberBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfPeopleBDay)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PeopleNumberBox
            // 
            this.m_PeopleNumberBox.Location = new System.Drawing.Point(91, 76);
            this.m_PeopleNumberBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.m_PeopleNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_PeopleNumberBox.Name = "m_PeopleNumberBox";
            this.m_PeopleNumberBox.Size = new System.Drawing.Size(120, 25);
            this.m_PeopleNumberBox.TabIndex = 0;
            this.m_PeopleNumberBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.m_PeopleNumberBox.ValueChanged += new System.EventHandler(this.m_PeopleNumberBox_ValueChanged);
            // 
            // m_FancyCheckBox
            // 
            this.m_FancyCheckBox.AutoSize = true;
            this.m_FancyCheckBox.Checked = true;
            this.m_FancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_FancyCheckBox.ForeColor = System.Drawing.Color.White;
            this.m_FancyCheckBox.Location = new System.Drawing.Point(91, 107);
            this.m_FancyCheckBox.Name = "m_FancyCheckBox";
            this.m_FancyCheckBox.Size = new System.Drawing.Size(110, 21);
            this.m_FancyCheckBox.TabIndex = 1;
            this.m_FancyCheckBox.Text = "Pimpin Party?";
            this.m_FancyCheckBox.UseVisualStyleBackColor = true;
            this.m_FancyCheckBox.CheckedChanged += new System.EventHandler(this.m_FancyCheckBox_CheckedChanged);
            // 
            // m_HealthyPartyBox
            // 
            this.m_HealthyPartyBox.AutoSize = true;
            this.m_HealthyPartyBox.ForeColor = System.Drawing.Color.White;
            this.m_HealthyPartyBox.Location = new System.Drawing.Point(91, 134);
            this.m_HealthyPartyBox.Name = "m_HealthyPartyBox";
            this.m_HealthyPartyBox.Size = new System.Drawing.Size(103, 21);
            this.m_HealthyPartyBox.TabIndex = 2;
            this.m_HealthyPartyBox.Text = "Boozin it up?";
            this.m_HealthyPartyBox.UseVisualStyleBackColor = true;
            this.m_HealthyPartyBox.CheckedChanged += new System.EventHandler(this.m_HealthyPartyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COST";
            // 
            // m_TotalCostLabel
            // 
            this.m_TotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_TotalCostLabel.Location = new System.Drawing.Point(101, 163);
            this.m_TotalCostLabel.Name = "m_TotalCostLabel";
            this.m_TotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.m_TotalCostLabel.TabIndex = 4;
            // 
            // m_NumberOfPeopleLabel
            // 
            this.m_NumberOfPeopleLabel.AutoSize = true;
            this.m_NumberOfPeopleLabel.ForeColor = System.Drawing.Color.White;
            this.m_NumberOfPeopleLabel.Location = new System.Drawing.Point(88, 56);
            this.m_NumberOfPeopleLabel.Name = "m_NumberOfPeopleLabel";
            this.m_NumberOfPeopleLabel.Size = new System.Drawing.Size(116, 17);
            this.m_NumberOfPeopleLabel.TabIndex = 5;
            this.m_NumberOfPeopleLabel.Text = "Number of People";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 292);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.m_NumberOfPeopleLabel);
            this.tabPage1.Controls.Add(this.m_PeopleNumberBox);
            this.tabPage1.Controls.Add(this.m_TotalCostLabel);
            this.tabPage1.Controls.Add(this.m_FancyCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.m_HealthyPartyBox);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Snow;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party Planner";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.m_BirthdayPartyCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.m_CakeWritingBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.m_FancyDecorationsBDay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.m_NumberOfPeopleBDay);
            this.tabPage2.ForeColor = System.Drawing.Color.Red;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birtday Parties";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // m_NumberOfPeopleBDay
            // 
            this.m_NumberOfPeopleBDay.Location = new System.Drawing.Point(87, 49);
            this.m_NumberOfPeopleBDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumberOfPeopleBDay.Name = "m_NumberOfPeopleBDay";
            this.m_NumberOfPeopleBDay.Size = new System.Drawing.Size(120, 25);
            this.m_NumberOfPeopleBDay.TabIndex = 0;
            this.m_NumberOfPeopleBDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumberOfPeopleBDay.ValueChanged += new System.EventHandler(this.m_NumberOfPeopleBDay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of People";
            // 
            // m_FancyDecorationsBDay
            // 
            this.m_FancyDecorationsBDay.AutoSize = true;
            this.m_FancyDecorationsBDay.Checked = true;
            this.m_FancyDecorationsBDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_FancyDecorationsBDay.Location = new System.Drawing.Point(87, 81);
            this.m_FancyDecorationsBDay.Name = "m_FancyDecorationsBDay";
            this.m_FancyDecorationsBDay.Size = new System.Drawing.Size(148, 21);
            this.m_FancyDecorationsBDay.TabIndex = 2;
            this.m_FancyDecorationsBDay.Text = "Fancy Decorations";
            this.m_FancyDecorationsBDay.UseVisualStyleBackColor = true;
            this.m_FancyDecorationsBDay.CheckedChanged += new System.EventHandler(this.m_FancyDecorationsBDay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cake Writing";
            // 
            // m_CakeWritingBox
            // 
            this.m_CakeWritingBox.Location = new System.Drawing.Point(87, 152);
            this.m_CakeWritingBox.Name = "m_CakeWritingBox";
            this.m_CakeWritingBox.Size = new System.Drawing.Size(148, 25);
            this.m_CakeWritingBox.TabIndex = 4;
            this.m_CakeWritingBox.TextChanged += new System.EventHandler(this.m_CakeWritingBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost";
            // 
            // m_BirthdayPartyCost
            // 
            this.m_BirthdayPartyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_BirthdayPartyCost.Location = new System.Drawing.Point(54, 212);
            this.m_BirthdayPartyCost.Name = "m_BirthdayPartyCost";
            this.m_BirthdayPartyCost.Size = new System.Drawing.Size(100, 25);
            this.m_BirthdayPartyCost.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(321, 293);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.m_PeopleNumberBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfPeopleBDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown m_PeopleNumberBox;
        private System.Windows.Forms.CheckBox m_FancyCheckBox;
        private System.Windows.Forms.CheckBox m_HealthyPartyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_TotalCostLabel;
        private System.Windows.Forms.Label m_NumberOfPeopleLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown m_NumberOfPeopleBDay;
        private System.Windows.Forms.Label m_BirthdayPartyCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_CakeWritingBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox m_FancyDecorationsBDay;
    }
}

