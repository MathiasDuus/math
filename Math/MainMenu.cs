using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class MainMenu : Form
    {
        public static Form1 f = new Form1();
        public static Pythagoras p = new Pythagoras();
        public static TrigonometriRet t = new TrigonometriRet();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void GoToPythagoras_Click(object sender, EventArgs e)
        {
            f.Show();
            f.Controls.Add(p);
            f.Text = p.Name;
            p.Show();
        }

        private void GoToTrigonometriRet_Click(object sender, EventArgs e)
        {
            f.Show();
            f.Controls.Add(t);
            f.Text = t.Name;
            t.Show();
        }
    }
}
