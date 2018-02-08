using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
/*
 * Provedores para OleDB:
 * - Microsoft.Jet.OLEDB.4.0 = OleDB Provider for Microsoft Jet
 * - MSDAORA = Microsoft OLE DB Provider para Oracle
 * - SQLOLEDB = Microsoft OLE DB Provider para SQL Server
 */

namespace BancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Cria conexão com o banco de dados
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\yurii\source\repos\BancoDeDados\BancoDeDados\database.mdb");
            //executa uma instrução SQL
            OleDbCommand sql = new OleDbCommand("select * from tb_bairro", conexao);

            try
            {
                //abre conexão
                conexao.Open();
                //Criando objeto para ler tabela
                OleDbDataReader ler_dados = sql.ExecuteReader();

                

                while (ler_dados.Read())
                {
                    //Console.WriteLine(ler_dados.GetInt32(0)+" - " + ler_dados.GetString(1));
                    //ou pode-se fazer da seguinte maneira:
                    Console.WriteLine(ler_dados["codbairro"]+" - "+ler_dados["nomebairro"]);
                }

                ler_dados.Close();
                conexao.Close();
                
                Console.ReadKey();


            }
            catch(OleDbException erro)
            {
                Console.WriteLine("Erro: "+erro);
                Console.ReadKey();
            }



        }
    }
}
