namespace Math
{
    partial class Pythagoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pythagoras));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_c = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.clear_pythagoras = new System.Windows.Forms.Button();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_c = new System.Windows.Forms.NumericUpDown();
            this.button_pythagoras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 399);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(61, 147);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(55, 32);
            this.label_c.TabIndex = 1;
            this.label_c.Text = "c = ";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(164, 375);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(58, 32);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "b = ";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(365, 211);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(56, 32);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "a = ";
            // 
            // clear_pythagoras
            // 
            this.clear_pythagoras.Location = new System.Drawing.Point(204, 265);
            this.clear_pythagoras.Name = "clear_pythagoras";
            this.clear_pythagoras.Size = new System.Drawing.Size(98, 48);
            this.clear_pythagoras.TabIndex = 3;
            this.clear_pythagoras.Text = "Slet";
            this.clear_pythagoras.UseVisualStyleBackColor = true;
            this.clear_pythagoras.Click += new System.EventHandler(this.clear_pythagoras_Click);
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.DecimalPlaces = 3;
            this.numericUpDown_a.Location = new System.Drawing.Point(413, 204);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(93, 39);
            this.numericUpDown_a.TabIndex = 0;
            this.numericUpDown_a.ThousandsSeparator = true;
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.DecimalPlaces = 3;
            this.numericUpDown_b.Location = new System.Drawing.Point(210, 373);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(93, 39);
            this.numericUpDown_b.TabIndex = 1;
            this.numericUpDown_b.ThousandsSeparator = true;
            // 
            // numericUpDown_c
            // 
            this.numericUpDown_c.DecimalPlaces = 3;
            this.numericUpDown_c.Location = new System.Drawing.Point(106, 145);
            this.numericUpDown_c.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown_c.Name = "numericUpDown_c";
            this.numericUpDown_c.Size = new System.Drawing.Size(93, 39);
            this.numericUpDown_c.TabIndex = 2;
            this.numericUpDown_c.ThousandsSeparator = true;
            // 
            // button_pythagoras
            // 
            this.button_pythagoras.Location = new System.Drawing.Point(204, 211);
            this.button_pythagoras.Name = "button_pythagoras";
            this.button_pythagoras.Size = new System.Drawing.Size(98, 48);
            this.button_pythagoras.TabIndex = 3;
            this.button_pythagoras.Text = "Beregn";
            this.button_pythagoras.UseVisualStyleBackColor = true;
            this.button_pythagoras.Click += new System.EventHandler(this.button_pythagoras_Click);
            // 
            // Pythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 440);
            this.Controls.Add(this.button_pythagoras);
            this.Controls.Add(this.numericUpDown_c);
            this.Controls.Add(this.numericUpDown_b);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.clear_pythagoras);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Pythagoras";
            this.Text = "Pythagoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Button clear_pythagoras;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_c;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.Button button_pythagoras;
    }
}