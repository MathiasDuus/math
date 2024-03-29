﻿using System;
using System.Windows.Forms;

namespace Math
{
    public partial class MainMenu : Form
    {
        public static Form1 f = new Form1();
        public static MainMenu mm = new MainMenu();
        public static Pythagoras p = new Pythagoras();
        public static TrigonometriRet t = new TrigonometriRet();
        public static TrigonometriVil tv = new TrigonometriVil();
        public static Graf g = new Graf();
        public static Cirkler c = new Cirkler();
        public static Firkanter fi = new Firkanter();
        public static AnalytiskPlangeometri ap = new AnalytiskPlangeometri();
        public static Vektor v = new Vektor();

        public MainMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void OpenUC(Control UC)
        {
            this.Hide();
            f.Show();
            f.Controls.Add(UC);
            f.Text = UC.Name;
            UC.Show();
        }


        private void GoToPythagoras_Click(object sender, EventArgs e)
        {
            OpenUC(p);
        }

        private void GoToTrigonometriRet_Click(object sender, EventArgs e)
        {
            OpenUC(t);
        }

        private void GoToTrigonometriVil_Click(object sender, EventArgs e)
        {
            OpenUC(tv);
        }

        private void Formler_Click(object sender, EventArgs e)
        {
            OpenUC(g);
        }

        private void Cirkler_Click(object sender, EventArgs e)
        {
            OpenUC(c);
        }

        private void Firkanter_Click(object sender, EventArgs e)
        {
            OpenUC(fi);
        }

        private void GoTo_AP_Click(object sender, EventArgs e)
        {
            OpenUC(ap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenUC(v);
        }
    }
}
