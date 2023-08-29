using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormstent1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMamar_Click(object sender, EventArgs e)
        {
            //variaveis hihi :333 owo uwu 
            int n1, n2, res;

            //recebendo pika
            n1 = int.Parse(txtboxN1.Text);
            n2 = int.Parse(txtboxN2.Text);
            res = n1 + n2;//banza

            //Exibir o result(resultado para os plebs)
            MessageBox.Show("O resultado é " + res);//plebs
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxN1.Text = "";
            txtboxN2.Text = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
