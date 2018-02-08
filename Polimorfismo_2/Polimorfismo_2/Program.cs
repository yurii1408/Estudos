using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pfisica = new PessoaFisica();

            pfisica.gravar("Yuri", "Rua tal", "neguinha", "060571", 22);
            Console.WriteLine(pfisica.getNome());
            Console.WriteLine(pfisica.getEndereco());
            Console.WriteLine(pfisica.getApelido());
            Console.WriteLine(pfisica.getCpf());
            Console.WriteLine(pfisica.getIdade());

            Console.ReadKey();
        }
    }
}
