using System;
using System.Windows.Forms;

namespace Math
{
    class Calculate
    {
        public static bool hasAllAngle;
        public static bool hasAllSide;

        public static decimal[] TrigonometriVil(float a, float b, float c, float A, float B, float C)
        {
            decimal[] svar = new decimal[6];
            try
            {

                // C# bruger radianer, derfor bliver vi nødt til at converte dem til grader og vice versa
                // TIL radian: (grader)*PI/180
                // TIL grader: (radian)*180/PI

                // HVIS Der kun er vinkler sæt "a" til 10
                if (A != 0 && B != 0 && C != 0)
                {
                    hasAllAngle = true;
                    a = 10;
                }

                // hvis der kun er sider
                if (a != 0 && b != 0 && c != 0)
                {
                    hasAllSide = true;
                }


                if (hasAllSide)
                {
                    if (A == 0)
                    {
                        A = ((b * b + c * c) - (a * a)) / (2 * b * c);
                        A = MathF.Acos(A) * 180 / MathF.PI;
                    }

                    if (B == 0)
                    {
                        B = ((a * a + c * c) - (b * b)) / (2 * a * c);
                        B = MathF.Acos(B) * 180 / MathF.PI;
                    }

                    if (C == 0)
                    {
                        C = ((a * a + b * b) - (c * c)) / (2 * a * b);
                        C = MathF.Acos(C) * 180 / MathF.PI;
                    }

                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));

                    hasAllSide = false;
                }

                if (hasAllAngle)
                {
                    if (b == 0)
                        b = (MathF.Sin(B * MathF.PI / 180) * a) / MathF.Sin(A * MathF.PI / 180);

                    if (c == 0)
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));

