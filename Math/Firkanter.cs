using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Firkanter : UserControl
    {
        public static float l;
        public static float b;
        public static float h;
        public static string svar;

        public Firkanter()
        {
            InitializeComponent();
        }

        public void GetValues()
        {
            l = Convert.ToSingle(numericUpDown_l.Value);
            b = Convert.ToSingle(numericUpDown_b.Value);
            h = Convert.ToSingle(numericUpDown_h.Value);
        }

        private void Firkant_Areal_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float A = l * b;
                svar = A.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_areal.Font);
                textBox_areal.Width = size.Width;
                textBox_areal.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_areal.Text = svar;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Firkant_Omkreds_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float O = (l * l) + (b * b);
                svar = O.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_omkreds.Font);
                textBox_omkreds.Width = size.Width;
                textBox_omkreds.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_omkreds.Text = svar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Firkant_Diagonal_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float d = MathF.Sqrt((l * l) + (b * b));
                svar = d.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_diagonal.Font);
                textBox_diagonal.Width = size.Width;
                textBox_diagonal.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_diagonal.Text = svar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Firkant_Volumen_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float V = l * b * h;
                svar = V.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_Volumen.Font);
                textBox_Volumen.Width = size.Width;
                textBox_Volumen.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_Volumen.Text = svar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
