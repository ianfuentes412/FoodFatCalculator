namespace FatPercentCalc
{
    partial class FatPercentageCalculator
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
            this.FatGrams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalGrams = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FatCheck = new System.Windows.Forms.CheckBox();
            this.CheckLowFatL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FatGrams
            // 
            this.FatGrams.Location = new System.Drawing.Point(301, 144);
            this.FatGrams.Name = "FatGrams";
            this.FatGrams.Size = new System.Drawing.Size(100, 22);
            this.FatGrams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Fat (grams)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Amount of Calories (grams)";
            // 
            // TotalGrams
            // 
            this.TotalGrams.Location = new System.Drawing.Point(301, 205);
            this.TotalGrams.Name = "TotalGrams";
            this.TotalGrams.Size = new System.Drawing.Size(100, 22);
            this.TotalGrams.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(355, 273);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(60, 17);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "             ";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your Fat Percentage:";
            // 
            // FatCheck
            // 
            this.FatCheck.AutoSize = true;
            this.FatCheck.Location = new System.Drawing.Point(279, 348);
            this.FatCheck.Name = "FatCheck";
            this.FatCheck.Size = new System.Drawing.Size(190, 21);
            this.FatCheck.TabIndex = 7;
            this.FatCheck.Text = "Check if product is low fat";
            this.FatCheck.UseVisualStyleBackColor = true;
            // 
            // CheckLowFatL
            // 
            this.CheckLowFatL.AutoSize = true;
            this.CheckLowFatL.Location = new System.Drawing.Point(309, 308);
            this.CheckLowFatL.Name = "CheckLowFatL";
            this.CheckLowFatL.Size = new System.Drawing.Size(68, 17);
            this.CheckLowFatL.TabIndex = 8;
            this.CheckLowFatL.Text = "               ";
            this.CheckLowFatL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckLowFatL.Click += new System.EventHandler(this.label4_Click);
            // 
            // FatPercentageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckLowFatL);
            this.Controls.Add(this.FatCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FatGrams);
            this.Name = "FatPercentageCalculator";
            this.Text = "FatPercentageCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FatGrams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalGrams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox FatCheck;
        private System.Windows.Forms.Label CheckLowFatL;
    }
}

