using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_aula_varios_exemplos
{
    public partial class Calculadora : Form
    {

        bool cliquei_operacao = false;
        double numero_armazenado = 0;
        string qual_operacao = "";
        double calculo = 0;
        bool mostrar = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        public void ler_numero (int numero_lido)
        {
            if (cliquei_operacao == false)
                tbx_tela.Text += numero_lido;
            else tbx_tela.Text = numero_lido.ToString();

            cliquei_operacao = false;
        }

        public void botao_operacao(string qual_operacao)
        {

            cliquei_operacao = true;
            /*
             Neste primeiro "if" ele ainda não é true, somente será true depois que ele passar pro else  */
            if(mostrar == true) calcular_e_mostrar();
            else



            this.qual_operacao = qual_operacao;
            numero_armazenado = Convert.ToDouble(tbx_tela.Text);
            mostrar = true;

        }
        
        
        public void calcular_e_mostrar ()
        {
            if (qual_operacao == "/") calculo = numero_armazenado / double.Parse(tbx_tela.Text);
            else if (qual_operacao == "*") calculo = numero_armazenado * double.Parse(tbx_tela.Text);
            else if(qual_operacao == "-") calculo = numero_armazenado - double.Parse(tbx_tela.Text);
            else if (qual_operacao == "+") calculo = numero_armazenado + double.Parse(tbx_tela.Text);

            tbx_tela.Text = calculo.ToString();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

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

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tbx_tela.Clear();
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            botao_operacao("/");
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            botao_operacao("*");
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            botao_operacao("-");
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            botao_operacao("+");
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            int tamanho = tbx_tela.Text.Length;
            if (tamanho > 0) tbx_tela.Text = tbx_tela.Text.Substring(0,tamanho-1);
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            tbx_tela.Text += ",";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            calcular_e_mostrar();
            mostrar = false;
        }
    }
}
