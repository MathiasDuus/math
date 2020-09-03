using System;
using System.Windows.Forms;

namespace Math
{
    class Calculate
    {
        public static float a;
        public static float b;
        public static float c;
        public static float A;
        public static float B;
        public static float C;
        public static string overFlow = "Indtast gyldige værdier";

        public static decimal[] TrigonometriVil(float q, float w, float e, float r, float t, float y)
        {
            decimal[] svar = new decimal[6];

            a = q;
            b = w;
            c = e;
            A = r;
            B = t;
            C = y;

            // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
            // Til radian: (grader)*PI/180
            // TIL grader: (radian)*180/PI

            // Hvis "a" mangler og de tre andre tal ikke er 0
            // Skal bruge: b, c, A
            if (a == 0)
            {
                svar[0] = Side_a();
            }

            // Hvis "b" mangler og de tre andre tal ikke er 0
            // Skal Bruge: a, c, B
            if (b == 0)
            {
                svar[1] = Side_b(); 
            }

            // Hvis "c" mangler og de tre andre tal ikke er 0
            // Skal bruge: a, b, C
            if (c == 0)
            {
                svar[2] = Side_c();
            }

            // Hvis "A" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (A == 0)
            {
                svar[3] = Vinkel_A();
            }

            // Hvis "B" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (B == 0)
            {
                svar[4] = Vinkel_B();
            }

            // Hvis "C" mangler og vi har resten der skal bruges til formlen
            // Skal bruge a, b, c
            if (C == 0)
            {
                svar[5] = Vinkel_C();
            }

            return svar;
        }

