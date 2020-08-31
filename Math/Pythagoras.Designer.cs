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
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(111, 144);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(90, 39);
            this.textBox_c.TabIndex = 2;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(216, 372);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(90, 39);
            this.textBox_b.TabIndex = 2;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(413, 208);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(90, 39);
            this.textBox_a.TabIndex = 2;
            // 
            // Pythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 440);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Pythagoras";
            this.Text = "Pythagoras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
    }
}