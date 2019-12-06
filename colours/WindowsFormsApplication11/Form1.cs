using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Color C;
        public int tbR=0;
        public int tbB=0;
        public int tbG = 0;
        public Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f2.MyParentForm = this;
            f2.Show();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            C = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            panel2.BackColor = C;
            panel2.Refresh();
            toolStripStatusLabel1.Text = "Form1: R " + Convert.ToString(trackBar1.Value) + ", G " + Convert.ToString(trackBar2.Value) + ", B " + Convert.ToString(trackBar3.Value);
        }


        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            C = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            panel2.BackColor = C;
            panel2.Refresh();
            toolStripStatusLabel1.Text = "Form1: R " + Convert.ToString(trackBar1.Value) + ", G " + Convert.ToString(trackBar2.Value) + ", B " + Convert.ToString(trackBar3.Value);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            C = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            panel2.BackColor = C;
            panel2.Refresh();
            toolStripStatusLabel1.Text = "Form1: R " + Convert.ToString(trackBar1.Value) + ", G " + Convert.ToString(trackBar2.Value) + ", B " + Convert.ToString(trackBar3.Value);
        }

    }
}
