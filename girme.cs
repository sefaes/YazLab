using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace yazlab22
{
    public partial class girme : Form
    {


        public girme()
        {
            InitializeComponent();
        }

       public static double[,] trans = new double[10, 10];
        public static double[,] car = new double[10, 10];
        public static double[,] d = new double[10, 10];
        public static double[,] carpım2 = new double[10, 10];
        public static int q2;
        public static int q3;
        private void girme_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i, k;
            int a = Convert.ToInt32(sat.Text);
            int b = Convert.ToInt32(sut.Text);
            double[,] matris = new double[a, b];
            if(a==b){

                MessageBox.Show("kare matris olmaması lazım satır ve sutun sayılarını farklı giriniz");
                sat.Text="";
                sut.Text="";
}


            else{
                q2 = a;
                q3 = b;


                for (i = 0; i < a; i++)
            {
                for (k = 0; k < b; k++)
                {
                    matris[i, k] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i + "," + k + ".eleman", "Matris Değer Girişi", "Buraya yazınız...", 300, 300));
                    ekran.Text = ekran.Text + "         " + matris[i, k].ToString();
                    
                }
                ekran.Text = ekran.Text + "\r\n";
                ekran.Text = ekran.Text + "\r\n";
            }


            double[,] transpoze = new double[b, a];

            for (i = 0; i < a; i++)
            {
                for ( k = 0; k < b; k++)
                {
                    transpoze[k, i] = matris[i, k];
                    trans[k, i] = matris[i, k];
                    }
               
            }

                        
 double[,] carpım = new double[10, 10];
            
                      for (k = 0; k < a; k++) 
                        {

                            for ( i = 0; i < a; i++) 

                            {

                                for (int j = 0; j < b; j++)
                                {

                                    carpım[k, i] += matris[k, j] * transpoze[j, i];
                            car[k, i] += matris[k, j] * transpoze[j, i];
                        }
                            }

                        }

               
                         
               
            for (i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == j)
                        d[i,j] = 1;
                    else
                        d[i,j] = 0;


                }



            }

          

            double r, t;
            for (i = 0; i < a; i++)
            {
                r = carpım[i, i];
                for(int j =0; j < a; j++)
                {
                    carpım[i, j] = carpım[i, j] / r;
                    d[i, j] = d[i, j] / r;
                }
                for (int f = 0; f < a; f++)
                {
                    if (f != i)
                    {
                        t = carpım[f, i];
                        for(int y=0; y < a; y++)
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

                    for (int j = 0; j < b; j++)

                        carpım2[k, i] += d[k, j] * transpoze[j, i];
                    
                }
               
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

        private void button4_Click(object sender, EventArgs e)
        {
            islemler y = new islemler();
            y.Show();
        }
    }
}
