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
    public partial class islemler : Form
    {
        public islemler()
        {
            InitializeComponent();
        }

        private void islemler_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "TRANSPOZE";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";
            int i, k;
            for (i = 0; i < girme.q3; i++)
            {
                for (k = 0; k < girme.q2; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + girme.trans[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }


            textBox1.Text = textBox1.Text + "MATRİSxTRANSPOZE";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < girme.q2; i++)
            {
                for (k = 0; k < girme.q2; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + girme.car[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }

            textBox1.Text = textBox1.Text + "TERS";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < girme.q2; i++)
            {
                for (k = 0; k < girme.q2; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + girme.d[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }

            textBox1.Text = textBox1.Text + "SONUC";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < girme.q2; i++)
            {
                for (k = 0; k < girme.q2; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + girme.carpım2[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }

        }
    }
}
