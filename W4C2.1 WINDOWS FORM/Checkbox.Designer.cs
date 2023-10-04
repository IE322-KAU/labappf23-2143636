namespace W4C2._1_WINDOWS_FORM
{
    partial class FRMCheckbox
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHBrownie = new System.Windows.Forms.CheckBox();
            this.CHDonut = new System.Windows.Forms.CheckBox();
            this.CHCoffee = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHBrownie);
            this.groupBox1.Controls.Add(this.CHDonut);
            this.groupBox1.Controls.Add(this.CHCoffee);
            this.groupBox1.Location = new System.Drawing.Point(72, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CHBrownie
            // 
            this.CHBrownie.AutoSize = true;
            this.CHBrownie.Location = new System.Drawing.Point(20, 108);
            this.CHBrownie.Name = "CHBrownie";
            this.CHBrownie.Size = new System.Drawing.Size(92, 25);
            this.CHBrownie.TabIndex = 8;
            this.CHBrownie.Text = "Brownie";
            this.CHBrownie.UseVisualStyleBackColor = true;
            // 
            // CHDonut
            // 
            this.CHDonut.AutoSize = true;
            this.CHDonut.Location = new System.Drawing.Point(20, 77);
            this.CHDonut.Name = "CHDonut";
            this.CHDonut.Size = new System.Drawing.Size(77, 25);
            this.CHDonut.TabIndex = 7;
            this.CHDonut.Text = "Donut";
            this.CHDonut.UseVisualStyleBackColor = true;
            // 
            // CHCoffee
            // 
            this.CHCoffee.AutoSize = true;
            this.CHCoffee.Location = new System.Drawing.Point(20, 46);
            this.CHCoffee.Name = "CHCoffee";
            this.CHCoffee.Size = new System.Drawing.Size(79, 25);
            this.CHCoffee.TabIndex = 6;
            this.CHCoffee.Text = "Coffee";
            this.CHCoffee.UseVisualStyleBackColor = true;
            this.CHCoffee.CheckedChanged += new System.EventHandler(this.CHCoffee_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCheckbox";
            this.Text = "Checkbox Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CHBrownie;
        private System.Windows.Forms.CheckBox CHDonut;
        private System.Windows.Forms.CheckBox CHCoffee;
        private System.Windows.Forms.Button button1;
    }
}