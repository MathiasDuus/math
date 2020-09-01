using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class TrigonometriRet : UserControl
    {
        public TrigonometriRet()
        {
            InitializeComponent();
        }

        private void beregn_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(numericUpDown_a.Value);
            float b = Convert.ToSingle(numericUpDown_b.Value);
            float c = Convert.ToSingle(numericUpDown_c.Value);
            float A = Convert.ToSingle(numericUpDown_va.Value);
            float B = Convert.ToSingle(numericUpDown_vb.Value);

            if ((a + b) == 0 || (a + c) == 0 || (c + b) == 0 && A!=0 || B!=0)
            {
                FindVinkelOgSide(a, b, c, A, B);
            }
            else
            {
                TrigonometriRetvinkelTrekant(a, b, c);
            }

        }
       
        private void clear_trigonometriRet_Click(object sender, EventArgs e)
        {
            Clear.NumericUpDowns(this);
        }

        public void TrigonometriRetvinkelTrekant(float a, float b, float c)
        {
            if (a == 0)
            {
                // Finder den manglende vinkel vha. Pythagoras
                numericUpDown_a.Value = Pythagoras.PythagorasCalc(a, b, c);

                // cosinus find vinkel A: A=cos^-1(b/c)

                float cosA = MathF.Acos(b / c);
                cosA = cosA * 180 / MathF.PI;
                numericUpDown_va.Value = Convert.ToDecimal(cosA);

                //Bruger vinkel summen til at finde den sidste vinkel
                float sum = 90-cosA;
                numericUpDown_vb.Value = Convert.ToDecimal(sum);

            }
            else if (b == 0)
            {
                numericUpDown_b.Value = Pythagoras.PythagorasCalc(a, b, c);

                // Cosinus find vinkel B: B=cos^-1(a/c)

                float cosB = MathF.Acos(a / c);
                cosB = cosB * 180 / MathF.PI;
                numericUpDown_vb.Value = Convert.ToDecimal(cosB);

                //Bruger vinkel summen til at finde den sidste vinkel
                float sum = 90 - cosB;
                numericUpDown_va.Value = Convert.ToDecimal(sum);

            }
            else if (c == 0)
            {
                numericUpDown_c.Value = Pythagoras.PythagorasCalc(a, b, c);

                // Tangens til at finde vinkel A: A=Tan^-1(a/b)

                float tanA = MathF.Atan(a / b);
                tanA = tanA * 180 / MathF.PI;
                numericUpDown_vb.Value = Convert.ToDecimal(tanA);

                //Bruger vinkel summen til at finde den sidste vinkel
                float sum = 90 - tanA;
                numericUpDown_va.Value = Convert.ToDecimal(sum);

            }
        }

        public void FindVinkelOgSide(float a, float b, float c, float A, float B)
        {







        }


    }
}
