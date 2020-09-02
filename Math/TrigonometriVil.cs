﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class TrigonometriVil : UserControl
    {
        public TrigonometriVil()
        {
            InitializeComponent();
        }

        private void Beregn_TrigonometriVil_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(numericUpDown_a.Value);
            float b = Convert.ToSingle(numericUpDown_b.Value);
            float c = Convert.ToSingle(numericUpDown_c.Value);
            float A = Convert.ToSingle(numericUpDown_va.Value);
            float B = Convert.ToSingle(numericUpDown_vb.Value);
            float C = Convert.ToSingle(numericUpDown_vc.Value);


            decimal[] val = Calculate.TrigonometriVil(a,b,c,A,B,C);

            // If statements to ensure that numericUpDowms that have a value isn't overwritten 
            if (a == 0)
            {
                numericUpDown_a.Value = val[0];
            }

            if (b == 0)
            {
                numericUpDown_b.Value = val[1];
            }

            if (c == 0)
            {
                numericUpDown_c.Value = val[2];
            }
            
            if (A == 0)
            {
                numericUpDown_va.Value = val[3];
            }
            
            if (B == 0)
            {
                numericUpDown_vb.Value = val[4];
            }
            
            if (C == 0)
            {
                numericUpDown_vc.Value = val[5];
            }
        }

        private void clear_TrigonometriVil_Click(object sender, EventArgs e)
        {
            Clear.NumericUpDowns(this);
        }
    }
}
