using System;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CloseUC(Control UC)
        {
            Clear.NumericUpDowns(this);
            Clear.ClearTextBox(this);
            this.Hide();
            MainMenu.mm.Show();
            UC.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Pythagoras":
                    CloseUC(MainMenu.p);
                    break;

                case "TrigonometriRet":
                    CloseUC(MainMenu.t);
                    break;

                case "TrigonometriVil":
                    CloseUC(MainMenu.tv);
                    break;

                case "Graf":
                    CloseUC(MainMenu.g);
                    break;

                case "Cirkler":
                    CloseUC(MainMenu.c);
                    break;
            }


        }

        private void Slet_Click(object sender, EventArgs e)
        {
            Clear.NumericUpDowns(this);
            Clear.ClearTextBox(this);
        }
    }
}
