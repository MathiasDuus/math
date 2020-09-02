using System;
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

            if ((a + b + c != 0) && (A != 0 || B != 0) && (A + B <= 90))
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
            // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
            // Til radian: (grader)*PI/180
            // TIL grader: (radian)*180/PI

            if (a == 0)
            {
                // Finder den manglende vinkel vha. Pythagoras
                numericUpDown_a.Value = Pythagoras.PythagorasCalc(a, b, c);

                // cosinus find vinkel A: A=cos^-1(b/c)

                float cosA = MathF.Acos(b / c);
                cosA = cosA * 180 / MathF.PI;
                numericUpDown_va.Value = Convert.ToDecimal(cosA);

                // Bruger vinkel summen til at finde den sidste vinkel
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

                // Bruger vinkel summen til at finde den sidste vinkel
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

                // Bruger vinkel summen til at finde den sidste vinkel
                float sum = 90 - tanA;
                numericUpDown_va.Value = Convert.ToDecimal(sum);

            }
        }

        public void FindVinkelOgSide(float a, float b, float c, float A, float B)
        {
            // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
            // Til radian: (grader)*PI/180
            // TIL grader: (radian)*180/PI

            // kender c og B
            if (a == 0 && b == 0 && A == 0)
            {
                // Finder A ved at minuse de kandte vikler med 180 (retvinklet trekant har én vinkel på 90) derfor 90 - ukendt
                A = 90 - B;

                // Finder siden a: Sin(A)=a/c <=> a = c*Sin(A)
                a = c * MathF.Sin((A*MathF.PI/180));

                // Finder b: Cos(A)=b/c <=> b = c*Cos(A)
                b = c * MathF.Cos((A * MathF.PI / 180));

                numericUpDown_va.Value = Convert.ToDecimal(MathF.Abs(A));
                numericUpDown_a.Value = Convert.ToDecimal(MathF.Abs(a));
                numericUpDown_b.Value = Convert.ToDecimal(MathF.Abs(b));
            }

            // kender c og A
            if (a == 0 && b == 0 && B == 0)
            {
                // Finder B
                B = 90 - A;

                // Finder siden a: a = c*Sin(A)
                a = c * MathF.Sin((A * MathF.PI / 180));

                // Finder b: b = c*Cos(A)
                b = c * MathF.Cos((A * MathF.PI / 180));

                numericUpDown_vb.Value = Convert.ToDecimal(MathF.Abs(B));
                numericUpDown_a.Value = Convert.ToDecimal(MathF.Abs(a));
                numericUpDown_b.Value = Convert.ToDecimal(MathF.Abs(b));
            }

            // kender b og B
            if (a == 0 && c == 0 && A == 0)
            {
                // Finder A
                A = 90 - B;

                // Finder a: a=b*Tan(A)
                a = b * MathF.Tan((A * MathF.PI / 180));

                // Finder c: a=b/Cos(A)
                c = b / MathF.Cos((A * MathF.PI / 180));

                numericUpDown_va.Value = Convert.ToDecimal(MathF.Abs(A));
                numericUpDown_a.Value = Convert.ToDecimal(MathF.Abs(a));
                numericUpDown_c.Value = Convert.ToDecimal(MathF.Abs(c));
            }

            // kender b og A
            if (a == 0 && c == 0 && B == 0)
            {
                // Finder B
                B = 90 - A;

                // Finder a: a=b*Tan(A)
                a = b * MathF.Tan((A * MathF.PI / 180));

                // Finder c: a=b/Cos(A)
                c = b / MathF.Cos((A * MathF.PI / 180));

                numericUpDown_vb.Value = Convert.ToDecimal(MathF.Abs(B));
                numericUpDown_a.Value = Convert.ToDecimal(MathF.Abs(a));
                numericUpDown_c.Value = Convert.ToDecimal(MathF.Abs(c));
            }

            // kender a og B
            if (c == 0 && b == 0 && A == 0)
            {
                // Finder A
                A = 90 - B;

                // Finder b: 
                b = a / MathF.Tan((A * MathF.PI / 180));

                // Finder c: a=b/Cos(A)
                c = a / MathF.Sin((A * MathF.PI / 180));

                numericUpDown_va.Value = Convert.ToDecimal(MathF.Abs(A));
                numericUpDown_b.Value = Convert.ToDecimal(MathF.Abs(b));
                numericUpDown_c.Value = Convert.ToDecimal(MathF.Abs(c));
            }

            // kender a og A
            if (c == 0 && b == 0 && B == 0)
            {
                // Finder B
                B = 90 - A;

                // Finder b: 
                b = a / MathF.Tan((A * MathF.PI / 180));

                // Finder c: a=b/Cos(A)
                c = a / MathF.Sin((A * MathF.PI / 180));

                numericUpDown_vb.Value = Convert.ToDecimal(MathF.Abs(B));
                numericUpDown_b.Value = Convert.ToDecimal(MathF.Abs(b));
                numericUpDown_c.Value = Convert.ToDecimal(MathF.Abs(c));
            }
        }
    }
}
