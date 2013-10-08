namespace Exercise_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.regionCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.divisionCombo = new System.Windows.Forms.ComboBox();
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region:";
            // 
            // regionCombo
            // 
            this.regionCombo.FormattingEnabled = true;
            this.regionCombo.Location = new System.Drawing.Point(75, 6);
            this.regionCombo.Name = "regionCombo";
            this.regionCombo.Size = new System.Drawing.Size(333, 24);
            this.regionCombo.TabIndex = 1;
            this.regionCombo.SelectedValueChanged += new System.EventHandler(this.regionCombo_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Division:";
            // 
            // divisionCombo
            // 
            this.divisionCombo.DisplayMember = "Name";
            this.divisionCombo.FormattingEnabled = true;
            this.divisionCombo.Location = new System.Drawing.Point(75, 46);
            this.divisionCombo.Name = "divisionCombo";
            this.divisionCombo.Size = new System.Drawing.Size(333, 24);
            this.divisionCombo.TabIndex = 3;
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(75, 103);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(154, 44);
            this.calculateRevenueButton.TabIndex = 4;
            this.calculateRevenueButton.Text = "Calculate revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.calculateRevenueButton_Click);
            // 
            // revenueTextBox
            // 
            this.revenueTextBox.Enabled = false;
            this.revenueTextBox.Location = new System.Drawing.Point(150, 177);
            this.revenueTextBox.Name = "revenueTextBox";
            this.revenueTextBox.Size = new System.Drawing.Size(205, 22);
            this.revenueTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Revenue:";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(253, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 44);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 254);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revenueTextBox);
            this.Controls.Add(this.calculateRevenueButton);
            this.Controls.Add(this.divisionCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regionCombo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Divisions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox regionCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox divisionCombo;
        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.TextBox revenueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
    }
}

