using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BancoDedados_Form_SQLServer_SQLConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            dgv_painel.DataSource = bll.lista_bairros_dal();
        }
                

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Modelo modelo = new Modelo();
                modelo.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                modelo.Nome = tbx_nome_bairro.Text;

                BLL bll = new BLL();
                bll.grava_dados_dal(modelo);
                MessageBox.Show("Registro gravado com sucesso!");
                dgv_painel.DataSource = bll.lista_bairros_dal();
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
                Modelo modelo = new Modelo();
                BLL bll = new BLL();

                modelo.Codigo = Convert.ToInt32(tbx_codigo_bairro.Text);
                bll.exclui_dados_dal(modelo);

                MessageBox.Show("Registro excluido com sucesso!");
                dgv_painel.DataSource = bll.lista_bairros_dal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + "\n" + "\n" + erro);
            }
        }
    }
}
