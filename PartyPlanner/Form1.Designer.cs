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
            ((System.ComponentModel.ISupportInitialize)(this.m_PeopleNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PeopleNumberBox
            // 
            this.m_PeopleNumberBox.Location = new System.Drawing.Point(26, 38);
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
            this.m_PeopleNumberBox.Size = new System.Drawing.Size(120, 20);
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
            this.m_FancyCheckBox.Location = new System.Drawing.Point(45, 64);
            this.m_FancyCheckBox.Name = "m_FancyCheckBox";
            this.m_FancyCheckBox.Size = new System.Drawing.Size(90, 17);
            this.m_FancyCheckBox.TabIndex = 1;
            this.m_FancyCheckBox.Text = "Pimpin Party?";
            this.m_FancyCheckBox.UseVisualStyleBackColor = true;
            this.m_FancyCheckBox.CheckedChanged += new System.EventHandler(this.m_FancyCheckBox_CheckedChanged);
            // 
            // m_HealthyPartyBox
            // 
            this.m_HealthyPartyBox.AutoSize = true;
            this.m_HealthyPartyBox.Location = new System.Drawing.Point(56, 87);
            this.m_HealthyPartyBox.Name = "m_HealthyPartyBox";
            this.m_HealthyPartyBox.Size = new System.Drawing.Size(87, 17);
            this.m_HealthyPartyBox.TabIndex = 2;
            this.m_HealthyPartyBox.Text = "Boozin it up?";
            this.m_HealthyPartyBox.UseVisualStyleBackColor = true;
            this.m_HealthyPartyBox.CheckedChanged += new System.EventHandler(this.m_HealthyPartyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COST";
            // 
            // m_TotalCostLabel
            // 
            this.m_TotalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_TotalCostLabel.Location = new System.Drawing.Point(35, 107);
            this.m_TotalCostLabel.Name = "m_TotalCostLabel";
            this.m_TotalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.m_TotalCostLabel.TabIndex = 4;
            // 
            // m_NumberOfPeopleLabel
            // 
            this.m_NumberOfPeopleLabel.AutoSize = true;
            this.m_NumberOfPeopleLabel.Location = new System.Drawing.Point(43, 22);
            this.m_NumberOfPeopleLabel.Name = "m_NumberOfPeopleLabel";
            this.m_NumberOfPeopleLabel.Size = new System.Drawing.Size(92, 13);
            this.m_NumberOfPeopleLabel.TabIndex = 5;
            this.m_NumberOfPeopleLabel.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(173, 178);
            this.Controls.Add(this.m_NumberOfPeopleLabel);
            this.Controls.Add(this.m_TotalCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_HealthyPartyBox);
            this.Controls.Add(this.m_FancyCheckBox);
            this.Controls.Add(this.m_PeopleNumberBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.m_PeopleNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown m_PeopleNumberBox;
        private System.Windows.Forms.CheckBox m_FancyCheckBox;
        private System.Windows.Forms.CheckBox m_HealthyPartyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_TotalCostLabel;
        private System.Windows.Forms.Label m_NumberOfPeopleLabel;
    }
}

