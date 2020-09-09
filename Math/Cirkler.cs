using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Cirkler : UserControl
    {
        public static float Vinkel;
        public static float radius;
        public Cirkler()
        {
            InitializeComponent();
        }

        public void SetVinkelRadius()
        {
            radius = Convert.ToSingle(numericUpDown_radiusCirkelafsnit.Value);
            Vinkel = Convert.ToSingle(numericUpDown_VCirkelafsnit.Value);
            Vinkel = Vinkel * MathF.PI / 180;
        }

        private void Cirkel_Omkreds_Click(object sender, EventArgs e)
        {
            float d = Convert.ToSingle(numericUpDown_dOmkreds.Value);
            float O;
            string svar;
            O = MathF.PI * d;
            svar = O.ToString();

            Size size = TextRenderer.MeasureText(svar, TextBox_Omkreds.Font);
            TextBox_Omkreds.Width = size.Width;
            TextBox_Omkreds.Height = size.Height;
            TextBox_Omkreds.Text = svar;
        }

        private void Cirkel_Areal_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(numericUpDown_rArealCirkel.Value);
            float A;
            string svar;
            A = MathF.PI * (r * r);
            svar = A.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_ArealCirkel.Font);
            textBox_ArealCirkel.Width = size.Width;
            textBox_ArealCirkel.Height = size.Height;
            textBox_ArealCirkel.Text = svar;
        }

        private void Cirkeludsnit_Areal_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(numericUpDown_rCirkeludsnit.Value);
            float V = Convert.ToSingle(numericUpDown_VCirkeludsnitAreal.Value);
            float A;
            string svar;
            A = (V/360)*MathF.PI*(r*r);
            svar = A.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_CirkeludsnitAreal.Font);
            textBox_CirkeludsnitAreal.Width = size.Width;
            textBox_CirkeludsnitAreal.Height = size.Height;
            textBox_CirkeludsnitAreal.Text = svar;
        }

        private void Cirkelbue_Click(object sender, EventArgs e)
        {
            float d = Convert.ToSingle(numericUpDown_dCirkelbue.Value);
            float V = Convert.ToSingle(numericUpDown_VCirkelbue.Value);
            float A;
            string svar;
            A = (V / 360) * MathF.PI * d;
            svar = A.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_CirkelbueLængde.Font);
            textBox_CirkelbueLængde.Width = size.Width;
            textBox_CirkelbueLængde.Height = size.Height;
            textBox_CirkelbueLængde.Text = svar;
        }

        private void Areal_Cirkelafsnit_Click(object sender, EventArgs e)
        {
            SetVinkelRadius();
            float A;
            float B;
            float C;
            string svar;
            float half = Convert.ToSingle(2 / (double)4);

            A = half*(radius*radius);
            B = Vinkel - MathF.Sin(Vinkel);
            C = A * B;
            svar = C.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_ArealCirkelafsnit.Font);
            textBox_ArealCirkelafsnit.Width = size.Width;
            textBox_ArealCirkelafsnit.Height = size.Height;
            textBox_ArealCirkelafsnit.Text = svar;
        }

        private void Korde_Cirkelafsnit_Click(object sender, EventArgs e)
        {
            SetVinkelRadius();
            float K;
            string svar;

            K = 2*radius*MathF.Sin(Vinkel/2);
            svar = K.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_Korde.Font);
            textBox_Korde.Width = size.Width;
            textBox_Korde.Height = size.Height;
            textBox_Korde.Text = svar;
        }

        private void Buelængde_Click(object sender, EventArgs e)
        {
            SetVinkelRadius();
            float s;
            string svar;

            s = radius * Vinkel;
            svar = s.ToString();

            Size size = TextRenderer.MeasureText(svar, textBox_CirkelbueLængde.Font);
            textBox_CirkelbueLængde.Width = size.Width;
            textBox_CirkelbueLængde.Height = size.Height;
            textBox_CirkelbueLængde.Text = svar;
        }
    }
}
