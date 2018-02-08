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
                        
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                DAL dal = new DAL();
                dgv_painel.DataSource = dal.lista_bairros();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
    }
}
