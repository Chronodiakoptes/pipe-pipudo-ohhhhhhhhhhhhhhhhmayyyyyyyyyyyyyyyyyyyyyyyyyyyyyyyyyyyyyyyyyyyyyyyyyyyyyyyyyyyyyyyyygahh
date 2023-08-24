using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6___list2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Chronodiakoptes be like
        private void btnFechar_Click(object sender, EventArgs e)
        {
            int qnt;
            double PS, final, PA, F;
            PA = 0;     
            PS = 0;
            F = 0;
            qnt = int.Parse(txtQuant.Text);
            if (cbSabores.SelectedIndex == 0){
                PS = 15;

            }else if(cbSabores.SelectedIndex == 1){
                PS = 10;

            }else if(cbSabores.SelectedIndex == 2){
                PS = 20;
            }
            if (chkBorda.Checked == true) 
            {
                PA += 1.5;
            }
            if(chkBroto.Checked == true)
            {
                PA += 4;
            }
            if(chkRefri.Checked == true)
            {
                PA += 2;
            }
            if(rdCheque.Checked == true)
            {
                F = 1.1;
            }else if(rdCredito.Checked == true)
            {
                F = 1.05;
            }else if (rdVista.Checked == true)
            {
                F = 0.9;
            }
            final = (((PS + PA) * qnt) * F);
            textBox1.Text = ("")+final;


        }

        private void cbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSabores.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-Ni637_o1uxQ/UW28M7NizgI/AAAAAAAABIw/ksRfz1gtRig/s1600/polenguinhopizza01.jpg";
            }else if(cbSabores.SelectedIndex == 1){
                pictureBox1.ImageLocation = "https://1.bp.blogspot.com/-2LtNqySkFEs/VT99NyLg69I/AAAAAAAACUM/BA8ZBP-bn8A/s1600/pizza.jpg";
            }else if(cbSabores.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "https://pbs.twimg.com/profile_images/1290802637143773185/xWH1a-Va_400x400.jpg";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            txtQuant.Text = null;
            rdCheque.Checked = false;
            rdCredito.Checked = false;
            rdVista.Checked = false;
            chkBorda.Checked = false;
            chkBroto.Checked = false;
            chkRefri.Checked = false;
            cbSabores.ResetText();
            pictureBox1.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volte sempre!!!!!");
            this.Close();
        }
    }
}
