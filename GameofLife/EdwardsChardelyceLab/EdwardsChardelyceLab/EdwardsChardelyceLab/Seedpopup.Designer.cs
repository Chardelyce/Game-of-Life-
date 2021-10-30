namespace EdwardsChardelyceLab
{
    partial class Seedpopup
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Location = new System.Drawing.Point(201, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 138);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate :)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Apply.Location = new System.Drawing.Point(36, 169);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(120, 47);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universe Seed";
            // 
            // Seedpopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(264, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Name = "Seedpopup";
            this.Text = "Seedpopup";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label1;
    }
}