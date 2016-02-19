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
           // textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
           // label3.Text = "A + B =";
            RunOperation("Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "A + B =";
            RunOperation("Sub");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "A * B =";
            RunOperation("Mul");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "A / B =";
            RunOperation("Div");
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
            label3.Text = "A^2 =";
            RunOperation("Square");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox3.Text = (1 / Convert.ToDecimal(textBox1.Text)).ToString();
            label3.Text = "1/A =";
        }

        void RunOperation(string MathOperation)       
            
        {
            MathFuctions ob = new MathFuctions();
            int n1 = 0, n2 = 0;
          //  int outtext = 0;
            string flag = (String.Compare(MathOperation, "Square", true)).ToString();
            if (flag!="0" && ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox1.Text)))))
            {
                MessageBox.Show("please provide valid inputdata");
            }
            else
            {
                n1 = ob.validatetextboxdata(textBox1.Text);
                n2 = ob.validatetextboxdata(textBox2.Text);
                if ((n1 == -9999 && n2 == -9999 || n1 == -9999 || n2 == -9999) && flag!="0")
                {
                    MessageBox.Show("Please Enter Valid Input Data char and string not allowed");
                }
                else
                {
                    int res = ob.calc(n1, n2, MathOperation);
                    textBox3.Text = res.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }
    }
}
