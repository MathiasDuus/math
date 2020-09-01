namespace Math
{
    partial class MainMenu
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
            this.GoToPythagoras = new System.Windows.Forms.Button();
            this.GoToTrigonometriRet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToPythagoras
            // 
            this.GoToPythagoras.Location = new System.Drawing.Point(12, 12);
            this.GoToPythagoras.Name = "GoToPythagoras";
            this.GoToPythagoras.Size = new System.Drawing.Size(159, 48);
            this.GoToPythagoras.TabIndex = 0;
            this.GoToPythagoras.Text = "Pythagoras";
            this.GoToPythagoras.UseVisualStyleBackColor = true;
            this.GoToPythagoras.Click += new System.EventHandler(this.GoToPythagoras_Click);
            // 
            // GoToTrigonometriRet
            // 
            this.GoToTrigonometriRet.Location = new System.Drawing.Point(177, 12);
            this.GoToTrigonometriRet.Name = "GoToTrigonometriRet";
            this.GoToTrigonometriRet.Size = new System.Drawing.Size(265, 48);
            this.GoToTrigonometriRet.TabIndex = 1;
            this.GoToTrigonometriRet.Text = "Trigonometri Retvinkel";
            this.GoToTrigonometriRet.UseVisualStyleBackColor = true;
            this.GoToTrigonometriRet.Click += new System.EventHandler(this.GoToTrigonometriRet_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 668);
            this.Controls.Add(this.GoToTrigonometriRet);
            this.Controls.Add(this.GoToPythagoras);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoToPythagoras;
        private System.Windows.Forms.Button GoToTrigonometriRet;
    }
}