        public static decimal Side_a()
        {
            try
            {
                // Hvis "b" mangler
                if (b == 0)
                {
                    b = Convert.ToSingle(Side_b());
                }

                // Hvis "c" mangler
                if (c == 0)
                {
                    c = Convert.ToSingle(Side_c());
                }

                // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
                // Til radian: (grader)*PI/180
                // TIL grader: (radian)*180/PI

                // Hvis "A" mangler
                if (A == 0)
                {
                    if (B == 0 && C != 0)
                    {
                        // B = Sin^-1((Sin(C)*b)/c)
                        B = (MathF.Sin(C) * b) / c;
                        if (B < 0)
                        {
                            B = (MathF.Sin(C * MathF.PI / 180) * b) / c;
                        }
                        B = MathF.Asin(B) * 180 / MathF.PI;
                    }
                    if (C == 0 && B != 0)
                    {
                        // C = Sin^-1((Sin(B)*c)/b)
                        C = (MathF.Sin(B) * c) / b;
                        if (C < 0)
                        {
                            C = (MathF.Sin((B * MathF.PI) / 180) * c) / b;
                        }
                        C = MathF.Asin(C) * 180 / MathF.PI;
                    }
                    if (B != 0 && C != 0)
                    {
                        //Tjekker begge sinus resultater
                        //Tjekker først B
                        if (CheckSin(B, C))
                        {
                            A = 180 - (180 - B) - C;
                        }
                        //Tjekker C
                        else if (CheckSin(C, B))
                        {
                            A = 180 - (180 - C) - B;
                        }
                        else
                        {
                            A = 180 - (B + C);
                        }
                    }
                }


                // Finder a vha. cosinus: a = sqrt(b^2+c^2-2*b*c*cos(A))

                a = MathF.Sqrt((b * b + c * c) - 2 * b * c * (MathF.Cos(A * MathF.PI / 180)));

                return Convert.ToDecimal(MathF.Abs(a));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static decimal Side_b()
        {
            try
            {
                // Hvis "a" mangler
                if (a == 0)
                {
                    a = Convert.ToSingle(Side_a());
                }

                // Hvis "c" mangler
                if (c == 0)
                {
                    c = Convert.ToSingle(Side_c());
                }

                // Hvis "B" mangler
                if (B == 0)
                {
                    if (A == 0 && C != 0)
                    {
                        // A = Sin^-1((Sin(C)*a)/c)
                        A = (MathF.Sin(C) * a) / c;
                        if (A < 0)
                        {
                            A = (MathF.Sin(C * MathF.PI / 180) * a) / c;
                        }
                        A = MathF.Asin(A) * 180 / MathF.PI;
                    }
                    if (C == 0 && A != 0)
                    {
                        // C = Sin^-1((Sin(A)*c)/a)
                        C = (MathF.Sin(A) * c) / a;
                        if (C < 0)
                        {
                            C = (MathF.Sin(A * MathF.PI / 180) * c) / a;
                        }
                        C = MathF.Asin(C) * 180 / MathF.PI;
                    }
                    //Tjekker A
                    if (CheckSin(A, C))
                    {
                        B = 180 - (180 - A) - C;
                    }
                    //Tjekker C
                    else if (CheckSin(C, A))
                    {
                        B = 180 - (180 - C) - A;
                    }
                    if (A != 0 && C != 0)
                    {
                        B = 180 - (A + C);
                    }
                }

                // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))

                b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));

                return Convert.ToDecimal(MathF.Abs(b));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static decimal Side_c()
        {
            try
            {
                // Hvis "a" mangler
                if (a == 0)
                {
                    a = Convert.ToSingle(Side_a());
                }

                // Hvis "c" mangler
                if (b == 0)
                {
                    b = Convert.ToSingle(Side_b());
                }

                // Hvis "C" mangler
                if (C == 0)
                {
                    if (A == 0 && B != 0)
                    {
                        // A = Sin^-1((Sin(B)*a)/b)
                        A = (MathF.Sin(B) * a) / b;
                        if (A < 0)
                        {
                            A = (MathF.Sin(B * MathF.PI / 180) * a) / b;
                        }
                        A = MathF.Asin(A) * 180 / MathF.PI;
                    }
                    if (B == 0 && A != 0)
                    {
                        // C = Sin^-1((Sin(A)*b)/a)
                        B = (MathF.Sin(A) * b) / a;
                        if (B < 0)
                        {
                            B = (MathF.Sin(A * MathF.PI / 180) * b) / a;
                        }
                        B = MathF.Asin(B) * 180 / MathF.PI;
                    }
                    //Tjekker B
                    if (CheckSin(B, A))
                    {
                        C = 180 - (180 - B) - A;
                    }
                    //Tjekker A
                    else if (CheckSin(A, B))
                    {
                        C = 180 - (180 - A) - B;
                    }
                    if (A != 0 && B != 0)
                    {
                        C = 180 - (A + B);
                    }
                }

                // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))

                c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));

                return Convert.ToDecimal(MathF.Abs(c));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static decimal Vinkel_A()
        {
            try
            {
                // Hvis "a" mangler
                if (a == 0)
                {
                    a = Convert.ToSingle(Side_a());
                }

                // Hvis "b" mangler
                if (b == 0)
                {
                    b = Convert.ToSingle(Side_b());
                }

                // Hvis "c" mangler
                if (c == 0)
                {
                    c = Convert.ToSingle(Side_c());
                }

                if (B != 0 && C != 0 && A == 0)
                {
                    A = 180 - (C + B);
                }
                else if (A == 0)
                {
                    // Finder A vha. cosinus: cos(A)=frac{b^2+c^2-a^2}{2*b*c}

                    A = ((b * b + c * c) - (a * a)) / (2 * b * c);
                    A = MathF.Acos(A) * 180 / MathF.PI;
                }

                return Convert.ToDecimal(MathF.Abs(A));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static decimal Vinkel_B()
        {
            try
            {
                // Hvis enten "a" mangler vil jeg bruge Sinus-relationerne til at finde vinklen "B"
                if (a == 0)
                {
                    a = Convert.ToSingle(Side_a());
                }

                // Hvis "c" mangler
                if (c == 0)
                {
                    c = Convert.ToSingle(Side_c());
                }

                // Hvis "b" mangler
                if (b == 0)
                {
                    b = Convert.ToSingle(Side_b());
                }

                if (A != 0 && C != 0 && B == 0)
                {
                    B = (C + A) - 180;
                }
                else if (B == 0)
                {
                    // Finder B vha. cosinus: cos(B)=frac{a^2+c^2-b^2}{2*a*c}

                    B = ((a * a + c * c) - (b * b)) / (2 * a * c);
                    B = MathF.Acos(B) * 180 / MathF.PI;
                }

                Console.WriteLine("Vinkel B " + B);
                return Convert.ToDecimal(MathF.Abs(B));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static decimal Vinkel_C()
        {
            try
            {
                // Hvis enten "a" mangler vil jeg bruge Sinus-relationerne til at finde vinklen "B"
                if (a == 0)
                {
                    a = Convert.ToSingle(Side_a());
                }

                // Hvis "b" mangler
                if (b == 0)
                {
                    b = Convert.ToSingle(Side_b());
                }

                // Hvis "c" mangler
                if (c == 0)
                {
                    c = Convert.ToSingle(Side_c());
                }

                if (B != 0 && A != 0 && C == 0)
                {
                    C = (A + B) - 180;
                }
                else if (C == 0)
                {
                    // Finder C vha. cosinus: cos(C)=frac{a^2+b^2-c^2}{2*a*b}

                    C = ((a * a + b * b) - (c * c)) / (2 * a * b);
                    C = MathF.Acos(C) * 180 / MathF.PI;
                }

                return Convert.ToDecimal(MathF.Abs(C));
            }
            catch (OverflowException)
            {
                MessageBox.Show(overFlow);
                return 1;
            }
        }

        public static bool CheckSin(float q, float w)
        {
            if (180 - (180 - q) - w > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
