using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Crud3CamadasFormSQLServer_TESTE
{
    class DAL
    {
        string conexao_sql = @"Data source=.\SQLEXPRESS;Initial Catalog=Bairro;PWD=postgres;UID=sa";
        SqlConnection conexao = null;

        public DataTable lista_bairros()
        {
            try
            {
                conexao = new SqlConnection(conexao_sql);
                SqlCommand sql = new SqlCommand("select * from tb_bairro", conexao);
                SqlDataAdapter adaptar = new SqlDataAdapter();
                adaptar.SelectCommand = sql;
                DataTable table = new DataTable();
                adaptar.Fill(table);
                return table;
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}
