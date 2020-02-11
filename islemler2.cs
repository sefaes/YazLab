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
    public partial class islemler2 : Form
    {
        public islemler2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void islemler2_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "TRANSPOZE";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";
            int i, k;
            for (i = 0; i < rastgele.q5; i++)
            {
                for (k = 0; k < rastgele.q4; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + rastgele.transpoze[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }


            textBox1.Text = textBox1.Text + "MATRİSxTRANSPOZE";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < rastgele.q4; i++)
            {
                for (k = 0; k < rastgele.q4; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + rastgele.car[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }

            textBox1.Text = textBox1.Text + "TERS";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < rastgele.q4; i++)
            {
                for (k = 0; k < rastgele.q4; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + rastgele.d[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }

            textBox1.Text = textBox1.Text + "SONUC";
            textBox1.Text = textBox1.Text + "\r\n";
            textBox1.Text = textBox1.Text + "\r\n";



            for (i = 0; i < rastgele.q4; i++)
            {
                for (k = 0; k < rastgele.q4; k++)
                {

                    textBox1.Text = textBox1.Text + "         " + rastgele.carpım2[i, k].ToString();


                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}
