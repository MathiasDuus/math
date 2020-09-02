using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    class Calculate
    {

        public static decimal[] TrigonometriVil(float a, float b, float c, float A, float B, float C)
        {
            decimal[] svar = new decimal[6];

            // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
            // Til radian: (grader)*PI/180
            // TIL grader: (radian)*180/PI

            // Hvis "a" mangler og de tre andre tal ikke er 0
            // Skal bruge: b, c, A
            if (a == 0)
            {
                svar[0] = Side_a(a, b, c, A, B, C);
            }

            // Hvis "b" mangler og de tre andre tal ikke er 0
            // Skal Bruge: a, c, B
            if (b == 0)
            {
                svar[1] = Side_b(a, b, c, A, B, C); 
            }

            // Hvis "c" mangler og de tre andre tal ikke er 0
            // Skal bruge: a, b, C
            if (c == 0)
            {
                svar[2] = Side_c(a, b, c, A, B, C);
            }

            // Hvis "A" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (A == 0)
            {
                svar[3] = Vinkel_A(a, b, c, A, B, C);
            }

            // Hvis "B" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (B == 0)
            {
                svar[4] = Vinkel_B(a, b, c, A, B, C);
            }

            // Hvis "C" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (C == 0)
            {
                svar[5] = Vinkel_C(a, b, c, A, B, C);
            }

            return svar;
        }


        public static decimal Side_a(float a, float b, float c, float A, float B, float C)
        {
            // Hvis "A" mangler
            if (A == 0)
            {
                A = Convert.ToSingle(Vinkel_A(a, b, c, A, B, C));
            }

            // Hvis "b" mangler
            if (b == 0)
            {
                b = Convert.ToSingle(Side_b(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (c == 0)
            {
                c = Convert.ToSingle(Side_c(a, b, c, A, B, C));
            }
            
            // Finder a vha. cosinus: a = sqrt(b^2+c^2-2*b*c*cos(A))

            a = MathF.Sqrt((b * b + c * c) - 2 * b * c * (MathF.Cos(A * MathF.PI / 180)));
            

            return Convert.ToDecimal(MathF.Abs(a));
        }

        public static decimal Side_b(float a, float b, float c, float A, float B, float C)
        {
            // Hvis "B" mangler
            if (B == 0)
            {
                B = Convert.ToSingle(Vinkel_B(a, b, c, A, B, C));
            }

            // Hvis "a" mangler
            if (a == 0)
            {
                a = Convert.ToSingle(Side_a(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (c == 0)
            {
                c = Convert.ToSingle(Side_c(a, b, c, A, B, C));
            }

            // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))

            b = MathF.Sqrt((a * a + c * c) * a * c * (MathF.Cos(B * MathF.PI / 180)));

            return Convert.ToDecimal(MathF.Abs(b));
        }

        public static decimal Side_c(float a, float b, float c, float A, float B, float C)
        {
            // Hvis "B" mangler
            if (C == 0)
            {
                C = Convert.ToSingle(Vinkel_C(a, b, c, A, B, C));
            }

            // Hvis "a" mangler
            if (a == 0)
            {
                a = Convert.ToSingle(Side_a(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (b == 0)
            {
                b = Convert.ToSingle(Side_b(a, b, c, A, B, C));
            }

            // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))

            c = MathF.Sqrt((b * b + a * a) * b * a * (MathF.Cos(C * MathF.PI / 180)));

            return Convert.ToDecimal(MathF.Abs(c));
        }

        public static decimal Vinkel_A(float a, float b, float c, float A, float B, float C)
        {
            // Hvis "a" mangler
            if (a == 0)
            {
                a = Convert.ToSingle(Side_a(a, b, c, A, B, C));
            }

            // Hvis "b" mangler
            if (b == 0)
            {
                b = Convert.ToSingle(Side_b(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (c == 0)
            {
                c = Convert.ToSingle(Side_c(a, b, c, A, B, C));
            }

            if (B != 0 && C != 0)
            {
                A = (C + B) - 180;
            }
            else
            {
                // Finder A vha. cosinus: cos(A)=frac{b^2+c^2-a^2}{2*b*c}

                A = ((b * b + c * c) - (a * a)) / (2 * b * c);
                A = MathF.Acos(A) * 180 / MathF.PI;
            }

            return Convert.ToDecimal(MathF.Abs(A));
        }

        public static decimal Vinkel_B(float a, float b, float c, float A, float B, float C)
        {
            // Hvis enten "a" mangler vil jeg bruge Sinus-relationerne til at finde vinklen "B"
            if (a == 0)
            {
                a = Convert.ToSingle(Side_a(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (c == 0)
            {
                c = Convert.ToSingle(Side_c(a, b, c, A, B, C));
            }

            // Hvis "b" mangler
            if (b == 0)
            {
                if (A != 0)
                {
                    // B = Sin^-1((Sin(A)*b)/a)
                    B = (MathF.Sin(A) * b) / a;
                    B = MathF.Asin(B) * 180 / MathF.PI;
                }
                else
                {
                    B = (MathF.Sin(C) * b) / c;
                    B = MathF.Asin(B) * 180 / MathF.PI;
                }
                return Convert.ToDecimal(MathF.Abs(B));
            }

            if (A != 0 && C != 0)
            {
                B = (C + A) - 180;
            }
            else
            {
                // Finder B vha. cosinus: cos(B)=frac{a^2+c^2-b^2}{2*a*c}

                B = ((a * a + c * c) - (b * b)) / (2 * a * c);
                B = MathF.Acos(B) * 180 / MathF.PI;
            }

            return Convert.ToDecimal(MathF.Abs(B));
        }
        
        public static decimal Vinkel_C(float a, float b, float c, float A, float B, float C)
        {
            // Hvis enten "a" mangler vil jeg bruge Sinus-relationerne til at finde vinklen "B"
            if (a == 0)
            {
                a = Convert.ToSingle(Side_a(a, b, c, A, B, C));
            }

            // Hvis "b" mangler
            if (b == 0)
            {
                b = Convert.ToSingle(Side_b(a, b, c, A, B, C));
            }

            // Hvis "c" mangler
            if (c == 0)
            {
                // Hvis "A" ikke er nul så brug den her ellers brug den sinus der bruger "B"
                if (A != 0)
                {
                    C = (MathF.Sin(A) * c) / a;
                    C = MathF.Asin(C) * 180 / MathF.PI;
                }
                else
                {
                    C = (MathF.Sin(B) * c) / b;
                    C = MathF.Asin(C) * 180 / MathF.PI;
                }
                return Convert.ToDecimal(MathF.Abs(B));
            }

            if (B != 0 && A != 0)
            {
                C = (A + B) - 180;
            }
            else
            {
                // Finder C vha. cosinus: cos(C)=frac{a^2+b^2-c^2}{2*a*b}

                C = ((a * a + b * b) - (c * c)) / (2 * a * b);
                C = MathF.Acos(B) * 180 / MathF.PI;
            }

            return Convert.ToDecimal(MathF.Abs(C));
        }
    }
}
