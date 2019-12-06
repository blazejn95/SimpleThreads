using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{

    public partial class Form2 : Form
    {
        public Form1 MyParentForm;
        public Color C;
        public double Col = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Col += 0.01;
            ColorRGB MyRBG = HSL2RGB(Col % 1, 1, 0.5);
            C = Color.FromArgb(MyRBG.R, MyRBG.G, MyRBG.B);
            panel1.BackColor = C;
            panel1.Refresh();
            MyParentForm.toolStripStatusLabel2.Text = "Form2: R " + Convert.ToString(MyRBG.R) + ", G " + Convert.ToString(MyRBG.G) + ", B " + Convert.ToString(MyRBG.B);
        }
        public static ColorRGB HSL2RGB(double h, double sl, double l)

        {
            double v;
            double r, g, b;
            r = l;   // default to gray
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
            if (v > 0)

            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;
                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)

                {

                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;

                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;

                }

            }

            ColorRGB rgb = new ColorRGB(new Color());
            rgb.R = Convert.ToByte(r * 255.0f);
            rgb.G = Convert.ToByte(g * 255.0f);
            rgb.B = Convert.ToByte(b * 255.0f);
            return rgb;

        }
    }
}
