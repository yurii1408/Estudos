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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void manipulaçãoDeStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulacao_strings janela = new manipulacao_strings();
            janela.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                     
            
            lbl_hora.Text = " Hora.: "+DateTime.Now.ToLongTimeString();
            lbl_data.Text = " Data.: " + DateTime.Now.ToShortDateString();

        }

        private void relógioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relogio relogio = new Relogio();
            relogio.ShowDialog();
        }

        private void maskedBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masked mascaras = new Masked();
            mascaras.ShowDialog();
        }

        private void funçõesMatematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcoes_matematicas math = new Funcoes_matematicas();
            math.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.ShowDialog();
        }
    }
}
