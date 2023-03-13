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

namespace OiMundo2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeEu = 21;
            int idadeGaby = 19;
            int idadeMae = 57;
            MessageBox.Show("A média das idades é:" + ( (idadeEu+idadeGaby+idadeMae)/3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14; 
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 252;
            int b = 20;
            int c = 5;
            double delta = ((b * b) - (4 * a * c));
            double a1 = ( -b + Math.Sqrt(delta) ) / (2 *a);
            double a2 = ( -b - Math.Sqrt(delta)) / (2 *a);

            string A1 = Convert.ToString(a1);
            string A2 = Convert.ToString(a2);

            if (delta < 0)
            {
                MessageBox.Show("Delta negativo. Logo não à raiz nos Reais");
            }
            else
            {
                MessageBox.Show("A raiz 1 é: " + A1);
                MessageBox.Show("A raiz 2 é: " + A2);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idadeUser;
            idadeUser= Convert.ToInt32(textBox1.Text);
            bool nacionalidade = Convert.ToBoolean(checkBox1.Checked);

            if (!((idadeUser > 16) && (nacionalidade = true)))
            {
                MessageBox.Show("Você não pode votar");
            }
            else
            {
                MessageBox.Show("Você pode votar!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = Convert.ToDouble(valorNota.Text);
            double impostoDevido;

            if(valorDaNotaFiscal <= 999)
            {

                impostoDevido = (valorDaNotaFiscal *= 0.02);
                MessageBox.Show("O imposto devido é de R$ " + impostoDevido);
            
            } else if (valorDaNotaFiscal <= 2999)
            {

                impostoDevido = (valorDaNotaFiscal *= 0.025);
                MessageBox.Show("O imposto devido é de R$ " + impostoDevido);

            } else if ( valorDaNotaFiscal <= 6999)
            {

                impostoDevido = (valorDaNotaFiscal *= 0.028);
                MessageBox.Show("O imposto devido é de R$ " + impostoDevido);

            } else
            {

                impostoDevido = (valorDaNotaFiscal *= 0.03);
                MessageBox.Show("O imposto devido é de R$ " + impostoDevido);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(NumeroInserido.Text);
            string mensagem = "o Número é ";

            mensagem += valor >= 10 ? "maior que dez" : "menor que 10";
            MessageBox.Show(mensagem);
        }
    }
}
