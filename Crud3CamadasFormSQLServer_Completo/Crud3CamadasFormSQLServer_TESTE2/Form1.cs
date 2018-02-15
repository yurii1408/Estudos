using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3CamadasFormSQLServer_TESTE2
{
    public partial class Form1 : Form
    {
        Business bus = new Business();
        Model model = new Model();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_painel.DataSource = bus.lista_bairros_bus();
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
                model.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                model.Nome = tbx_nome_bairro.Text;

                bus.insere_bairro_bus(model);
                MessageBox.Show("Gravado com sucesso!");
                dgv_painel.DataSource = bus.lista_bairros_bus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + "\n" + "\n" + erro);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                model.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                bus.deleta_bairros_bus(model);
                MessageBox.Show("Excluido com sucesso!");
                tbx_codigo_bairro.Text = null;
                dgv_painel.DataSource = bus.lista_bairros_bus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + "\n" + "\n" + erro);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            model.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
            model.Nome = tbx_nome_bairro.Text;
            try
            {
                bus.altera_bairros_bus(model);
                MessageBox.Show("Alterado com sucesso!");
                dgv_painel.DataSource = bus.lista_bairros_bus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + "\n" + "\n" + erro);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = tbx_pesquisa.Text;
            Business bus = new Business();

            try
            {
                Model model = new Model();
                model = bus.pesquisa_bairros_bus(pesquisa);
                tbx_codigo_bairro.Text = model.Codigo.ToString();
                tbx_nome_bairro.Text = model.Nome;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + "\n" + "\n" + erro);
            }
        }
    }
}
