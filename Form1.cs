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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rastgele a = new rastgele();
            a.Show();
            this.Hide();        }

        private void button2_Click(object sender, EventArgs e)
        {
            girme t = new girme();
            t.Show();
            this.Hide();

        }
    }
}
