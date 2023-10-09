namespace W4C2._1_WINDOWS_FORM
{
    partial class FRMCombo
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnRemoveByBane = new System.Windows.Forms.Button();
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.BtnShowSelected2 = new System.Windows.Forms.Button();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(558, 383);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(132, 44);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnRemoveLast.Location = new System.Drawing.Point(496, 110);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(132, 63);
            this.BtnRemoveLast.TabIndex = 5;
            this.BtnRemoveLast.Text = "Remove least item";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(496, 179);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(132, 71);
            this.BtnRemove2ndLast.TabIndex = 6;
            this.BtnRemove2ndLast.Text = "Remove 2nd least item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(34, 321);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(150, 49);
            this.BtnRemoveByIndex.TabIndex = 7;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnRemoveByBane
            // 
            this.BtnRemoveByBane.Location = new System.Drawing.Point(190, 321);
            this.BtnRemoveByBane.Name = "BtnRemoveByBane";
            this.BtnRemoveByBane.Size = new System.Drawing.Size(150, 49);
            this.BtnRemoveByBane.TabIndex = 8;
            this.BtnRemoveByBane.Text = "Remove by Name";
            this.BtnRemoveByBane.UseVisualStyleBackColor = true;
            this.BtnRemoveByBane.Click += new System.EventHandler(this.BtnRemoveByBane_Click);
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(34, 43);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(150, 49);
            this.BtnShowSelected1.TabIndex = 1;
            this.BtnShowSelected1.Text = "Show Selected Method 1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.Location = new System.Drawing.Point(190, 43);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(150, 49);
            this.BtnShowSelected2.TabIndex = 2;
            this.BtnShowSelected2.Text = "Show Selected Method 2";
            this.BtnShowSelected2.UseVisualStyleBackColor = true;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.Location = new System.Drawing.Point(346, 43);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(150, 49);
            this.BtnShowSelected3.TabIndex = 3;
            this.BtnShowSelected3.Text = "Show Selected Method 3";
            this.BtnShowSelected3.UseVisualStyleBackColor = true;
            this.BtnShowSelected3.Click += new System.EventHandler(this.button12_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(34, 122);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(201, 24);
            this.CmbDays.TabIndex = 9;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.CmbDays_SelectedIndexChanged);
            // 
            // FRMCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemoveByBane);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnShowSelected3);
            this.Controls.Add(this.BtnShowSelected2);
            this.Controls.Add(this.BtnShowSelected1);
            this.Controls.Add(this.BtnBack);
            this.Name = "FRMCombo";
            this.Text = "Combo Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByBane;
        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnShowSelected3;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}