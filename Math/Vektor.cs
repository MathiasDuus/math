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

            textBox_extend.Text = svar.ToString();
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            //Declares all necessary floats
            float ax, ay, bx, by, cx, cy;

            // Assigns "ax" and "ay" values
            ax = Convert.ToSingle(numericUpDown_add_a1.Value);
            ay = Convert.ToSingle(numericUpDown_add_a2.Value);

            // Assigns "bx" and "by" values
            bx = Convert.ToSingle(numericUpDown_add_b1.Value);
            by = Convert.ToSingle(numericUpDown_add_b2.Value);

            // Adds the two sets of coordinates 
            cx = ax + bx;
            cy = ay + by;

            // Displays the new set of coordinates in the textbox
            textBox_addition.Text = cx.ToString();
            textBox_addtion2.Text = cy.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float ax, ay, bx, by, cx, cy;

            // Assigns "ax" and "ay" values
            ax = Convert.ToSingle(numericUpDown_sub_a1.Value);
            ay = Convert.ToSingle(numericUpDown_sub_a2.Value);

            // Assigns "bx" and "by" values
            bx = Convert.ToSingle(numericUpDown_sub_b1.Value);
            by = Convert.ToSingle(numericUpDown_sub_b2.Value);

            // Subtracts the two sets of coordinates 
            cx = ax - bx;
            cy = ay - by;

            // Displays the new set of coordinates in the textbox
            textBox_subtraktion.Text = cx.ToString();
            textBox_subtraktion2.Text = cy.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float ax, ay, cx, cy, k;

            // Assigns "ax" and "ay" values
            ax = Convert.ToSingle(numericUpDown_mult_a1.Value);
            ay = Convert.ToSingle(numericUpDown_mult_a2.Value);

            // Assigns "k" a value
            k = Convert.ToSingle(numericUpDown_k.Value);

            // Multiplies both a's with k
            cx = ax * k;
            cy = ay * k;

            // Displays the new set of coordinates in the textbox
            textBox_multiplikation1.Text = cx.ToString();
            textBox_multiplikation2.Text = cy.ToString();
        }
    }
}
