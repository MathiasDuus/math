using System;
using System.Windows.Forms;

namespace Math
{
    public partial class Vektor : UserControl
    {
        public Vektor()
        {
            InitializeComponent();
        }

        private void button__ansExtend_Click(object sender, EventArgs e)
        {
            float x, y, temp, svar;

            x = MathF.Pow(Convert.ToSingle(numericUpDown_extend_X.Value), 2);
            y = MathF.Pow(Convert.ToSingle(numericUpDown_extend_Y.Value), 2);

            temp = x + y;
            svar = MathF.Sqrt(temp);

            textBox_extend.Text = svar.ToString(); ;
        }
    }
}
