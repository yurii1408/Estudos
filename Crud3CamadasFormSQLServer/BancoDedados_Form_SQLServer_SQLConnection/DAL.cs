using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BancoDedados_Form_SQLServer_SQLConnection
{
    class DAL
    {
        string conexao_sqlserver = @"Data source=.\SQLEXPRESS;Initial Catalog=Bairro;UID=sa;PWD=postgres";
        SqlConnection conexao = null;

        public DataTable lista_bairros()
        {
            try
            {
                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("select * from tb_bairro", conexao);
                SqlDataAdapter daBairro = new SqlDataAdapter();
                daBairro.SelectCommand = sql;
                DataTable dtBairro = new DataTable();
                daBairro.Fill(dtBairro);
                return dtBairro;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
