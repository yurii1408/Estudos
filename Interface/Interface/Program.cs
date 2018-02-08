using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Filha_classe filha = new Filha_classe();

            filha.getCampo("Yuri", "Pinheiro");
            Console.WriteLine(filha.getCampo1());
            Console.WriteLine(filha.getCampo2());

            Console.ReadKey();
        }
    }
}
