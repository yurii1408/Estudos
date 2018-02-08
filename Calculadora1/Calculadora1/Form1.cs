using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool botao_operacao_acionada = false,
             mostrar_calculo = false;
        string qual_operacao = "";
        double numero_armazenado = 0;
        double calculo = 0;



        public void ler_numero(int numero_lido)
        {
            if(botao_operacao_acionada == false)
            tbx_tela.Text += numero_lido;
            else
            {
                tbx_tela.Text = numero_lido.ToString();
                botao_operacao_acionada = false;
            }
        }

        public void operacao_identificada (string qual_operacao)
        {
            if (mostrar_calculo == true) { calculando(); }
            else
            botao_operacao_acionada = true;
            this.qual_operacao = qual_operacao;
            numero_armazenado = Convert.ToDouble(tbx_tela.Text);
            mostrar_calculo = true;
        }

        public void calculando()
        {
            if (qual_operacao == "+") calculo = numero_armazenado + Convert.ToDouble(tbx_tela.Text);
            else
                 if (qual_operacao == "-") calculo = numero_armazenado - Convert.ToDouble(tbx_tela.Text);
            else
                 if (qual_operacao == "*") calculo = numero_armazenado * Convert.ToDouble(tbx_tela.Text);
            else
                 if (qual_operacao == "/") calculo = numero_armazenado / Convert.ToDouble(tbx_tela.Text);

            tbx_tela.Text = calculo.ToString();
            botao_operacao_acionada = false;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            ler_numero(0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            ler_numero(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            ler_numero(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            ler_numero(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            ler_numero(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            ler_numero(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            ler_numero(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            ler_numero(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            ler_numero(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            ler_numero(9);
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operacao_identificada("/");
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            operacao_identificada("*");
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operacao_identificada("-");
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            operacao_identificada("+");
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tbx_tela.Clear();
            botao_operacao_acionada = false;
             mostrar_calculo = false;
            qual_operacao = "";
            numero_armazenado = 0;
            calculo = 0;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            calculando();
        }
    }
}
