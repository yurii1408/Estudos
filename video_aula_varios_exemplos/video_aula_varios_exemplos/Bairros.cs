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
    public partial class Bairros : Form
    {
        Business business = new Business();
        Model model = null;

        public Bairros()
        {
            InitializeComponent();
        }

        private void Bairros_Load(object sender, EventArgs e)
        {
            try
            {                
                dgv_painel.DataSource = business.lista_dados_bus();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_painel.DataSource = business.lista_dados_bus();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                model = new Model();
                business = new Business();
                model.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                model.Nome = tbx_nome_bairro.Text;
                business.grava_dados_bus(model);
                MessageBox.Show("Dados gravados com sucesso!");
                dgv_painel.DataSource = business.lista_dados_bus();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + "\n" + "\n" + erro);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                business = new Business();
                model = new Model();
                model.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                business.deleta_dados_bus();
                MessageBox.Show("Bairro {0} excluido com sucesso!",tbx_codigo_bairro.Text);
                dgv_painel.DataSource = business.lista_dados_bus();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + "\n" + "\n" + erro);
            }
        }
    }
}
