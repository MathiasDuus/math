using System;
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

        public MainMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GoToPythagoras_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
            f.Controls.Add(p);
            f.Text = p.Name;
            p.Show();
        }

        private void GoToTrigonometriRet_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
            f.Controls.Add(t);
            f.Text = t.Name;
            t.Show();
        }

        private void GoToTrigonometriVil_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
            f.Controls.Add(tv);
            f.Text = tv.Name;
            tv.Show();
        }

        private void Formler_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
            f.Controls.Add(g);
            f.Text = g.Name;
            g.Show();
        }
    }
}
