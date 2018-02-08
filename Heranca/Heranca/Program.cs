using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.nome = "Yuri";
            pf.CPF = "060.571.583.18";
            pf.endereço = "Rua tal";
            pf.telefone = "65432135496";
            pf.apelido = "AISDHsiajds";
            Console.WriteLine(pf.nome + pf.CPF + pf.endereço+ pf.telefone+ pf.apelido);

            PessoaJuridica pj = new PessoaJuridica();
            pj.nome = "Sei la";
            pj.CNPJ = "65465132165";
            pj.IE = "654651420013";
            pj.telefone = "35121645";
            


            Console.ReadKey();
        }
    }
}
