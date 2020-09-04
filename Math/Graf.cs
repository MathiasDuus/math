using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Graf : UserControl
    {
        public Graf()
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

                Size size = TextRenderer.MeasureText(svar, textBox_AndFindX.Font);
                textBox_AndFindX.Width = size.Width;
                textBox_AndFindX.Height = size.Height;
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

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_AndFindD.Font);
                textBox_AndFindD.Width = size.Width;
                textBox_AndFindD.Height = size.Height;
                //tilføjer svar til textboxen
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

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_LinFinda.Font);
                textBox_LinFinda.Width = size.Width;
                textBox_LinFinda.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_LinFinda.Text = svar;
            }
            catch (Exception)
            {
                MessageBox.Show(ups);
            }
        }

        private void Button_LinFindb_Click(object sender, EventArgs e)
        {
            try
            {
                float y1 = Convert.ToSingle(numericUpDown_LinFindb_y.Value);
                float x1 = Convert.ToSingle(numericUpDown_LinFindb_x.Value);
                float a = Convert.ToSingle(numericUpDown_LinFindb_a.Value);
                float b;
                string svar;

                //a=(Y_1-Y_2)/(X_1-X_2 )
                b = a*x1-y1;

                // Tilføjer resultatet til en string.
                svar = b.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_LindFindb.Font);
                textBox_LindFindb.Width = size.Width;
                textBox_LindFindb.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_LindFindb.Text = svar;
            }
            catch (Exception)
            {
                MessageBox.Show(ups);
            }
        }
    }
}
