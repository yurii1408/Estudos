using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace video_aula_varios_exemplos
{
    class Data
    {
        SqlConnection conexao = null;
        string server = @"Data Source=.\SQLEXPRESS;Initial Catalog=Bairro;UID=sa;PWD=postgres";

        public DataTable lista_dados_data()
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

        public void grava_dados_data(Model model)
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

        public void deleta_dados_data(Model model)
        {
            conexao = new SqlConnection(server);
            SqlCommand sql = new SqlCommand("delete from tb_bairro where codigo = @codigo",conexao);
            sql.Parameters.AddWithValue("@codigo", model.Codigo);
            conexao.Open();
            sql.ExecuteNonQuery();
        }
    }
}
