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
            SqlConnection conexao = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=bairro;UID=sa;pwd=postgres");
            SqlCommand select = new SqlCommand("select * from tb_bairro", conexao);

            try
            {
                conexao.Open();
                SqlDataReader lerdados = select.ExecuteReader();
                while (lerdados.Read())
                {
                    richTextBox1.Text += lerdados["codigo"] + " - " + lerdados["nome"] + "\n";
                }
                lerdados.Close();
                conexao.Close();
            }
            catch(SqlException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
    }
}
