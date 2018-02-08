using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace video_aula_varios_exemplos
{
    public partial class manipulacao_strings : Form
    {
        public manipulacao_strings()
        {
            InitializeComponent();
        }

        private void btn_maiuscula_Click(object sender, EventArgs e)
        {
            lbl_info.Text = tbx_info.Text.ToUpper();
        }

        private void btn_minuscula_Click(object sender, EventArgs e)
        {
            lbl_info.Text = tbx_info.Text.ToLower();

        }

        private void btn_substring_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.Length < 5) { MessageBox.Show("Insira uma string com no mínimo 5 caracteres",
                "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
            else
            {
                lbl_info.Text = tbx_info.Text.Substring(4);
            }
        }

        private void btn_indexof_Click(object sender, EventArgs e)
        {
            int posicao = tbx_info.Text.IndexOf("Yuri");
            lbl_info.Text = "" + posicao;
        }

        private void btn_startwith_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.StartsWith("Yuri"))
                MessageBox.Show("Sim, começa com 'Yuri'!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Insira 'Yuri' no textbox", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_endwith_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.EndsWith(".txt"))
                MessageBox.Show("Arquivo de texto reconhecido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Insira o caminho de um arquivo de texto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_PadLeft_Click(object sender, EventArgs e)
        {


            lbl_info.Text = tbx_info.Text.PadLeft(20, '*');

        }

        private void btn_PadRight_Click(object sender, EventArgs e)
        {
            lbl_info.Text = tbx_info.Text.PadRight(20, '*');
        }

        private void btn_Trim_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.Contains(" "))
            {
                lbl_info.Text = "Início-"+tbx_info.Text.Trim()+"-Fim";
            }

            else
            {
                MessageBox.Show("Insira uma string CONTENDO espaços" +
             ", e veja que o método Trim irá remover os espaços do início e do fim da mesma.", "Info",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TrimEnd_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.EndsWith(" "))
            {
                lbl_info.Text = "Início-"+tbx_info.Text.TrimEnd()+"-Fim";
            }

            else
            {
                MessageBox.Show("Insira uma String TERMINANDO com espaços" +
             ", e veja que o método TrimEnd irá remover somente os espaços do final da mesma.", "Info",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TrimStart_Click(object sender, EventArgs e)
        {
            if (tbx_info.Text.StartsWith(" "))
            {
                lbl_info.Text = "Início-" + tbx_info.Text.TrimStart() + "-Fim";
            }

            else
            {
                MessageBox.Show("Insira uma string COMEÇANDO com espaços" +
             ", e veja que o método TrimStart irá remover somente os espaços do inícioda mesma.", "Info",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            string[] array_matriz = tbx_info.Text.Split(' ');
            int array_tamanho = array_matriz.Length;
            MessageBox.Show("Tamanho do array: " + array_tamanho);

            for (int i = 0; i < array_tamanho; i++)
                MessageBox.Show("Conteúdo da posição: " + i + " Valor: "+array_matriz[i]);
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            string[] nomes_array = { "Yuri", "Pinheiro", "Teixeira" };
            string nomes_string = String.Join("-", nomes_array);
            lbl_info.Text = nomes_string;

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            tbx_info.Clear();
            lbl_info.Text = String.Empty;
        }

        private void btn_Format_Click(object sender, EventArgs e)
        {
            /*  
             *  
             *  {0:S} A letra S depois dos dois pontos, significa que o parametro esperado seja obrigatoriamente uma String
             *  {0:D} Para numeros inteiros; 
             *  {0:F} Para numeros decimais; 
             *  {0:N} Para numero decimais variavel
             *  {0,30:S} o 30 representa caracteres em branco que serão adicionados à esquerda da string, 
             *  para adicionar à direita ficaria assim = {0,-30:S}.
             *  Interessante também é a quebra de linha em meio aos MessageBox's utilizando o "\n"
             *  
             *  
             */



            MessageBox.Show(String.Format( "Primeiro nome: {0:S10}"+"\n"+ "Segundo nome: {1}" + "\n" + "Terceiro nome: {2}", "Yuri", "Pinheiro", "Teixeira",
                MessageBoxIcon.Information, MessageBoxButtons.OK));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 20;
            //Adicionando espaços à direita
            string numero_formatado = String.Format("Inicio:{0,8:D}:Fim", numero);
            MessageBox.Show(numero_formatado);
            //Adicionando espaços à esqeurda
            numero_formatado = String.Format("Inicio:{0,-8:D}:Fim", numero);
            MessageBox.Show(numero_formatado);
            //Complementando com zeros
            numero_formatado = String.Format("Inicio:{0:D5}:Fim", numero);
            MessageBox.Show(numero_formatado);

            //Formatando decimais
            
            
            MessageBox.Show(String.Format("Decimais {0:F}", 8.9));
            MessageBox.Show(String.Format("Decimais com 4 casas {0:F4}", 8.9));
            MessageBox.Show(String.Format("Decimais normal {0:F}", 89987.5632));
            MessageBox.Show(String.Format("Decimais com milhar {0:N}", 89987.5632));
            MessageBox.Show(String.Format("Decimais com milhar e mais casas à direita {0:N5}", 89987.5632));
            MessageBox.Show(String.Format("Decimais em moeda {0:C}", 89987.5632));
            MessageBox.Show(String.Format("Decimais com percentuais {0:P}", 2));

        }

        private void btn_formatDeH_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            string data_hora = String.Format("Data completa: {0:D}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Data simples: {0:d}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Hora completa: {0:T}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Hora simples: {0:t}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Data completa e hora simples: {0:F}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Data simples e hora completa: {0:G}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Data e hora simples: {0:g}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Dia e mês: {0:M}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Mês e ano: {0:Y}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Data personalizada {0:dd/MM/yyyy}", date);
            MessageBox.Show(data_hora);

            data_hora = String.Format("Hora personalizada {0:hh:mm:ssss}", date);
            MessageBox.Show(data_hora);

            /*
             * "M" é usado para meses e "m" para minutos
             * "H"para horas em 24h e "h" para horas com 12h
             */

        }
    }
}
