using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                    MainMenu.p.Hide();
                    break;

                case "TrigonometriRet":
                    MainMenu.t.Hide();
                    break;

                case "TrigonometriVil":
                    MainMenu.tv.Hide();
                    break;

                case "2":

                    break;

                case "3":

                    break;
            }


        }
    }
}
