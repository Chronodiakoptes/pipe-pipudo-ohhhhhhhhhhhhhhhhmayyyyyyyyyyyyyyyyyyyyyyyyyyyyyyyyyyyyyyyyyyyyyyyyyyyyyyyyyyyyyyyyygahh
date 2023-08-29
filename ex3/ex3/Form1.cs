using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, div, mul, soma, sub;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            sub = n1 - n2;
            
            soma = n1 + n2;
            
           
            lblsoma.Text = ("") + soma;
          
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            double div, n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            div = n1 / n2;
            lblsoma.Text = ("") + div;
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            double mul, n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            mul = n1 * n2;
            lblsoma.Text = ("") + mul;
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            double sub, n1, n2;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            sub = n1 - n2;
            lblsoma.Text = ("") + sub;
        }
    }
    }

