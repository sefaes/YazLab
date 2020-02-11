using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab22
{
    public partial class rastgele : Form
    {
        public rastgele()
        {
            InitializeComponent();
        }

        public static double[,] transpoze = new double[10, 10];

        public static  double[,] carpım = new double[10, 10];
        public static double[,] d = new double[10, 10];
        public static double[,] carpım2 = new double[10, 10];
        public static double[,] car = new double[10, 10];
        public static int q4;
        public static int q5;
        private void rastgele_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int a = rastgele.Next(1,6);
            int b = rastgele.Next(1,6);
            int i, k,j;
            if (a == b)
            {
                while (a != b)
                {

                     b = rastgele.Next(1, 6);
                }
            }


            q4 = a;
            q5 = b;

            int[,] A = new int[10, 10];

            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    A[i, j] =  rastgele.Next(1,10);
                    textBox1.Text = textBox1.Text + "          " + A[i, j].ToString();

                }

                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";

            }


           

            for (i = 0; i < a; i++)
            {
                for (k = 0; k < b; k++)
                {
                    transpoze[k, i] = A[i, k];
                    
                }

            }

           

            for (k = 0; k < a; k++)
            {

                for (i = 0; i < a; i++)

                {

                    for (j = 0; j < b; j++)
                    {

                        carpım[k, i] += A[k, j] * transpoze[j, i];
                        car[k, i] += A[k, j] * transpoze[j, i];
                    }
                }

            }

            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    if (i == j)
                        d[i, j] = 1;
                    else
                        d[i, j] = 0;


                }



            }



            double r, t;
            for (i = 0; i < a; i++)
            {
                r = carpım[i, i];
                for (j = 0; j < a; j++)
                {
                    carpım[i, j] = carpım[i, j] / r;
                    d[i, j] = d[i, j] / r;
                }
                for (int f = 0; f < a; f++)
                {
                    if (f != i)
                    {
                        t = carpım[f, i];
                        for (int y = 0; y < a; y++)
                        {
                            carpım[f, y] = carpım[f, y] - (carpım[i, y] * t);
                            d[f, y] = d[f, y] - (d[i, y] * t);

                        }
                    }

                }

            }

            for (k = 0; k < a; k++)
            {

                for (i = 0; i < a; i++)

                {

                    for (j = 0; j < b; j++)

                        carpım2[k, i] += d[k, j] * transpoze[j, i];

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            islemler2 y = new islemler2();
            y.Show();
        }
    }
}
