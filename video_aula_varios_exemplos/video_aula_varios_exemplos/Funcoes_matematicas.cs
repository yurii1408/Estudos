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
    public partial class Funcoes_matematicas : Form
    {
        public Funcoes_matematicas()
        {
            InitializeComponent();
        }

        private void btn_absoluto_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Valor: "+ Math.Abs(-67));

        }

        private void btn_ceiling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor definido era 59,6 e retornou: " + Math.Ceiling(59.6));
        }

        private void btn_floor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor definido era 59,6 e retornou: " + Math.Floor(59.6));
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De 0 a 10 o mínimo é: " + Math.Min(0,10));
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De 0 a 10 o máximo é: " + Math.Max(0, 10));
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O expoente 2³ calculado é: " + Math.Pow(2,3));
        }

        private void btn_raizq_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A raiz quadrada de 81 é: " + Math.Sqrt(81));
        }

        private void btn_round_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arredondando o valor 99,7 resultará: " + Math.Round(99.7));
        }
    }
}
