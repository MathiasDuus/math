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

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.mm.Show();
            switch (this.Text)
            {
                case "Pythagoras":
                    Clear.NumericUpDowns(this);
                    MainMenu.p.Hide();
                    break;

                case "TrigonometriRet":
                    Clear.NumericUpDowns(this);
                    MainMenu.t.Hide();
                    break;

                case "TrigonometriVil":
                    Clear.NumericUpDowns(this);
                    MainMenu.tv.Hide();
                    break;

                case "Formler":
                    Clear.NumericUpDowns(this);
                    Clear.ClearTextBox(this);
                    MainMenu.fo.Hide();
                    break;

                case "3":

                    break;
            }


        }
    }
}
