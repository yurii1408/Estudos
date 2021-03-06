﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BancoDedados_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                 
            OleDbConnection conexao = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=.\SQLEXPRESS;Initial catalog=bairro;UID=sa;Password=postgres");
            OleDbCommand select = new OleDbCommand("select * from tb_bairro", conexao);

            try
            {
                conexao.Open();
                OleDbDataReader lerdados = select.ExecuteReader();
                while (lerdados.Read())
                {
                    rtb_texto.Text += lerdados["codigo"] + " - " + lerdados["nome"] + "\n";
                }
                lerdados.Close();
                conexao.Close();
            }
            catch(OleDbException erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
    }
}