                    hasAllAngle = false;
                }

                if (a != 0 && b != 0 && A != 0)
                {
                    if (B == 0)
                    {
                        // Finder vinkel B
                        B = MathF.Sin(A * MathF.PI / 180) * b / a;
                        if (B < 0)
                        {
                            B = MathF.Sin(A * 180 / MathF.PI) * b / a;
                        }
                        B = MathF.Asin(B) * 180 / MathF.PI;
                    }

                    if (C == 0)
                    {
                        // Finder Vikel C 
                        // "B" er den vinkel der er regnet med Sinus
                        if (CheckSin(B, A))
                        {
                            C = 180 - (180 - B) - A;
                        }
                        else
                        {
                            C = 180 - (A + B);
                        }
                    }

                    if (c == 0)
                    {
                        // Finder side c
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }

                        svar[2] = Convert.ToDecimal(MathF.Abs(c));
                        svar[4] = Convert.ToDecimal(MathF.Abs(B));
                        svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (a != 0 && b != 0 && B != 0)
                {
                    if (A == 0)
                    {
                        // A = Sin^-1((Sin(B)*a)/b)
                        A = (MathF.Sin(B * MathF.PI / 180) * a) / b;
                        if (A < 0)
                        {
                            A = MathF.Sin(B * 180 / MathF.PI) * a / b;
                        }
                        A = MathF.Asin(A) * 180 / MathF.PI;
                    }

                    if (C == 0)
                    {
                        // Finder Vikel C 
                        if (CheckSin(A, B))
                        {
                            C = 180 - (180 - A) - B;
                        }
                        else
                        {
                            C = 180 - (A + B);
                        }
                    }
                    if (c == 0)
                    {
                        // Finder side c
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }

                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (a != 0 && b != 0 && C != 0)
                {
                    if (c == 0)
                    {
                        // Finder side c
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }

                    if (A == 0)
                    {
                        // Finder A vha. cosinus: cos(A)=frac{b^2+c^2-a^2}{2*b*c}
                        A = ((b * b + c * c) - (a * a)) / (2 * b * c);
                        A = MathF.Acos(A) * 180 / MathF.PI;
                    }
                    if (B == 0)
                    {
                        B = (C + A) - 180;
                    }

                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (a != 0 && c != 0 && A != 0)
                {
                    if (C == 0)
                    {
                        // C = Sin^-1((Sin(A)*c)/a)
                        C = (MathF.Sin(A * MathF.PI / 180) * c) / a;
                        if (C < 0)
                        {
                            C = MathF.Sin(A * 180 / MathF.PI) * c / a;
                        }
                        C = MathF.Asin(C) * 180 / MathF.PI;
                    }

                    if (B == 0)
                    {
                        // Finder Vikel C 
                        if (CheckSin(C, A))
                        {
                            B = 180 - (180 - C) - A;
                        }
                        else
                        {
                            B = 180 - (C + A);
                        }
                    }

                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }

                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (a != 0 && c != 0 && B != 0)
                {
                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }

                    if (C == 0)
                    {
                        // Finder C vha. cosinus: cos(C)=frac{a^2+b^2-c^2}{2*a*b}
                        C = ((a * a + b * b) - (c * c)) / (2 * a * b);
                        C = MathF.Acos(C) * 180 / MathF.PI;
                    }

                    if (A == 0)
                    {
                        A = 180 - (C + B);
                    }


                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (a != 0 && c != 0 && C != 0)
                {
                    if (A == 0)
                    {
                        // A = Sin^-1((Sin(B)*a)/b)
                        A = (MathF.Sin(C * MathF.PI / 180) * a) / c;
                        if (A < 0)
                        {
                            A = MathF.Sin(C * 180 / MathF.PI) * a / c;
                        }
                        A = MathF.Asin(A) * 180 / MathF.PI;
                    }

                    if (B == 0)
                    {
                        // Finder Vikel C 
                        if (CheckSin(A,C))
                        {
                            B = 180 - (180 - A) - C;
                        }
                        else
                        {
                            B = 180 - (C + A);
                        }
                    }

                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }


                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (a != 0 && B != 0 && A != 0)
                {
                    if (C == 0)
                    {
                        C = 180 - A - B;
                    }

                    if (b == 0)
                    {
                        b = (MathF.Sin(B * MathF.PI / 180) * a) / MathF.Sin(A * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (a != 0 && C != 0 && A != 0)
                {
                    if (B == 0)
                    {
                        B = 180 - A - C;
                    }

                    if (b == 0)
                    {
                        b = (MathF.Sin(B * MathF.PI / 180) * a) / MathF.Sin(A * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (a != 0 && C != 0 && B != 0)
                {
                    if (A == 0)
                    {
                        A = 180 - B - C;
                    }

                    if (b == 0)
                    {
                        b = (MathF.Sin(B * MathF.PI / 180) * a) / MathF.Sin(A * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                }

                if (b != 0 && c != 0 && A != 0)
                {
                    if (a == 0)
                    {
                        // Finder a vha. cosinus: a = sqrt(b^2+c^2-2*b*c*cos(A))
                        a = MathF.Sqrt((b * b + c * c) - 2 * b * c * (MathF.Cos(A * MathF.PI / 180)));
                    }

                    if (B == 0)
                    {
                        // Finder B vha. cosinus: cos(B)=frac{a^2+c^2-b^2}{2*a*c}
                        B = ((a * a + c * c) - (b * b)) / (2 * a * c);
                        B = MathF.Acos(B) * 180 / MathF.PI;
                    }

                    if (C == 0)
                    {
                        C = 180 - A - B;
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (b != 0 && c != 0 && B != 0)
                {
                    if (C == 0)
                    {
                        // C = Sin^-1((Sin(A)*c)/a)
                        C = (MathF.Sin(B * MathF.PI / 180) * c) / b;
                        if (C < 0)
                        {
                            C = MathF.Sin(B * 180 / MathF.PI) * c / b;
                        }
                        C = MathF.Asin(C) * 180 / MathF.PI;
                    }

                    if (A == 0)
                    {
                        // Finder Vikel C 
                        if (CheckSin(C,B))
                        {
                            A = 180 - (180 - C) - B;
                        }
                        else
                        {
                            A = 180 - (C + B);
                        }
                    }

                    if (a == 0)
                    {
                        // Finder a vha. cosinus: a = sqrt(b^2+c^2-2*b*c*cos(A))
                        a = MathF.Sqrt((b * b + c * c) - 2 * b * c * (MathF.Cos(A * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (b != 0 && c != 0 && C != 0)
                {
                    if (B == 0)
                    {
                        // Finder vinkel B
                        B = MathF.Sin(C * MathF.PI / 180) * b / c;
                        if (B < 0)
                        {
                            B = MathF.Sin(C * 180 / MathF.PI) * b / c;
                        }
                        B = MathF.Asin(B) * 180 / MathF.PI;
                    }

                    if (A == 0)
                    {
                        // Finder Vikel C 
                        if (CheckSin(B, C))
                        {
                            A = 180 - (180 - B) - C;
                        }
                        else
                        {
                            A = 180 - (C + B);
                        }
                    }

                    if (a == 0)
                    {
                        // Finder a vha. cosinus: a = sqrt(b^2+c^2-2*b*c*cos(A))
                        a = MathF.Sqrt((b * b + c * c) - 2 * b * c * (MathF.Cos(A * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (b != 0 && B != 0 && A != 0)
                {
                    if (C == 0)
                    {
                        C = 180 - A - B;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * b) / MathF.Sin(B * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (b != 0 && A != 0 && C != 0)
                {
                    if (B == 0)
                    {
                        B = 180 - A - C;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * b) / MathF.Sin(B * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (b != 0 && B != 0 && C != 0)
                {
                    if (A == 0)
                    {
                        A = 180 - B - C;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * b) / MathF.Sin(B * MathF.PI / 180);
                    }

                    if (c == 0)
                    {
                        // Finder c vha. cosinus: c = sqrt(a^2+b^2-2*a*b*cos(C))
                        c = MathF.Sqrt((b * b + a * a) - 2 * b * a * (MathF.Cos(C * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[2] = Convert.ToDecimal(MathF.Abs(c));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                }

                if (c != 0 && A != 0 && B != 0)
                {
                    if (C == 0)
                    {
                        C = 180 - A - B;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * c) / MathF.Sin(C * MathF.PI / 180);
                    }

                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[5] = Convert.ToDecimal(MathF.Abs(C));
                }

                if (c != 0 && A != 0 && C != 0)
                {
                    if (B == 0)
                    {
                        B = 180 - A - C;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * c) / MathF.Sin(C * MathF.PI / 180);
                    }

                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[4] = Convert.ToDecimal(MathF.Abs(B));
                }

                if (c != 0 && B != 0 && C != 0)
                {
                    if (A == 0)
                    {
                        A = 180 - B - C;
                    }

                    if (a == 0)
                    {
                        a = (MathF.Sin(A * MathF.PI / 180) * c) / MathF.Sin(C * MathF.PI / 180);
                    }

                    if (b == 0)
                    {
                        // Finder b vha. cosinus: b = sqrt(a^2+c^2-2*a*c*cos(B))
                        b = MathF.Sqrt((a * a + c * c) - 2 * a * c * (MathF.Cos(B * MathF.PI / 180)));
                    }


                    svar[0] = Convert.ToDecimal(MathF.Abs(a));
                    svar[1] = Convert.ToDecimal(MathF.Abs(b));
                    svar[3] = Convert.ToDecimal(MathF.Abs(A));
                }

                return svar;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return svar;
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
