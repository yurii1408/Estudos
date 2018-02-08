using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Bancodedados_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.Jet.oledb.4.0;Data source=C:\Users\yurii\source\repos\BancoDeDados\BancoDeDados\database.mdb");
            OleDbCommand sql = new OleDbCommand("select * from tb_bairro",conexao);

            try
            {
                conexao.Open();
                OleDbDataReader lerdados = sql.ExecuteReader();
                while (lerdados.Read())
                {
                    Console.WriteLine(lerdados.GetString(1));
                }

                lerdados.Close();
                conexao.Close();
                Console.ReadKey();

            }
            catch(OleDbException erro)
            {
                Console.WriteLine(erro);
                Console.ReadKey();
            }
        }
    }
}
