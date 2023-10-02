namespace W4C2._1_WINDOWS_FORM
{
    partial class FRMRADIO
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDORed1 = new System.Windows.Forms.RadioButton();
            this.RDOGreen1 = new System.Windows.Forms.RadioButton();
            this.RDOBlue1 = new System.Windows.Forms.RadioButton();
            this.RDOYellow1 = new System.Windows.Forms.RadioButton();
            this.RDORed2 = new System.Windows.Forms.RadioButton();
            this.RDOGreen2 = new System.Windows.Forms.RadioButton();
            this.RDOYellow2 = new System.Windows.Forms.RadioButton();
            this.RDOBlue2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDOYellow1);
            this.groupBox1.Controls.Add(this.RDOBlue1);
            this.groupBox1.Controls.Add(this.RDOGreen1);
            this.groupBox1.Controls.Add(this.RDORed1);
            this.groupBox1.Location = new System.Drawing.Point(267, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // RDORed1
            // 
            this.RDORed1.AutoSize = true;
            this.RDORed1.Location = new System.Drawing.Point(19, 43);
            this.RDORed1.Name = "RDORed1";
            this.RDORed1.Size = new System.Drawing.Size(60, 25);
            this.RDORed1.TabIndex = 0;
            this.RDORed1.TabStop = true;
            this.RDORed1.Text = "Red";
            this.RDORed1.UseVisualStyleBackColor = true;
            this.RDORed1.CheckedChanged += new System.EventHandler(this.RDORed1_CheckedChanged);
            // 
            // RDOGreen1
            // 
            this.RDOGreen1.AutoSize = true;
            this.RDOGreen1.Location = new System.Drawing.Point(19, 74);
            this.RDOGreen1.Name = "RDOGreen1";
            this.RDOGreen1.Size = new System.Drawing.Size(75, 25);
            this.RDOGreen1.TabIndex = 1;
            this.RDOGreen1.TabStop = true;
            this.RDOGreen1.Text = "Green";
            this.RDOGreen1.UseVisualStyleBackColor = true;
            this.RDOGreen1.CheckedChanged += new System.EventHandler(this.RDOGRreen1_CheckedChanged);
            // 
            // RDOBlue1
            // 
            this.RDOBlue1.AutoSize = true;
            this.RDOBlue1.Location = new System.Drawing.Point(19, 105);
            this.RDOBlue1.Name = "RDOBlue1";
            this.RDOBlue1.Size = new System.Drawing.Size(68, 25);
            this.RDOBlue1.TabIndex = 2;
            this.RDOBlue1.TabStop = true;
            this.RDOBlue1.Text = "Blue ";
            this.RDOBlue1.UseVisualStyleBackColor = true;
            this.RDOBlue1.CheckedChanged += new System.EventHandler(this.RDOBlue1_CheckedChanged);
            // 
            // RDOYellow1
            // 
            this.RDOYellow1.AutoSize = true;
            this.RDOYellow1.Location = new System.Drawing.Point(19, 139);
            this.RDOYellow1.Name = "RDOYellow1";
            this.RDOYellow1.Size = new System.Drawing.Size(80, 25);
            this.RDOYellow1.TabIndex = 3;
            this.RDOYellow1.TabStop = true;
            this.RDOYellow1.Text = "Yellow";
            this.RDOYellow1.UseVisualStyleBackColor = true;
            this.RDOYellow1.CheckedChanged += new System.EventHandler(this.RDOYellow1_CheckedChanged);
            // 
            // RDORed2
            // 
            this.RDORed2.AutoSize = true;
            this.RDORed2.Location = new System.Drawing.Point(60, 158);
            this.RDORed2.Name = "RDORed2";
            this.RDORed2.Size = new System.Drawing.Size(60, 25);
            this.RDORed2.TabIndex = 3;
            this.RDORed2.TabStop = true;
            this.RDORed2.Text = "Red";
            this.RDORed2.UseVisualStyleBackColor = true;
            this.RDORed2.CheckedChanged += new System.EventHandler(this.RDORed2_CheckedChanged);
            // 
            // RDOGreen2
            // 
            this.RDOGreen2.AutoSize = true;
            this.RDOGreen2.Location = new System.Drawing.Point(57, 189);
            this.RDOGreen2.Name = "RDOGreen2";
            this.RDOGreen2.Size = new System.Drawing.Size(75, 25);
            this.RDOGreen2.TabIndex = 4;
            this.RDOGreen2.TabStop = true;
            this.RDOGreen2.Text = "Green";
            this.RDOGreen2.UseVisualStyleBackColor = true;
            this.RDOGreen2.CheckedChanged += new System.EventHandler(this.RDOGreen2_CheckedChanged);
            // 
            // RDOYellow2
            // 
            this.RDOYellow2.AutoSize = true;
            this.RDOYellow2.Location = new System.Drawing.Point(57, 251);
            this.RDOYellow2.Name = "RDOYellow2";
            this.RDOYellow2.Size = new System.Drawing.Size(80, 25);
            this.RDOYellow2.TabIndex = 6;
            this.RDOYellow2.TabStop = true;
            this.RDOYellow2.Text = "Yellow";
            this.RDOYellow2.UseVisualStyleBackColor = true;
            this.RDOYellow2.CheckedChanged += new System.EventHandler(this.RDOYellow2_CheckedChanged);
            // 
            // RDOBlue2
            // 
            this.RDOBlue2.AutoSize = true;
            this.RDOBlue2.Location = new System.Drawing.Point(57, 220);
            this.RDOBlue2.Name = "RDOBlue2";
            this.RDOBlue2.Size = new System.Drawing.Size(63, 25);
            this.RDOBlue2.TabIndex = 5;
            this.RDOBlue2.TabStop = true;
            this.RDOBlue2.Text = "Blue";
            this.RDOBlue2.UseVisualStyleBackColor = true;
            this.RDOBlue2.CheckedChanged += new System.EventHandler(this.RDOBlue2_CheckedChanged);
            // 
            // FRMRADIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 356);
            this.Controls.Add(this.RDOYellow2);
            this.Controls.Add(this.RDOBlue2);
            this.Controls.Add(this.RDOGreen2);
            this.Controls.Add(this.RDORed2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMRADIO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDOYellow1;
        private System.Windows.Forms.RadioButton RDOBlue1;
        private System.Windows.Forms.RadioButton RDOGreen1;
        private System.Windows.Forms.RadioButton RDORed1;
        private System.Windows.Forms.RadioButton RDORed2;
        private System.Windows.Forms.RadioButton RDOGreen2;
        private System.Windows.Forms.RadioButton RDOYellow2;
        private System.Windows.Forms.RadioButton RDOBlue2;
    }
}