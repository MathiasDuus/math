﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Formler : UserControl
    {
        public Formler()
        {
            InitializeComponent();
        }

        public static string ups = "Ups!";

        private void Button_AndFindX_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(numericUpDown_xa.Value);
                float b = Convert.ToSingle(numericUpDown_xb.Value);
                float D = Convert.ToSingle(numericUpDown_xd.Value);
                float x;
                string svar;

                // x=(-b±√d)/2a
                x = ((-b) + MathF.Sqrt(D)) / (2 * a);
                // Tilføjer resultatet til en string.
                svar = x.ToString();
                //Denne gang med minus
                x = ((-b) - MathF.Sqrt(D)) / (2 * a);
                // Tilføjer resultatet til den samme string som før
                svar += ", " + x.ToString();
                textBox_AndFindX.Text = svar;
            }
            catch (Exception)
            {
                MessageBox.Show(ups);
            }
        }

        private void Button_AndFindD_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(numericUpDown_da.Value);
                float b = Convert.ToSingle(numericUpDown_db.Value);
                float c = Convert.ToSingle(numericUpDown_dc.Value);
                float D;
                string svar;

                // d=b^2-4ac
                D = (b * b) - (4 * a * c);
                // Tilføjer resultatet til en string.
                svar = D.ToString();

                textBox_AndFindD.Text = svar;
            }
            catch (Exception)
            {
                MessageBox.Show(ups);
            }
        }

        private void Button_LinFinda_Click(object sender, EventArgs e)
        {
            try
            {
                float y1 = Convert.ToSingle(numericUpDown_y1.Value);
                float y2 = Convert.ToSingle(numericUpDown_y2.Value);
                float x1 = Convert.ToSingle(numericUpDown_x1.Value);
                float x2 = Convert.ToSingle(numericUpDown_x2.Value);
                float a;
                string svar;

                //a=(Y_1-Y_2)/(X_1-X_2 )
                a = (y1-y2) / (x1-x2);

                // Tilføjer resultatet til en string.
                svar = a.ToString();

                textBox_LinFinda.Text = svar;
            }
            catch (Exception)
            {
                MessageBox.Show(ups);
            }


        }
    }
}
