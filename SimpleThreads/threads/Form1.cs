using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

 



namespace watki_jeden
{
    public partial class Form1 : Form
    {
        Thread one;
        void up1()
        {

            while (true)
            {
                if (progressBar1.Value == 100)
                    progressBar1.Value = 1;
                else
                    progressBar1.Value = progressBar1.Value + 1;

                Thread.Sleep(100);
            }

        }

        Thread two;
        void up2()
        {
            while (true)
            {
                if (progressBar2.Value == 100)
                    progressBar2.Value = 1;
                else
                    progressBar2.Value = progressBar2.Value + 1;
                Thread.Sleep(100);
            }
        }

        Thread three;
        void up3()
        {
            while (true)
            {
                if (progressBar3.Value == 100) 
                  progressBar3.Value = 1;
                else
                      progressBar3.Value = progressBar3.Value + 1;
                    Thread.Sleep(100);
            }
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (one == null || one.IsAlive == false)
            {
                one = new Thread(new ThreadStart(up1));
                one.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (two == null || two.IsAlive == false)
            {
                two = new Thread(new ThreadStart(up2));
                two.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (three == null || three.IsAlive == false)
            {
                three = new Thread(new ThreadStart(up3));
                three.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (one!=null && one.IsAlive == true)
                one.Abort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (two != null && two.IsAlive == true)

                two.Abort();
        }

        private void button6_Click(object sender, EventArgs e)
        {


                if (three != null && three.IsAlive == true)
                    three.Abort();

        }
    }
}
