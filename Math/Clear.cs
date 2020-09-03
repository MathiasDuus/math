﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    class Clear
    {
        //Clear numericUpDown
        public static void NumericUpDowns(Control parent)
        {
            if (parent == null)
            {
                throw new ArgumentNullException("parent");
            }

            else
            {
                foreach (Control control in parent.Controls)
                {
                    NumericUpDown nud = control as NumericUpDown;

                    if (nud != null)
                    {
                        nud.Value = nud.Minimum;
                    }

                    if (control.Controls.Count > 0)
                    {
                        NumericUpDowns(control);
                    }
                }
            }
        }
    }
}