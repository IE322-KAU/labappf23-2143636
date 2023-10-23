namespace W4C2._1_WINDOWS_FORM
{
    partial class FRMPICTURE
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnImagefromFile = new System.Windows.Forms.Button();
            this.BtnImagefromResources = new System.Windows.Forms.Button();
            this.picTry1 = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radStretchImage = new System.Windows.Forms.RadioButton();
            this.raAutoSize = new System.Windows.Forms.RadioButton();
            this.radCenterImage = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radZoom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnImagefromFile
            // 
            this.BtnImagefromFile.Location = new System.Drawing.Point(36, 22);
            this.BtnImagefromFile.Name = "BtnImagefromFile";
            this.BtnImagefromFile.Size = new System.Drawing.Size(153, 56);
            this.BtnImagefromFile.TabIndex = 1;
            this.BtnImagefromFile.Text = "Image from File";
            this.BtnImagefromFile.UseVisualStyleBackColor = true;
            this.BtnImagefromFile.Click += new System.EventHandler(this.BtnImagefromFile_Click);
            // 
            // BtnImagefromResources
            // 
            this.BtnImagefromResources.Location = new System.Drawing.Point(36, 95);
            this.BtnImagefromResources.Name = "BtnImagefromResources";
            this.BtnImagefromResources.Size = new System.Drawing.Size(153, 56);
            this.BtnImagefromResources.TabIndex = 2;
            this.BtnImagefromResources.Text = "Image from Resources";
            this.BtnImagefromResources.UseVisualStyleBackColor = true;
            // 
            // picTry1
            // 
            this.picTry1.Location = new System.Drawing.Point(26, 26);
            this.picTry1.Name = "picTry1";
            this.picTry1.Size = new System.Drawing.Size(236, 291);
            this.picTry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry1.TabIndex = 3;
            this.picTry1.TabStop = false;
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(288, 26);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(236, 291);
            this.picTry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry2.TabIndex = 4;
            this.picTry2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radZoom);
            this.groupBox1.Controls.Add(this.raAutoSize);
            this.groupBox1.Controls.Add(this.radCenterImage);
            this.groupBox1.Controls.Add(this.radStretchImage);
            this.groupBox1.Controls.Add(this.radNormal);
            this.groupBox1.Location = new System.Drawing.Point(36, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(26, 35);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(72, 21);
            this.radNormal.TabIndex = 0;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radStretchImage
            // 
            this.radStretchImage.AutoSize = true;
            this.radStretchImage.Location = new System.Drawing.Point(26, 70);
            this.radStretchImage.Name = "radStretchImage";
            this.radStretchImage.Size = new System.Drawing.Size(112, 21);
            this.radStretchImage.TabIndex = 1;
            this.radStretchImage.TabStop = true;
            this.radStretchImage.Text = "StretchImage";
            this.radStretchImage.UseVisualStyleBackColor = true;
            this.radStretchImage.CheckedChanged += new System.EventHandler(this.radStretchImage_CheckedChanged);
            // 
            // raAutoSize
            // 
            this.raAutoSize.AutoSize = true;
            this.raAutoSize.Location = new System.Drawing.Point(26, 105);
            this.raAutoSize.Name = "raAutoSize";
            this.raAutoSize.Size = new System.Drawing.Size(81, 21);
            this.raAutoSize.TabIndex = 3;
            this.raAutoSize.TabStop = true;
            this.raAutoSize.Text = "AutoSize";
            this.raAutoSize.UseVisualStyleBackColor = true;
            this.raAutoSize.CheckedChanged += new System.EventHandler(this.raAutoSize_CheckedChanged);
            // 
            // radCenterImage
            // 
            this.radCenterImage.AutoSize = true;
            this.radCenterImage.Location = new System.Drawing.Point(26, 140);
            this.radCenterImage.Name = "radCenterImage";
            this.radCenterImage.Size = new System.Drawing.Size(108, 21);
            this.radCenterImage.TabIndex = 2;
            this.radCenterImage.TabStop = true;
            this.radCenterImage.Text = "CenterImage";
            this.radCenterImage.UseVisualStyleBackColor = true;
            this.radCenterImage.CheckedChanged += new System.EventHandler(this.radCenterImage_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picTry2);
            this.groupBox2.Controls.Add(this.picTry1);
            this.groupBox2.Location = new System.Drawing.Point(226, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 330);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture Boxes";
            // 
            // radZoom
            // 
            this.radZoom.AutoSize = true;
            this.radZoom.Location = new System.Drawing.Point(26, 175);
            this.radZoom.Name = "radZoom";
            this.radZoom.Size = new System.Drawing.Size(65, 21);
            this.radZoom.TabIndex = 4;
            this.radZoom.TabStop = true;
            this.radZoom.Text = "Zoom";
            this.radZoom.UseVisualStyleBackColor = true;
            this.radZoom.CheckedChanged += new System.EventHandler(this.radZoom_CheckedChanged);
            // 
            // FRMPICTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImagefromResources);
            this.Controls.Add(this.BtnImagefromFile);
            this.Controls.Add(this.button1);
            this.Name = "FRMPICTURE";
            this.Text = "Picture Form";
            ((System.ComponentModel.ISupportInitialize)(this.picTry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnImagefromFile;
        private System.Windows.Forms.Button BtnImagefromResources;
        private System.Windows.Forms.PictureBox picTry1;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raAutoSize;
        private System.Windows.Forms.RadioButton radCenterImage;
        private System.Windows.Forms.RadioButton radStretchImage;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radZoom;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}