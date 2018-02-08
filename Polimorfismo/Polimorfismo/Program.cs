using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.gravar();

            Fisica fisica = new Fisica();
            fisica.gravar();

            Juridica juridica = new Juridica();
            juridica.gravar();


            Console.ReadKey();
        }
    }
}
