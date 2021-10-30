namespace EdwardsChardelyceLab
{
    partial class Applicationsettings
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
            this.timerthing = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Uni = new System.Windows.Forms.TabControl();
            this.Universe = new System.Windows.Forms.TabPage();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Colors = new System.Windows.Forms.TabPage();
            this.bckgrnd = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cellclr = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.timerthing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.Uni.SuspendLayout();
            this.Universe.SuspendLayout();
            this.Colors.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerthing
            // 
            this.timerthing.Location = new System.Drawing.Point(9, 44);
            this.timerthing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerthing.Name = "timerthing";
            this.timerthing.Size = new System.Drawing.Size(126, 20);
            this.timerthing.TabIndex = 0;
            this.timerthing.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timerthing.ValueChanged += new System.EventHandler(this.timerthing_ValueChanged);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(217, 44);
            this.Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(126, 20);
            this.Width.TabIndex = 1;
            this.Width.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Width.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(217, 84);
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(126, 20);
            this.height.TabIndex = 2;
            this.height.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.LightCyan;
            this.Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Apply.Location = new System.Drawing.Point(25, 296);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(126, 23);
            this.Apply.TabIndex = 3;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timer Interval";
            // 
            // Uni
            // 
            this.Uni.Controls.Add(this.Universe);
            this.Uni.Controls.Add(this.Colors);
            this.Uni.Location = new System.Drawing.Point(12, 2);
            this.Uni.Name = "Uni";
            this.Uni.SelectedIndex = 0;
            this.Uni.Size = new System.Drawing.Size(368, 292);
            this.Uni.TabIndex = 5;
            // 
            // Universe
            // 
            this.Universe.BackColor = System.Drawing.Color.Black;
            this.Universe.Controls.Add(this.domainUpDown1);
            this.Universe.Controls.Add(this.label3);
            this.Universe.Controls.Add(this.label2);
            this.Universe.Controls.Add(this.label1);
            this.Universe.Controls.Add(this.height);
            this.Universe.Controls.Add(this.timerthing);
            this.Universe.Controls.Add(this.Width);
            this.Universe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Universe.Location = new System.Drawing.Point(4, 22);
            this.Universe.Name = "Universe";
            this.Universe.Padding = new System.Windows.Forms.Padding(3);
            this.Universe.Size = new System.Drawing.Size(360, 266);
            this.Universe.TabIndex = 0;
            this.Universe.Text = "Universe";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(9, 144);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "toridoal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Boundary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Universe W+H";
            // 
            // Colors
            // 
            this.Colors.BackColor = System.Drawing.Color.Black;
            this.Colors.Controls.Add(this.bckgrnd);
            this.Colors.Controls.Add(this.grd);
            this.Colors.Controls.Add(this.label7);
            this.Colors.Controls.Add(this.label6);
            this.Colors.Controls.Add(this.label5);
            this.Colors.Controls.Add(this.cellclr);
            this.Colors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Colors.Location = new System.Drawing.Point(4, 22);
            this.Colors.Name = "Colors";
            this.Colors.Padding = new System.Windows.Forms.Padding(3);
            this.Colors.Size = new System.Drawing.Size(360, 266);
            this.Colors.TabIndex = 1;
            this.Colors.Text = "Colors";
            // 
            // bckgrnd
            // 
            this.bckgrnd.Location = new System.Drawing.Point(236, 40);
            this.bckgrnd.Name = "bckgrnd";
            this.bckgrnd.Size = new System.Drawing.Size(75, 23);
            this.bckgrnd.TabIndex = 11;
            this.bckgrnd.Text = "color :)";
            this.bckgrnd.UseVisualStyleBackColor = true;
            this.bckgrnd.Click += new System.EventHandler(this.bckgrnd_Click);
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(236, 117);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(75, 23);
            this.grd.TabIndex = 10;
            this.grd.Text = "color :)";
            this.grd.UseVisualStyleBackColor = true;
            this.grd.Click += new System.EventHandler(this.grd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cell Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Background";
            // 
            // cellclr
            // 
            this.cellclr.Location = new System.Drawing.Point(236, 202);
            this.cellclr.Name = "cellclr";
            this.cellclr.Size = new System.Drawing.Size(75, 23);
            this.cellclr.TabIndex = 6;
            this.cellclr.Text = "color :)";
            this.cellclr.UseVisualStyleBackColor = true;
            this.cellclr.Click += new System.EventHandler(this.cellclr_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(233, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // Applicationsettings
            // 
            this.AcceptButton = this.Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 320);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Uni);
            this.Controls.Add(this.Apply);
            this.Name = "Applicationsettings";
            this.Text = "Applicationsettings";
            ((System.ComponentModel.ISupportInitialize)(this.timerthing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.Uni.ResumeLayout(false);
            this.Universe.ResumeLayout(false);
            this.Universe.PerformLayout();
            this.Colors.ResumeLayout(false);
            this.Colors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timerthing;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Uni;
        private System.Windows.Forms.TabPage Universe;
        private System.Windows.Forms.TabPage Colors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cellclr;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button bckgrnd;
        private System.Windows.Forms.Button grd;
        private System.Windows.Forms.Button button4;
    }
}