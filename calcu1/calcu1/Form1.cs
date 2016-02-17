using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            label3.Text = "A + B =";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            label3.Text = "A - B =";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            label3.Text = "A * B =";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox2.Text)).ToString();
            label3.Text = "A / B =";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            label3.Text = "Result =";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text)).ToString();
            label3.Text = "A^2 =";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = (1 / Convert.ToDecimal(textBox1.Text)).ToString();
            label3.Text = "1/A =";
        }
    }
}
