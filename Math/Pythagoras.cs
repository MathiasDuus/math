using System;
using System.Windows.Forms;

namespace Math
{
    public partial class Pythagoras : UserControl
    {
        public Pythagoras()
        {
            InitializeComponent();
        }

        private void button_pythagoras_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(numericUpDown_a.Value);
            float b = Convert.ToSingle(numericUpDown_b.Value);
            float c = Convert.ToSingle(numericUpDown_c.Value);

            if (a == 0)
            {
                numericUpDown_a.Value = svar(a, b, c);
            }
            else if (b == 0)
            {
                numericUpDown_b.Value = svar(a, b, c);
            }
            else if (c == 0)
            {
                numericUpDown_c.Value = svar(a, b, c);
            }

        }

        public static decimal svar(float a, float b, float c)
        {
            float svar;

            if (c != 0)
            {
                svar = MathF.Sqrt((c * c) - (b * b + a * a));
            }
            else
            {
                svar = MathF.Sqrt(a * a + b * b);
            }

            return Convert.ToDecimal(svar);
        }

        private void clear_pythagoras_Click(object sender, EventArgs e)
        {
            numericUpDown_a.Value = 0;
            numericUpDown_b.Value = 0;
            numericUpDown_c.Value = 0;
        }
    }
}
