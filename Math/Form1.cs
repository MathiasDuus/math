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

            var p = new Pythagoras();
            string name = p.Name;
            this.Text = name;
            this.Update();
        }



    }
}
