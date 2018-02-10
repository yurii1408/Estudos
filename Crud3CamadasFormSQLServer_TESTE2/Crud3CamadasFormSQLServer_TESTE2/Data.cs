using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Crud3CamadasFormSQLServer_TESTE2
{
    class Data
    {
        SqlConnection conexao = null;
        string server = @"Data source=.\SQLEXPRESS;Initial catalog=Bairro;UID=sa;PWD=postgres";

        public DataTable lista_bairros_data()
        {
            try
            {
                conexao = new SqlConnection(server);
                SqlCommand sql = new SqlCommand("select * from tb_bairro", conexao);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sql;
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void insere_bairros_data(Model model)
        {
            try
            {
                conexao = new SqlConnection(server);
                SqlCommand sql = new SqlCommand("insert into tb_bairro values (@codigo,@nome)", conexao);
                sql.Parameters.AddWithValue("@codigo", model.Codigo);
                sql.Parameters.AddWithValue("@nome", model.Nome);
                conexao.Open();
                sql.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void deleta_bairros_data(Model model)
        {
            try
            {
                conexao = new SqlConnection(server);
                SqlCommand sql = new SqlCommand("delete from tb_bairro where codigo = @codigo", conexao);
                sql.Parameters.AddWithValue("@codigo", model.Codigo);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void altera_bairros_data(Model model)
        {

            try
            {
                conexao = new SqlConnection(server);
                SqlCommand sql = new SqlCommand("update tb_bairro set nome = @nome where codigo = @codigo",conexao);
                sql.Parameters.AddWithValue("@codigo", model.Codigo);
                sql.Parameters.AddWithValue("@nome", model.Nome);
                conexao.Open();
                sql.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}



