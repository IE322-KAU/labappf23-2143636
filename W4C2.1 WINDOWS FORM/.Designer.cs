namespace W4C2._1_WINDOWS_FORM
{
    partial class FrmRandom
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
            this.BtnSeed = new System.Windows.Forms.Button();
            this.BtnGenerateRandom = new System.Windows.Forms.Button();
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.BtnGenerateRandomIneger = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.cmbRnd2 = new System.Windows.Forms.ComboBox();
            this.cmbRnd1 = new System.Windows.Forms.ComboBox();
            this.LblRGB = new System.Windows.Forms.Label();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSeed
            // 
            this.BtnSeed.Location = new System.Drawing.Point(537, 37);
            this.BtnSeed.Name = "BtnSeed";
            this.BtnSeed.Size = new System.Drawing.Size(147, 51);
            this.BtnSeed.TabIndex = 0;
            this.BtnSeed.Text = "Seed";
            this.BtnSeed.UseVisualStyleBackColor = true;
            this.BtnSeed.Click += new System.EventHandler(this.BtnSeed_Click_1);
            // 
            // BtnGenerateRandom
            // 
            this.BtnGenerateRandom.Location = new System.Drawing.Point(24, 30);
            this.BtnGenerateRandom.Name = "BtnGenerateRandom";
            this.BtnGenerateRandom.Size = new System.Drawing.Size(294, 58);
            this.BtnGenerateRandom.TabIndex = 1;
            this.BtnGenerateRandom.Text = "Generate Random Color";
            this.BtnGenerateRandom.UseVisualStyleBackColor = true;
            this.BtnGenerateRandom.Click += new System.EventHandler(this.BtnGenerateRandom_Click);
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Location = new System.Drawing.Point(24, 187);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(202, 51);
            this.BtnRandomNum.TabIndex = 2;
            this.BtnRandomNum.Text = "Random Number";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // BtnGenerateRandomIneger
            // 
            this.BtnGenerateRandomIneger.Location = new System.Drawing.Point(24, 244);
            this.BtnGenerateRandomIneger.Name = "BtnGenerateRandomIneger";
            this.BtnGenerateRandomIneger.Size = new System.Drawing.Size(202, 51);
            this.BtnGenerateRandomIneger.TabIndex = 3;
            this.BtnGenerateRandomIneger.Text = "Random Ineger";
            this.BtnGenerateRandomIneger.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(645, 397);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 41);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbRnd2
            // 
            this.cmbRnd2.FormattingEnabled = true;
            this.cmbRnd2.Location = new System.Drawing.Point(626, 125);
            this.cmbRnd2.Name = "cmbRnd2";
            this.cmbRnd2.Size = new System.Drawing.Size(162, 24);
            this.cmbRnd2.TabIndex = 6;
            // 
            // cmbRnd1
            // 
            this.cmbRnd1.FormattingEnabled = true;
            this.cmbRnd1.Location = new System.Drawing.Point(436, 125);
            this.cmbRnd1.Name = "cmbRnd1";
            this.cmbRnd1.Size = new System.Drawing.Size(162, 24);
            this.cmbRnd1.TabIndex = 7;
            // 
            // LblRGB
            // 
            this.LblRGB.AutoSize = true;
            this.LblRGB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LblRGB.Location = new System.Drawing.Point(123, 125);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(93, 24);
            this.LblRGB.TabIndex = 8;
            this.LblRGB.Text = "R * G * B";
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.Location = new System.Drawing.Point(293, 254);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(146, 25);
            this.LblDisplay.TabIndex = 9;
            this.LblDisplay.Text = "Disblay Label";
            this.LblDisplay.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.LblRGB);
            this.Controls.Add(this.cmbRnd1);
            this.Controls.Add(this.cmbRnd2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGenerateRandomIneger);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.BtnGenerateRandom);
            this.Controls.Add(this.BtnSeed);
            this.Name = "FrmRandom";
            this.Text = "Random Form";
            this.Load += new System.EventHandler(this.LblDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeed;
        private System.Windows.Forms.Button BtnGenerateRandom;
        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button BtnGenerateRandomIneger;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox cmbRnd2;
        private System.Windows.Forms.ComboBox cmbRnd1;
        private System.Windows.Forms.Label LblRGB;
        private System.Windows.Forms.Label LblDisplay;
    }
}