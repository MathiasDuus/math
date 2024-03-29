﻿namespace Math
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
            this.GoToTrigonometriVil = new System.Windows.Forms.Button();
            this.Formler = new System.Windows.Forms.Button();
            this.Cirkler = new System.Windows.Forms.Button();
            this.Firkanter = new System.Windows.Forms.Button();
            this.GoTo_AP = new System.Windows.Forms.Button();
            this.button_Vektor = new System.Windows.Forms.Button();
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
            // GoToTrigonometriVil
            // 
            this.GoToTrigonometriVil.Location = new System.Drawing.Point(448, 12);
            this.GoToTrigonometriVil.Name = "GoToTrigonometriVil";
            this.GoToTrigonometriVil.Size = new System.Drawing.Size(265, 48);
            this.GoToTrigonometriVil.TabIndex = 2;
            this.GoToTrigonometriVil.Text = "Trigonometri vilkårlig";
            this.GoToTrigonometriVil.UseVisualStyleBackColor = true;
            this.GoToTrigonometriVil.Click += new System.EventHandler(this.GoToTrigonometriVil_Click);
            // 
            // Formler
            // 
            this.Formler.Location = new System.Drawing.Point(12, 66);
            this.Formler.Name = "Formler";
            this.Formler.Size = new System.Drawing.Size(159, 48);
            this.Formler.TabIndex = 3;
            this.Formler.Text = "Graf";
            this.Formler.UseVisualStyleBackColor = true;
            this.Formler.Click += new System.EventHandler(this.Formler_Click);
            // 
            // Cirkler
            // 
            this.Cirkler.Location = new System.Drawing.Point(177, 66);
            this.Cirkler.Name = "Cirkler";
            this.Cirkler.Size = new System.Drawing.Size(159, 48);
            this.Cirkler.TabIndex = 4;
            this.Cirkler.Text = "Cirkler";
            this.Cirkler.UseVisualStyleBackColor = true;
            this.Cirkler.Click += new System.EventHandler(this.Cirkler_Click);
            // 
            // Firkanter
            // 
            this.Firkanter.Location = new System.Drawing.Point(342, 66);
            this.Firkanter.Name = "Firkanter";
            this.Firkanter.Size = new System.Drawing.Size(159, 48);
            this.Firkanter.TabIndex = 5;
            this.Firkanter.Text = "Firkanter";
            this.Firkanter.UseVisualStyleBackColor = true;
            this.Firkanter.Click += new System.EventHandler(this.Firkanter_Click);
            // 
            // GoTo_AP
            // 
            this.GoTo_AP.Location = new System.Drawing.Point(507, 66);
            this.GoTo_AP.Name = "GoTo_AP";
            this.GoTo_AP.Size = new System.Drawing.Size(268, 48);
            this.GoTo_AP.TabIndex = 6;
            this.GoTo_AP.Text = "Analytisk plangeometri";
            this.GoTo_AP.UseVisualStyleBackColor = true;
            this.GoTo_AP.Click += new System.EventHandler(this.GoTo_AP_Click);
            // 
            // button_Vektor
            // 
            this.button_Vektor.Location = new System.Drawing.Point(12, 120);
            this.button_Vektor.Name = "button_Vektor";
            this.button_Vektor.Size = new System.Drawing.Size(159, 48);
            this.button_Vektor.TabIndex = 7;
            this.button_Vektor.Text = "Vektor";
            this.button_Vektor.UseVisualStyleBackColor = true;
            this.button_Vektor.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 224);
            this.Controls.Add(this.button_Vektor);
            this.Controls.Add(this.GoTo_AP);
            this.Controls.Add(this.Firkanter);
            this.Controls.Add(this.Cirkler);
            this.Controls.Add(this.Formler);
            this.Controls.Add(this.GoToTrigonometriVil);
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
        private System.Windows.Forms.Button GoToTrigonometriVil;
        private System.Windows.Forms.Button Formler;
        private System.Windows.Forms.Button Cirkler;
        private System.Windows.Forms.Button Firkanter;
        private System.Windows.Forms.Button GoTo_AP;
        private System.Windows.Forms.Button button_Vektor;
    }
}