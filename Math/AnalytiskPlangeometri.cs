using System;
using System.Drawing;
using System.Windows.Forms;

namespace Math
{
    public partial class AnalytiskPlangeometri : UserControl
    {
        public static float x1;
        public static float y1;
        public static float x2;
        public static float y2;
        public static float al;
        public static float bl;
        public static float am;
        public static float bm;
        public static string svar;
        public AnalytiskPlangeometri()
        {
            InitializeComponent();
        }

        public void GetValues()
        {
            x1 = Convert.ToSingle(numericUpDown_x1.Value);
            y1 = Convert.ToSingle(numericUpDown_y1.Value);
            x2 = Convert.ToSingle(numericUpDown_x2.Value);
            y2 = Convert.ToSingle(numericUpDown_y2.Value);
            al = Convert.ToSingle(numericUpDown_al.Value);
            bl = Convert.ToSingle(numericUpDown_bl.Value);
            am = Convert.ToSingle(numericUpDown_am.Value);
            bm = Convert.ToSingle(numericUpDown_bm.Value);
        }

        private void Midtpunkt_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float x;
                float y;
                float half = Convert.ToSingle(2 / (double)4);

                x = half * (x1 + x2);
                y = half * (y1 + y2);

                svar = "(" + x + "; " + y + ")";

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_midtpunkt.Font);
                textBox_midtpunkt.Width = size.Width;
                textBox_midtpunkt.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_midtpunkt.Text = svar;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Afstand_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float af;
                float temp;

                temp = MathF.Pow((x1 - x2), 2) + MathF.Pow((y1 - y2), 2);
                af = MathF.Sqrt(temp);

                svar = af.ToString();

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_afstand.Font);
                textBox_afstand.Width = size.Width;
                textBox_afstand.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_afstand.Text = svar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Skæringspunkt_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                float x;
                float y;
                float a;
                float b;

                //ax+b=ax+b
                //ax-ax+b=b
                //al - am = bm - bl
                if (al >= am)
                {
                    a = al-am;
                    //Finder b
                    b = bm - bl;
                }
                else
                {
                    a = am - al;
                    //Finder b
                    b = bl - bm;
                }


                //finder x ved at dividere b med a
                x = b / a;

                //Finder y ved at sætte x ind i ligningen
                y = al * x + bl;


                svar = "(" + x + "; " + y + ")";

                //ændre størelsen på textboxen efter indholdet
                Size size = TextRenderer.MeasureText(svar, textBox_skæringspunkt.Font);
                textBox_skæringspunkt.Width = size.Width;
                textBox_skæringspunkt.Height = size.Height;
                //tilføjer svar til textboxen
                textBox_skæringspunkt.Text = svar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
